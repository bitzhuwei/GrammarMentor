using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of DFA transformed from NFA
    /// </summary>
    partial class DFAInfo {

        public void ToMermaid(TextWriter w) {
            this.ToMermaid(w, null);
        }

        public void ToMermaid(TextWriter w, bool printSubgraph) {
            var context = new DFA2MermaidContext(printSubgraph, this);

            this.ToMermaid(w, context);
        }

        public void ToMermaid(TextWriter w, DFA2MermaidContext context) {
            // describe states
            PrintStates(w, context);
            // describe edges
            PrintEdges(w);
        }

        private void PrintEdges(TextWriter w) {
            var queue = new Queue<DFAStateDraft>(); queue.Enqueue(this.start);
            var visitedEdges = new List<DFAEdgeDraft>();
            var visitedStates = new List<DFAStateDraft>();
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

        private void PrintStates(TextWriter w, DFA2MermaidContext context) {
            StateSign.PrintClassDefs(w);

            var queue = new Queue<DFAStateDraft>(); queue.Enqueue(this.start);
            var visited = new List<DFAStateDraft>();
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

    public class DFA2MermaidContext {
        public readonly bool printSubgraph;
        public readonly DFAInfo DFAInfo;
        public int NFACounter;

        public DFA2MermaidContext(bool sub, DFAInfo info) {
            this.printSubgraph = sub;
            this.DFAInfo = info;
        }

        public override string ToString() {
            return $"sub:{printSubgraph}, next order: {NFACounter}";
        }
    }
}