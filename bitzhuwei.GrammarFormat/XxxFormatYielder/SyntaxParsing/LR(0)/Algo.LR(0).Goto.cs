using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// LR(0)的Goto操作。
        /// 将圆点移到所有LR(0)项中的符号<paramref name="V"/>之后。
        /// </summary>
        /// <param name="state"></param>
        /// <param name="V">a Vt or a Vn</param>
        /// <returns></returns>
        static LR0State Goto(this LR0State state, string/*Node.type*/ V) {
            var toState = new LR0State();
            foreach (var item in state.Items) {
                string/*Node.type*/ nextNode = item.nodeNext2Dot;
                if (nextNode == V) {
                    var newItem = LR0Item.GetItem(item.VnRegulation, item.dotPosition + 1);
                    toState.TryInsert(newItem);
                }
            }

            return toState;
        }
    }
}
