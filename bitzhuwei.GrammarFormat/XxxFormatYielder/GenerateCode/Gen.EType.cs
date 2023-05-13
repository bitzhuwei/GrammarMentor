using bitzhuwei.Compiler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {
        private void GenerateEType(YieldContext context) {
            var VtDeclarationList = GenerateVtDeclarationList(context.grammar.VnRegulations);
            var VnDeclarationList = GenerateVnDeclarationList(context.grammar.VnRegulations);

            var p = context.parameter;
            string template = File.ReadAllText(templateEType);
            string step1 = template.Replace(strGrammarName, p.GrammarName);
            string step2 = step1.Replace(strVtDeclarationList, VtDeclarationList);
            string step3 = step2.Replace(strVnDeclarationList, VnDeclarationList);

            if (!Directory.Exists(p.generationDirectory)) { Directory.CreateDirectory(p.generationDirectory); }
            string fullname = Path.Combine(p.generationDirectory, $"Compiler{p.GrammarName}.EType.gen.cs");
            File.WriteAllText(fullname, step3);
        }

        private string GenerateVnDeclarationList(VnRegulationDraft[] regulations) {
            const int tab = 4 * 3;
            var b = new StringBuilder();
            var Vns = regulations.GetVnNodes();
            for (int i = 0; i < Vns.Length; i++) {
                var Vn = Vns[i];
                var name = Vn.Vn2Name();
                b.Tab(tab); b.AppendLine("/// <summary>");
                b.Tab(tab); b.AppendLine($"/// {Vn}");
                b.Tab(tab); b.AppendLine("/// </summary>");
                b.Tab(tab); b.AppendLine($"public const string {name} = \"{Vn}\";");
            }

            return b.ToString();
        }

        private string GenerateVtDeclarationList(VnRegulationDraft[] regulations) {
            const int tab = 4 * 3;
            var b = new StringBuilder();
            var Vts = regulations.GetVtNodes();
            for (int i = 0; i < Vts.Length; i++) {
                var Vt = Vts[i];
                var name = Vt.Vt2Name();
                b.Tab(tab); b.AppendLine("/// <summary>");
                b.Tab(tab); b.AppendLine($"/// {Vt}");
                b.Tab(tab); b.AppendLine("/// </summary>");
                b.Tab(tab); b.AppendLine($"public const string {name} = \"{Vt}\";");
            }

            var result = b.ToString();
            return result;
        }
    }
}