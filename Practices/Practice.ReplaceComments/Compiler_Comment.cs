using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ReplaceComments
{
    public partial class Compiler_Comment
    {
        /// <summary>
        /// lexical analyze source code to get tokens(<see cref="Token"/>).
        /// </summary>
        private readonly LexicalAnalyzer lexiAnalyzer = new LexicalAnalyzer(Compiler_Comment.state0);

        static Compiler_Comment()
        {
        }

        /// <summary>
        /// lexically analyze <paramref name="sourceCode"/>and return token list.
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <returns></returns>
        public TokenList Analyze(string sourceCode)
        {
            var tokenList = this.lexiAnalyzer.Analyze(sourceCode);
            return tokenList;
        }
    }


}
