using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Linq;

namespace bitzhuwei.PatternFormat {
    partial class eNFAEdgeDraft {
        /// <summary>
        /// from -->|"xxx"|to
        /// <para>or</para>
        /// <para>
        /// from -.->|"#949;"|to
        /// </para>
        /// </summary>
        /// <param name="w"></param>
        /// <param name="eNFAInfo"></param>
        public void ToMermaid(TextWriter w, eNFAInfo eNFAInfo) {
            this.from.PrintId(w);

            // -->|"xxx"|
            var empty = this.IsEmpty();
            // -->|"
            w.Write(empty ? " -.->" : " -->"); w.Write("|\"");
            // xxx
            var condition = empty ? "ε"/* #949; */ : this.condition;
            //if (condition == ConditionHelper.otherSign) { w.Write("other"); }
            //else { w.Write(condition.ToMermaid()); }
            condition.ToMermaid(w);
            if (eNFAInfo != null) {
                if (eNFAInfo.edgeTokenScriptDict.TryGetValue(this, out var tokenScripts)) {
                    var query = from tokenScript in tokenScripts
                                group tokenScript by tokenScript.type into g
                                orderby g.Key ascending
                                select g;
                    foreach (var g in query) {
                        w.WriteLine();
                        var type = g.Key;
                        w.Write(type); w.Write(' ');
                        foreach (var tokenScript in g) {
                            //tokenScript.ToMermaid(w);
                            tokenScript.Vt.ToMermaid(w);
                        }
                    }
                }
            }
            // "|
            w.Write("\"|");

            this.to.PrintId(w);
        }
    }
}