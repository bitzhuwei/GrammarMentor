using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class LALR1State {
        // 分析表对第一个State是有要求的。必须是<S'> ::= . <S> "$" ;所在的state。
        // 由外部（<see cref="LALR1StateList"/>）指定的索引。
        /// <summary>
        /// index in the <see cref="LALR1StateList"/>
        /// </summary>
        public int index = -1; // -1 means not ready

        private readonly CoupleList<LALR1Item> m_Items = new CoupleList<LALR1Item>();
        public CoupleList<LALR1Item> Items => m_Items;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="items"></param>
        public LALR1State(params LALR1Item[] items) {
            if (items != null) {
                foreach (var item in items) {
                    this.TryInsert(item);
                }
            }
        }

        public bool TryInsert(LALR1Item item) {
            var inserted = this.m_Items.TryInsert(item);

            return inserted;
        }

        public int IndexOf(LALR1Item item) {
            var index = this.m_Items.IndexOf(item);

            return index;
        }

        public bool Contains(LALR1Item item) {
            var index = this.m_Items.IndexOf(item);

            return index >= 0;
        }

        public void Print(TextWriter w) {
            var items = this.m_Items; var count = items.Count;
            for (int i = 0; i < count; i++) {
                var item = items[i];
                item.Print(w);
                if (i + 1 < count) {
                    w.WriteLine();
                }
            }
        }

        public override string ToString() {
            var b = new StringBuilder();
            b.Append($"id:{this.index} ");
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        // group by group
        public void ToMermaid(TextWriter w, VnRegulationDraft[] regulations) {
            w.Write("syntaxState"); w.Write(this.index);
            w.Write("(\"syntaxState"); w.Write(this.index); w.WriteLine();
            var query = from item in this.m_Items
                        group item by new { item.VnRegulation, item.dotPosition } into g
                        select g;
            var groupCount = query.Count(); var index = 0;
            foreach (var group in query) {
                // A : X . 'y' Z ; 
                var regulation = group.Key.VnRegulation;
                var dotPosition = group.Key.dotPosition;
                if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, regulation)}] "); }
                w.Write(regulation.left); w.Write(" : ");
                var right = regulation.Right; var count = right.Count;
                for (int i = 0; i < count; i++) {
                    if (i == dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                    string/*Node.type*/ node = right[i];
                    w.Write(node.ToMermaid()); w.Write(' ');
                }
                if (dotPosition == count) { w.Write(Utility.dot); w.Write(' '); }
                w.Write("; ");
                // 'a' 'b' ...
                foreach (var item in group) {
                    w.Write(item.lookAhead.ToMermaid()); w.Write(' ');
                }

                if (index++ + 1 < groupCount) {
                    w.WriteLine();
                }
            }
            w.Write("\")");
        }

        // item by item.
        //public void ToMermaid(TextWriter w)
        //{
        //    w.Write("syntaxState"); w.Write(this.id);
        //    w.Write("(\"syntaxState"); w.Write(this.id); w.WriteLine();
        //    var items = this.m_Items; var count = items.Count;
        //    for (int i = 0; i < count; i++)
        //    {
        //        var item = items[i];
        //        item.ToMermaid(w);
        //        if (i + 1 < count)
        //        {
        //            w.WriteLine();
        //        }
        //    }
        //    w.Write("\")");
        //}
    }

}
