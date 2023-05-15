using bitzhuwei.GrammarFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA, NFA, DFA and minDFA.
    /// </summary>
    partial class AutomatonInfo {
        /// <summary>
        /// build edges that are implyed by ε edges.
        /// </summary>
        /// <param name="eNFA"></param>
        /// <returns></returns>
        private static eNFAInfo ManifesteNFA(eNFAInfo eNFA) {

            var copyed = eNFA.Copy();

            DistributeTokenScripts(copyed);

            SpreadEnds(copyed);

            CompleteEdges(copyed);

            return copyed;
        }

        /// <summary>
        /// complete edges.
        /// </summary>
        /// <param name="eNFA"></param>
        /// <param name="initialEmptyQueue"></param>
        private static void CompleteEdges(eNFAInfo eNFA) {
            var initialEmptyQueue = new Queue<eNFAEdgeDraft>();
            {
                var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(eNFA.start);
                var visited = new List<eNFAStateDraft>();
                while (queue.Count > 0) {
                    var from = queue.Dequeue();
                    if (!visited.Contains(from)) {
                        visited.Add(from);

                        foreach (var edge in from.toEdges) {
                            if (edge.IsEmpty()) {
                                if (!initialEmptyQueue.Contains(edge)) { initialEmptyQueue.Enqueue(edge); }
                            }

                            var to = edge.to;
                            if (!visited.Contains(to)) { queue.Enqueue(to); }
                        }
                    }
                }

            }
            {
                var emptyQueue = initialEmptyQueue;
                var visited = new List<eNFAEdgeDraft>();
                while (emptyQueue.Count > 0) {
                    var emptyEdge = emptyQueue.Dequeue();
                    if (!visited.Contains(emptyEdge)) {
                        visited.Add(emptyEdge);

                        var from = emptyEdge.from; var to = emptyEdge.to;
                        foreach (var edge in to.toEdges) {
                            var to2 = edge.to;
                            //// if(from -->|emptyEdge| to) { from -->|to.toEdges| to2 }
                            //if (to2 == to) { // link from --> from
                            //    var newEdge = eNFAEdgeDraft.Connect(from, from, edge.condition);
                            //    if (eNFA.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                            //        eNFA.edgeTokenScriptDict.TryInsert(newEdge, tokenScripts);
                            //    }
                            //    if (newEdge.IsEmpty()) { emptyQueue.Enqueue(newEdge); }
                            //}
                            //else { // link from --> to2
                            //    var newEdge = eNFAEdgeDraft.Connect(from, to2, edge.condition);
                            //    if (eNFA.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                            //        eNFA.edgeTokenScriptDict.TryInsert(newEdge, tokenScripts);
                            //    }
                            //    if (newEdge.IsEmpty()) { emptyQueue.Enqueue(newEdge); }
                            //}
                            var newEdge = eNFAEdgeDraft.Connect(from, to2, edge.condition);
                            if (eNFA.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                                newEdge.TryAttach(tokenScripts, eNFA);
                            }
                            if (newEdge.IsEmpty()) { emptyQueue.Enqueue(newEdge); }
                        }
                    }
                }
            }
        }

        private static void SpreadEnds(eNFAInfo eNFA) {
            var initialEnds = new Queue<eNFAStateDraft>();
            {
                var queue = new Queue<eNFAStateDraft>(); queue.Enqueue(eNFA.start);
                var visited = new List<eNFAStateDraft>();
                while (queue.Count > 0) {
                    var from = queue.Dequeue();
                    if (!visited.Contains(from)) {
                        visited.Add(from);

                        if (from.isEnd) {
                            if (!initialEnds.Contains(from)) { initialEnds.Enqueue(from); }
                        }

                        foreach (var edge in from.toEdges) {
                            var to = edge.to;
                            if (!visited.Contains(to)) { queue.Enqueue(to); }
                        }
                    }
                }
            }
            // spread the ends
            {
                var queue = initialEnds;
                var visited = new List<eNFAStateDraft>();
                while (queue.Count > 0) {
                    var state = queue.Dequeue();
                    if (!visited.Contains(state)) {
                        visited.Add(state);

                        foreach (var edge in state.fromEdges) {
                            if (edge.IsEmpty()) {
                                var from = edge.from;
                                from.isEnd = true;
                                if (!visited.Contains(from)) { queue.Enqueue(from); }
                            }
                        }
                        foreach (var edge in state.toEdges) {
                            if (edge.IsEmpty()) {
                                var to = edge.to;
                                to.isEnd = true;
                                if (!visited.Contains(to)) { queue.Enqueue(to); }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// push token drafts to non-empty edges
        /// </summary>
        /// <param name="eNFA"></param>
        /// <exception cref="NotImplementedException"></exception>
        private static void DistributeTokenScripts(eNFAInfo eNFA) {
            var list = new List<KeyValuePair<eNFAEdgeDraft, TokenScript>>();
            foreach (var item in eNFA.edgeTokenScriptDict.GetPairs()) {
                list.Add(item);
            }

            foreach (var pair in list) {
                var tokenScript = pair.Value;
                var emptyQueue = new Queue<eNFAEdgeDraft>();
                { var edge = pair.Key; emptyQueue.Enqueue(edge); }
                var visited = new List<eNFAEdgeDraft>();
                while (emptyQueue.Count > 0) {
                    var currentEdge = emptyQueue.Dequeue();
                    if (!visited.Contains(currentEdge)) {
                        visited.Add(currentEdge);

                        var from = currentEdge.from; var to = currentEdge.to;
                        switch (tokenScript.type) {
                        case ETokenScriptType.AcceptPrevious:
                        foreach (var edge in to.toEdges) {
                            edge.TryAttach(tokenScript, eNFA);
                            if (edge.IsEmpty()) {// maybe not needed ?
                                if (!visited.Contains(edge)) { emptyQueue.Enqueue(edge); }
                            }
                        }
                        break;
                        case ETokenScriptType.CheckToken:
                        // set post-regex for every related Vt
                        foreach (var edge in to.toEdges) {
                            edge.TryAttach(tokenScript, eNFA);
                            if (edge.IsEmpty()) {// maybe not needed ?
                                if (!visited.Contains(edge)) { emptyQueue.Enqueue(edge); }
                            }
                        }
                        break;
                        case ETokenScriptType.BeginToken:
                        // The assumption is that eNFA.regex is NEVER empty.
                        // Push down to non-empty edges, which are the first char of regex.
                        foreach (var edge in to.toEdges) {
                            edge.TryAttach(tokenScript, eNFA);
                            if (edge.IsEmpty()) {// maybe not needed ?
                                if (!visited.Contains(edge)) { emptyQueue.Enqueue(edge); }
                            }
                        }
                        break;
                        case ETokenScriptType.ExtendToken:
                        // update token end checkpoint
                        foreach (var edge in from.fromEdges) {
                            edge.TryAttach(tokenScript, eNFA);
                            if (edge.IsEmpty()) {// maybe not needed ?
                                if (!visited.Contains(edge)) { emptyQueue.Enqueue(edge); }
                            }
                        }
                        break;
                        case ETokenScriptType.AcceptToken:
                        from.TryAttach(tokenScript, eNFA);
                        foreach (var edge in from.fromEdges) {
                            if (edge.IsEmpty()) {
                                if (!visited.Contains(edge)) { emptyQueue.Enqueue(edge); }
                            }
                        }
                        break;
                        default:
                        throw new NotImplementedException();
                        }
                    }
                }
            }
        }
    }
}