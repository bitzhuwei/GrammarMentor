﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public partial class LR1EdgeList {
        private readonly CoupleList<LR1Edge> m_Edges = new CoupleList<LR1Edge>();
        public IReadOnlyList<LR1Edge> Edges => m_Edges;

        /// <summary>
        /// </summary>
        /// <param name="edges"></param>
        public LR1EdgeList(params LR1Edge[] edges) {
            if (edges != null) {
                foreach (var item in edges) {
                    this.m_Edges.TryInsert(item);
                }
            }
        }

        public bool TryInsert(LR1Edge edge) {
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
