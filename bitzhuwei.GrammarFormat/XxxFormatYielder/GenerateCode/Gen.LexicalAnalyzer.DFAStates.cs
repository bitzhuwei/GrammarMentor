using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateLexicalAnalyzerDFAStates(YieldContext context) {
            var p = context.parameter;
            string template = File.ReadAllText(templateLexicalStates);
            template = template.Replace(strGrammarName, p.GrammarName);

            var path = Path.Combine(p.generationDirectory, "LexicalAnalyzer", "DFA");
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

            var DFA = context.automatonInfo.DFA; // context.automatonInfo.miniDFA
            int length = GetStateIdLength(DFA); // 1-9 or 1-99 or 1-999 or ..
            var queue = new Queue<DFAStateDraft>(); queue.Enqueue(DFA.start);
            var visited = new List<DFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    var stateId = $"{state.Id}";
                    var newLexicalRuleList = GetNewLexicalRules(state, DFA);
                    var template2 = template.Replace(strLexicalStateId, stateId);
                    template2 = template2.Replace(strnewLexicalRuleList, newLexicalRuleList);
                    var eId = Convert.ToString(state.Id, 10);
                    eId = eId.PadLeft(length, '0');
                    string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.LexcicalState{eId}.gen.cs");
                    File.WriteAllText(fullname, template2);

                    foreach (var edge in state.toEdges) {
                        var to = edge.to;
                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }
        }
    }
}