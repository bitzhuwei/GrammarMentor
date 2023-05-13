using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// SLR(1)的Closure操作。
        /// 补全一个状态。
        /// </summary>
        /// <param name="state"></param>
        /// <param name="eRegulations">correspond extended <see cref="GrammarDraft.VnRegulations"/></param>
        /// <returns></returns>
        static void Closure(this SLR1State state, VnRegulationDraft[] eRegulations) {
            var queue = new Queue<SLR1Item>();
            foreach (var item in state.Items) { queue.Enqueue(item); }
            while (queue.Count > 0) {
                var item = queue.Dequeue();
                string/*Node.type*/ node = item.nodeNext2Dot;
                if (node == null || node.IsVt()) { continue; }

                foreach (var regulation in eRegulations) {
                    if (regulation.left == node) {
                        const int dotPosition = 0;
                        var newItem = SLR1Item.GetItem(regulation, dotPosition);
                        if (state.TryInsert(newItem)) {
                            queue.Enqueue(newItem);
                        }
                    }
                }
            }
        }
    }
}
