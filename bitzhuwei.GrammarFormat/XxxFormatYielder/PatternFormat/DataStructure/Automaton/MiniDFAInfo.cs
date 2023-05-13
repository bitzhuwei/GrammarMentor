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
    public partial class MiniDFAInfo {
        /// <summary>
        /// the DFA start state.
        /// </summary>
        public readonly MiniDFAStateDraft start;

        ///// <summary>
        ///// the DFA end states.
        ///// </summary>
        //public readonly List<MiniDFAStateDraft> ends;

        /// <summary>
        /// <see cref="MiniDFAEdgeDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// general edge to attach <see cref="TokenScript"/>
        /// </para> 
        /// </summary>
        public readonly ListedDict<MiniDFAEdgeDraft, TokenScript> edgeTokenScriptDict = new ListedDict<MiniDFAEdgeDraft, TokenScript>();

        /// <summary>
        /// <see cref="MiniDFAStateDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// the <see cref="TokenScript"/> is actually at the 'other' edge to initial state.
        /// </para>
        /// </summary>
        public readonly ListedDict<MiniDFAStateDraft, TokenScript> stateTokenScriptDict = new ListedDict<MiniDFAStateDraft, TokenScript>();

        public readonly DFAInfo sourceDFAInfo;

        /// <summary>
        /// info of MiniDFA transformed from DFA
        /// </summary>
        /// <param name="start">the DFA start state.</param>
        /// <param name="sourceDFAInfo">transformed from which NFA?</param>
        public MiniDFAInfo(MiniDFAStateDraft start, DFAInfo sourceDFAInfo) {
            if (start == null) { throw new ArgumentNullException($"{nameof(start)}"); }
            if (sourceDFAInfo == null) { throw new ArgumentNullException($"{nameof(sourceDFAInfo)}"); }

            this.start = start;
            this.sourceDFAInfo = sourceDFAInfo;
        }

        public override string ToString() {
            return $"{this.start}, {this.edgeTokenScriptDict.Count} + {this.stateTokenScriptDict.Count} token drafts";
        }
    }
}