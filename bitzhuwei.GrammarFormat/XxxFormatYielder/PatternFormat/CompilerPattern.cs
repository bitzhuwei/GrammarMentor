using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// lexical analyzing, syntax parsing and extracting.
    /// </summary>
    public partial class CompilerPattern {
        /// <summary>
        /// lexical analyze source code to get <see cref="Token"/>s.
        /// </summary>
        private readonly LexicalAnalyzer lexiAnalyzer = new LexicalAnalyzer(CompilerPattern.lexicalState0_0);
        /// <summary>
        /// 
        /// </summary>
        private readonly TExtracter<TokenDraft> tokenDraftExtracter = new TExtracter<TokenDraft>(CompilerPattern.someTokenExtracterDict, new Node(EType.EndOfTokenList));

        static CompilerPattern() {
            InitializeSyntaxStates();

            InitializeSomeTokenExtracterDict();
        }

        /// <summary>
        /// lexical analyzing, syntax parsing and extracting.
        /// </summary>
        public CompilerPattern() { }

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
            var syntaxTree = this.syntaxParser.Parse(tokenList);
            return syntaxTree;
        }

        /// Extract a <see cref="TokenDraft"/> object from syntax tree.
        /// <para>Post-order traversing.</para>
        /// </summary>
        /// <param name="rootNode">root node of the syntax tree.</param>
        /// <param name="tokens">the token list correspond to <paramref name="rootNode"/>.</param>
        /// <returns></returns>
        public TokenDraft Extract(Node rootNode, TokenList tokens) {
            var tokenDraft = this.tokenDraftExtracter.Extract(rootNode, tokens);
            return tokenDraft;
        }

    }

}
