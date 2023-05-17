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

        private void GenerateSyntaxParserLL1(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "SyntaxParser");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            {
                var table = GetTableSetActionLines(context.ll1SyntaxInfo.table);
                string template = File.ReadAllText(templateTableLL1);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strfirstVn, context.grammar.VnRegulations[0].left);
                template = template.Replace(strVnCount, table.VnCount.ToString());
                template = template.Replace(stractionCount, table.actionCount.ToString());
                template = template.Replace(strconflicts, table.conflictCount.ToString());
                template = template.Replace(strEParsingTable, "LL(1) syntax parsing table");
                template = template.Replace(stractionDict_Add_List, table.actionDict_Add_List);

                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.Table.LL(1).gen.cs");
                File.WriteAllText(fullname, template);
            }
        }
        private void GenerateSyntaxParserLR0(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "SyntaxParser");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            {
                var table = GetTableSetActionLines(context.lr0SyntaxInfo, context.grammar.VnRegulations);
                string template = File.ReadAllText(templateTableLR);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strsyntaxStateCount, table.syntaxStateCount.ToString());
                template = template.Replace(stractionCount, table.actionCount.ToString());
                template = template.Replace(strconflicts, table.conflictCount.ToString());
                template = template.Replace(strEParsingTable, "LR(0) syntax parsing table");
                template = template.Replace(stractionDict_Add_List, table.actionDict_Add_List);

                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.Table.LR(0).gen.cs");
                File.WriteAllText(fullname, template);
            }
        }

        private void GenerateSyntaxParserSLR1(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "SyntaxParser");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            {
                var table = GetTableSetActionLines(context.slr1SyntaxInfo, context.grammar.VnRegulations);
                string template = File.ReadAllText(templateTableLR);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strsyntaxStateCount, table.syntaxStateCount.ToString());
                template = template.Replace(stractionCount, table.actionCount.ToString());
                template = template.Replace(strconflicts, table.conflictCount.ToString());
                template = template.Replace(strEParsingTable, "SLR(1) syntax parsing table");
                template = template.Replace(stractionDict_Add_List, table.actionDict_Add_List);

                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.Table.SLR(1).gen.cs");
                File.WriteAllText(fullname, template);
            }
        }
        private void GenerateSyntaxParserLALR1(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "SyntaxParser");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            {
                var table = GetTableSetActionLines(context.lalr1SyntaxInfo, context.grammar.VnRegulations);
                string template = File.ReadAllText(templateTableLR);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strsyntaxStateCount, table.syntaxStateCount.ToString());
                template = template.Replace(stractionCount, table.actionCount.ToString());
                template = template.Replace(strconflicts, table.conflictCount.ToString());
                template = template.Replace(strEParsingTable, "LALR(1) syntax parsing table");
                template = template.Replace(stractionDict_Add_List, table.actionDict_Add_List);

                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.Table.LALR(1).gen.cs");
                File.WriteAllText(fullname, template);
            }
        }
        private void GenerateSyntaxParserLR1(YieldContext context) {
            var p = context.parameter;
            var path = Path.Combine(p.generationDirectory, "SyntaxParser");
            if (!Directory.Exists(path)) {
                Directory.CreateDirectory(path);
            }
            {
                var table = GetTableSetActionLines(context.lr1SyntaxInfo, context.grammar.VnRegulations);
                string template = File.ReadAllText(templateTableLR);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strsyntaxStateCount, table.syntaxStateCount.ToString());
                template = template.Replace(stractionCount, table.actionCount.ToString());
                template = template.Replace(strconflicts, table.conflictCount.ToString());
                template = template.Replace(strEParsingTable, "LR(1) syntax parsing table");
                template = template.Replace(stractionDict_Add_List, table.actionDict_Add_List);

                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.Table.LR(1).gen.cs");
                File.WriteAllText(fullname, template);
            }
        }
    }
}