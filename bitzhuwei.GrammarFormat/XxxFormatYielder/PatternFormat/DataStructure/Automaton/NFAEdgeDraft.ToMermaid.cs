using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace bitzhuwei.PatternFormat {
    partial class NFAEdgeDraft {
        /// <summary>
        /// from -->|"xxx"|to
        /// </summary>
        /// <param name="w"></param>
        /// <param name="context"></param>
        public void ToMermaid(TextWriter w, NFAInfo NFAInfo) {
            this.from.PrintId(w);

            // -->|"xxx"|
            // -->|"
            w.Write(" -->|\"");
            // xxx
            //if (this.condition == ConditionHelper.otherSign) { w.Write("other"); }
            //else { w.Write(this.condition.ToMermaid()); }
            this.condition.ToMermaid(w);
            if (NFAInfo != null) {
                if (NFAInfo.edgeTokenScriptDict.TryGetValue(this, out var tokenScripts)) {
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