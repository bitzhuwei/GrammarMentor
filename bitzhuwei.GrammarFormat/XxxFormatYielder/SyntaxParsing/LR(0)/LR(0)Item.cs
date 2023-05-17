using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    // LR(0)项：VnRegulation + 圆点的位置
    /// <summary>
    /// <see cref="VnRegulationDraft"/> with position of the dot.
    /// </summary>
    public partial class LR0Item {
        private static Dictionary<VnRegulationDraft, Dictionary<int, LR0Item>> objDict = new Dictionary<VnRegulationDraft, Dictionary<int, LR0Item>>();
        /// <summary>
        /// Get <see cref="LR0Item"/> from the object pool.
        /// </summary>
        /// <param name="regulation"></param>
        /// <param name="dotPosition"></param>
        /// <returns></returns>
        public static LR0Item GetItem(VnRegulationDraft regulation, int dotPosition) {
            LR0Item result;
            if (objDict.TryGetValue(regulation, out var dict2)) {
                if (dict2.TryGetValue(dotPosition, out result)) {
                    // nothing to do.
                }
                else {
                    result = new LR0Item(regulation, dotPosition);
                    dict2.Add(dotPosition, result);
                }
            }
            else {
                result = new LR0Item(regulation, dotPosition);
                dict2 = new Dictionary<int, LR0Item>();
                dict2.Add(dotPosition, result);
                objDict.Add(regulation, dict2);
            }

            return result;
        }

        // 规则
        /// <summary>
        /// </summary>
        public readonly VnRegulationDraft VnRegulation;

        // 圆点的位置(0 to <see cref="VnRegulationDraft.right.Count"/>)
        /// <summary>
        /// position of the dot(0 to <see cref="VnRegulationDraft.right.Count"/>)
        /// </summary>
        public readonly int dotPosition;

        /// <summary>
        /// <see cref="VnRegulationDraft"/> with position of the dot.
        /// </summary>
        /// <param name="regulation"></param>
        /// <param name="dotPosition"></param>
        private LR0Item(VnRegulationDraft regulation, int dotPosition) {
            if (regulation == null) { throw new ArgumentNullException(); }
            if (dotPosition < 0 || regulation.Right.Count < dotPosition) { throw new ArgumentOutOfRangeException(); }

            this.VnRegulation = regulation;
            this.dotPosition = dotPosition;

            var right = regulation.Right;
            if (dotPosition < right.Count) {
                this.nodeNext2Dot = right[dotPosition];
            }
            else {
                //return CompilerGrammar.keywordEmpty;// theoretically brilliant!
                this.nodeNext2Dot = null;
            }
        }

        /// <summary>
        /// 获取圆点后面的第一个结点
        /// </summary>
        public readonly string/*Node.type*/nodeNext2Dot;

        public void Print(System.IO.TextWriter w, VnRegulationDraft[] regulations = null) {
            if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, this.VnRegulation)}] "); }

            w.Write(this.VnRegulation.left); w.Write(" : ");

            var right = this.VnRegulation.Right;
            var count = right.Count;
            for (int i = 0; i < count; i++) {
                if (i == this.dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                var item = right[i];
                w.Write(item); w.Write(' ');
            }

            if (this.dotPosition == count) { w.Write(Utility.dot); w.Write(' '); }

            w.Write(';');
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        public void ToMermaid(TextWriter w, VnRegulationDraft[] regulations = null) {
            if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, this.VnRegulation)}] "); }

            w.Write(this.VnRegulation.left); w.Write(" : ");

            var right = this.VnRegulation.Right;
            int count = right.Count;
            for (int i = 0; i < count; i++) {
                if (i == this.dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                var item = right[i];
                w.Write(item.ToMermaid()); w.Write(' ');
            }
            if (this.dotPosition == count) { w.Write(Utility.dot); w.Write(' '); }

            w.Write(';');
        }
    }
}
