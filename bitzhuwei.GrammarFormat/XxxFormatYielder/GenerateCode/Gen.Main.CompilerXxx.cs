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

        private void GenerateCompilerXxx(YieldContext context) {
            var p = context.parameter;
            var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            if (!Directory.Exists(p.generationDirectory)) { Directory.CreateDirectory(p.generationDirectory); }
            {
                string template = File.ReadAllText(templateMain);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strExtractedType, p.ExtractedType);
                template = template.Replace(strExtractedType_var, p.ExtractedType_var);
                string fullname = Path.Combine(p.generationDirectory, $"Compiler{p.GrammarName}.gen.cs");
                File.WriteAllText(fullname, template);
            }
        }
    }
}