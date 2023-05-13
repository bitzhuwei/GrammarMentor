using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of NFA
    /// </summary>
    public partial class NFAInfo {
        /// <summary>
        /// the NFA start state.
        /// </summary>
        public readonly NFAStateDraft start;

        ///// <summary>
        ///// the NFA end states.
        ///// </summary>
        //public readonly List<NFAStateDraft> ends;

        /// <summary>
        /// <see cref="NFAEdgeDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// general edge to attach <see cref="TokenScript"/>
        /// </para> 
        /// </summary>
        public readonly ListedDict<NFAEdgeDraft, TokenScript> edgeTokenScriptDict = new ListedDict<NFAEdgeDraft, TokenScript>();
        /// <summary>
        /// <see cref="NFAStateDraft"/> -&gt; list of <see cref="TokenScript"/>
        /// <para>
        /// the <see cref="TokenScript"/> is actually at the 'other' edge to initial state.
        /// </para>
        /// </summary>
        public readonly ListedDict<NFAStateDraft, TokenScript> stateTokenScriptDict = new ListedDict<NFAStateDraft, TokenScript>();

        /// <summary>
        /// info of NFA
        /// </summary>
        /// <param name="start">the NFA start state.</param>
        /// <para>
        /// the <see cref="TokenScript"/> is actually at the 'other' edge to initial state.
        /// </para></param>
        public NFAInfo(NFAStateDraft start) {
            if (start == null) { throw new ArgumentNullException($"{nameof(start)}"); }

            this.start = start;
        }

        public override string ToString() {
            return $"{this.start}, {this.edgeTokenScriptDict.Count} + {this.stateTokenScriptDict.Count} token drafts";
        }
    }

}