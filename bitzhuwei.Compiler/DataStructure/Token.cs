using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// Token from lexical analyzing.
    /// </summary>
    public class Token {
        // We don't need explict NotYet any more.
        ///// <summary>
        ///// syntax parsing for this <see cref="Node"/> is not finished yet.
        ///// <para>This must be set to 0, so that we don't need to "this.type = ENode.NotYet;" in the <see cref="Node"/> class.</para>
        ///// </summary>
        /// <summary>
        /// initial type of the <see cref="Token"/>
        /// <para>this means that the type for this <see cref="Token"/> is not specified yet.</para>
        /// </summary>
        public const string NotYet = "'？'";
        /// <summary>
        /// token type in lexical analyzing.
        /// </summary>
        public string type = NotYet;
        /// <summary>
        /// index of the first character in the source code.
        /// </summary>
        public readonly int index;
        /// <summary>
        /// line number(starts from 1).
        /// </summary>
        public readonly int line;
        /// <summary>
        /// column number(starts from 1).
        /// </summary>
        public readonly int column;

        // TODO: use `int length;` instead
        /// <summary>
        /// content in source code.
        /// </summary>
        public string value = string.Empty;
        ///// <summary>
        ///// Gets tokenCount of <paramref name="Content"/>
        ///// </summary>
        //public int Length { get { return this.value.Length; } }

        /// <summary>
        /// Token from lexical analyzing.
        /// </summary>
        /// <param name="index">tokenIndex of the first character in the source code.</param>
        /// <param name="line">line number(starts from 1).</param>
        /// <param name="column">column number(starts from 1).</param>
        public Token(int index, int line, int column) {
            this.index = index;
            this.line = line;
            this.column = column;
        }

        public void Print(System.IO.TextWriter w) {
            w.Write($"{type} {value} [ln:{line}, col:{column}, i:{index}, L:{value.Length}]");
        }

        public override string ToString() {
            return ($"{type} {value} [ln:{line}, col:{column}, i:{index}, L:{value.Length}]");
        }
    }
}
