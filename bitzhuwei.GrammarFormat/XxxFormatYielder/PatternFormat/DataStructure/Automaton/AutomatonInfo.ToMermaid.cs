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
    partial class AutomatonInfo {
        public void ToMermaid(TextWriter w) {
            w.WriteLine("-------------------------------");
            w.WriteLine("# 1/5: extracted ε-NFA");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.eNFA.ToMermaid(w);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
            w.WriteLine("# 2/5: manifested ε-NFA");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.eNFAManifested.ToMermaid(w);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
            w.WriteLine("# 3/5: NFA");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.NFA.ToMermaid(w);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
            w.WriteLine("# 4/5: DFA");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.DFA.ToMermaid(w, true);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
            w.WriteLine("# 4/5: DFA.simple");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.DFA.ToMermaid(w, false);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
            w.WriteLine("# 5/5: miniDFA");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.miniDFA.ToMermaid(w, true);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
            w.WriteLine("# 5/5: miniDFA.simple");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.miniDFA.ToMermaid(w, false);
            w.WriteLine("```");
            w.WriteLine("-------------------------------");
        }
    }
}