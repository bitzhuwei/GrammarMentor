using bitzhuwei.Compiler;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateREADME(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            if (!Directory.Exists(p.generationDirectory)) { Directory.CreateDirectory(p.generationDirectory); }
            {
                string template = File.ReadAllText(templateREADME);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                string fullname = Path.Combine(p.generationDirectory, $"README.gen.md");
                File.WriteAllText(fullname, template);
            }
        }
    }
}