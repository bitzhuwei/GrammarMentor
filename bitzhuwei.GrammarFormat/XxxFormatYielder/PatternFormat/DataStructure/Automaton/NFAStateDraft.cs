using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// CompilerXxx.lexicalStateN.cs
    /// <para>NFA of ¦Å-NFA¡¢NFA¡¢DFA</para>
    /// </summary>
    public partial class NFAStateDraft {
        public int VtId;
        public readonly int Id;
        /// <summary>
        /// readable name
        /// </summary>
        public readonly string name;

        /// <summary>
        /// is this state an end state?
        /// <para>used when transform <see cref="DFAInfo"/> to <see cref="MiniDFAInfo"/></para>
        /// </summary>
        public bool isEnd;
        public readonly string pattern;
        public readonly string Vt;

        public NFAStateDraft(eNFAStateDraft eNFA) {
            this.VtId = eNFA.VtId;
            this.Id = eNFA.Id;
            this.name = eNFA.name;
            this.isEnd = eNFA.isEnd;
            this.pattern = eNFA.pattern;
            this.Vt = eNFA.Vt;
        }

        public void PrintId(TextWriter w) {
            w.Write($"NFA{this.VtId}_{this.Id}_{this.GetHashCode()}");
        }

        /// <summary>
        /// edges through which I can go to this state.
        /// </summary>
        public readonly CoupleList<NFAEdgeDraft> fromEdges = new CoupleList<NFAEdgeDraft>();

        /// <summary>
        /// edges through which I can go to another state.
        /// </summary>
        public readonly CoupleList<NFAEdgeDraft> toEdges = new CoupleList<NFAEdgeDraft>();

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.ToMermaid(w, null);
            }

            return b.ToString();
        }
    }
}
