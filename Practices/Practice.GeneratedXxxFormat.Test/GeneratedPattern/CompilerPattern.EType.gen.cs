using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
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
            /// 'refVt'
            /// </summary>
            public const string @refVt = "'refVt'";
            /// <summary>
            /// '/'
            /// </summary>
            public const string @Slash = "'/'";
            /// <summary>
            /// '|'
            /// </summary>
            public const string @Pipe = "'|'";
            /// <summary>
            /// 'char'
            /// </summary>
            public const string @char = "'char'";
            /// <summary>
            /// '.'
            /// </summary>
            public const string @Dot = "'.'";
            /// <summary>
            /// 'scope'
            /// </summary>
            public const string @scope = "'scope'";
            /// <summary>
            /// '('
            /// </summary>
            public const string @LeftParenthesis = "'('";
            /// <summary>
            /// ')'
            /// </summary>
            public const string @RightParenthesis = "')'";
            /// <summary>
            /// '?'
            /// </summary>
            public const string @Question = "'?'";
            /// <summary>
            /// '+'
            /// </summary>
            public const string @Plus = "'+'";
            /// <summary>
            /// '*'
            /// </summary>
            public const string @Asterisk = "'*'";
            /// <summary>
            /// '{'
            /// </summary>
            public const string @LeftBrace = "'{'";
            /// <summary>
            /// 'min'
            /// </summary>
            public const string @min = "'min'";
            /// <summary>
            /// '}'
            /// </summary>
            public const string @RightBrace = "'}'";
            /// <summary>
            /// ','
            /// </summary>
            public const string @Comma = "','";
            /// <summary>
            /// 'max'
            /// </summary>
            public const string @max = "'max'";


            /// <summary>
            /// end of token list.
            /// </summary>
            public const string EndOfTokenList = "'￥'";

            // Vn
            /// <summary>
            /// Pattern
            /// </summary>
            public const string Pattern = "Pattern";
            /// <summary>
            /// PreRegex
            /// </summary>
            public const string PreRegex = "PreRegex";
            /// <summary>
            /// PostRegex
            /// </summary>
            public const string PostRegex = "PostRegex";
            /// <summary>
            /// Regex
            /// </summary>
            public const string Regex = "Regex";
            /// <summary>
            /// Bunch
            /// </summary>
            public const string Bunch = "Bunch";
            /// <summary>
            /// Unit
            /// </summary>
            public const string Unit = "Unit";
            /// <summary>
            /// Repeat
            /// </summary>
            public const string Repeat = "Repeat";
            /// <summary>
            /// UpperBound
            /// </summary>
            public const string UpperBound = "UpperBound";

        }
    }
}
