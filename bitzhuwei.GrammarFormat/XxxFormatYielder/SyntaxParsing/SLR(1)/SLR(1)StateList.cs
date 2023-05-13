using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class SLR1StateList {
        private readonly CoupleList<SLR1State> m_States = new CoupleList<SLR1State>();
        public IReadOnlyList<SLR1State> States => m_States;

        public bool TryInsert(SLR1State slr1State) {
            //Debug.Assert(slr1State != null && slr1State.index < 0);
            var inserted = this.m_States.TryInsert(slr1State);
            if (inserted) {
                slr1State.index = this.m_States.Count - 1;
            }

            return inserted;
        }

        /// <summary>
        /// SLR(1)状态的列表
        /// 经过优化的SLR(1)State列表。插入新元素用二分法，速度更快。
        /// </summary>
        /// <param name="states"></param>
        public SLR1StateList(params SLR1State[] states) {
            if (states != null) {
                foreach (var item in states) {
                    this.TryInsert(item);
                }
            }
        }

        public int IndexOf(SLR1State state) {
            var index = this.m_States.IndexOf(state);

            return index;
        }

        public bool Contains(SLR1State state) {
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
            return $"{this.m_States.Count} SLR(1)States";
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
