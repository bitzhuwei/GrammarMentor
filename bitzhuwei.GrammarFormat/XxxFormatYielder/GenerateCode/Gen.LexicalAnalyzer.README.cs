using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {
        private void GenerateLexicalAnalyzerREADME(YieldContext context) {
            var p = context.parameter;
            {
                string lexicalStateCount = GetLexicalStateCount(context.automatonInfo.DFA);
                string VtRegexList = GetVtRegexList(context.tokenDraftDict);
                string extractedENFA = GetENFA(context.automatonInfo.eNFA);
                string completedENFA = GetENFA(context.automatonInfo.eNFAManifested);
                string NFA = GetNFA(context.automatonInfo.NFA);
                string DFA = GetDFA(context.automatonInfo.DFA, true);
                string DFASimple = GetDFA(context.automatonInfo.DFA, false);
                string miniDFA = GetMiniDFA(context.automatonInfo.miniDFA, true);
                string miniDFASimple = GetMiniDFA(context.automatonInfo.miniDFA, false);
                string template = File.ReadAllText(templateLexicalAnalyzerREADME);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strLexicalStateCount, lexicalStateCount);
                template = template.Replace(strVtRegexList, VtRegexList);
                template = template.Replace(strextractedENFA, extractedENFA);
                template = template.Replace(strcompletedENFA, completedENFA);
                template = template.Replace(strNFA, NFA);
                template = template.Replace(strDFA, DFA);
                template = template.Replace(strDFASimple, DFASimple);
                template = template.Replace(strminiDFA, miniDFA);
                template = template.Replace(strminiDFASimple, miniDFASimple);

                var path = Path.Combine(p.generationDirectory, "LexicalAnalyzer");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                string fullname = Path.Combine(path, $"README.gen.md");
                File.WriteAllText(fullname, template);
            }
            {
                string template = File.ReadAllText(templateLexicalAnalyzerChooseDFAorMiniDFA);
                var path = Path.Combine(p.generationDirectory, "LexicalAnalyzer");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                string fullname = Path.Combine(path, $"ChooseDFAorMiniDFA.gen.md");
                File.WriteAllText(fullname, template);
            }
        }

        private string GetMiniDFA(MiniDFAInfo miniDFA, bool printSubgraph) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                w.WriteLine("flowchart");
                var context = new MiniDFA2MermaidContext(printSubgraph, miniDFA);
                miniDFA.ToMermaid(w, context);
            }

            return b.ToString();
        }

        private string GetDFA(DFAInfo DFA, bool printSubgraph) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                w.WriteLine("flowchart");
                DFA.ToMermaid(w, printSubgraph);
            }

            return b.ToString();
        }

        private string GetNFA(NFAInfo NFA) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                w.WriteLine("flowchart");
                NFA.ToMermaid(w);
            }

            return b.ToString();
        }

        private string GetENFA(eNFAInfo eNFA) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                w.WriteLine("flowchart");
                eNFA.ToMermaid(w);
            }

            return b.ToString();
        }

        private string GetVtRegexList(Dictionary<TokenDraft, string> someTokenDict) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                foreach (var item in someTokenDict) {
                    var someToken = item.Key; var Vt = item.Value;
                    w.Write($"## {Vt}"); w.WriteLine();
                    someToken.ToMermaid(w); w.WriteLine();
                }
            }

            return b.ToString();
        }

        private string GetLexicalStateCount(DFAInfo DFAInfo) {
            var count = 0;
            var queue = new Queue<DFAStateDraft>(); queue.Enqueue(DFAInfo.start);
            var visited = new List<DFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    count++;

                    foreach (var edge in state.toEdges) {
                        var to = edge.to;
                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }

            return $"{count}";
        }
    }
}