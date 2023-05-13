using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat
{
    public partial class Test
    {
        public static void PrintABB()
        {
            var compiler = new bitzhuwei.ABBFormat.CompilerABB();

            using (var w = new StreamWriter("ABB.outputs"))
            {
                using (var reader = new StreamReader("ABB.inputs"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var tokens = compiler.Analyze(line);
                        var node = compiler.Parse(tokens);
                        var bCounter = compiler.Extract(node, tokens);
                        w.WriteLine("===============================");
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
