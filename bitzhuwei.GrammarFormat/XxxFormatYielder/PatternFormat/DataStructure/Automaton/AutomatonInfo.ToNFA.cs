using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA, NFA, DFA and minDFA.
    /// </summary>
    partial class AutomatonInfo {
        /// <summary>
        /// remove empty edges(and thus useless states).
        /// </summary>
        /// <param name="eNFAManifested"></param>
        /// <returns></returns>
        private static NFAInfo ToNFA(eNFAInfo eNFAManifested) {
            // Template.state -> Copyed.state
            var stateDict = new Dictionary<eNFAStateDraft, NFAStateDraft>();
            // Template.edge -> Copyed.edge
            var edgeDict = new Dictionary<eNFAEdgeDraft, NFAEdgeDraft>();
            NFAInfo NFA;
            {
                var cStart = new NFAStateDraft(eNFAManifested.start); stateDict.Add(eNFAManifested.start, cStart);
                NFA = new NFAInfo(cStart);
                if (eNFAManifested.stateTokenScriptDict.TryGetValue(eNFAManifested.start, out var tokenScripts)) {
                    NFA.stateTokenScriptDict.TryInsert(cStart, tokenScripts);
                }
            }
            {
                var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(eNFAManifested.start);
                var visited = new List<eNFAStateDraft>();
                while (queue.Count > 0) {
                    var tFrom = queue.Dequeue();
                    if (!visited.Contains(tFrom)) {
                        visited.Add(tFrom);

                        // copy state and attached token drafts
                        if (!stateDict.TryGetValue(tFrom, out var cFrom)) {
                            cFrom = new NFAStateDraft(tFrom); stateDict.Add(tFrom, cFrom);
                            if (eNFAManifested.stateTokenScriptDict.TryGetValue(tFrom, out var tokenScripts)) {
                                NFA.stateTokenScriptDict.TryInsert(cFrom, tokenScripts);
                            }
                        }

                        bool allEmpty = true;
                        foreach (var tEdge in tFrom.toEdges) {
                            if (!tEdge.IsEmpty()) {
                                allEmpty = false;
                                var tTo = tEdge.to;
                                // copy state and attached token drafts
                                if (!stateDict.TryGetValue(tTo, out var cTo)) {
                                    cTo = new NFAStateDraft(tTo); stateDict.Add(tTo, cTo);
                                    if (eNFAManifested.stateTokenScriptDict.TryGetValue(tTo, out var tokenScripts)) {
                                        NFA.stateTokenScriptDict.TryInsert(cTo, tokenScripts);
                                    }
                                }
                                // copy edge and attached token drafts
                                if (!edgeDict.TryGetValue(tEdge, out var cEdge)) {
                                    cEdge = NFAEdgeDraft.Connect(cFrom, cTo, tEdge.condition); edgeDict.Add(tEdge, cEdge);
                                    if (eNFAManifested.edgeTokenScriptDict.TryGetValue(tEdge, out var tokenScripts)) {
                                        NFA.edgeTokenScriptDict.TryInsert(cEdge, tokenScripts);
                                    }
                                }

                                if (!visited.Contains(tTo)) { queue.Enqueue(tTo); }
                            }
                        }
                        if (allEmpty) { // don't forget token scripts on useless states
                            foreach (var tEdge in tFrom.toEdges) {
                                var tTo = tEdge.to;
                                // copy state and attached token drafts
                                if (eNFAManifested.stateTokenScriptDict.TryGetValue(tTo, out var tokenScripts)) {
                                    NFA.stateTokenScriptDict.TryInsert(cFrom, tokenScripts);
                                }
                            }
                        }
                    }
                }
            }

            return NFA;
        }

    }

}