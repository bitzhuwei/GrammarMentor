using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// Result of lexical analyzing.
    /// </summary>
    public partial class TokenList : List<Token> {
        public readonly string sourceCode;

        public readonly Dictionary<Token, TokenErrorInfo> errorDict = new Dictionary<Token, TokenErrorInfo>();

        /// <summary>
        /// Result of lexical analyzing.
        /// </summary>
        /// <param name="sourceCode"></param>
        public TokenList(string sourceCode) {
            if (sourceCode == null) { sourceCode = string.Empty; }

            this.sourceCode = sourceCode;
        }
    }
}
