using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// condition in edge of ε-NFA, NFA, DFA and minDFA
    /// <para>is a single char which represents its value</para>
    /// <para>or a [xxx] which is a regex.</para>
    /// </summary>
    public static partial class ConditionHelper {

        /// <summary>
        /// ASCII chars that are used in text file.
        /// </summary>
        public static readonly char[] ASCIIinText;// = new char[] { '\t','\n','\r' };
        /// <summary>
        /// currentChar
        /// </summary>
        public const string var_currentChar = "currentChar";
        //// TODO: remove this obsoluted thing ?
        ///// <summary>
        ///// chars that are not explicitly specified that <see cref="eNFAEdgeDraft.from"/> can go through.
        ///// </summary>
        //public const string otherSign = "【^】";

        static ConditionHelper() {
            char tail = '~', head = ' ';
            ASCIIinText = new char[3 + tail - head + 1];
            ASCIIinText[0] = '\t';
            ASCIIinText[1] = '\n';
            ASCIIinText[2] = '\r';
            int index = 3;
            for (char c = head; c <= tail; c++) {
                ASCIIinText[index++] = c;
            }
        }

        /// <summary>
        /// get chars represented by <paramref name="condition"/> in regex
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        internal static IEnumerable<char> GetChars(this string condition) {
            if (!string.IsNullOrEmpty(condition)) {
                if (condition.Length == 1) {
                    // literal single char
                    yield return condition[0];
                }
                else {
                    // [xxx] to resolved scope
                    var scope = ResolveScope(condition);
                    if (scope.reverse) {
                        for (int index = 0; index < ASCIIinText.Length; index++) {
                            var c = ASCIIinText[index];
                            bool inside = false;
                            foreach (var rangeItem in scope.rangeItems) {
                                if (rangeItem.min <= c && c <= rangeItem.max) {
                                    inside = true;
                                    break;
                                }
                            }
                            if (!inside) {
                                yield return c;
                            }
                        }
                    }
                    else {
                        for (int index = 0; index < ASCIIinText.Length; index++) {
                            var c = ASCIIinText[index];
                            foreach (var rangeItem in scope.rangeItems) {
                                if (rangeItem.min <= c && c <= rangeItem.max) {
                                    yield return c;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 'a' <= c && c <= 'z' || 'A' <= c && c <= 'Z' ...
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static void ToCSCode(this MiniDFAEdgeDraft miniDFAEdge, TextWriter w, CSCodeContext context) {
            var condition = miniDFAEdge.condition;
            if (string.IsNullOrEmpty(condition)) { throw new ArgumentNullException($"{nameof(miniDFAEdge)}"); }

            ToCSCode(condition, w, context);
        }

        // 'a' <= c && c <= 'z' || 'A' <= c && c <= 'Z' ...
        /// <summary>
        /// 'a' &lt;= c &amp;&amp; c &lt;= 'z' || 'A' &lt;= c &amp;&amp; c &lt;= 'Z' ...
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static void ToCSCode(this DFAEdgeDraft DFAEdge, TextWriter w, CSCodeContext context) {
            var condition = DFAEdge.condition;
            if (string.IsNullOrEmpty(condition)) { throw new ArgumentNullException($"{nameof(DFAEdge)}"); }

            ToCSCode(condition, w, context);
        }

        private static void ToCSCode(string condition, TextWriter w, CSCodeContext context) {
            //// from -->|"other"| to
            //if (condition == ConditionHelper.otherSign) {
            //    w.Write("true/* this should be the last one */"); // lazy coding style.
            //    return;
            //}

            // literal single char
            if (condition.Length == 1) {
                w.Write($"{var_currentChar} == {condition[0].csAppear()}");
                return;
            }

            // [xxx] to resolved scope
            var scope = ResolveScope(condition);
            // !( '0' <= c && c <= '9' )
            // !( ('0' <= c && c <= '9') || (c == 'x') )
            // '0' <= c && c <= '9'
            // ('0' <= c && c <= '9') || (c == 'x')
            if (scope.reverse) { w.Write("!("); }
            bool firstItem = true;
            var rangeCount = scope.rangeItems.Length;
            foreach (var rangeItem in scope.rangeItems) {
                if (!firstItem) {
                    w.WriteLine();
                    w.Print(context.Tab, "|| ");
                }
                if (rangeItem.min == rangeItem.max) {
                    if (rangeCount > 1) { w.Write("("); }
                    w.Write($"{var_currentChar} == {rangeItem.min.csAppear()}");
                    if (rangeCount > 1) { w.Write(")"); }
                }
                else {
                    if (rangeCount > 1) { w.Write("("); }
                    w.Write($"{rangeItem.min.csAppear()} <= {var_currentChar}");
                    w.Write($" && ");
                    w.Write($"{var_currentChar} <= {rangeItem.max.csAppear()}");
                    if (rangeCount > 1) { w.Write(")"); }
                }

                firstItem = false;
            }
            if (scope.reverse) { w.Write(")"); }
        }

        class ResolvedScope {
            public readonly RangeItem[] rangeItems;
            public readonly bool reverse;
            public ResolvedScope(RangeItem[] rangeItems, bool reversed) {
                this.rangeItems = rangeItems;
                this.reverse = reversed;
            }

            public override string ToString() {
                return $"{rangeItems.Length}, {reverse}";
            }
        }
        private static readonly Dictionary<string/*[xxx]*/, ResolvedScope> scopeDict = new Dictionary<string, ResolvedScope>();
        /// <summary>
        /// [xxx] to <see cref="ResolvedScope"/>
        /// </summary>
        /// <param name="condition">[xxx]</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private static ResolvedScope ResolveScope(string condition) {
            if (scopeDict.TryGetValue(condition, out var result)) { return result; }

            bool reverse;
            var firstContent = 1;
            if (condition[firstContent] == '^') { reverse = true; firstContent++; }
            else { reverse = false; }

            // now index refer to the first candidate char
            var stack = new Stack<RangeItem>();
            var count = condition.Length;
            for (int index = firstContent; index < count - 1; index++) {
                var current = condition[index];
                if (current != '-') {
                    //if (current == '\\') {
                    //    index++;
                    //    current = condition[index];
                    //    if (current == 't') { current = '\t'; }
                    //    else if (current == 'n') { current = '\n'; }
                    //    else if (current == 'r') { current = '\r'; }
                    //    else if (current == '\\') { current = '\\'; }
                    //    stack.Push(new RangeItem(current, current));
                    //}
                    //else {
                    //    stack.Push(new RangeItem(current, current));
                    //}
                    stack.Push(new RangeItem(current, current));
                }
                else {
                    // '-' is in the middle of chars.
                    if (firstContent < index && index < count - 1 - 1) {
                        var left = (stack.Pop() as RangeItem).min;
                        var right = condition[index + 1];
                        //if (right == '\\') {
                        //    index++;
                        //    if (index < count - 1) {
                        //        right = condition[index];
                        //        if (right == 't') { right = '\t'; }
                        //        else if (right == 'n') { right = '\n'; }
                        //        else if (right == 'r') { right = '\r'; }
                        //        else if (right == '\\') { right = '\\'; }
                        //    }
                        //    else {
                        //        throw new Exception($"Error scope [{condition}]");
                        //    }
                        //}
                        if (left > right) { var tmp = left; left = right; right = tmp; }
                        stack.Push(new RangeItem(left, right));
                        index++;
                    }
                    else // '-' is at first or at last
                    {
                        stack.Push(new RangeItem(current, current));
                    }
                }
            }

            var array = new RangeItem[stack.Count];
            {
                int index = array.Length - 1;
                while (stack.Count > 0) { array[index--] = stack.Pop(); }
            }

            result = new ResolvedScope(array, reverse);
            scopeDict.Add(condition, result);

            return result;
        }
    }
}
