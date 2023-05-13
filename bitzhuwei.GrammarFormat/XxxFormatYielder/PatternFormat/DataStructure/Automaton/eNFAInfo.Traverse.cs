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

        /// <summary>
        /// traverse the <see cref="eNFAInfo"/> graph to do something.
        /// </summary>
        /// <param name="actionState"></param>
        public void Traverse(Action<eNFAStateDraft> actionState, Action<eNFAEdgeDraft> actionEdge) {
            var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
            var visited = new List<eNFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    if (actionState != null) { actionState(state); }

                    foreach (var edge in state.toEdges) {
                        if (actionEdge != null) { actionEdge(edge); }

                        var to = edge.to;
                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }
        }
        //public void SetFirstId(int firstId) {
        //    var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
        //    var visited = new List<eNFAStateDraft>();
        //    while (queue.Count > 0) {
        //        var state = queue.Dequeue();
        //        if (!visited.Contains(state)) {
        //            visited.Add(state);

        //            state.firstId = firstId;

        //            foreach (var edge in state.toEdges) {
        //                var to = edge.to;
        //                if (!visited.Contains(to)) { queue.Enqueue(to); }
        //            }
        //        }
        //    }
        //}
    }
}
