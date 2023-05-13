using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;
using System.IO;
using System.Threading;

namespace bitzhuwei.GrammarFormat.Console {
    internal class Program {
        static void Main(string[] args) {
            var compiler = new CompilerGrammar();

            var grammarFiles = Directory.GetFiles(".", "*.st");
            foreach (var grammarFile in grammarFiles) {
                var configFile = Path.Combine(grammarFile + ".config");
                if (!File.Exists(configFile)) {
                    System.Console.WriteLine($"No config file for {grammarFile}");
                    continue;
                }
                TryParseConfig(configFile, out string grammarName, out string extractedType);
                var fileInfo = new FileInfo(grammarFile);
                var filename = fileInfo.Name.Substring(0, fileInfo.Name.Length - 3);

                System.Console.WriteLine($"parsing {fileInfo.Name} ...");
                var sourceCode = File.ReadAllText(grammarFile);
                var tokens = compiler.Analyze(sourceCode);
                var node = compiler.Parse(tokens);
                var grammar = compiler.Extract(node, tokens);

                var folder = Path.Combine(".", filename);
                if (Directory.Exists(folder)) { Directory.Delete(folder, true); Thread.Sleep(0); }
                Directory.CreateDirectory(folder);
                //System.Diagnostics.Process.Start("explorer.exe", folder);// there's something to show now.
                var error = grammar.SemanticCheck(out var errorInfo);
                if (!error) {
                    var vn = grammar.VnRegulations[0].left;
                    var sameFirstName = (vn == extractedType);
                    if (sameFirstName) { extractedType = extractedType + "@"; }
                    var parameter = new YieldParameter(folder, grammarName, extractedType, sourceCode, tokens, node);
                    grammar.YieldCompiler(parameter);
                    if (sameFirstName) {
                        System.Console.WriteLine($"提取的class名称[{vn}]与Grammar的第一个Vn相同，请注意修改[{vn}Extracter.Init.cs]！提示：搜索[EType.EndOfTokenList]");
                    }
                }
                else {
                    System.Console.WriteLine($"{errorInfo}");
                }
            }

            System.Console.WriteLine("all process finished.");
            //System.Console.WriteLine("press any key to quit..");
            //System.Console.ReadKey();
        }

        private static void TryParseConfig(string configFile, out string grammarName, out string extractedType) {
            grammarName = string.Empty; extractedType = string.Empty;

            using (var reader = new StreamReader(configFile)) {
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    if (line.StartsWith("#")) { continue; }

                    var parts = line.Split('=');
                    if (parts[0] == "GrammarName") { grammarName = parts[1]; }
                    else if (parts[0] == "ExtractedType") { extractedType = parts[1]; }
                }
            }
        }
    }
}
