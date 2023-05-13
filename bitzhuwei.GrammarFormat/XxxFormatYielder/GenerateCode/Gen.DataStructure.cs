using bitzhuwei.Compiler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateDataStructure(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "DataStructure");
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            {
                string template = File.ReadAllText(templateDataStructureExtractedType);
                string step1 = template.Replace(strGrammarName, p.GrammarName);
                {
                    string step2 = step1.Replace(strExtractedType, p.ExtractedType);
                    string fullname = Path.Combine(path, $"{p.ExtractedType}.gen.cs");
                    File.WriteAllText(fullname, step2);
                }
            }
            {
                string template = File.ReadAllText(templateDataStructureVn);
                string step1 = template.Replace(strGrammarName, p.GrammarName);
                var Vns = context.grammar.VnRegulations.GetVnNodes();
                foreach (var vn in Vns) {
                    string step2 = step1.Replace(strVn, vn);
                    string fullname = Path.Combine(path, $"{vn}.gen.cs");
                    File.WriteAllText(fullname, step2);
                }
            }
        }
    }
}