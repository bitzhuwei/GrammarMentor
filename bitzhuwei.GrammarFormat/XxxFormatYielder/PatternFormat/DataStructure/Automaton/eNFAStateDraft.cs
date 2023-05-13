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
    /// <para>¦Å-NFA of ¦Å-NFA¡¢NFA¡¢DFA</para>
    /// </summary>
    public partial class eNFAStateDraft {
        public readonly int VtId;
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

        // for debug purpose
        public string pattern;
        public string Vt;

        public eNFAStateDraft(int Id, string name = null) {
            this.Id = Id;
            this.name = name;
        }

        public eNFAStateDraft(int VtId, eNFAStateDraft source) : this(source) {
            this.VtId = VtId;
        }

        public eNFAStateDraft(eNFAStateDraft source) {
            this.VtId = source.VtId;
            this.Id = source.Id;
            this.name = source.name;
            this.isEnd = source.isEnd;
            this.pattern = source.pattern;
            this.Vt = source.Vt;
        }

        public bool TryAttach(TokenScript tokenScript, eNFAInfo eNFA) {
            return eNFA.stateTokenScriptDict.TryInsert(this, tokenScript);
        }

        public void PrintId(TextWriter w) {
            w.Write($"eNFA{this.VtId}_{this.Id}_{this.GetHashCode()}");
        }

        /// <summary>
        /// edges through which I can go to this state.
        /// </summary>
        public readonly CoupleList<eNFAEdgeDraft> fromEdges = new CoupleList<eNFAEdgeDraft>();

        /// <summary>
        /// edges through which I can go to another state.
        /// </summary>
        public readonly CoupleList<eNFAEdgeDraft> toEdges = new CoupleList<eNFAEdgeDraft>();

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.ToMermaid(w, null);
            }

            return b.ToString();
        }
    }
}
