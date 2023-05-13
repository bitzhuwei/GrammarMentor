using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of DFA transformed from NFA
    /// </summary>
    public partial class DFAInfo {
        /// <summary>
        /// the DFA start state.
        /// </summary>
        public readonly DFAStateDraft start;

        ///// <summary>
        ///// the DFA end states.
        ///// </summary>
        //public readonly List<DFAStateDraft> ends;

        /// <summary>
        /// <see cref="DFAEdgeDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// general edge to attach <see cref="TokenScript"/>
        /// </para> 
        /// </summary>
        public readonly ListedDict<DFAEdgeDraft, TokenScript> edgeTokenScriptDict = new ListedDict<DFAEdgeDraft, TokenScript>();

        /// <summary>
        /// <see cref="DFAStateDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// the <see cref="TokenScript"/> is actually at the 'other' edge to initial state.
        /// </para>
        /// </summary>
        public readonly ListedDict<DFAStateDraft, TokenScript> stateTokenScriptDict = new ListedDict<DFAStateDraft, TokenScript>();

        public readonly NFAInfo sourceNFAInfo;

        /// <summary>
        /// info of DFA transformed from NFA
        /// </summary>
        /// <param name="start">the DFA start state.</param>
        /// <param name="sourceNFAInfo">transformed from which NFA?</param>
        public DFAInfo(DFAStateDraft start, NFAInfo sourceNFAInfo) {
            if (start == null) { throw new ArgumentNullException($"{nameof(start)}"); }
            if (sourceNFAInfo == null) { throw new ArgumentNullException($"{nameof(sourceNFAInfo)}"); }

            this.start = start;
            this.sourceNFAInfo = sourceNFAInfo;
        }

        public override string ToString() {
            return $"{this.start}, {this.edgeTokenScriptDict.Count} + {this.stateTokenScriptDict.Count} token drafts";
        }
    }
}