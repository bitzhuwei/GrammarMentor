using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class LR0StateList {
        private readonly CoupleList<LR0State> m_States = new CoupleList<LR0State>();
        public IReadOnlyList<LR0State> States => m_States;

        public bool TryInsert(LR0State state) {
            //Debug.Assert(state != null && state.index < 0);
            var inserted = this.m_States.TryInsert(state);
            if (inserted) {
                state.index = this.m_States.Count - 1;
            }

            return inserted;
        }

        /// <summary>
        /// LR(0)状态的列表
        /// 经过优化的LR(0)State列表。插入新元素用二分法，速度更快。
        /// </summary>
        /// <param name="states"></param>
        public LR0StateList(params LR0State[] states) {
            if (states != null) {
                foreach (var item in states) {
                    this.TryInsert(item);
                }
            }
        }

        public int IndexOf(LR0State state) {
            var index = this.m_States.IndexOf(state);

            return index;
        }

        public bool Contains(LR0State state) {
            var index = this.m_States.IndexOf(state);

            return index >= 0;
        }

        public void Print(System.IO.TextWriter w) {
            var states = this.m_States; var count = states.Count;
            for (int i = 0; i < count; i++) {
                var state = states[i];
                state.Print(w); if (i + 1 < count) { w.WriteLine(); }
            }
        }

        public override string ToString() {
            return $"{this.m_States.Count} LR(0)States";
        }

        public void ToMermaid(TextWriter w, VnRegulationDraft[] regulations) {
            var states = this.m_States; var count = states.Count;
            for (int i = 0; i < count; i++) {
                var state = states[i];
                state.ToMermaid(w, regulations); if (i + 1 < count) { w.WriteLine(); }
            }
        }
    }
}
