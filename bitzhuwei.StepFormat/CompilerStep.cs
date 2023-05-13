using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    /// <summary>
    /// lexical analyzing, syntax parsing and extracting.
    /// </summary>
    public partial class CompilerStep
    {
        /// <summary>
        /// lexical analyze source code to get tokens(<see cref="Token"/>).
        /// </summary>
        private readonly LexicalAnalyzer lexiAnalyzer = new LexicalAnalyzer(CompilerStep.lexicalState0);
        /// <summary>
        /// syntax parse tokens to get syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerStep.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });
        /// <summary>
        /// 
        /// </summary>
        private readonly TExtracter<StepModel> stepModelExtracter = new TExtracter<StepModel>(CompilerStep.stepModelExtracterDict, new Node(EType.EndOfTokenList));

        static CompilerStep()
        {
            InitializeSyntaxStates();

            InitializeStepModelExtracterDict();
        }

        /// <summary>
        /// lexical analyzing, syntax parsing and extracting.
        /// </summary>
        public CompilerStep() { }

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

        /// <summary>
        /// parse specified <paramref name="tokenList"/> to get syntax tree.
        /// </summary>
        /// <param name="tokenList"></param>
        /// <returns></returns>
        public Node Parse(TokenList tokenList)
        {
            var syntaxTree = this.syntaxParser.Parse(tokenList);
            return syntaxTree;
        }

        /// Extract a <see cref="StepModel"/> object from syntax tree.
        /// <para>Post-order traversing.</para>
        /// </summary>
        /// <param name="rootNode">root node of the syntax tree.</param>
        /// <param name="tokens">the token list correspond to <paramref name="rootNode"/>.</param>
        /// <returns></returns>
        public StepModel Extract(Node rootNode, TokenList tokens)
        {
            var stepModel = this.stepModelExtracter.Extract(rootNode, tokens);
            return stepModel;
        }

    }

}
