using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;

namespace bitzhuwei.GrammarFormat {
    public class YieldContext {
        /// <summary>
        /// original grammar.
        /// </summary>
        internal readonly GrammarDraft grammar;
        /// <summary>
        /// key(<see cref="GrammarDraft"/>) to value(<see cref="NFF"/>).
        /// </summary>
        public NFF nff;
        private GrammarDraft extendedGrammar;
        /// <summary>
        /// key(<see cref="GrammarDraft"/>) to value(<see cref="NFF"/>).
        /// </summary>
        internal NFF extendedNFF;
        //internal readonly Dictionary<Grammar, NFF> nffDict = new Dictionary<Grammar, NFF>();
        /// <summary>
        /// State list, syntax parsing table.
        /// </summary>
        public LL1SyntaxInfo ll1SyntaxInfo;
        /// <summary>
        /// State list, Edge list, syntax parsing table.
        /// </summary>
        public LR0SyntaxInfo lr0SyntaxInfo;
        /// <summary>
        /// State list, Edge list, syntax parsing table.
        /// </summary>
        internal SLR1SyntaxInfo slr1SyntaxInfo;
        /// <summary>
        /// State list, Edge list, syntax parsing table.
        /// </summary>
        internal LALR1SyntaxInfo lalr1SyntaxInfo;
        /// <summary>
        /// State list, Edge list, syntax parsing table.
        /// </summary>
        internal LR1SyntaxInfo lr1SyntaxInfo;
        public readonly YieldParameter parameter;
        /// <summary>
        /// Vt -> pattern ( xxx in %%xxx%% )
        /// </summary>
        internal Dictionary<string, string> patternDict;
        /// <summary>
        /// <see cref="TokenDraft"/> --> Vt
        /// </summary>
        internal Dictionary<TokenDraft, string> tokenDraftDict;
        /// <summary>
        /// info of whole automaton of lexical analyzer.
        /// </summary>
        internal AutomatonInfo automatonInfo;

        public YieldContext(GrammarDraft grammar, YieldParameter parameter) {
            if (grammar == null) { throw new ArgumentNullException($"{nameof(grammar)}"); }
            if (parameter == null) { throw new ArgumentNullException($"{nameof(parameter)}"); }

            this.grammar = grammar;
            this.parameter = parameter;
        }

        // <para>Start☞ : ? '¥' ;</para>
        /// <summary>
        /// Add 
        /// <para>Start> : ? ;</para>
        /// <para>as the first regulation.</para>
        /// <para>So there would be only one accept action.</para>
        /// </summary>
        /// <returns></returns>
        public GrammarDraft GetExtendedGrammar() {
            if (this.extendedGrammar == null) {
                var grammar = this.grammar;
                var regulations = new VnRegulationDraft[1 + grammar.VnRegulations.Length];
                //var start = new VnRegulationDraft(exntenedStart, grammar.regulations[0].left, CompilerGrammar.EType.EndOfTokenList);
                var eVn = GetExtendedStartNode();
                //var eEnd = CompilerGrammar.EType.EndOfTokenList;
                //var eRegulation = new VnRegulationDraft(eVn, grammar.regulations[0].left, eEnd);
                var eRegulation = new VnRegulationDraft(eVn, grammar.VnRegulations[0].left);
                regulations[0] = eRegulation;
                for (int i = 1; i < regulations.Length; i++) {
                    regulations[i] = new VnRegulationDraft(grammar.VnRegulations[i - 1].left, grammar.VnRegulations[i - 1].Right.ToArray());
                }
                var VtPatterns = new VtPatternDraft[grammar.VtPatterns.Length];
                for (int i = 0; i < VtPatterns.Length; i++) {
                    VtPatterns[i] = new VtPatternDraft(grammar.VtPatterns[i].Vt, grammar.VtPatterns[i].pattern);
                }
                // not needed
                //var rootNode = new Node(eVn, 0);rootNode.Children.Add(grammar.rootNode);
                this.extendedGrammar = new GrammarDraft(regulations, VtPatterns);
            }

            return this.extendedGrammar;
        }

        public string GetExtendedStartNode() {
            var eVn = $"{this.parameter.ExtractedType}>";
            return eVn;
        }
        //public const string extendedVnTail = ">";//"☞";

    }
}