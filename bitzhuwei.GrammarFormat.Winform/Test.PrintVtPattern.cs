using bitzhuwei.PatternFormat;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitzhuwei.GrammarFormat.Winform {
    partial class Test {
        public static void PrintVtRegex() {
            var compiler = new bitzhuwei.PatternFormat.CompilerPattern();

            using (var w = new StreamWriter("regexDraft.outputs")) {
                using (var reader = new StreamReader("regexDraft.inputs")) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        if (line.StartsWith("//")) { continue; }
                        var tokens = compiler.Analyze(line);
                        var node = compiler.Parse(tokens);
                        var tokenDraft = compiler.Extract(node, tokens);
                        var info = new AutomatonInfo(tokenDraft.regexInfo);
                        w.WriteLine("===============================");
                        w.WriteLine("```");
                        w.WriteLine(line);
                        w.WriteLine("```");
                        info.ToMermaid(w);
                    }
                }
            }
        }
    }
}
