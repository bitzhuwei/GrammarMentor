using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// 从一个LR(1)状态跳转到另一个LR(1)状态
    /// </summary>
    public partial class LR1Edge {
        /// <summary>
        /// 从一个LR(1)状态跳转到另一个LR(1)状态
        /// </summary>
        /// <param name="from"></param>
        /// <param name="V"></param>
        /// <param name="to"></param>
        public LR1Edge(LR1State from, string/*Node.type*/ V, LR1State to) {
            this.from = from;
            this.V = V;
            this.to = to;
        }

        public readonly LR1State from;

        public readonly string/*Node.type*/ V;

        public readonly LR1State to;


        public void Print(System.IO.TextWriter w) {
            this.from.Print(w);
            w.WriteLine();
            w.Write("    └──("); w.Write(this.V); w.Write(")──┒");
            w.WriteLine();
            this.to.Print(w);
        }

        public override string ToString() {
            return $"state({this.from.index}) -- {this.V} --> state({this.to.index})";
        }

        public void ToMermaid(TextWriter w) {
            w.Write("syntaxState"); w.Write(this.from.index);
            w.Write(" --> |\""); w.Write(this.V.ToMermaid()); w.Write("\"| ");
            w.Write("syntaxState"); w.Write(this.to.index);
        }
    }
}
