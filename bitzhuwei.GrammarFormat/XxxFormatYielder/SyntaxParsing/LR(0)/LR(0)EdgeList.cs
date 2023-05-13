using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// 经过优化的LR(0)Edge列表。插入新元素用二分法，速度更快。
    /// </summary>
    public partial class LR0EdgeList {
        private readonly CoupleList<LR0Edge> m_Edges = new CoupleList<LR0Edge>();
        public IEnumerable<LR0Edge> Edges => m_Edges;
        /// <summary>
        /// 经过优化的LR(0)Edge列表。插入新元素用二分法，速度更快。
        /// </summary>
        /// <param name="edges"></param>
        public LR0EdgeList(params LR0Edge[] edges) {
            if (edges != null) {
                foreach (var item in edges) {
                    this.TryInsert(item);
                }
            }
        }

        public bool TryInsert(LR0Edge edge) {
            var inserted = this.m_Edges.TryInsert(edge);
            //if (inserted)
            //{
            //    this.dirty = true;
            //}

            return inserted;
        }

        public void Print(System.IO.TextWriter w) {
            var edges = this.m_Edges; var count = edges.Count;
            for (int i = 0; i < count; i++) {
                var edge = edges[i];
                w.Write($"Edges[{i}]: "); edge.Print(w);
                if (i + 1 < count) {
                    w.WriteLine();
                }
            }
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        public void ToMermaid(TextWriter w) {
            var edges = this.m_Edges; var count = edges.Count;
            for (int i = 0; i < count; i++) {
                var edge = edges[i];
                edge.ToMermaid(w); if (i + 1 < count) { w.WriteLine(); }
            }
        }
    }
}
