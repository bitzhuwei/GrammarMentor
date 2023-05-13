using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA
    /// </summary>
    public partial class eNFAInfo {
        /// <summary>
        /// the ε-NFA start state.
        /// </summary>
        public readonly eNFAStateDraft start;

        /// <summary>
        /// the ε-NFA end state.
        /// </summary>
        public readonly eNFAStateDraft end;

        /// <summary>
        /// <see cref="eNFAEdgeDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// general edge to attach <see cref="TokenScript"/>
        /// </para>
        /// </summary>
        public readonly ListedDict<eNFAEdgeDraft, TokenScript> edgeTokenScriptDict = new ListedDict<eNFAEdgeDraft, TokenScript>();
        /// <summary>
        /// <see cref="eNFAStateDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// the <see cref="TokenScript"/> is actually at the 'other' edge to initial state.
        /// </para>
        /// </summary>
        public readonly ListedDict<eNFAStateDraft, TokenScript> stateTokenScriptDict = new ListedDict<eNFAStateDraft, TokenScript>();

        /// <summary>
        /// info of ε-NFA
        /// </summary>
        /// <param name="start">the ε-NFA start state.</param>
        /// <param name="end">the ε-NFA end state.</param>
        /// <para>
        /// the <see cref="TokenScript"/> is actually at the 'other' edge to initial state.
        /// </para></param>
        public eNFAInfo(eNFAStateDraft start, eNFAStateDraft end) {
            if (start == null) { throw new ArgumentNullException($"{nameof(start)}"); }
            if (end == null) { throw new ArgumentNullException($"{nameof(end)}"); }

            this.start = start;
            this.end = end;
        }

        public bool TryInsert(eNFAEdgeDraft edge, TokenScript tokenScript) {
            return this.edgeTokenScriptDict.TryInsert(edge, tokenScript);
        }

        public bool TryInsert(eNFAStateDraft state, TokenScript tokenScript) {
            return this.stateTokenScriptDict.TryInsert(state, tokenScript);
        }

        public override string ToString() {
            return $"{this.start} => {this.end}, {this.edgeTokenScriptDict.Count} + {this.stateTokenScriptDict.Count} token drafts";
        }
    }

}