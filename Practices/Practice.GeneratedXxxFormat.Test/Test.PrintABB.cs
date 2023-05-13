using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Practice.GeneratedXxxFormat.Test {
    static partial class Test {
        public static void PrintABB() {
            var compiler = new bitzhuwei.ABBFormat.CompilerABB();

            Console.WriteLine("############ Processing: ABB ############");
            using (var w = new StreamWriter("Xxx/ABB.outputs")) {
                using (var reader = new StreamReader("Xxx/ABB.inputs")) {
                    while (!reader.EndOfStream) {
                        var line = reader.ReadLine();
                        Console.WriteLine($"line:{line}");
                        var tokens = compiler.Analyze(line);
                        var node = compiler.Parse(tokens);
                        var bCounter = compiler.Extract(node, tokens);
                        w.WriteLine("===============================");
                        if (tokens.errorDict.Count > 0) { Console.WriteLine($"!!!!!{tokens.errorDict.Count} errors.."); }
                        tokens.Print(w);
                        w.WriteLine("```````````````````````````````");
                        node.Print(w, tokens, bitzhuwei.ABBFormat.CompilerABB.Regulations);
                        w.WriteLine("```````````````````````````````");
                        var formatted = compiler.PrintFormat(node, tokens);
                        w.WriteLine($"{bCounter.value} = {formatted}");
                        w.WriteLine("-------------------------------");
                    }
                }
            }
        }
    }
}
namespace bitzhuwei.ABBFormat {

    partial class CompilerABB {

        public string PrintFormat(Node rootNode, TokenList tokens) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                Print(w, rootNode, tokens);
            }

            return b.ToString();
        }

        private void Print(StringWriter w, Node node, TokenList tokens) {
            if (node.type == EType.Plus) {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.a) {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.b) {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.EndOfTokenList) {
                // -1: <BCounter> : A  ;
                // this branch will never happen.
            }
            else if (node.type == EType.A) {
                if (node.regulation == regulations[0]) {
                    // 0: A: A '+' B;
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++) {
                        Print(w, node.Children[i], tokens);
                        w.Write(' ');
                    }
                    if (count > 0) {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else if (node.regulation == regulations[1]) {
                    // 1: A: 'a';
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++) {
                        Print(w, node.Children[i], tokens);
                        w.Write(' ');
                    }
                    if (count > 0) {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else { throw new NotImplementedException(); }
            }
            else if (node.type == EType.B) {
                if (node.regulation == regulations[2]) {
                    // 2: B: 'b';
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++) {
                        Print(w, node.Children[i], tokens);
                        w.Write(' ');
                    }
                    if (count > 0) {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else { throw new NotImplementedException(); }
            }
        }
    }
}

