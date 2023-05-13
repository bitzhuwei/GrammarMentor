using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA
    /// </summary>
    partial class eNFAInfo {
        public void ToMermaid(TextWriter w) {
            PrintStates(w);

            // describe edges
            PrintEdges(w);
        }

        private void PrintEdges(TextWriter w) {
            var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
            var visitedEdges = new List<eNFAEdgeDraft>();
            var visitedStates = new List<eNFAStateDraft>();
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

        private void PrintStates(TextWriter w) {
            StateSign.PrintClassDefs(w);

            var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
            var visited = new List<eNFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    state.ToMermaid(w, this); w.WriteLine();
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
}