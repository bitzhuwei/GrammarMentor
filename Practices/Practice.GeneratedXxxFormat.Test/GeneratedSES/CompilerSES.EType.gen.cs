using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        /// <summary>
        /// Vt types are used both for lexical analyzing and syntax parsing.
        /// <para>Vt is quoted in ''.</para>
        /// <para>Vn types are only for syntax parsing.</para>
        /// <para>Vn is not quoted in ''.</para>
        /// </summary>
        public static class EType {
            // We don't need explict NotYet any more.
            ///// <summary>
            ///// syntax parsing for this <see cref="Node"/> is not finished yet.
            ///// <para>This must be set to 0, so that we don't need to "this.type = ENode.NotYet;" in the <see cref="Node"/> class.</para>
            ///// </summary>
            //public const string NotYet = "'？'";

            /// <summary>
            /// 多行注释 /**/
            /// </summary>
            public const string blockComment = "/**/";
            /// <summary>
            /// 单行注释 //
            /// </summary>
            public const string inlineComment = "//";

            /// <summary>
            /// Something wrong within the source code.
            /// </summary>
            public const string Error = "'×'";

            // Vt
            /// <summary>
            /// 's'
            /// </summary>
            public const string @s = "'s'";
            /// <summary>
            /// 't'
            /// </summary>
            public const string @t = "'t'";
            /// <summary>
            /// 'g'
            /// </summary>
            public const string @g = "'g'";
            /// <summary>
            /// 'w'
            /// </summary>
            public const string @w = "'w'";
            /// <summary>
            /// 'e'
            /// </summary>
            public const string @e = "'e'";
            /// <summary>
            /// 'd'
            /// </summary>
            public const string @d = "'d'";


            /// <summary>
            /// end of token list.
            /// </summary>
            public const string EndOfTokenList = "'￥'";

            // Vn
            /// <summary>
            /// S
            /// </summary>
            public const string S = "S";
            /// <summary>
            /// N
            /// </summary>
            public const string N = "N";
            /// <summary>
            /// V
            /// </summary>
            public const string V = "V";

        }
    }
}
