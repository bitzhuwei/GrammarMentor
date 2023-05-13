using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;

namespace bitzhuwei.PatternFormat {
    partial class DFAStateDraft {
        public void ToMermaid(TextWriter w, DFA2MermaidContext context) {
            if (context == null || (!context.printSubgraph)) { // print self or self in DFA
                // id{{"DFAn"}} or id{{"DFAn name"}}
                this.PrintId(w);
                if (this.isEnd) { w.Write("[\\\""); } else { w.Write("{{\""); }

                if (string.IsNullOrEmpty(this.name)) {
                    w.Write($"DFA{this.Id}");
                }
                else {
                    w.Write($"DFA{this.Id} {this.name}");
                }

                if (context != null) {
                    if (context.DFAInfo.stateTokenScriptDict.TryGetValue(this, out var tokenScripts)) {
                        foreach (var tokenScript in tokenScripts) {
                            w.WriteLine();
                            w.Write($"{tokenScript.type} {tokenScript.Vt}");
                        }
                    }
                }

                if (this.isEnd) { w.Write("\"/]"); } else { w.Write("\"}}"); }
            }
            else { // print subgraph
                w.Write("subgraph "); this.PrintId(w);
                w.Write("[\"");

                if (string.IsNullOrEmpty(this.name)) {
                    w.Write($"DFA{this.Id}");
                }
                else {
                    w.Write($"DFA{this.Id} {this.name}");
                }

                // repeated in subItems(NFA)
                //if (context != null) {
                //    if (context.DFAInfo.stateTokenDraftDict.TryGetValue(this, out var tokenScripts)) {
                //        foreach (var tokenScript in tokenScripts) {
                //            w.WriteLine();
                //            w.Write($"{tokenScript.statement} {tokenScript.Vt}");
                //        }
                //    }
                //}

                w.Write("\"]"); w.WriteLine();

                foreach (var NFAState in this.m_NFAStates) {
                    // items in the subgraph
                    var itemId = $"NFA{NFAState.VtId}_{NFAState.Id}_{NFAState.GetHashCode()}_{context.NFACounter}";
                    w.Write(itemId);
                    if (NFAState.isEnd) { w.Write("[\\\""); } else { w.Write("(\""); }

                    if (string.IsNullOrEmpty(NFAState.name)) {
                        w.Write($"NFA{NFAState.VtId}-{NFAState.Id}");
                    }
                    else {
                        w.Write($"NFA{NFAState.VtId}-{NFAState.Id} {NFAState.name}");
                    }

                    if (context.DFAInfo.sourceNFAInfo.stateTokenScriptDict.TryGetValue(NFAState, out var tokenScripts)) {
                        foreach (var tokenScript in tokenScripts) {
                            w.WriteLine();
                            w.Write($"{tokenScript.type} {tokenScript.Vt}");
                        }
                    }

                    if (NFAState.isEnd) { w.Write("\"/]"); } else { w.Write("\")"); }
                    w.WriteLine();

                    var stateSign = StateSign.Parse(NFAState, context.DFAInfo.sourceNFAInfo);
                    stateSign.Print(w, NFAState, itemId, EStateSignPrint.Class);

                    context.NFACounter++;
                }

                w.Write("end");
            }
        }
    }
}
