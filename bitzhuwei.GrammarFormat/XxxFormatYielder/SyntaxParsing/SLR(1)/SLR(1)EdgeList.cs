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
    /// 经过优化的SLR(1)Edge列表。插入新元素用二分法，速度更快。
    /// </summary>
    public partial class SLR1EdgeList {
        //public readonly SLR1StateList stateList;
        private readonly CoupleList<SLR1Edge> m_Edges = new CoupleList<SLR1Edge>();
        public IEnumerable<SLR1Edge> Edges => m_Edges;
        /// <summary>
        /// 经过优化的SLR(1)Edge列表。插入新元素用二分法，速度更快。
        /// </summary>
        ///// <param name="stateList"></param>
        /// <param name="edges"></param>
        public SLR1EdgeList(/*SLR1StateList stateList, */params SLR1Edge[] edges) {
            //this.stateList = stateList;
            if (edges != null) {
                foreach (var item in edges) {
                    this.TryInsert(item);
                }
            }
        }

        public bool TryInsert(SLR1Edge lr0Edge) {
            Debug.Assert(lr0Edge != null);

            var inserted = this.m_Edges.TryInsert(lr0Edge);
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

        public void ToMermaid(TextWriter w, object context) {
            var edges = this.m_Edges; var count = edges.Count;
            for (int i = 0; i < count; i++) {
                var edge = edges[i];
                edge.ToMermaid(w, context); if (i + 1 < count) { w.WriteLine(); }
            }
        }
    }
}
