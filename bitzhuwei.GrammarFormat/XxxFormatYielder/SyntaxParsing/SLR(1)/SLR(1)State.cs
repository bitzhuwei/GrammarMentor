using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class SLR1State {
        // 分析表对第一个State是有要求的。必须是<S'> ::= . <S> "$" ;所在的state。
        // 由外部（<see cref="SLR1StateList"/>）指定的索引。
        /// <summary>
        /// index in the <see cref="SLR1StateList"/>
        /// </summary>
        public int index = -1;// not ready

        /// <summary>
        /// list of <see cref="SLR1Item"/>.
        /// </summary>
        private readonly CoupleList<SLR1Item> m_Items = new CoupleList<SLR1Item>();
        /// <summary>
        /// list of <see cref="SLR1Item"/>.
        /// </summary>
        public IReadOnlyList<SLR1Item> Items => m_Items;

        /// <summary>
        /// </summary>
        /// <param name="item"></param>
        public SLR1State(params SLR1Item[] item) {
            if (item != null) {
                foreach (var lr0Item in item) {
                    bool inserted = this.m_Items.TryInsert(lr0Item);
                    //if (inserted) { this.dirty = true; }
                }
            }
        }
        public bool TryInsert(SLR1Item item) {
            Debug.Assert(item != null);

            var inserted = this.m_Items.TryInsert(item);
            if (inserted) {
                this.dirty = true;
            }

            return inserted;
        }

        public int IndexOf(SLR1Item item) {
            var index = this.m_Items.IndexOf(item);

            return index;
        }

        public bool Contains(SLR1Item item) {
            var index = this.m_Items.IndexOf(item);

            return index >= 0;
        }

        public void Print(TextWriter w) {
            w.Write("syntaxStates["); w.Write(this.index); w.WriteLine("] = {");
            var items = this.m_Items; var count = items.Count;
            for (int i = 0; i < count; i++) {
                var item = items[i];
                w.Write("    "); item.Print(w); w.WriteLine();
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

        //public int CompareTo(SLR1State other)
        //{
        //    if (other == null) { return 1; }

        //    int aCount = this.m_Items.Count;
        //    int bCount = other.m_Items.Count;
        //    if (aCount < bCount) { return -1; }
        //    else if (aCount > bCount) { return 1; }
        //    else
        //    {
        //        int result = 0;
        //        for (int i = 0; i < aCount; i++)
        //        {
        //            var a = this.m_Items[i];
        //            var b = other.m_Items[i];
        //            Debug.Assert(a != null && b != null);
        //            var value = a.CompareTo(b);
        //            if (value != 0)
        //            {
        //                result = value;
        //                break;
        //            }
        //        }

        //        return result;
        //    }
        //}
    }
}
