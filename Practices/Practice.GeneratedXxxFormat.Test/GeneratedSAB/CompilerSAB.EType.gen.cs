using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SABFormat {
    partial class CompilerSAB {
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
            /// 'a'
            /// </summary>
            public const string @a = "'a'";
            /// <summary>
            /// 's'
            /// </summary>
            public const string @s = "'s'";
            /// <summary>
            /// 'b'
            /// </summary>
            public const string @b = "'b'";
            /// <summary>
            /// 'd'
            /// </summary>
            public const string @d = "'d'";
            /// <summary>
            /// 'c'
            /// </summary>
            public const string @c = "'c'";


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
            /// A
            /// </summary>
            public const string A = "A";
            /// <summary>
            /// B
            /// </summary>
            public const string B = "B";

        }
    }
}
