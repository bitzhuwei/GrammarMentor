using bitzhuwei.GrammarFormat;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA, NFA, DFA and minDFA.
    /// </summary>
    partial class AutomatonInfo {
        /// <summary>
        /// minimize states of the specified <paramref name="DFAInfo"/>.
        /// </summary>
        /// <param name="DFAInfo"></param>
        /// <returns></returns>
        private static MiniDFAInfo ToMiniDFA(DFAInfo DFAInfo) {
            List<CoupleList<DFAStateDraft>> chaos = InitChaos(DFAInfo);
            var completedChaos = SplitChaos(chaos);
            // dump minimum DFA
            MiniDFAStateDraft[] miniDFAStates = ConstructMiniDFAStates(completedChaos);
            MiniDFAInfo result;
            {
                MiniDFAStateDraft miniDFAStart = null;
                foreach (var state in miniDFAStates) {
                    if (state.DFAStates.Contains(DFAInfo.start)) {
                        miniDFAStart = state;
                        break;
                    }
                }
                if (miniDFAStart != null) {
                    result = new MiniDFAInfo(miniDFAStart, DFAInfo);
                }
                else { throw new NotImplementedException(); }
            }
            foreach (var miniDFAState in miniDFAStates) {
                foreach (var DFAState in miniDFAState.DFAStates) {
                    if (DFAInfo.stateTokenScriptDict.TryGetValue(DFAState, out var tokenScripts)) {
                        result.stateTokenScriptDict.TryInsert(miniDFAState, tokenScripts);
                    }
                }
            }

            // DFA state -> index of the item(which is a collection) in chaos
            var DFA2ChaosDict = new Dictionary<DFAStateDraft, /*Collection<DFAStateDraft>*/int>();
            {
                var count = completedChaos.Count;
                for (int index = 0; index < count; index++) {
                    var DFAStates = completedChaos[index];
                    foreach (var DFAState in DFAStates) { DFA2ChaosDict.Add(DFAState, /*DFAStates*/index); }
                }
            }
            //var tokenScriptDict = new ListedDict<DFAEdgeDraft, TokenDraft>();
            {
                // edges and tokenScripts of minimum DFA
                var miniEdges = new CoupleList<MiniDFAEdgeDraft>();
                var queue = new Queue<DFAStateDraft>(); queue.Enqueue(DFAInfo.start);
                var visited = new List<DFAStateDraft>();
                while (queue.Count > 0) {
                    var from = queue.Dequeue();
                    if (!visited.Contains(from)) {
                        visited.Add(from);
                        var fromIndex = DFA2ChaosDict[from];// var fromIndex = chaos.IndexOf(chaosFrom);
                        var miniDFAFrom = miniDFAStates[fromIndex];
                        foreach (var edge in from.toEdges) {
                            var to = edge.to;
                            var toIndex = DFA2ChaosDict[to];// var toIndex = chaos.IndexOf(chaosTo);
                            var newEdge = MiniDFAEdgeDraft.Connect(miniDFAFrom, miniDFAStates[toIndex], edge.condition);
                            if (miniEdges.TryInsert(newEdge)) {
                                if (DFAInfo.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                                    result.edgeTokenScriptDict.TryInsert(newEdge, tokenScripts);
                                }
                            }
                            else {
                                var t = miniEdges.IndexOf(newEdge);
                                var oldEdge = miniEdges[t];
                                if (DFAInfo.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                                    result.edgeTokenScriptDict.TryInsert(oldEdge, tokenScripts);
                                }
                            }

                            if (!visited.Contains(to)) { queue.Enqueue(to); }
                        }
                    }
                }
            }

            return result;
        }

        private static MiniDFAStateDraft[] ConstructMiniDFAStates(List<CoupleList<DFAStateDraft>> completedChaos) {
            var count = completedChaos.Count;
            var miniDFAStates = new MiniDFAStateDraft[count];
            for (int id = 0; id < count; id++) {
                var DFAStates = completedChaos[id];
                var miniDFAState = new MiniDFAStateDraft(id, DFAStates);
                //from DFAState in DFAStates select DFAState);
                miniDFAStates[id] = miniDFAState;
            }

            return miniDFAStates;
        }

        private static List<CoupleList<DFAStateDraft>> SplitChaos(List<CoupleList<DFAStateDraft>> initialChaos) {
            var currentChaos = initialChaos;
            bool updated = true;
            while (updated) {
                var nextChaos = new List<CoupleList<DFAStateDraft>>();
                foreach (var group in currentChaos) {
                    var grouped = new List<int>();
                    for (int i = 0; i < group.Count; i++) {
                        if (grouped.Contains(i)) { continue; }

                        var standard = group[i];
                        var buildingGroup = new CoupleList<DFAStateDraft>(); buildingGroup.TryInsert(standard);
                        grouped.Add(i);
                        for (int j = i + 1; j < group.Count; j++) {
                            if (grouped.Contains(j)) { continue; }

                            var state = group[j];
                            if (EqualValue(standard, state, currentChaos)) {
                                buildingGroup.TryInsert(state);
                                grouped.Add(j);
                            }
                        }
                        nextChaos.Add(buildingGroup);
                    }

                    //CoupleList<DFAStateDraft> newGroup = null;
                    //foreach (var state in group) {
                    //    if (newGroup == null) {
                    //        newGroup = new CoupleList<DFAStateDraft>(); newGroup.TryInsert(state);
                    //        nextChaos.Add(newGroup);
                    //    }
                    //    else {
                    //        var standard = newGroup[0];
                    //        if (EqualValue(standard, state, currentChaos)) {
                    //            newGroup.TryInsert(state);
                    //        }
                    //        else {
                    //            newGroup = new CoupleList<DFAStateDraft>(); newGroup.TryInsert(state);
                    //            nextChaos.Add(newGroup);
                    //            updated = true;
                    //        }
                    //    }
                    //}
                }

                updated = nextChaos.Count != currentChaos.Count;
                currentChaos = nextChaos;
            }

            return currentChaos;
        }

        /// <summary>
        /// <paramref name="standard"/> and <paramref name="current"/> are in the same group of <paramref name="chaos"/>.
        /// <para>Are they of equal value?</para>
        /// </summary>
        /// <param name="standard"></param>
        /// <param name="current"></param>
        /// <param name="chaos"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static bool EqualValue(DFAStateDraft standard, DFAStateDraft current, List<CoupleList<DFAStateDraft>> chaos) {
            var standardDict = new Dictionary<char, int>();// standard.sChar -> index of the group in the chaos.
            foreach (var edge in standard.toEdges) {
                foreach (var sChar in edge.GetChars()) {
                    var to = edge.to; bool found4c = false;
                    for (int sIndex = 0; sIndex < chaos.Count; sIndex++) {
                        var group = chaos[sIndex];
                        foreach (var item in group) {
                            if (item == to) {
                                if (standardDict.TryGetValue(sChar, out var index)) {
                                    if (sIndex != index) { throw new NotImplementedException(); }
                                    Console.WriteLine($"standard: repeated {sChar}");
                                    Console.WriteLine($"{edge}");
                                }
                                else {
                                    standardDict.Add(sChar, sIndex);
                                }

                                found4c = true;
                                break;
                            }
                        }
                        if (found4c) { break; }
                    }
                }
            }

            bool equalValue = true;
            // current.cChar -> index of the group in the chaos.
            var currentDict = new Dictionary<char, int>();
            // is every char(in every edge) refer to same group in chaos?
            // for all char(in every edge), if standard and current go to same group, then standard and current are of equal value.
            // Q: what does that mean?
            // A: when char is 'a', standard and current both go to some DFAstates of the same <groupX>(no matter which DFAstate, same or different),
            //  & when char is 'b', standard and current both go to some DFAstates of the same <groupX>(no matter which DFAstate, same or different),
            //  & when char is 'c', standard and current both go to some DFAstates of the same <groupY>(no matter which DFAstate, same or different),
            //  & ... (the list of ['a', 'b', 'c', ..] ranges from char.MinValue to char.MaxValue)
            foreach (var edge in current.toEdges) {
                foreach (var cChar in edge.GetChars()) {
                    if (!standardDict.TryGetValue(cChar, out var sIndex)) { equalValue = false; break; }

                    var to = edge.to; bool found4c = false;
                    for (int cIndex = 0; cIndex < chaos.Count; cIndex++) {
                        var group = chaos[cIndex];
                        foreach (var item in group) {
                            if (item == to) {
                                if (sIndex != cIndex) { equalValue = false; }
                                else {
                                    if (currentDict.TryGetValue(cChar, out var index)) {
                                        if (cIndex != index) { throw new NotImplementedException(); }
                                        // TODO: log for semantic error of grammar
                                        Console.WriteLine($"current: repeated {cChar}");
                                        Console.WriteLine($"{edge}");
                                    }
                                    else {
                                        currentDict.Add(cChar, cIndex);
                                    }
                                }

                                found4c = true;
                                break;
                            }
                        }
                        if (found4c) { break; }
                    }
                    if (!equalValue) { break; }
                }
                if (!equalValue) { break; }
            }

            if (standardDict.Count != currentDict.Count) { equalValue = false; }

            return equalValue;
        }

        private static List<CoupleList<DFAStateDraft>> InitChaos(DFAInfo DFAInfo) {
            var chaos = new List<CoupleList<DFAStateDraft>>();
            /*var ends = new CoupleList<DFAStateDraft>();*/
            var others = new CoupleList<DFAStateDraft>();
            var queue = new Queue<DFAStateDraft>(); queue.Enqueue(DFAInfo.start);
            var visited = new List<DFAStateDraft>();
            while (queue.Count > 0) {
                var from = queue.Dequeue();
                if (!visited.Contains(from)) {
                    visited.Add(from);

                    //bool isEnd = false;
                    // failed solution:
                    //if (from.isEnd) {
                    //    var VtId = from.NFAStates[0].VtId;
                    //    foreach (var item in from.NFAStates) {
                    //        if (item.VtId != VtId) { Console.WriteLine(item.VtId); break; }
                    //    }
                    //}

                    //if (DFAInfo.stateTokenScriptDict.TryGetValue(from, out var _)) {
                    //    isEnd = true;
                    //}
                    //else {
                    //    foreach (var edge in from.fromEdges) {
                    //        if (DFAInfo.edgeTokenScriptDict.TryGetValue(edge, out var _)) {
                    //            isEnd = true; break;
                    //        }
                    //    }
                    //}

                    //if (DFAInfo.endDict.TryGetValue(tState, out var tokenEndDraft)) { starts.Add(tState); }
                    //else { others.Add(tState); }

                    //if (tState == DFAInfo.start) { starts.TryInsert(tState); }
                    //else { others.TryInsert(tState); }

                    // just split every ends for now
                    if (from.isEnd) { /*ends.TryInsert(from);*/
                        var ends = new CoupleList<DFAStateDraft>(); ends.TryInsert(from);
                        chaos.Add(ends);
                    }
                    else { others.TryInsert(from); }

                    foreach (var edge in from.toEdges) {
                        var to = edge.to;
                        //if (to != from) { isEnd = false; }

                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }

            if (others.Count > 0) { chaos.Insert(0, others); /*chaos.Add(others);*/ }
            //if (ends.Count > 0) { chaos.Add(ends); }

            return chaos;
        }

        //private static List<CoupleList<DFAStateDraft>> InitChaos(DFAInfo DFAInfo) {
        //    var chaos = new List<CoupleList<DFAStateDraft>>();
        //    var ends = new CoupleList<DFAStateDraft>(); var others = new CoupleList<DFAStateDraft>();
        //    var queue = new Queue<DFAStateDraft>(); queue.Enqueue(DFAInfo.start);
        //    var visited = new List<DFAStateDraft>();
        //    while (queue.Count > 0) {
        //        var from = queue.Dequeue();
        //        if (!visited.Contains(from)) {
        //            visited.Add(from);

        //            bool isEnd = true;
        //            //if (from.toEdges.Count > 0) { isEnd = false; }

        //            foreach (var edge in from.toEdges) {
        //                var to = edge.to;
        //                if (to != from) { isEnd = false; }

        //                if (!visited.Contains(to)) { queue.Enqueue(to); }
        //            }

        //            if (isEnd) { ends.TryInsert(from); }
        //            else { others.TryInsert(from); }
        //            //if (DFAInfo.endDict.TryGetValue(tState, out var tokenEndDraft)) { starts.Add(tState); }
        //            //else { others.Add(tState); }
        //            //if (tState == DFAInfo.start) { starts.TryInsert(tState); }
        //            //else { others.TryInsert(tState); }
        //        }
        //    }

        //    if (others.Count > 0) { chaos.Add(others); }
        //    if (ends.Count > 0) { chaos.Add(ends); }

        //    return chaos;
        //}
    }
}