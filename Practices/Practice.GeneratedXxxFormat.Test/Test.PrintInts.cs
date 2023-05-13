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
        public static void PrintInts() {
            var compiler = new bitzhuwei.IntsFormat.CompilerInts();

            Console.WriteLine("############ Processing: Ints ############");
            using (var w = new StreamWriter("Xxx/Ints.outputs")) {
                using (var reader = new StreamReader("Xxx/Ints.inputs")) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        Console.WriteLine($"line:{line}");
                        var tokens = compiler.Analyze(line);
                        var node = compiler.Parse(tokens);
                        var finalValue = compiler.Extract(node, tokens);
                        w.WriteLine("===============================");
                        if (tokens.errorDict.Count > 0) { Console.WriteLine($"!!!!!{tokens.errorDict.Count} errors.."); }
                        tokens.Print(w);
                        w.WriteLine("```````````````````````````````");
                        node.Print(w, tokens, bitzhuwei.IntsFormat.CompilerInts.Regulations);
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

