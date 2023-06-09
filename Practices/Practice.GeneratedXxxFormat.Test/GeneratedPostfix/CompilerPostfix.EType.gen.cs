using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
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
            /// 'entityId'
            /// </summary>
            public const string @entityId = "'entityId'";
            /// <summary>
            /// '='
            /// </summary>
            public const string @Equal = "'='";
            /// <summary>
            /// 'refEntity'
            /// </summary>
            public const string @refEntity = "'refEntity'";


            /// <summary>
            /// end of token list.
            /// </summary>
            public const string EndOfTokenList = "'￥'";

            // Vn
            /// <summary>
            /// Items
            /// </summary>
            public const string Items = "Items";
            /// <summary>
            /// Item
            /// </summary>
            public const string Item = "Item";

        }
    }
}
