using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateLexicalAnalyzerMermaid(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "doc");
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            {
                string fullname = Path.Combine(path, $"LexicalStates.gen.md");
                using (var w = new StreamWriter(fullname)) {
                    context.automatonInfo.ToMermaid(w);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.1.eNFA.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    w.WriteLine("flowchart");
                    context.automatonInfo.eNFA.ToMermaid(w);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.2.ManifestedeNFA.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    w.WriteLine("flowchart");
                    context.automatonInfo.eNFAManifested.ToMermaid(w);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.3.NFA.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    w.WriteLine("flowchart");
                    context.automatonInfo.NFA.ToMermaid(w);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.4.DFA.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    var DFA = context.automatonInfo.DFA;
                    w.WriteLine("flowchart");
                    DFA.ToMermaid(w, true);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.4.DFA.smiple.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    var DFA = context.automatonInfo.DFA;
                    w.WriteLine("flowchart");
                    DFA.ToMermaid(w, false);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.5.miniDFA.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    var miniDFA = context.automatonInfo.miniDFA;
                    w.WriteLine("flowchart");
                    miniDFA.ToMermaid(w, true);
                }
            }
            {
                string fullname = Path.Combine(path, $"LexicalStates.5.miniDFA.simple.gen.mmd");
                using (var w = new StreamWriter(fullname)) {
                    var miniDFA = context.automatonInfo.miniDFA;
                    w.WriteLine("flowchart");
                    miniDFA.ToMermaid(w, false);
                }
            }
        }
    }
}