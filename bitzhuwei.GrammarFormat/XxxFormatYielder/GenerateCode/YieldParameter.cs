using bitzhuwei.Compiler;
using System;
using System.Reflection.Emit;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    public class YieldParameter {
        /// <summary>
        /// where to put the generated source code ?
        /// </summary>
        public readonly string generationDirectory;

        /// <summary>
        /// what do you call this grammar ?
        /// </summary>
        public readonly string GrammarName;

        public readonly string ExtractedType;

        public readonly string ExtractedType_var;

        public readonly string sourceCode;

        public readonly TokenList tokens;

        public readonly Node rootNode;

        public YieldParameter(string generationDirectory, string compilerName, string extractedType,
            string sourceCode, TokenList tokens, Node rootNode) {
            if (string.IsNullOrEmpty(generationDirectory)) { throw new ArgumentNullException($"{nameof(generationDirectory)}"); }
            if (string.IsNullOrEmpty(compilerName)) { throw new ArgumentNullException($"{nameof(generationDirectory)}"); }
            if (string.IsNullOrEmpty(extractedType)) { throw new ArgumentNullException($"{nameof(generationDirectory)}"); }

            this.generationDirectory = generationDirectory;
            this.GrammarName = compilerName;
            this.ExtractedType = extractedType;
            this.ExtractedType_var = extractedType.Type2VarName();

            this.sourceCode = sourceCode;
            this.tokens = tokens;
            this.rootNode = rootNode;
        }
    }
}