using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class LR0State {
        // 分析表对第一个State是有要求的。必须是<S'> ::= . <S> "$" ;所在的state。
        // 由外部（<see cref="LR0StateList"/>）指定的索引。
        /// <summary>
        /// index in the <see cref="LR0StateList"/>
        /// </summary>
        public int index = -1;// -1 means not ready

        /// <summary>
        /// list of <see cref="LR0Item"/>.
        /// </summary>
        private readonly CoupleList<LR0Item> m_Items = new CoupleList<LR0Item>();
        /// <summary>
        /// list of <see cref="LR0Item"/>.
        /// </summary>
        public IReadOnlyList<LR0Item> Items => m_Items;

        /// <summary>
        /// </summary>
        /// <param name="items"></param>
        public LR0State(params LR0Item[] items) {
            if (items != null) {
                foreach (var item in items) {
                    bool inserted = this.m_Items.TryInsert(item);
                    // if (inserted) { this.dirty = true; }
                }
            }
        }
        public bool TryInsert(LR0Item item) {
            var inserted = this.m_Items.TryInsert(item);
            if (inserted) {
                this.dirty = true;
            }

            return inserted;
        }

        public int IndexOf(LR0Item item) {
            var index = this.m_Items.IndexOf(item);

            return index;
        }

        public bool Contains(LR0Item item) {
            var index = this.m_Items.IndexOf(item);

            return index >= 0;
        }

        public void Print(TextWriter w) {
            w.Write("syntaxStates["); w.Write(this.index); w.WriteLine("] = {");
            var lr0Items = this.m_Items; var count = lr0Items.Count;
            for (int i = 0; i < count; i++) {
                var lr0Item = lr0Items[i];
                w.Write("    "); lr0Item.Print(w); w.WriteLine();
            }
            w.Write("}");
        }

        public override string ToString() {
            var b = new StringBuilder();
            b.Append($"id:{this.index} ");
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        public void ToMermaid(TextWriter w, VnRegulationDraft[] regulations) {
            w.Write("syntaxState"); w.Write(this.index);
            w.Write("(\"syntaxState"); w.Write(this.index); w.WriteLine();
            var items = this.m_Items;
            var count = items.Count;
            for (int i = 0; i < count; i++) {
                var item = items[i];
                item.ToMermaid(w, regulations);
                //w.Write("， ");
                w.Write(" ");
                if (i + 1 < count) {
                    w.WriteLine();
                }
            }
            w.Write("\")");
        }
    }
}
