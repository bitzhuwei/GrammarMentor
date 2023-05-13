using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// <para>mini-DFA of ¦Å-NFA¡¢NFA¡¢DFA¡¢mini-DFA</para>
    /// </summary>
    public partial class MiniDFAStateDraft {
        private static int guidCounter;
        private readonly int guid;
        /// <summary>
        /// lexicalStateN
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// readable name
        /// </summary>
        public readonly string name;

        /// <summary>
        /// is this state an end state?
        /// <para>used when transform <see cref="DFAInfo"/> to <see cref="MiniDFAInfo"/></para>
        /// </summary>
        public bool isEnd { get; private set; }

        public MiniDFAStateDraft(int Id, params DFAStateDraft[] DFAStates) : this(Id, string.Empty, DFAStates) { }

        public MiniDFAStateDraft(int Id, IEnumerable<DFAStateDraft> DFAStates) : this(Id, string.Empty, DFAStates) { }

        public MiniDFAStateDraft(int Id, string name, params DFAStateDraft[] DFAStates) {
            this.guid = guidCounter++;
            this.Id = Id;
            if (DFAStates != null) {
                foreach (var item in DFAStates) {
                    this.TryInsert(item);
                }
            }
            if (string.IsNullOrEmpty(name)) {
                this.name = $"{{{this.m_DFAStates.Count}}}";
            }
            else {
                this.name = name;
            }
        }

        public MiniDFAStateDraft(int Id, string name, IEnumerable<DFAStateDraft> DFAStates) {
            this.guid = guidCounter++;
            this.Id = Id;
            if (DFAStates != null) {
                foreach (var item in DFAStates) {
                    this.TryInsert(item);
                }
            }
            if (string.IsNullOrEmpty(name)) {
                this.name = $"{{{this.m_DFAStates.Count}}}";
            }
            else {
                this.name = name;
            }
        }

        public void PrintId(TextWriter w) {
            w.Write($"MiniDFA{this.Id}_{this.GetHashCode()}");
        }

        /// <summary>
        /// edges through which I can go to this state.
        /// </summary>
        public readonly CoupleList<MiniDFAEdgeDraft> fromEdges = new CoupleList<MiniDFAEdgeDraft>();

        /// <summary>
        /// edges through which I can go to another state.
        /// </summary>
        public readonly CoupleList<MiniDFAEdgeDraft> toEdges = new CoupleList<MiniDFAEdgeDraft>();

        // DFA -> MiniDFA
        /// <summary>
        /// DFA -&gt; MiniDFA
        /// <para>Mapped DFA states of this MiniDFA state.</para>
        /// </summary> 
        private readonly CoupleList<DFAStateDraft> m_DFAStates = new CoupleList<DFAStateDraft>();
        // DFA -> MiniDFA
        /// <summary>
        /// DFA -&gt; MiniDFA
        /// <para>Mapped DFA states of this MiniDFA state.</para>
        /// </summary>
        public IReadOnlyList<DFAStateDraft> DFAStates => m_DFAStates;

        public bool TryInsert(DFAStateDraft DFAState) {
            var inserted = this.m_DFAStates.TryInsert(DFAState);

            if (inserted) {
                this.dirty = true;

                if (DFAState.isEnd) {
                    this.isEnd = true;
                }
            }

            return inserted;
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.ToMermaid(w, null);
            }

            return b.ToString();
        }
    }

}
