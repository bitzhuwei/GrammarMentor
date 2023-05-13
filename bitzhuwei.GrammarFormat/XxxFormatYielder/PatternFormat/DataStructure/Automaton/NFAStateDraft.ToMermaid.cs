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
    partial class NFAStateDraft {
        /// <summary>
        /// id("NFAn-n")
        /// <para>or</para>
        /// <para>
        /// id("NFAn-n name")
        /// </para>
        /// </summary>
        /// <param name="w"></param>
        /// <param name="NFAInfo"></param>
        public void ToMermaid(TextWriter w, NFAInfo NFAInfo) {
            this.PrintId(w);
            if (this.isEnd) { w.Write("[\\\""); } else { w.Write("(\""); }

            if (string.IsNullOrEmpty(this.name)) {
                w.Write($"NFA{this.VtId}-{this.Id}");
            }
            else {
                w.Write($"NFA{this.VtId}-{this.Id} {this.name}");

            }

            if (NFAInfo != null) {
                if (NFAInfo.stateTokenScriptDict.TryGetValue(this, out var tokenScripts)) {
                    foreach (var tokenScript in tokenScripts) {
                        w.WriteLine();
                        w.Write($"{tokenScript.type} {tokenScript.Vt}");
                    }
                }
            }

            if (this.isEnd) { w.Write("\"/]"); } else { w.Write("\")"); }
        }
    }
}
