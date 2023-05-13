using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    /// <summary>
    /// lexical analyzing, syntax parsing and extracting.
    /// </summary>
    public partial class CompilerSES {
        /// <summary>
        /// lexical analyze source code to get <see cref="Token"/>s.
        /// </summary>
        private readonly LexicalAnalyzer lexiAnalyzer = new LexicalAnalyzer(CompilerSES.lexicalState0);
        /// <summary>
        /// 
        /// </summary>
        private readonly TExtracter<SES2> sES2Extracter = new TExtracter<SES2>(CompilerSES.sES2ExtracterDict, new Node(EType.EndOfTokenList));

        static CompilerSES() {
            InitializeSyntaxStates();

            InitializeSES2ExtracterDict();
        }

        /// <summary>
        /// lexical analyzing, syntax parsing and extracting.
        /// </summary>
        public CompilerSES() { }

        /// <summary>
        /// lexically analyze <paramref name="sourceCode"/>and return token list.
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <returns></returns>
        public TokenList Analyze(string sourceCode) {
            var tokenList = this.lexiAnalyzer.Analyze(sourceCode);
            return tokenList;
        }

        /// <summary>
        /// parse specified <paramref name="tokenList"/> to get syntax tree.
        /// </summary>
        /// <param name="tokenList"></param>
        /// <returns></returns>
        public Node Parse(TokenList tokenList) {
            var rootNode = this.syntaxParser.Parse(tokenList);
            return rootNode;
        }

        /// Extract a <see cref="SES2"/> object from syntax tree.
        /// <para>Post-order traversing.</para>
        /// </summary>
        /// <param name="rootNode">root node of the syntax tree.</param>
        /// <param name="tokens">the token list correspond to <paramref name="rootNode"/>.</param>
        /// <returns></returns>
        public SES2 Extract(Node rootNode, TokenList tokens) {
            var sES2 = this.sES2Extracter.Extract(rootNode, tokens);
            return sES2;
        }

    }

}
