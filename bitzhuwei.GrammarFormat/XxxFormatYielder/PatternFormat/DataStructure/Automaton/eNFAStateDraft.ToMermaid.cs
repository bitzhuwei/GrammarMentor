using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;

namespace bitzhuwei.PatternFormat {
    partial class eNFAStateDraft {
        /// <summary>
        /// id[["¦ÅNFAn-n"]]
        /// <para>or</para>
        /// <para>
        /// id[["¦ÅNFAn-n name"]]
        /// </para>
        /// </summary>
        /// <param name="w"></param>
        public void ToMermaid(TextWriter w, eNFAInfo eNFAInfo) {
            this.PrintId(w);
            if (this.isEnd) { w.Write("[\\\""); } else { w.Write("[[\""); }

            if (string.IsNullOrEmpty(this.name)) {
                w.Write($"¦ÅNFA{this.VtId}-{this.Id}");
            }
            else {
                w.Write($"¦ÅNFA{this.VtId}-{this.Id} {this.name}");
            }

            if (eNFAInfo != null) {
                if (eNFAInfo.stateTokenScriptDict.TryGetValue(this, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        w.WriteLine();
                        w.Write($"{tokenScript.type} {tokenScript.Vt}");
                    }
                }
            }

            if (this.isEnd) { w.Write("\"/]"); } else { w.Write("\"]]"); }
        }
    }
}
