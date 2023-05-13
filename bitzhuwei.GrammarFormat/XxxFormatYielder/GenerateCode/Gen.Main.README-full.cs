using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateMainPost(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            var LexicalAnalyerStatesDFA = GetLexicalAnalyerStatesDFA(context.automatonInfo.DFA);
            var firstList = GetFIRSTList(context.nff.firstDict);
            var followList = GetFOLLOWList(context.nff.followDict);
            var ll1Table = GetSyntaxParsingTableMD(context.ll1SyntaxInfo.table,
                context.grammar.VnRegulations);
            var lr0Table = GetSyntaxParsingTableMD(context.lr0SyntaxInfo.table,
                 context.grammar.VnRegulations, context.lr0SyntaxInfo.stateList.States.Count);
            var lr0Diagram = GetLR0SyntaxDiagram(context.lr0SyntaxInfo, context.grammar.VnRegulations);
            var slr1Table = GetSyntaxParsingTableMD(context.slr1SyntaxInfo.table,
                            context.grammar.VnRegulations, context.slr1SyntaxInfo.stateList.States.Count);
            var slr1Diagram = GetSLR1SyntaxDiagram(context.slr1SyntaxInfo, context.grammar.VnRegulations);
            var lalr1Table = GetSyntaxParsingTableMD(context.lalr1SyntaxInfo.table,
                         context.grammar.VnRegulations, context.lalr1SyntaxInfo.stateList.States.Count);
            var lalr1Diagram = GetLALR1SyntaxDiagram(context.lalr1SyntaxInfo, context.grammar.VnRegulations);
            var lr1Table = GetSyntaxParsingTableMD(context.lr1SyntaxInfo.table,
                           context.grammar.VnRegulations, context.lr1SyntaxInfo.stateList.States.Count);
            var lr1Diagram = GetLR1SyntaxDiagram(context.lr1SyntaxInfo, context.grammar.VnRegulations);
            //var lr0StateList = GetLR0StateList(context.lr0SyntaxInfo.lr0StateList);
            //var slr1StateList = GetSLR1StateList(context.slr1SyntaxInfo.slr1StateList);
            //var lalr1StateList = GetLALR1StateList(context.lalr1SyntaxInfo.lalr1StateList);
            //var lr1StateList = GetLR1StateList(context.lr1SyntaxInfo.lr1StateList);

            //var lr0EdgeList = GetLR0EdgeList(context.lr0SyntaxInfo.lr0EdgeList);
            //var slr1EdgeList = GetSLR1EdgeList(context.slr1SyntaxInfo.slr1EdgeList);
            //var lalr1EdgeList = GetLALR1EdgeList(context.lalr1SyntaxInfo.lalr1EdgeList);
            //var lr1EdgeList = GetLR1EdgeList(context.lr1SyntaxInfo.lr1EdgeList);
            {
                string template = File.ReadAllText(templateReadmeFull);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strLexicalAnalyerStatesDFA, LexicalAnalyerStatesDFA);
                template = template.Replace(strFirstList, firstList);
                template = template.Replace(strFollowList, followList);
                template = template.Replace(strLL1SyntaxTable, ll1Table);
                template = template.Replace(strLR0SyntaxTable, lr0Table);
                template = template.Replace(strLR0SyntaxDiagram, lr0Diagram);
                template = template.Replace(strSLR1SyntaxTable, slr1Table);
                template = template.Replace(strSLRSyntaxDiagram, slr1Diagram);
                template = template.Replace(strLALR1SyntaxTable, lalr1Table);
                template = template.Replace(strLALR1SyntaxDiagram, lalr1Diagram);
                template = template.Replace(strLR1SyntaxTable, lr1Table);
                template = template.Replace(strLR1SyntaxDiagram, lr1Diagram);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"README-full.gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
        }

        private string GetLexicalAnalyerStatesDFA(DFAInfo DFA) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                //w.WriteLine("```Mermaid");
                w.WriteLine("flowchart");
                DFA.ToMermaid(w, null);
                //w.WriteLine("```");
            }

            return b.ToString();
        }
    }
}