using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// info of ε-NFA, NFA, DFA and minDFA.
    /// </summary>
    public partial class AutomatonInfo {
        /// <summary>
        /// 0: extracted ε-NFA from <see cref="CompilerPattern"/>
        /// </summary>
        public readonly eNFAInfo eNFA;
        /// <summary>
        /// 1: built edges that are implyed by ε edges
        /// </summary>
        public readonly eNFAInfo eNFAManifested;
        /// <summary>
        /// 2: removed empty edges(and thus useless states)
        /// </summary>
        public readonly NFAInfo NFA;
        /// <summary>
        /// 3: transformed from NFA to DFA
        /// </summary>
        public readonly DFAInfo DFA;
        /// <summary>
        /// 4: minimized states of the specified <paramref name="DFAInfo"/>
        /// </summary>
        public readonly MiniDFAInfo miniDFA;

        /// <summary>
        /// info of ε-NFA, NFA and DFA.
        /// </summary>
        /// <param name="eNFA">extracted ε-NFA from <see cref="CompilerPattern"/></param>
        public AutomatonInfo(eNFAInfo eNFA) {
            this.eNFA = eNFA;
            //using (var w = new StreamWriter("AutomatonInfo.1.eNFA.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.eNFA.ToMermaid(w);
            //    w.WriteLine("```");
            //}
            this.eNFAManifested = ManifesteNFA(eNFA);
            //using (var w = new StreamWriter("AutomatonInfo.2.eNFAManifested.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.eNFACompleted.ToMermaid(w);
            //    w.WriteLine("```");
            //}
            this.NFA = ToNFA(this.eNFAManifested);
            //using (var w = new StreamWriter("AutomatonInfo.3.NFA.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.NFA.ToMermaid(w);
            //    w.WriteLine("```");
            //}
            this.DFA = ToDFA(this.NFA);
            //using (var w = new StreamWriter("AutomatonInfo.4.DFA.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.DFA.ToMermaid(w, true);
            //    w.WriteLine("```");
            //}
            //using (var w = new StreamWriter("AutomatonInfo.4.DFA.simple.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.DFA.ToMermaid(w, false);
            //    w.WriteLine("```");
            //}
            this.miniDFA = ToMiniDFA(this.DFA);
            //using (var w = new StreamWriter("AutomatonInfo.5.miniDFA.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.miniDFA.ToMermaid(w, true);
            //    w.WriteLine("```");
            //}
            //using (var w = new StreamWriter("AutomatonInfo.5.miniDFA.simple.md")) {
            //    w.WriteLine("```Mermaid");
            //    w.WriteLine("flowchart");
            //    this.miniDFA.ToMermaid(w, false);
            //    w.WriteLine("```");
            //}

            //using (var w = new StreamWriter("AutomatonInfo.0.all.md")) {
            //    this.ToMermaid(w);
            //}
        }

        public override string ToString() {
            //return $"{this.miniDFA}";
            return $"{this.DFA}";
        }
    }

}