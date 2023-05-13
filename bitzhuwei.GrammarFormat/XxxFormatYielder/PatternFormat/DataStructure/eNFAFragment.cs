using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// A fragment of a future <see cref="eNFAInfo"/>.
    /// </summary>
    public class eNFAFragment {

        public readonly eNFAStateDraft start;
        public readonly eNFAStateDraft end;

        /// <summary>
        /// Only a record of <see cref="eNFAFragment.start"/> and <see cref="eNFAFragment.end"/>.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public eNFAFragment(eNFAStateDraft start, eNFAStateDraft end) {
            this.start = start;
            this.end = end;
        }

        /// <summary>
        /// make a copy of the fragment(without <see cref="TokenScript"/> dict).
        /// </summary>
        /// <returns></returns>
        public eNFAFragment Copy() {
            // template.state -> copyed.state
            var stateDict = new Dictionary<eNFAStateDraft, eNFAStateDraft>();
            // template.edge -> copyed.edge
            var edgeDict = new Dictionary<eNFAEdgeDraft, eNFAEdgeDraft>();
            var visited = new List<eNFAStateDraft>();
            var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
            while (queue.Count > 0) {
                var tFrom = queue.Dequeue();
                if (!visited.Contains(tFrom)) {
                    visited.Add(tFrom);

                    if (!stateDict.TryGetValue(tFrom, out var cFrom)) {
                        cFrom = new eNFAStateDraft(tFrom);
                        stateDict.Add(tFrom, cFrom);
                    }
                    foreach (var tEdge in tFrom.toEdges) {
                        var tTo = tEdge.to;
                        // try to copy the template state tTo.
                        if (!stateDict.TryGetValue(tTo, out var cTo)) {
                            cTo = new eNFAStateDraft(tTo);
                            stateDict.Add(tTo, cTo);
                        }
                        // try to copy the template edge from tState to tTo.
                        if (!edgeDict.TryGetValue(tEdge, out var cEdge)) {
                            cEdge = eNFAEdgeDraft.Connect(cFrom, cTo, tEdge.condition);
                            edgeDict.Add(tEdge, cEdge);
                        }

                        if (!visited.Contains(tTo)) { queue.Enqueue(tTo); }
                    }
                }
            }

            var start = stateDict[this.start];
            var end = stateDict[this.end];
            var result = new eNFAFragment(start, end);

            return result;
        }

        public override string ToString() {
            return $"{this.start}->{this.end}";
        }
    }
}
