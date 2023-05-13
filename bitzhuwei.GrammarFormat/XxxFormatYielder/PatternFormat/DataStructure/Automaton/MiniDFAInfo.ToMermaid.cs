using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of DFA transformed from NFA
    /// </summary>
    partial class MiniDFAInfo {


        public void ToMermaid(TextWriter w) {
            ToMermaid(w, null);
        }

        public void ToMermaid(TextWriter w, bool printSubgraph) {
            var context = new MiniDFA2MermaidContext(printSubgraph, this);

            ToMermaid(w, context);
        }

        public void ToMermaid(TextWriter w, MiniDFA2MermaidContext context) {
            // describe states
            PrintStates(w, context);
            // describe edges
            PrintEdges(w);
        }

        private void PrintEdges(TextWriter w) {
            var queue = new Queue<MiniDFAStateDraft>(); queue.Enqueue(this.start);
            var visitedEdges = new List<MiniDFAEdgeDraft>();
            var visitedStates = new List<MiniDFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visitedStates.Contains(state)) {
                    visitedStates.Add(state);

                    foreach (var edge in state.toEdges) {
                        if (!visitedEdges.Contains(edge)) {
                            visitedEdges.Add(edge);
                            edge.ToMermaid(w, this); w.WriteLine();
                        }
                        var to = edge.to;
                        if (!visitedStates.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }
        }

        private void PrintStates(TextWriter w, MiniDFA2MermaidContext context) {
            StateSign.PrintClassDefs(w);

            var queue = new Queue<MiniDFAStateDraft>(); queue.Enqueue(this.start);
            var visited = new List<MiniDFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    state.ToMermaid(w, context); w.WriteLine();
                    var stateSign = StateSign.Parse(state, this);
                    stateSign.Print(w, state, EStateSignPrint.Class);

                    foreach (var edge in state.toEdges) {
                        var to = edge.to;
                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }
        }
    }

    public class MiniDFA2MermaidContext {
        public readonly bool printSubgraph;
        public readonly MiniDFAInfo MiniDFAInfo;
        public int DFACounter;

        public MiniDFA2MermaidContext(bool sub, MiniDFAInfo info) {
            this.printSubgraph = sub;
            this.MiniDFAInfo = info;
        }

        public override string ToString() {
            return $"sub:{printSubgraph}, next order: {DFACounter}";
        }
    }
}