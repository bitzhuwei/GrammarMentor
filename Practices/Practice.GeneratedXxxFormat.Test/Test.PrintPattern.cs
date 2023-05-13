using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;

namespace Practice.GeneratedXxxFormat.Test {
    static partial class Test {
        public static void PrintPattern() {
            var compiler = new bitzhuwei.PatternFormat.CompilerPattern();

            Console.WriteLine("############ Processing: Pattern ############");
            using (var w = new StreamWriter("Xxx/Pattern.outputs")) {
                using (var reader = new StreamReader("Xxx/Pattern.inputs")) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        var tokens = compiler.Analyze(line);
                        var node = compiler.Parse(tokens);
                        var finalValue = compiler.Extract(node, tokens);
                        w.WriteLine("===============================");
                        if (tokens.errorDict.Count > 0) { Console.WriteLine($"!!!!!{tokens.errorDict.Count} errors.."); }
                        tokens.Print(w);
                        w.WriteLine("```````````````````````````````");
                        node.Print(w, tokens, bitzhuwei.PatternFormat.CompilerPattern.Regulations);
                        w.WriteLine("-------------------------------");
                    }
                }
            }
        }
    }
}

