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
        /// 用LR(0)分析法计算Edge、State、分析表
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="eRegulations">extended regulations.</param>
        /// <returns></returns>
        public static LR0SyntaxInfo GetLR0SyntaxInfo(this VnRegulationDraft[] regulations,
            VnRegulationDraft[] eRegulations) {
            var stateList = new LR0StateList();
            var edgeList = new LR0EdgeList();
            var queue = new Queue<LR0State>();
            {
                var firstItem = LR0Item.GetItem(eRegulations[0], 0);
                var firstState = new LR0State(firstItem); Closure(firstState, eRegulations);
                stateList.TryInsert(firstState);
                queue.Enqueue(firstState);
            }
            while (queue.Count > 0) {
                var from = queue.Dequeue();
                var Vs = new CoupleList<string>();
                foreach (var item in from.Items) {
                    Utility.Rewrite($"LR(0)StateList[{stateList.States.Count}] <-- {queue.Count}, collected {Vs.Count} V in {from.Items.Count}");

                    string/*Node.type*/ V = item.nodeNext2Dot;
                    if (V == null) { continue; }
                    Vs.TryInsert(V);
                }
                for (int index = 0; index < Vs.Count; index++) {
                    Utility.Rewrite($"LR(0)StateList[{stateList.States.Count}] <-- {queue.Count}, working on {index + 1}/{Vs.Count}");

                    var V = Vs[index];
                    var to = Goto(from, V); Closure(to, eRegulations);
                    if (stateList.TryInsert(to)) {
                        queue.Enqueue(to);
                        var edge = new LR0Edge(from, V, to);
                        edgeList.TryInsert(edge);
                    }
                    else {
                        int t = stateList.IndexOf(to);
                        var oldTo = stateList.States[t];
                        var edge = new LR0Edge(from, V, oldTo);
                        edgeList.TryInsert(edge);
                    }
                }
            }
            Console.WriteLine();

            var table = new LRParsingTableDraft();
            foreach (var edge in edgeList.Edges) {
                int currentInex = edge.from.index;// + 1;//stateCollection.IndexOf(edge.From) + 1;
                int toIndex = edge.to.index;// + 1;//stateCollection.IndexOf(edge.To) + 1;
                if (edge.V == CompilerGrammar.keywordEmpty) { throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(LR0Edge.V)}"); }
                else if (edge.V.IsVt()) {
                    // shift in action
                    table.SetAction(currentInex, edge.V, new LRShiftInActionDraft(toIndex));
                }
                else {
                    // goto action
                    table.SetAction(currentInex, edge.V, new LRGotoActionDraft(toIndex));
                }
            }
            var Vts = eRegulations.GetVtNodes();
            var eLeft = eRegulations[0].left; // the S' in many books.
            var eEnd = CompilerGrammar.EType.EndOfTokenList;
            foreach (var state in stateList.States) {
                int stateId = state.index;
                foreach (var item in state.Items) {
                    string/*Node.type*/ V = item.nodeNext2Dot;
                    if (V == null) {
                        if (item.VnRegulation.left == eLeft) {
                            // accept action
                            var acceptAction = new LRAcceptActionDraft();
                            table.SetAction(stateId, eEnd, acceptAction);
                        }
                        else {
                            // reduction action
                            int reductionIndex = Array.IndexOf(eRegulations, item.VnRegulation) - 1;
                            var action = new LRReducitonActionDraft(reductionIndex);
                            foreach (var Vt in Vts) {
                                table.SetAction(stateId, Vt, action);
                            }
                            {
                                table.SetAction(stateId, eEnd, action);
                            }
                        }
                    }
                }
            }

            var result = new LR0SyntaxInfo(stateList, edgeList, table);

            return result;
        }
        // before optimized
        ///// <summary>
        ///// 用LR(0)分析法计算Edge、State、分析表
        ///// </summary>
        ///// <param name="regulations"></param>
        ///// <param name="eRegulations">extended regulations.</param>
        ///// <returns></returns>
        //public static LR0SyntaxInfo GetLR0SyntaxInfo(this VnRegulationDraft[] regulations,
        //    VnRegulationDraft[] eRegulations)
        //{
        //    var firstItem = new LR0Item(eRegulations[0], 0);
        //    var firstState = new LR0State(firstItem); Closure(firstState, eRegulations);
        //    var stateList = new LR0StateList(firstState);
        //    var edgeList = new LR0EdgeList(/*lr0StateList*/);
        //    var queue = new Queue<LR0State>(); queue.Enqueue(firstState);
        //    while (queue.Count > 0)
        //    {
        //        var fromState = queue.Dequeue();
        //        int itemIndex = 0;
        //        foreach (var item in fromState.Items)
        //        {
        //            Utility.Rewrite($"Calculating LR(0) State List: {stateList.States.Count} < -- {queue.Count}, working on {1 + itemIndex++}/{fromState.Items.Count}");

        //            string/*Node.type*/ V = item.GetNodeNext2Dot();
        //            if (V == null) { continue; }

        //            var toState = Goto(fromState, V); Closure(toState, eRegulations);
        //            if (stateList.TryInsert(toState))
        //            {
        //                queue.Enqueue(toState);
        //                var edge = new LR0Edge(fromState, V, toState);
        //                edgeList.TryInsert(edge);
        //            }
        //            else
        //            {
        //                int index = stateList.IndexOf(toState);
        //                toState = stateList.States[index];
        //                var edge = new LR0Edge(fromState, V, toState);
        //                edgeList.TryInsert(edge);
        //            }
        //        }
        //    }
        //    Console.WriteLine();

        //    var table = new LRParsingTableDraft();
        //    foreach (var edge in edgeList.Edges)
        //    {
        //        int currentId = edge.From.id;// + 1;//stateCollection.IndexOf(edge.From) + 1;
        //        int toId = edge.To.id;// + 1;//stateCollection.IndexOf(edge.To) + 1;
        //        if (edge.V == CompilerGrammar.keywordEmpty) { throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(LR0Edge.V)}"); }
        //        else if (edge.V.IsVt())
        //        {
        //            // shift action
        //            table.SetAction(currentId, edge.V, new LRShiftInActionDraft(toId));
        //        }
        //        else
        //        {
        //            // goto action
        //            table.SetAction(currentId, edge.V, new LRGotoActionDraft(toId));
        //        }
        //    }
        //    var Vts = eRegulations.GetVtNodes();
        //    var eLeft = eRegulations[0].left; // the S' in many books.
        //    var eEnd = CompilerGrammar.EType.EndOfTokenList;
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
        //                    foreach (var Vt in Vts)
        //                    {
        //                        table.SetAction(currentId, Vt, action);
        //                    }
        //                    {
        //                        table.SetAction(currentId, eEnd, action);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    var result = new LR0SyntaxInfo(stateList, edgeList, table);

        //    return result;
        //}

    }
}
