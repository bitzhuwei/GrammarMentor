using bitzhuwei.Compiler;
using bitzhuwei.StepFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Practice.StepParser.Winform
{
    static partial class Test
    {
        public static void PrintStep()
        {
            var filenames1 = System.IO.Directory.GetFiles(@"D:\stepFiles", "*.step");
            var filenames2 = System.IO.Directory.GetFiles(@"D:\stepFiles", "*.stp");
            var filenames = new List<string>(filenames1); filenames.AddRange(filenames2);
            var query = from item in filenames orderby (new FileInfo(item)).Length ascending select item;
            var compiler = new bitzhuwei.StepFormat.CompilerStep();
            foreach (var filename in query)
            {
                string content = File.ReadAllText(filename);
                var tokens = compiler.Analyze(content);
                var node = compiler.Parse(tokens);
                var stepFile = compiler.Extract(node, tokens);
                try
                {
                    var fileInfo = new System.IO.FileInfo(filename);
                    var directory = fileInfo.DirectoryName;
                    int index = fileInfo.Name.LastIndexOf('.');
                    var name = fileInfo.Name.Substring(0, index);
                    using (var w = new System.IO.StreamWriter(Path.Combine(directory, "tokens", name + ".tokens")))
                    {
                        tokens.Print(w);
                    }
                    string formatted;
                    {
                        if (fileInfo.Name.ToLower().EndsWith(".step")) { formatted = (name + ".formatted.step"); }
                        else { formatted = (name + ".formatted.stp"); }
                    }
                    using (var w = new System.IO.StreamWriter(Path.Combine(directory, "formatted", formatted)))
                    {
                        stepFile.Print(w);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            foreach (var filename in query)
            {
                string content = File.ReadAllText(filename);
                var tokens = compiler.Analyze(content);
                var node = compiler.Parse(tokens);
                var stepFile = compiler.Extract(node, tokens);
                try
                {
                    var fileInfo = new System.IO.FileInfo(filename);
                    var directory = fileInfo.DirectoryName;
                    int index = fileInfo.Name.LastIndexOf('.');
                    var name = fileInfo.Name.Substring(0, index);
                    // .node file is too big.
                    var nodeFilename = System.IO.Path.Combine(name + ".node");
                    using (var w = new System.IO.StreamWriter(Path.Combine(directory, "node", name + ".node")))
                    {
                        node.Print(w, tokens, CompilerStep.Regulations);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
