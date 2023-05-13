using bitzhuwei.WRLFormat;
using CSharpGL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.WRL.Winform
{
    static class Test
    {
        public static void ExtractWRL()
        {
            var compiler = new CompilerWRL();
            var filenames = Directory.GetFiles(@"D:\stepFiles\SC80-EC", "*.wrl");
            for (int i = 0; i < filenames.Length; i++)
            {
                string filename = filenames[i];
                var content = File.ReadAllText(filename);
                var tokens = compiler.Analyze(content);
                var syntaxTree = compiler.Parse(tokens);
                var wrlFile = compiler.Extract(syntaxTree, tokens);
                var model = new WRLModel(wrlFile);
                var node = NoShadowNode.Create(model, "position", "normal", model.modelSize);
                node.WorldPosition = model.initialPosition;
                //node.Name = filename;
            }

        }
    }
}
