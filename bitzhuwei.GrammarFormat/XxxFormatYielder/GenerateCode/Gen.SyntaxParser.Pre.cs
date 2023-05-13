using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateSyntaxParserPre(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "SyntaxParser");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            {
                var newRegulations = GetnewRegulations(context.grammar.VnRegulations);
                string template = File.ReadAllText(templateRegulation);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strnew_Regulations, newRegulations);

                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.Regulations.gen.cs");
                File.WriteAllText(fullname, template);
            }
            {
                string template = File.ReadAllText(templateSyntaxParserREADME);
                string fullname = Path.Combine(path, $"README.gen.md");
                File.WriteAllText(fullname, template);
            }
        }

    }
}