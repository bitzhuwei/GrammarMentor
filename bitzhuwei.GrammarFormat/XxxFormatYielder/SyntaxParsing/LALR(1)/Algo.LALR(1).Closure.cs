using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// LALR(1)的Closure操作。
        /// 补全一个状态。
        /// </summary>
        /// <param name="state"></param>
        /// <param name="eRegulations">correspond extended <see cref="GrammarDraft.VnRegulations"/></param>
        /// <param name="emptyDict"></param>
        /// <param name="firstDict"></param>
        /// <param name="afterBetaZDict">cache for faster closure.</param>
        /// <param name="nodeRegulationsDict"></param>
        /// <returns></returns>
        private static void Closure(this LALR1State state, VnRegulationDraft[] eRegulations,
            Dictionary<string/*Node.type*/, bool> emptyDict, Dictionary<string, FIRST> firstDict,
             Dictionary<IReadOnlyList<string/*Node.type*/>, FIRST> afterBetaZDict,
             Dictionary<string/*Node.type*/, VnRegulationDraft[]> nodeRegulationsDict) {
            var queue = new Queue<LALR1Item>();
            foreach (var item in state.Items) { queue.Enqueue(item); }
            while (queue.Count > 0) {
                var item = queue.Dequeue();
                string/*Node.type*/ node = item.nodeNext2Dot;
                if (node == null || node.IsVt()) { continue; }

                IReadOnlyList<string/*Node.type*/> betaZ = item.betaZ;
                if (!afterBetaZDict.TryGetValue(betaZ, out var first)) {
                    first = GetFIRST(betaZ, firstDict, emptyDict);
                    afterBetaZDict.Add(betaZ, first);
                }
                if (!nodeRegulationsDict.TryGetValue(node, out var nodeRegulations)) {
                    nodeRegulations = eRegulations.GetVnRegulations(left: node);
                    nodeRegulationsDict.Add(node, nodeRegulations);
                }
                foreach (var regulation in nodeRegulations) {
                    foreach (var lookAhead in first.Values) {
                        const int dotPosition = 0;
                        var newItem = LALR1Item.GetItem(regulation, dotPosition, lookAhead);
                        if (state.TryInsert(newItem)) {
                            queue.Enqueue(newItem);
                        }
                    }
                }
            }
        }
    }
}
