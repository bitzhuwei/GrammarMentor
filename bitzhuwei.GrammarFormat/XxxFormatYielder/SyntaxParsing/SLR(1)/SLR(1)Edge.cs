using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    // 从一个SLR(1)状态跳转到另一个SLR(1)状态
    /// <summary>
    /// </summary>
    public partial class SLR1Edge {
        /// <summary>
        /// 从一个SLR(1)状态跳转到另一个SLR(1)状态
        /// </summary>
        /// <param name="from"></param>
        /// <param name="V"><see cref="Node.type"/>
        /// <para>a Vn or a Vt</para></param>
        /// <param name="to"></param>
        public SLR1Edge(SLR1State from, string/*Node.type*/ V, SLR1State to) {
            this.from = from;
            this.V = V;
            this.to = to;
        }

        public readonly SLR1State from;

        /// <summary>
        /// <see cref="Node.type"/>
        /// <para>a Vn or a Vt</para>
        /// </summary>
        public readonly string/*Node.type*/ V;

        public readonly SLR1State to;


        public void Print(System.IO.TextWriter w) {
            w.Write("syntaxStates["); w.Write(this.from.index); w.Write("]");
            w.Write(" -- "); w.Write(this.V); w.Write(" --> ");
            w.Write("syntaxStates["); w.Write(this.to.index); w.Write("]");
        }

        public override string ToString() {
            return $"state({this.from.index}) -- {this.V} --> state({this.to.index})";
        }

        public void ToMermaid(TextWriter w, object context) {
            w.Write("syntaxState"); w.Write(this.from.index);
            w.Write(" --> |\""); w.Write(this.V.ToMermaid()); w.Write("\"| ");
            w.Write("syntaxState"); w.Write(this.to.index);
        }
    }
}
