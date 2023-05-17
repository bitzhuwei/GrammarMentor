using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// LR(1)项（A : α . β ; 'z' ）指出，序列α在栈顶，且输入中开头的是可以从 β 'z' 导出的符号。
    /// 当某个LR(1)项为（A : α . ; 'z' ）时（即β为empty时），可以规约。
    /// 某则'z'没有用。
    /// </summary>
    public partial class LR1Item {
        private static Dictionary<VnRegulationDraft, Dictionary<int, Dictionary<string, LR1Item>>> objDict = new Dictionary<VnRegulationDraft, Dictionary<int, Dictionary<string, LR1Item>>>();
        /// <summary>
        /// Get <see cref="LR1Item"/> from the object pool.
        /// </summary>
        /// <param name="regulation"></param>
        /// <param name="dotPosition"></param>
        /// <param name="lookAhead"></param>
        /// <returns></returns>
        public static LR1Item GetItem(VnRegulationDraft regulation, int dotPosition, string lookAhead) {
            LR1Item result;
            if (objDict.TryGetValue(regulation, out var dict2)) {
                if (dict2.TryGetValue(dotPosition, out var dict3)) {
                    if (dict3.TryGetValue(lookAhead, out result)) {
                        // nothing to do.
                    }
                    else {
                        result = new LR1Item(regulation, dotPosition, lookAhead);
                        dict3.Add(lookAhead, result);
                    }
                }
                else {
                    result = new LR1Item(regulation, dotPosition, lookAhead);
                    dict3 = new Dictionary<string, LR1Item>();
                    dict3.Add(lookAhead, result);
                    dict2.Add(dotPosition, dict3);
                }
            }
            else {
                result = new LR1Item(regulation, dotPosition, lookAhead);
                var dict3 = new Dictionary<string, LR1Item>();
                dict3.Add(lookAhead, result);
                dict2 = new Dictionary<int, Dictionary<string, LR1Item>>();
                dict2.Add(dotPosition, dict3);
                objDict.Add(regulation, dict2);
            }

            return result;
        }

        /// <summary>
        /// 规则。
        /// </summary>
        public readonly VnRegulationDraft VnRegulation;

        /// <summary>
        /// 圆点的位置（0 - VnRegulation.Right.Count）
        /// </summary>
        public readonly int dotPosition;

        /// <summary>
        /// 超前查看的符号
        /// <see cref="Node.type"/>
        /// </summary>
        public readonly string/*Node.type*/ lookAhead;

        /// <summary>
        /// LR(1)项（A->α.β,x）指出，序列α在栈顶，且输入中开头的是可以从βx导出的符号。
        /// </summary>
        /// <param name="regulation">A->αβ/param>
        /// <param name="dotPosition">圆点的位置</param>
        /// <param name="lookAhead">a Vn or a Vt</param>
        private LR1Item(VnRegulationDraft regulation, int dotPosition, string/*Node.type*/ lookAhead) {
            if (regulation == null || lookAhead == null) { throw new ArgumentNullException(); }
            if (dotPosition < 0 || regulation.Right.Count < dotPosition) { throw new ArgumentOutOfRangeException(); }

            this.VnRegulation = regulation;
            this.dotPosition = dotPosition;
            this.lookAhead = lookAhead;

            var right = regulation.Right; var count = right.Count;
            if (dotPosition < count) {
                this.nodeNext2Dot = right[dotPosition];
            }
            else {
                //return CompilerGrammar.keywordEmpty;// theoretically brilliant!
                this.nodeNext2Dot = null;
            }
            {
                var list = new List<string/*Node.type*/>();
                for (int i = dotPosition + 1; i < count; i++) {
                    list.Add(right[i]);
                }
                list.Add(lookAhead);
                this.betaZ = list;
            }
        }

        /// <summary>
        /// 获取圆点后面的第一个结点。
        /// </summary>
        public readonly string nodeNext2Dot;

        /// <summary>
        /// A : α . Vt β ; 'z'
        /// <para>get [ β 'z' ] without the first Vt</para>
        /// </summary>
        public readonly IReadOnlyList<string/*Node.type*/> betaZ;

        public void Print(System.IO.TextWriter w, VnRegulationDraft[] regulations = null) {
            if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, this.VnRegulation)}] "); }

            w.Write(this.VnRegulation.left); w.Write(" : ");

            var right = this.VnRegulation.Right; var count = right.Count;
            for (int i = 0; i < count; i++) {
                if (i == this.dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                string/*Node.type*/ node = right[i];
                w.Write(node.ToMermaid()); w.Write(' ');
            }

            if (this.dotPosition == count) { w.Write(Utility.dot); w.Write(' '); }
            w.Write("; ");

            w.Write(this.lookAhead);
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        public void ToMermaid(TextWriter w, VnRegulationDraft[] regulations) {
            if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, this.VnRegulation)}] "); }

            w.Write(this.VnRegulation.left); w.Write(" : ");

            var right = this.VnRegulation.Right; var count = right.Count;
            for (int i = 0; i < count; i++) {
                if (i == this.dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                string/*Node.type*/ node = right[i];
                w.Write(node.ToMermaid()); w.Write(' ');
            }

            if (this.dotPosition == count) { w.Write(Utility.dot); w.Write(' '); }

            w.Write("; ");
            w.Write(this.lookAhead);
        }
    }
}
