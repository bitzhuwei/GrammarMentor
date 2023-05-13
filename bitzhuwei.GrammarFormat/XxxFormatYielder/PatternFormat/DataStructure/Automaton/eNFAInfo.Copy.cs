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
        /// make a copy of the graph specified by <paramref name="eNFAInfo"/>.
        /// </summary>
        /// <param name="VtId">specified <paramref name="VtId"/> for the copy</param>
        /// <returns></returns>
        public eNFAInfo Copy(int VtId) {
            // template.state -> copyed.state
            var stateDict = new Dictionary<eNFAStateDraft, eNFAStateDraft>();
            // template.edge -> copyed.edge
            var edgeDict = new Dictionary<eNFAEdgeDraft, eNFAEdgeDraft>();
            var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
            var visited = new List<eNFAStateDraft>();
            // copy states and edges
            while (queue.Count > 0) {
                var tFrom = queue.Dequeue();
                if (!visited.Contains(tFrom)) {
                    visited.Add(tFrom);

                    // copy tState
                    if (!stateDict.TryGetValue(tFrom, out var cFrom)) {
                        cFrom = new eNFAStateDraft(VtId, tFrom);
                        stateDict.Add(tFrom, cFrom);
                    }

                    foreach (var tEdge in tFrom.toEdges) {
                        var tTo = tEdge.to;
                        // copy tTo
                        if (!stateDict.TryGetValue(tTo, out var cTo)) {
                            cTo = new eNFAStateDraft(VtId, tTo);
                            stateDict.Add(tTo, cTo);
                        }
                        // copy tEdge
                        if (!edgeDict.TryGetValue(tEdge, out var cEdge)) {
                            cEdge = eNFAEdgeDraft.Connect(cFrom, cTo, tEdge.condition);
                            edgeDict.Add(tEdge, cEdge);
                        }

                        if (!visited.Contains(tTo)) { queue.Enqueue(tTo); }
                    }
                }
            }

            var cStart = stateDict[this.start]; var cEnd = stateDict[this.end];
            var result = new eNFAInfo(cStart, cEnd);
            // copy token drafts on edges
            foreach (var item in this.edgeTokenScriptDict) {
                var tEdge = item.Key;
                var cEdge = edgeDict[tEdge];
                var tokenScripts = item.Value;
                result.edgeTokenScriptDict.TryInsert(cEdge, tokenScripts);
            }
            // copy token drafts on states
            foreach (var item in this.stateTokenScriptDict) {
                var tState = item.Key;
                var cState = stateDict[tState];
                var tokenScripts = item.Value;
                result.stateTokenScriptDict.TryInsert(cState, tokenScripts);
            }

            return result;
        }

        /// <summary>
        /// make a copy of the graph specified by <paramref name="eNFAInfo"/>.
        /// </summary>
        /// <param name="eNFAInfo"></param>
        /// <returns></returns>
        public eNFAInfo Copy() {
            // template.state -> copyed.state
            var stateDict = new Dictionary<eNFAStateDraft, eNFAStateDraft>();
            // template.edge -> copyed.edge
            var edgeDict = new Dictionary<eNFAEdgeDraft, eNFAEdgeDraft>();
            var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(this.start);
            var visited = new List<eNFAStateDraft>();
            // copy states and edges
            while (queue.Count > 0) {
                var tFrom = queue.Dequeue();
                if (!visited.Contains(tFrom)) {
                    visited.Add(tFrom);

                    // copy tState
                    if (!stateDict.TryGetValue(tFrom, out var cFrom)) {
                        cFrom = new eNFAStateDraft(tFrom);
                        stateDict.Add(tFrom, cFrom);
                    }

                    foreach (var tEdge in tFrom.toEdges) {
                        var tTo = tEdge.to;
                        // copy tTo
                        if (!stateDict.TryGetValue(tTo, out var cTo)) {
                            cTo = new eNFAStateDraft(tTo);
                            stateDict.Add(tTo, cTo);
                        }
                        // copy tEdge
                        if (!edgeDict.TryGetValue(tEdge, out var cEdge)) {
                            cEdge = eNFAEdgeDraft.Connect(cFrom, cTo, tEdge.condition);
                            edgeDict.Add(tEdge, cEdge);
                        }

                        if (!visited.Contains(tTo)) { queue.Enqueue(tTo); }
                    }

                }
            }

            var cStart = stateDict[this.start]; var cEnd = stateDict[this.end];
            var result = new eNFAInfo(cStart, cEnd);
            // copy token drafts on edges
            foreach (var item in this.edgeTokenScriptDict) {
                var tEdge = item.Key;
                var cEdge = edgeDict[tEdge];
                var tokenScripts = item.Value;
                result.edgeTokenScriptDict.TryInsert(cEdge, tokenScripts);
            }
            // copy token drafts on states
            foreach (var item in this.stateTokenScriptDict) {
                var tState = item.Key;
                var cState = stateDict[tState];
                var tokenScripts = item.Value;
                result.stateTokenScriptDict.TryInsert(cState, tokenScripts);
            }

            return result;
        }
    }
}