using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA, NFA, DFA and minDFA.
    /// </summary>
    partial class AutomatonInfo {
        // 子集构造法
        /// <summary>
        /// transform from NFA to DFA.
        /// </summary>
        /// <param name="NFA"></param>
        /// <returns></returns>
        private static DFAInfo ToDFA(NFAInfo NFA) {
            int DFAId = 0;// id in order of DFA state creation
            DFAInfo DFA;
            var stateList = new CoupleList<DFAStateDraft>();
            var edgeList = new CoupleList<DFAEdgeDraft>();
            var queue = new Queue<DFAStateDraft>();
            {
                var DFAStart = new DFAStateDraft(DFAId++, NFA.start.name, NFA.start);
                DFA = new DFAInfo(DFAStart, NFA);
                if (NFA.stateTokenScriptDict.TryGetValue(NFA.start, out var tokenScripts)) {
                    DFA.stateTokenScriptDict.TryInsert(DFAStart, tokenScripts);
                }
                stateList.TryInsert(DFAStart);
                queue.Enqueue(DFAStart);
            }
            while (queue.Count > 0) { // find DFA states except the DFAStart
                var from = queue.Dequeue();
                // DFAToDict: { DFAFrom go through {some chars} to { DFATo } }
                var chars = new List<char>();
                foreach (var NFAState in from.NFAStates) {
                    foreach (var NFAEdge in NFAState.toEdges) {
                        foreach (var c in NFAEdge.GetChars()) {
                            if (!chars.Contains(c)) { chars.Add(c); }
                        }
                    }
                }
                // DFATo -> matching chars
                var rawDict = new ListedDict<CoupleList<NFAEdgeDraft>, char>();
                foreach (var c in chars) {
                    var NFAEdges = new CoupleList<NFAEdgeDraft>(); // -->|c| { toStates }
                    foreach (var NFAState in from.NFAStates) {
                        foreach (var NFAEdge in NFAState.toEdges) {
                            if (NFAEdge.Contains(c)) {
                                NFAEdges.TryInsert(NFAEdge);
                            }
                        }
                    }
                    rawDict.TryInsert(NFAEdges, c);
                }
                foreach (var item in rawDict) {
                    var NFAEdges = item.Key;
                    var to = new DFAStateDraft(DFAId, from NFAEdge in NFAEdges select NFAEdge.to);
                    foreach (var NFAState in to.NFAStates) {
                        if (NFA.stateTokenScriptDict.TryGetValue(NFAState, out var tokenScripts)) {
                            DFA.stateTokenScriptDict.TryInsert(to, tokenScripts);
                        }
                    }

                    if (stateList.TryInsert(to)) {
                        DFAId++;
                        string condition;
                        var literalChars = item.Value;
                        if (OnevsOne(NFAEdges, literalChars)) { condition = NFAEdges[0].condition; }
                        else { condition = ToCharRange(literalChars); }
                        var edge = DFAEdgeDraft.Connect(from, to, condition);
                        edgeList.TryInsert(edge);
                        foreach (var NFAEdge in NFAEdges) {
                            if (NFA.edgeTokenScriptDict.TryGetValue(NFAEdge, out var tokenScripts)) {
                                DFA.edgeTokenScriptDict.TryInsert(edge, tokenScripts);
                            }
                        }

                        queue.Enqueue(to);
                    }
                    else {
                        var t = stateList.IndexOf(to);
                        var oldTo = stateList[t];
                        string condition;
                        var literalChars = item.Value;
                        if (OnevsOne(NFAEdges, literalChars)) { condition = NFAEdges[0].condition; }
                        else { condition = ToCharRange(literalChars); }
                        var edge = DFAEdgeDraft.Connect(from, oldTo, condition);
                        edgeList.TryInsert(edge);
                        foreach (var NFAEdge in NFAEdges) {
                            if (NFA.edgeTokenScriptDict.TryGetValue(NFAEdge, out var tokenScripts)) {
                                DFA.edgeTokenScriptDict.TryInsert(edge, tokenScripts);
                            }
                        }
                    }
                }
            }

            return DFA;
        }

        /// <summary>
        /// NOT actually split at all.
        /// </summary>
        /// <param name="NFAEdges"></param>
        /// <param name="literalChars"></param>
        /// <returns></returns>
        private static bool OnevsOne(CoupleList<NFAEdgeDraft> NFAEdges, CoupleList<char> literalChars) {
            if (NFAEdges.Count != 1) {
                return false;
            }

            int index = 0;
            var edge = NFAEdges[0];
            foreach (var item in edge.GetChars()) {
                if (literalChars.Count <= index) {
                    return false;
                }
                if (literalChars[index++] != item) {
                    return false;
                }
            }
            if (index != literalChars.Count) {
                return false;
            }

            return true;
        }

        // TODO: CompilerScope to perfectly analyze the charList
        //       now [-] is printed as [---], which is dumb
        private static string/*DFAEdgeDraft.condition*/ ToCharRange(CoupleList<char> charList) {
            if (charList.Count == 1) {
                var c = charList[0];
                return c.ToString();// keep the content here, should not use c.regexAppear();
            }

            //var maxLength = ConditionHelper.ASCIIinText.Length;
            //var reverse = charList.Count > maxLength / 2;
            //CoupleList<char> targetList;
            //if (reverse) {
            //    targetList = new CoupleList<char>();
            //    for (int i = 0; i < maxLength; i++) {
            //        var c = ConditionHelper.ASCIIinText[i];
            //        if (!charList.Contains(c)) { targetList.TryInsert(c); }
            //    }
            //}
            //else {
            //    targetList = charList;
            //}

            //if (targetList.Count == char.MaxValue) {
            //    return new OtherChar();
            //}

            var rangeItems = new List<RangeItem>();
            var index = 0;
            while (index < charList.Count) {
                var min = charList[index]; var max = charList[index];
                while (index < charList.Count - 1
                    && Math.Abs(charList[index] - charList[index + 1]) == 1) {
                    if (charList[index + 1] < min) { min = charList[index + 1]; }
                    if (max < charList[index + 1]) { max = charList[index + 1]; }
                    index++;
                }

                rangeItems.Add(new RangeItem(min, max));
                index++;
            }

            bool dashExists = false;
            for (int t = 0; t < rangeItems.Count; t++) {
                var rangeItem = rangeItems[t];
                if (rangeItem.min == '-' && rangeItem.max == '-') {
                    rangeItems.Remove(rangeItem);
                    t--;
                    dashExists = true;
                }
            }
            var b = new StringBuilder();
            b.Append("["); if (dashExists) { b.Append("-"); }
            foreach (var item in rangeItems) {
                b.Append(item.ToCondition());
            }
            b.Append("]");
            //return new MultipleChar(scope: b.ToString());
            return b.ToString();
        }

    }

}