using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// LALR(1)的Goto操作。
        /// 将圆点移到所有LR(1)项中的符号<paramref name="V"/>之后。
        /// </summary>
        /// <param name="state"></param>
        /// <param name="V">一个文法符号，终结点或非终结点。</param>
        /// <returns></returns>
        static LALR1State Goto(this LALR1State state, string/*Node.type*/ V) {
            var toState = new LALR1State();
            //foreach (var group in state.GetGroups())
            //{
            //    string/*Node.type*/ nextNode = group.Item1.GetNodeNext2Dot();
            //    if (nextNode == x)
            //    {
            //        toState.TryInsert(
            //            new LR0Item(group.Item1.VnRegulation, group.Item1.DotPosition + 1),
            //            group.Item2);
            //    }
            //}
            foreach (var item in state.Items) {
                string/*Node.type*/ next = item.nodeNext2Dot;
                if (next == V) {
                    var newItem = LALR1Item.GetItem(item.VnRegulation, item.dotPosition + 1, item.lookAhead);
                    toState.TryInsert(newItem);
                }
            }

            return toState;
        }

    }
}
