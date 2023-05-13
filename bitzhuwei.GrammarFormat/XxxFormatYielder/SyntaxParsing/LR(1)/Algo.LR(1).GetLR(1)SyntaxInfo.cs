using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// 用LR(1)分析法计算Edge、State、分析表
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="eRegulations">extended regulations.</param>
        /// <param name="eNullableDict"></param>
        /// <param name="eFIRSTDict"></param>
        /// <returns></returns>
        public static LR1SyntaxInfo GetLR1SyntaxInfo(this VnRegulationDraft[] regulations,
            VnRegulationDraft[] eRegulations, Dictionary<string, bool> eNullableDict, Dictionary<string, FIRST> eFIRSTDict) {
            var firstBetaZDict = new Dictionary<IReadOnlyList<string/*Node.type*/>, FIRST>();
            var nodeRegulationsDict = new Dictionary<string/*Node.type*/, VnRegulationDraft[]>();
            var stateList = new LR1StateList();
            var edgeList = new LR1EdgeList();
            var eEnd = CompilerGrammar.EType.EndOfTokenList;
            var queue = new Queue<LR1State>();
            {
                var firstItem = LR1Item.GetItem(eRegulations[0], 0, eEnd);
                var firstState = new LR1State(firstItem); Closure(firstState, eRegulations, eNullableDict, eFIRSTDict, firstBetaZDict, nodeRegulationsDict);
                stateList.TryInsert(firstState);
                queue.Enqueue(firstState);
            }
            while (queue.Count > 0) {
                var from = queue.Dequeue();// queueCount--;
                var Vs = new CoupleList<string>();
                foreach (var item in from.Items) {
                    Utility.Rewrite($"LR(1)StateList[{stateList.States.Count}] <-- {queue.Count}, collected {Vs.Count} V in {from.Items.Count}");

                    string/*Node.type*/ V = item.nodeNext2Dot;
                    if (V == null) { continue; }

                    Vs.TryInsert(V);
                }
                for (int itemIndex = 0; itemIndex < Vs.Count; itemIndex++) {
                    Utility.Rewrite($"LR(1)StateList[{stateList.States.Count}] <-- {queue.Count}, working on {itemIndex + 1}/{Vs.Count}");

                    var V = Vs[itemIndex];
                    var to = Goto(from, V); to.Closure(eRegulations, eNullableDict, eFIRSTDict, firstBetaZDict, nodeRegulationsDict);

                    if (stateList.TryInsert(to))//融入组织之中吧
                    {
                        queue.Enqueue(to);
                        var edge = new LR1Edge(from, V, to);
                        edgeList.TryInsert(edge);
                    }
                    else {
                        int t = stateList.IndexOf(to);
                        var oldTo = stateList.States[t];
                        var edge = new LR1Edge(from, V, oldTo);
                        edgeList.TryInsert(edge);
                    }
                }
            }
            Console.WriteLine();

            var table = new LRParsingTableDraft();
            foreach (var edge in edgeList.Edges) {
                int currentIndex = edge.from.index;// + 1;// stateCollection.IndexOf(edge.From) + 1;
                int toIndex = edge.to.index;// + 1;//stateCollection.IndexOf(edge.To) + 1
                if (edge.V == CompilerGrammar.keywordEmpty) { throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(LR1Edge.V)}"); }
                else if (edge.V.IsVt()) {
                    // shift in action
                    table.SetAction(currentIndex, edge.V, new LRShiftInActionDraft(toIndex));
                }
                else {
                    // goto action
                    table.SetAction(currentIndex, edge.V, new LRGotoActionDraft(toIndex));
                }
            }
            var eLeft = eRegulations[0].left; // the S' in many books.
            foreach (var state in stateList.States) {
                int stateId = state.index;
                foreach (var item in state.Items) {
                    string/*Node.type*/ V = item.nodeNext2Dot;
                    if (V == null) {
                        if (item.VnRegulation.left == eLeft) {
                            // accept action
                            var action = new LRAcceptActionDraft();
                            table.SetAction(stateId, eEnd, action);
                        }
                        else {
                            // reduction action
                            int reductionIndex = Array.IndexOf(eRegulations, item.VnRegulation) - 1;
                            var action = new LRReducitonActionDraft(reductionIndex);
                            {
                                table.SetAction(stateId, item.lookAhead, action);
                            }
                        }
                    }
                }
            }

            var result = new LR1SyntaxInfo(stateList, edgeList, table);

            return result;
        }

    }
}
