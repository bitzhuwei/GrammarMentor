using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    // 从一个LR(0)状态跳转到另一个LR(0)状态
    /// <summary>
    /// </summary>
    public partial class LR0Edge {
        /// <summary>
        /// 从一个LR(0)状态跳转到另一个LR(0)状态
        /// </summary>
        /// <param name="from"></param>
        /// <param name="V"><see cref="Node.type"/>
        /// <para>a Vn or a Vt</para></param>
        /// <param name="to"></param>
        public LR0Edge(LR0State from, string/*Node.type*/ V, LR0State to) {
            this.from = from;
            this.V = V;
            this.to = to;
        }

        public readonly LR0State from;

        /// <summary>
        /// <see cref="Node.type"/>
        /// <para>a Vn or a Vt</para>
        /// </summary>
        public readonly string/*Node.type*/ V;

        public readonly LR0State to;


        public void Print(System.IO.TextWriter w) {
            w.Write("syntaxStates["); w.Write(this.from.index); w.Write("]");
            w.Write(" -- "); w.Write(this.V); w.Write(" --> ");
            w.Write("syntaxStates["); w.Write(this.to.index); w.Write("]");
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
