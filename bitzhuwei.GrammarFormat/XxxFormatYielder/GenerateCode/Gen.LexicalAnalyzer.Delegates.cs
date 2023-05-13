using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateLexicalAnalyzerDelegates(YieldContext context) {
            var p = context.parameter;
            {
                string template = File.ReadAllText(templateLexicalDelegates);
                template = template.Replace(strGrammarName, p.GrammarName);

                var path = Path.Combine(p.generationDirectory, "LexicalAnalyzer");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.LexicalDelegates.gen.cs");
                File.WriteAllText(fullname, template);
            }
        }
    }
}