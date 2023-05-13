using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        /// <summary>
        /// ' '
        /// </summary>
        const char space = (char)32; // ' ';
        /// <summary>
        /// '\''
        /// </summary>
        const char quot = '\'';
        /// <summary>
        /// '\"'
        /// </summary>
        const char doubleQuot = '\"';

        /// <summary>
        /// the keyword(empty)
        /// <para>NOTE: empty is neither a Vt nor a Vn.</para>
        /// </summary>
        public const string keywordEmpty = "empty";

        public const string keywordMultipleLineComment = "'multipleLineComment'";
        public const string keywordSingleLineComment = "'singleLineComment'";
    }
}
