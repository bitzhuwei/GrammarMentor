using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    /// <summary>
    /// extracted info from syntax tree(<see cref="Node"/>).
    /// </summary>
    public partial class ResolvedScope {
        private readonly Scope scope;
        public readonly bool reverse;
        public readonly IReadOnlyList<ScopeRange> ranges;

        public ResolvedScope(Scope scope) {
            this.scope = scope;
            this.reverse = scope.reverse;
            this.ranges = Parse(scope.ItemsAppearance());
        }

        /// <summary>
        /// xxx in [xxx] or [^xxx] -> <see cref="ScopeRange"/>[]
        /// </summary>
        private static readonly Dictionary<string/*xxx in [xxx] or [^xxx]*/, ScopeRange[]> scopeDict = new Dictionary<string, ScopeRange[]>();
        private static ScopeRange[] Parse(string items) {
            if (scopeDict.TryGetValue(items, out var result)) { return result; }

            // now index refer to the first candidate char
            var stack = new Stack<ScopeRange>();
            var count = items.Length;
            for (int index = 0; index < count - 1; index++) {
                var current = items[index];
                if (current != '-') {
                    stack.Push(new ScopeRange(current, current));
                }
                else {
                    // '-' is in the middle of chars.
                    if (0 < index && index < count - 1 - 1) {
                        var left = stack.Pop().min;
                        var right = items[index + 1];
                        // 'a' > 'b' in [a-b] is allowed in regex.
                        if (left > right) { var tmp = left; left = right; right = tmp; }
                        stack.Push(new ScopeRange(left, right));
                        index++;
                    }
                    else // '-' is at first or at last
                    {
                        stack.Push(new ScopeRange(current, current));
                    }
                }
            }

            var array = new ScopeRange[stack.Count];
            {
                int index = array.Length - 1;
                while (stack.Count > 0) { array[index--] = stack.Pop(); }
            }

            scopeDict.Add(items, array);

            return array;
        }

        public override string ToString() {
            return $"{this.scope}";
        }
    }

    public class ScopeRange {
        public readonly char min;
        public readonly char max;
        public ScopeRange(char min, char max) {
            if (min > max) { throw new ArgumentException("min > max!"); }

            this.min = min;
            this.max = max;
        }

        public void Print(TextWriter w) {
            if (min == max) {
                if (min == '-') { w.Write(@"\-"); }
                else { w.Write($"{CompilerScope.ToAppearance(min)}"); }

            }
            else if (min + 1 == max) {
                if (min == '-') { w.Write(@"\-."); }
                else if (max == '-') { w.Write(@",\-"); }
                else { w.Write($"{CompilerScope.ToAppearance(min)}{CompilerScope.ToAppearance(max)}"); }
            }
            else {
                w.Write($"{CompilerScope.ToAppearance(min)}-{CompilerScope.ToAppearance(max)}");
            }
        }
        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                Print(w);
            }

            return b.ToString();
        }
    }
}
