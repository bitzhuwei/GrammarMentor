using bitzhuwei.Compiler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ReplaceComments
{
    partial class Compiler_Comment
    {
        /// <summary>
        /// token type in lexical analyzing.
        /// </summary>
        public static class EType
        {
            // We don't need explict NotYet any more.
            ///// <summary>
            ///// syntax parsing for this <see cref="Node"/> is not finished yet.
            ///// <para>This must be set to 0, so that we don't need to "this.type = ENode.NotYet;" in the <see cref="Node"/> class.</para>
            ///// </summary>
            //public const string NotYet = "'？'";
            public const string Error = "'×'";
            public const string MultipleLineComment = "/**/";
            public const string SingleLineComment = "//";
        }
    }


}
