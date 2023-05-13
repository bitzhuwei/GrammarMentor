using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
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
            // Vt
            /// <summary>
            /// Something wrong within the source code.
            /// </summary>
            public const string Error = "'×'";
            /// <summary>
            /// 多行注释 /**/
            /// </summary>
            public const string MultipleLineComment = "/**/";
            /// <summary>
            /// 单行注释 //
            /// </summary>
            public const string SingleLineComment = "//";
            /// <summary>
            /// '['
            /// </summary>
            public const string @LeftBracket = "'['";
            /// <summary>
            /// 'firstItem1'
            /// </summary>
            public const string @firstItem1 = "'firstItem1'";
            /// <summary>
            /// ']'
            /// </summary>
            public const string @RightBracket = "']'";
            /// <summary>
            /// '[^'
            /// </summary>
            public const string @LeftBracketCaret = "'[^'";
            /// <summary>
            /// 'firstItem2'
            /// </summary>
            public const string @firstItem2 = "'firstItem2'";
            /// <summary>
            /// 'char'
            /// </summary>
            public const string @char = "'char'";

            /// <summary>
            /// end of token list.
            /// </summary>
            public const string EndOfTokenList = "'￥'";
            /// <summary>
            /// in coding. Lexical analyzing for this character is not done yet.
            /// <para>remove this when all compiling system is done.</para>
            /// </summary>
            public const string Coding = "'。。。'";
            // Vn
            /// <summary>
            /// Scope
            /// </summary>
            public const string Scope = "Scope";
            /// <summary>
            /// RangeItems
            /// </summary>
            public const string RangeItems = "RangeItems";
            /// <summary>
            /// RangeItem
            /// </summary>
            public const string RangeItem = "RangeItem";

        }
    }
}
