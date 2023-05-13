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
        public static void PrintPrefix() {
            var compiler = new bitzhuwei.PrefixFormat.CompilerPrefix();

            Console.WriteLine("############ Processing: Prefix ############");
            using (var w = new StreamWriter("Xxx/Prefix.outputs")) {
                using (var reader = new StreamReader("Xxx/Prefix.inputs")) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        var tokens = compiler.Analyze(line);
                        var node = compiler.Parse(tokens);
                        var finalValue = compiler.Extract(node, tokens);
                        w.WriteLine("===============================");
                        if (tokens.errorDict.Count > 0) { Console.WriteLine($"!!!!!{tokens.errorDict.Count} errors.."); }
                        tokens.Print(w);
                        w.WriteLine("```````````````````````````````");
                        node.Print(w, tokens, bitzhuwei.PrefixFormat.CompilerPrefix.Regulations);
                        //w.WriteLine("```````````````````````````````");
                        //var formatted = compiler.PrintFormat(node, tokens);
                        //w.WriteLine($"{finalValue.value} = {formatted}");
                        w.WriteLine("-------------------------------");
                    }
                }
            }
        }
    }
}

