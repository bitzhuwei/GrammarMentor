using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;

namespace bitzhuwei.PatternFormat {
    partial class MiniDFAStateDraft {
        public void ToMermaid(TextWriter w, MiniDFA2MermaidContext context) {
            if (context == null || (!context.printSubgraph)) { // print self or self in MiniDFA
                this.PrintId(w);
                if (this.isEnd) { w.Write("[\\\""); } else { w.Write("([\""); }

                if (string.IsNullOrEmpty(this.name)) {
                    w.Write($"MiniDFA{this.Id}");
                }
                else {
                    w.Write($"MiniDFA{this.Id} {this.name}");
                }

                if (context != null) {
                    if (context.MiniDFAInfo.stateTokenScriptDict.TryGetValue(this, out var tokenScripts)) {
                        foreach (var tokenScript in tokenScripts) {
                            w.WriteLine();
                            w.Write($"{tokenScript.type} {tokenScript.Vt}");
                        }
                    }
                }

                if (this.isEnd) { w.Write("\"/]"); } else { w.Write("\"])"); }
            }
            else { // print subgraph
                w.Write("subgraph "); this.PrintId(w);
                w.Write("[\"");

                if (string.IsNullOrEmpty(this.name)) {
                    w.Write($"MiniDFA{this.Id}");
                }
                else {
                    w.Write($"MiniDFA{this.Id} {this.name}");
                }

                // repeated in subItems(DFA)
                //if (context != null) {
                //    if (context.MiniDFAInfo.stateTokenDraftDict.TryGetValue(this, out var tokenScripts)) {
                //        foreach (var tokenScript in tokenScripts) {
                //            w.WriteLine();
                //            w.Write($"{tokenScript.statement} {tokenScript.Vt}");
                //        }
                //    }
                //}

                w.Write("\"]"); w.WriteLine();

                foreach (var DFAState in this.m_DFAStates) {
                    // items in the subgraph
                    var itemId = $"DFA{DFAState.Id}_{DFAState.GetHashCode()}_{context.DFACounter}";
                    w.Write(itemId);
                    if (DFAState.isEnd) { w.Write("[\\\""); } else { w.Write("{{\""); }

                    if (string.IsNullOrEmpty(DFAState.name)) {
                        w.Write($"DFA{DFAState.Id}");
                    }
                    else {
                        w.Write($"DFA{DFAState.Id} {DFAState.name}");
                    }

                    if (context.MiniDFAInfo.sourceDFAInfo.stateTokenScriptDict.TryGetValue(DFAState, out var tokenScripts)) {
                        foreach (var tokenScript in tokenScripts) {
                            w.WriteLine();
                            w.Write($"{tokenScript.type} {tokenScript.Vt}");
                        }
                    }

                    if (DFAState.isEnd) { w.Write("\"/]"); } else { w.Write("\"}}"); }
                    w.WriteLine();

                    var stateSign = StateSign.Parse(DFAState, context.MiniDFAInfo.sourceDFAInfo);
                    stateSign.Print(w, DFAState, itemId, EStateSignPrint.Class);

                    context.DFACounter++;
                }

                w.Write("end");
            }
        }
    }
}
