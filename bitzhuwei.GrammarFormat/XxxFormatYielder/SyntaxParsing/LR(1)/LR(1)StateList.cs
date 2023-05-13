using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class LR1StateList {
        private readonly CoupleList<LR1State> m_States = new CoupleList<LR1State>();
        public IReadOnlyList<LR1State> States => m_States;

        public bool TryInsert(LR1State state) {
            Debug.Assert(state != null && state.index < 0);

            var inserted = this.m_States.TryInsert(state);
            if (inserted) {
                state.index = this.m_States.Count - 1;
            }

            return inserted;
        }

        /// <summary>
        /// SLR(1)状态的列表
        /// 经过优化的SLR(1)State列表。插入新元素用二分法，速度更快。
        /// </summary>
        /// <param name="states"></param>
        public LR1StateList(params LR1State[] states) {
            if (states != null) {
                foreach (var item in states) {
                    this.TryInsert(item);
                }
            }
        }

        public int IndexOf(LR1State state) {
            var index = this.m_States.IndexOf(state);

            return index;
        }

        public bool Contains(LR1State state) {
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
            return $"{this.m_States.Count} LR(1)States";
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
