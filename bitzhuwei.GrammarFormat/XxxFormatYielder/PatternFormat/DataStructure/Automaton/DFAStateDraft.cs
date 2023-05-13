using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// <para>DFA of ¦Å-NFA¡¢NFA¡¢DFA</para>
    /// </summary>
    public partial class DFAStateDraft {
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

        public DFAStateDraft(int Id, params NFAStateDraft[] NFAStates) : this(Id, string.Empty, NFAStates) { }

        public DFAStateDraft(int Id, IEnumerable<NFAStateDraft> NFAStates) : this(Id, string.Empty, NFAStates) { }

        public DFAStateDraft(int Id, string name, params NFAStateDraft[] NFAStates) {
            this.Id = Id;
            if (NFAStates != null) {
                foreach (var item in NFAStates) {
                    this.TryInsert(item);
                }
            }

            if (string.IsNullOrEmpty(name)) {
                this.name = $"{{{this.m_NFAStates.Count}}}";
            }
            else {
                this.name = name;
            }
        }

        public DFAStateDraft(int Id, string name, IEnumerable<NFAStateDraft> NFAStates) {
            this.Id = Id;
            if (NFAStates != null) {
                foreach (var item in NFAStates) {
                    this.TryInsert(item);
                }
            }

            if (string.IsNullOrEmpty(name)) {
                this.name = $"{{{this.m_NFAStates.Count}}}";
            }
            else {
                this.name = name;
            }
        }

        public void PrintId(TextWriter w) {
            w.Write($"DFA{this.Id}_{this.GetHashCode()}");
        }

        /// <summary>
        /// edges through which I can go to this state.
        /// </summary>
        public readonly CoupleList<DFAEdgeDraft> fromEdges = new CoupleList<DFAEdgeDraft>();

        /// <summary>
        /// edges through which I can go to another state.
        /// </summary>
        public readonly CoupleList<DFAEdgeDraft> toEdges = new CoupleList<DFAEdgeDraft>();

        // NFA -> DFA
        /// <summary>
        /// NFA -&gt; DFA
        /// <para>Mapped NFA states of this DFA state.</para>
        /// </summary> 
        private readonly CoupleList<NFAStateDraft> m_NFAStates = new CoupleList<NFAStateDraft>();
        // NFA -> DFA
        /// <summary>
        /// NFA -&gt; DFA
        /// <para>Mapped NFA states of this DFA state.</para>
        /// </summary>
        public IReadOnlyList<NFAStateDraft> NFAStates => m_NFAStates;

        public bool TryInsert(NFAStateDraft NFAState) {
            var inserted = this.m_NFAStates.TryInsert(NFAState);

            if (inserted) {
                this.dirty = true;

                if (NFAState.isEnd) {
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
