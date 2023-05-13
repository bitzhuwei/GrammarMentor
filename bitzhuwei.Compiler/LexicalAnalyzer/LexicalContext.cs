using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// It's an internal bag. You can find anything you need for lexical analyzing.
    /// </summary>
    public class LexicalContext {
        /// <summary>
        /// source code like C, C++, C#, Java, Xml, etc.
        /// </summary>
        private readonly string sourceCode;
        /// <summary>
        /// tokenIndex of current char in the <paramref name="sourceCode"/>.
        /// </summary>
        private int m_Cursor = 0;
        /// <summary>
        /// Gets tokenIndex of current char in the <paramref name="sourceCode"/>.
        /// </summary>
        public int Cursor { get { return this.m_Cursor; } }
        /// <summary>
        /// line number(starts from 1).
        /// </summary>
        private int m_Line = 1;
        /// <summary>
        /// line number(starts from 1).
        /// </summary>
        public int Line { get { return this.m_Line; } }
        /// <summary>
        /// column number(starts from 1).
        /// </summary>
        private int m_Column = 1;
        /// <summary>
        /// column number(starts from 1).
        /// </summary>
        public int Column { get { return this.m_Column; } }

        /// <summary>
        /// use this dict to pass user defined data.
        /// </summary>
        public readonly Dictionary<string/*key*/, object> tagDict = new Dictionary<string, object>();

        /// <summary>
        /// current state which is ready to read current char.
        /// </summary>
        public LexicalState currentState;
        /// <summary>
        /// When lexical analyzing is finished, this is where token list lies.
        /// </summary>
        public readonly TokenList result;

        /// <summary>
        /// It's an internal context. You can find anything you need for lexical analyzing.
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <param name="initialState"></param>
        internal LexicalContext(string sourceCode, LexicalState initialState) {
            this.sourceCode = sourceCode != null ? sourceCode : string.Empty;
            this.result = new TokenList(sourceCode);
            this.currentState = initialState;
        }

        /// <summary>
        /// return true if the last char is lexically analyzed.
        /// </summary>
        public bool EOF { get { return this.m_Cursor >= this.sourceCode.Length; } }
        /// <summary>
        /// Gets current lexically analyzing character.
        /// </summary>
        public char CurrentChar {
            get {
                var cursor = this.m_Cursor;
                string sourceCode = this.sourceCode;
                if (cursor < sourceCode.Length) {
                    return sourceCode[cursor];
                }
                else {
                    return char.MinValue;
                }
            }
        }

        /// <summary>
        /// the token that is constructing...
        /// </summary>
        public Token analyzingToken;
        /// <summary>
        /// possible <see cref="Token.type"/>s of <see cref="LexicalContext.analyzingToken"/>.
        /// </summary>
        public List<string> typeCandidates = new List<string>();

        /// <summary>
        /// paramter of <see cref="LexicalContext.MoveBack(int)"/>
        /// <para>
        /// <see cref="LexicalContext.Cursor"/> - <see cref="LexicalContext.checkpoint"/> + 1
        /// </para>
        /// </summary>
        public int checkpoint;

        /// <summary>
        /// <see cref="LexicalContext.analyzingToken"/> is accepted at least once.
        /// </summary>
        public bool accepted = true;
        public bool endTokenCame;
        public readonly CheckerDict checkerDict = new CheckerDict();

        /// <summary>
        /// Get handler of this state according to specified <paramref name="c"/>
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public Func<LexicalContext, LexicalState> GetFunction(char c) {
            var function = this.currentState.GetFunction(c);
            return function;
        }

        ///// <summary>
        ///// prepare the current state to meet with next char.
        ///// </summary>
        ///// <param name="nextState"></param>
        //internal void UpdateState(LexicalState nextState) {
        //    this.currentState = nextState;
        //}

        /// <summary>
        /// Cursor向前进一个char，即指向下一个char。
        /// <para>如果越过了最后一个char，则指向EOF。</para>
        /// </summary>
        public void MoveForward() {
            if (this.EOF) { return; }

            int cursor = this.m_Cursor + 1;
            int length = this.sourceCode.Length;
            if (cursor < length) {
                this.m_Cursor = cursor;
                char c = this.sourceCode[cursor];
                switch (c) {
                case '\n':
                this.m_Line++;
                // 0 for '\n', so that 1 for the first char of next line.
                this.m_Column = 0;
                break;
                case '\r': // nothing need to do.
                break;
                default:
                this.m_Column++;
                break;
                }
            }
            else // (cursor >= tokenCount)
            {
                this.m_Cursor = length;
                this.m_Column++;
            }
        }

        /// <summary>
        /// Cursor向后退<paramref name="step"/>个char，即指向前<paramref name="step"/>个char。
        /// <para>如果越过了第一个char，则抛出Exception。</para>
        /// </summary>
        /// <param name="step"></param>
        public void MoveBack(int step) {
            if (step == 0) { return; }

            if (step < 0) { throw new ArgumentOutOfRangeException($"{nameof(step)}", "step should > 0."); }
            if (this.m_Cursor < step) { throw new ArgumentOutOfRangeException($"{nameof(step)}", "Move back too far."); }

            bool jumpLine = false;
            int cursor = this.m_Cursor;
            int line = this.m_Line;
            int column = this.m_Column;
            // move back cursor and reduce line no.
            for (int i = 0; i < step; i++) {
                cursor--;
                char c = this.sourceCode[cursor];
                switch (c) {
                case '\n':
                line--;
                jumpLine = true;
                break;
                case '\r': // nothing need to do.
                break;
                default:
                break;
                }
            }
            // recalculate column no.
            if (jumpLine) {
                // we run into previous line.
                column = 0;
                for (int cursor2 = cursor; cursor2 >= 0; cursor2--) {
                    column++;

                    char c = this.sourceCode[cursor2];
                    //if (c == '\r' || c == '\n') { break; }
                    if (c == '\n' || c == '\r') { break; }
                }
            }
            else {
                // we are still in the same line.
                column = column - step;
            }

            this.m_Line = line;
            this.m_Column = column;
            this.m_Cursor = cursor;
        }

        public string Substring(int startIndex, int length) {
            string str = this.sourceCode.Substring(startIndex, length);
            return str;
        }

        public override string ToString() {
            var c = this.CurrentChar;
            if (char.IsControl(c)) {
                //var x = new char[] {
                //    '\a', '\b', '\c', '\d', '\e', '\f', '\g',
                //    '\h', '\i', '\j', '\k', '\l', '\m', '\n',
                //    '\o', '\p', '\q', '\r', '\s', '\t',
                //    '\u', '\v', '\w', '\x', '\y', '\z',
                //    '\A', '\B', '\C', '\D', '\E', '\F', '\G',
                //    '\H', '\I', '\J', '\K', '\L', '\M', '\N',
                //    '\O', '\P', '\Q', '\R', '\S', '\T',
                //    '\U', '\V', '\W', '\X', '\Y', '\Z',
                //    '\0', '\1', '\2', '\3', '\4', '\5',
                //};
                string appearance;
                switch (c) {
                case '\0': appearance = @"\0"; break;
                case '\a': appearance = @"\a"; break;
                case '\b': appearance = @"\b"; break;
                case '\f': appearance = @"\f"; break;
                case '\n': appearance = @"\n"; break;
                case '\r': appearance = @"\r"; break;
                case '\t': appearance = @"\t"; break;
                case '\v': appearance = @"\v"; break;
                default: appearance = string.Format("\\u{0:X4}", (int)c); break;
                }

                return $"'{appearance}' ➡ {this.analyzingToken}";
            }
            else { return $"'{c}' ➡ {this.analyzingToken}"; }
        }
    }

    public class CheckerDict {
        private readonly Dictionary<string, int> dict = new Dictionary<string, int>();

        /// <summary>
        /// if any one of <paramref name="Vts"/> is set?
        /// </summary>
        /// <param name="Vts"></param>
        /// <returns></returns>
        public bool IsSet(params string[] Vts) {
            var result = false;
            foreach (var Vt in Vts) {
                if (dict.TryGetValue(Vt, out var checker)) {
                    if (checker > 0) {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public int GetCount(string Vt) {
            if (!dict.TryGetValue(Vt, out var count)) {
                count = 0;
            }

            return count;
        }

        public void Check(string Vt) {
            if (dict.TryGetValue(Vt, out var count)) {
                // now dict[Vt] works like <Vt, bool>
                //dict[Vt] = count + 1;
            }
            else {
                dict.Add(Vt, 1);
            }
        }

        public void TryUncheck(string Vt) {
            if (dict.TryGetValue(Vt, out var count)) {
                if (count > 0) {
                    dict[Vt] = count - 1;
                }
                //else {
                //    throw new ArgumentException("Too many uncheck.", $"{Vt}");
                //}
                //if (count == 1) {
                //    dict.Remove(Vt);
                //}
                //else {
                //    dict[Vt] = count - 1;
                //}
            }
            //else {
            //    throw new ArgumentException("key is not in the dict.", $"{Vt}");
            //}
        }

        /// <summary>
        /// no Vt checked.
        /// <para>it means that we are still in regex and not in post-regex</para>
        /// </summary>
        public bool IsEmpty {
            get {
                var result = true;
                foreach (var item in this.dict) {
                    if (item.Value > 0) { result = false; break; }
                }

                return result;
            }
        }

        public void Clear() {
            this.dict.Clear();
        }
    }
}
