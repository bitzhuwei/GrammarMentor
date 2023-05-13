using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    /// <summary>
    /// lexical analyzing and syntax parsing of *.step/*.stp file.
    /// </summary>
    public partial class CompilerWRL
    {
        /// <summary>
        /// lexical analyze source code to get tokens(<see cref="Token"/>).
        /// </summary>
        private readonly LexicalAnalyzer lexiAnalyzer = new LexicalAnalyzer(CompilerWRL.lexicalState0);
        /// <summary>
        /// syntax parse tokens to get syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerWRL.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });
        /// <summary>
        /// 
        /// </summary>
        private readonly TExtracter<WRLFile> stepExtracter = new TExtracter<WRLFile>(CompilerWRL.wrlExtracterDict, new Node(EType.EndOfTokenList));

        static CompilerWRL()
        {
            // initialize syntaxStates
            InitializeSyntaxStates();

            //var b = new StringBuilder();
            //for (int index = 0; index < regulations.Length; index++)
            //{
            //    b.AppendLine($"[{index}] = {regulations[index]}");
            //}
            //var String_ = b.ToString();
            //Console.WriteLine();

            InitializeWRLFileExtracterDict();
        }

        /// <summary>
        /// lexical analyzing, syntax parsing and extracting of *.step/*.stp file.
        /// </summary>
        public CompilerWRL() { }

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

        /// Extract a <see cref="WRLFile"/> object from syntax tree.
        /// <para>Post-order traversing.</para>
        /// </summary>
        /// <param name="rootNode">root node of the syntax tree.</param>
        /// <param name="tokens">the token list correspond to <paramref name="rootNode"/>.</param>
        /// <returns></returns>
        public WRLFile Extract(Node rootNode, TokenList tokens)
        {
            var result = this.stepExtracter.Extract(rootNode, tokens);
            return result;
        }

    }

}
