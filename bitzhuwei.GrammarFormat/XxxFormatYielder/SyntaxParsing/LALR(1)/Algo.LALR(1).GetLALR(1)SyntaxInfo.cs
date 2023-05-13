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
        // optimized
        /// <summary>
        /// 用LALR(1)分析法计算Edge、State、分析表
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="eRegulations">extended regulations.</param>
        /// <param name="eEmptyDict"></param>
        /// <param name="eFIRSTDict"></param>
        /// <returns></returns>
        public static LALR1SyntaxInfo GetLALR1SyntaxInfo(this VnRegulationDraft[] regulations,
            VnRegulationDraft[] eRegulations, Dictionary<string, bool> eEmptyDict, Dictionary<string, FIRST> eFIRSTDict) {
            var stateList = new LALR1StateList();
            var edgeList = new LALR1EdgeList();
            var eEnd = CompilerGrammar.EType.EndOfTokenList;
            var afterBetaZDict = new Dictionary<IReadOnlyList<string/*Node.type*/>, FIRST>();
            var nodeRegulationsDict = new Dictionary<string/*Node.type*/, VnRegulationDraft[]>();
            var queue = new Queue<LALR1State>();
            {
                var firstItem = LALR1Item.GetItem(eRegulations[0], 0, eEnd);
                var firstState = new LALR1State(firstItem); Closure(firstState, eRegulations, eEmptyDict, eFIRSTDict, afterBetaZDict, nodeRegulationsDict);
                stateList.TryInsert(firstState);
                queue.Enqueue(firstState);
            }
            while (queue.Count > 0) {
                var from = queue.Dequeue();
                var Vs = new CoupleList<string>();
                foreach (var item in from.Items) {
                    Utility.Rewrite($"LALR(1)StateList[{stateList.States.Count}] <-- {queue.Count}, collected {Vs.Count} V in {from.Items.Count}");

                    string/*Node.type*/ V = item.nodeNext2Dot;
                    if (V == null) { continue; }

                    Vs.TryInsert(V);
                }
                for (int index = 0; index < Vs.Count; index++) {
                    Utility.Rewrite($"LALR(1)StateList[{stateList.States.Count}] <-- {queue.Count}, working on {index + 1}/{Vs.Count}");

                    var V = Vs[index];
                    var to = Goto(from, V); to.Closure(eRegulations, eEmptyDict, eFIRSTDict, afterBetaZDict, nodeRegulationsDict);

                    if (stateList.TryInsert(to))//融入组织之中吧
                    {
                        queue.Enqueue(to);
                        var edge = new LALR1Edge(from, V, to);
                        edgeList.TryInsert(edge);
                    }
                    else {
                        int t = stateList.IndexOf(to);
                        var oldTo = stateList.States[t];

                        // add lookAheads in toState to target.
                        var updated = false;
                        foreach (var item in to.Items) { if (oldTo.TryInsert(item)) { updated = true; } }
                        if (updated) { queue.Enqueue(oldTo); }

                        var edge = new LALR1Edge(from, V, oldTo);
                        edgeList.TryInsert(edge);
                    }
                }
            }
            Console.WriteLine();

            var table = new LRParsingTableDraft();
            foreach (var edge in edgeList.Edges) {
                int currentIndex = edge.from.index;
                int toIndex = edge.to.index;
                if (edge.V == CompilerGrammar.keywordEmpty) { throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(LALR1Edge.V)}"); }
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

            var result = new LALR1SyntaxInfo(stateList, edgeList, table);

            return result;
        }

        ///// <summary>
        ///// add lookAheads in <paramref name="newOne"/> to <paramref name="target"/>
        ///// </summary>
        ///// <param name="target"></param>
        ///// <param name="newOne"></param>
        ///// <exception cref="NotImplementedException"></exception>
        //private static void RefreshLookAhead(LALR1State target, LALR1State newOne) {
        //    foreach (var item in newOne.Items) {
        //        target.TryInsert(item);
        //    }
        //}

        // before optimazed
        ///// <summary>
        ///// 用LALR(1)分析法计算Edge、State、分析表
        ///// </summary>
        ///// <param name="regulations"></param>
        ///// <param name="eRegulations">extended regulations.</param>
        ///// <param name="eEmptyDict"></param>
        ///// <param name="eFIRSTDict"></param>
        ///// <returns></returns>
        //public static LALR1SyntaxInfo GetLALR1SyntaxInfo(this VnRegulationDraft[] regulations,
        //    VnRegulationDraft[] eRegulations, Dictionary<string, bool> eEmptyDict, Dictionary<string, FIRST> eFIRSTDict)
        //{
        //    var eEnd = CompilerGrammar.EType.EndOfTokenList;
        //    var firstItem = new LALR1Item(eRegulations[0], 0, eEnd);
        //    var firstState = new LALR1State(firstItem); Closure(firstState, eRegulations, eEmptyDict, eFIRSTDict);
        //    var stateList = new LALR1StateList(firstState);
        //    var edgeList = new LALR1EdgeList();
        //    var queue = new Queue<LALR1State>(); queue.Enqueue(firstState);
        //    int lastOutputLength = 0;
        //    while (queue.Count > 0)
        //    {
        //        var fromState = queue.Dequeue();// queueCount--;
        //        int itemIndex = 0;
        //        int itemCount = fromState.Items.Count;
        //        foreach (var item in fromState.Items)
        //        {
        //            for (int i = 0; i < lastOutputLength; i++) { Console.Write('\u0008'); }
        //            string output = $"Calculating LALR(1) State List: {stateList.States.Count} < -- {queue.Count}, working on {1 + itemIndex++}/{itemCount}";
        //            Console.Write(output);
        //            lastOutputLength = output.Length;

        //            string/*Node.type*/ V = item.GetNodeNext2Dot();
        //            if (V == null) { continue; }
        //            var toState = Goto(fromState, V, eEmptyDict, eFIRSTDict); toState.Closure(eRegulations, eEmptyDict, eFIRSTDict);
        //            if (stateList.TryInsert(toState))//融入组织之中吧
        //            {
        //                queue.Enqueue(toState);
        //                var edge = new LALR1Edge(fromState, V, toState);
        //                edgeList.TryInsert(edge);
        //            }
        //            else
        //            {
        //                int index = stateList.IndexOf(toState);
        //                toState = stateList.States[index];
        //                var edge = new LALR1Edge(fromState, V, toState);
        //                edgeList.TryInsert(edge);
        //            }
        //        }
        //    }
        //    Console.WriteLine();

        //    var table = new LRParsingTableDraft();
        //    foreach (var edge in edgeList.Edges)
        //    {
        //        int currentId = edge.From.id;// + 1;// stateCollection.IndexOf(edge.From) + 1;
        //        int toId = edge.To.id;// + 1;//stateCollection.IndexOf(edge.To) + 1
        //        if (edge.V == CompilerGrammar.keywordEmpty) { throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(LALR1Edge.V)}"); }
        //        else if (edge.V.IsVt())
        //        {
        //            table.SetAction(currentId, edge.V, new LRShiftInActionDraft(toId));
        //        }
        //        else
        //        {
        //            table.SetAction(currentId, edge.V, new LRGotoActionDraft(toId));
        //        }
        //    }
        //    var eLeft = eRegulations[0].left; // the S' in many books.
        //    foreach (var state in stateList.States)
        //    {
        //        foreach (var item in state.Items)
        //        {
        //            string/*Node.type*/ V = item.GetNodeNext2Dot();
        //            if (V == null)
        //            {
        //                int currentId = state.id;// + 1;//stateCollection.IndexOf(state) + 1
        //                if (item.VnRegulation.left == eLeft)
        //                {
        //                    // accept action
        //                    //int reductionId = Array.IndexOf(eRegulations, lr0Item.VnRegulation) - 1;
        //                    //var action = new LR1ReducitonActionDraft(reductionId);
        //                    var action = new LRAcceptActionDraft();
        //                    table.SetAction(currentId, eEnd, action);
        //                }
        //                else
        //                {
        //                    // reduction action
        //                    int reductionId = Array.IndexOf(eRegulations, item.VnRegulation) - 1;
        //                    var action = new LRReducitonActionDraft(reductionId);
        //                    {
        //                        table.SetAction(currentId, item.LookAheadNode, action);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    var result = new LALR1SyntaxInfo(stateList, edgeList, table);

        //    return result;
        //}
    }
}
