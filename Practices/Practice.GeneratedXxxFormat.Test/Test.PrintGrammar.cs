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
        public static void PrintGrammar() {
            var compiler = new bitzhuwei.GrammarFormat.CompilerGrammar();

            Console.WriteLine("############ Processing: Grammar ############");
            using (var w = new StreamWriter("Xxx/Grammar.outputs")) {
                using (var reader = new StreamReader("Xxx/Grammar.inputs")) {
                    var content = reader.ReadToEnd();
                    var tokens = compiler.Analyze(content);
                    var node = compiler.Parse(tokens);
                    var extracted = compiler.Extract(node, tokens);
                    w.WriteLine("===============================");
                    if (tokens.errorDict.Count > 0) { Console.WriteLine($"!!!!!{tokens.errorDict.Count} errors.."); }
                    tokens.Print(w);
                    w.WriteLine("```````````````````````````````");
                    node.Print(w, tokens, bitzhuwei.GrammarFormat.CompilerGrammar.Regulations);
                    w.WriteLine("```````````````````````````````");
                    //var formatted = compiler.PrintFormat(node, tokens);
                    //w.WriteLine($"{finalValue.value} = {formatted}");
                    w.WriteLine($"extracted: {extracted}");
                    w.WriteLine("-------------------------------");
                }
            }
        }
    }
}

