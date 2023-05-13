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

        private void GenerateMainLL1(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            //var firstList = GetFIRSTList(context.nff.firstDict);
            //var followList = GetFOLLOWList(context.nff.followDict);
            var ll1Table = GetSyntaxParsingTableMD(context.ll1SyntaxInfo.table, context.grammar.VnRegulations);
            {
                string template = File.ReadAllText(templateSyntaxMachineLL1);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strLL1SyntaxTable, ll1Table);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"SyntaxMachine.LL(1).gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
        }

        private void GenerateMainLR0(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            //var firstList = GetFIRSTList(context.nff.firstDict);
            //var followList = GetFOLLOWList(context.nff.followDict);
            var lr0Table = GetSyntaxParsingTableMD(context.lr0SyntaxInfo.table,
                context.grammar.VnRegulations, context.lr0SyntaxInfo.stateList.States.Count);
            var lr0Diagram = GetLR0SyntaxDiagram(context.lr0SyntaxInfo, context.grammar.VnRegulations);
            //var lr0StateList = GetLR0StateList(context.lr0SyntaxInfo.lr0StateList);
            //var lr0EdgeList = GetLR0EdgeList(context.lr0SyntaxInfo.lr0EdgeList);
            {
                string template = File.ReadAllText(templateSytnaxMachineLR0);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strLR0SyntaxTable, lr0Table);
                template = template.Replace(strLR0SyntaxDiagram, lr0Diagram);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"SytnaxMachine.LR(0).gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
            {
                //template = template.Replace(strLR0States, lr0StateList);
                //template = template.Replace(strLR0Edges, lr0EdgeList);
            }
        }

        private void GenerateMainSLR1(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            //var firstList = GetFIRSTList(context.nff.firstDict);
            //var followList = GetFOLLOWList(context.nff.followDict);
            var slr1Table = GetSyntaxParsingTableMD(context.slr1SyntaxInfo.table,
                context.grammar.VnRegulations, context.slr1SyntaxInfo.stateList.States.Count);
            var slr1Diagram = GetSLR1SyntaxDiagram(context.slr1SyntaxInfo, context.grammar.VnRegulations);
            //var slr1StateList = GetSLR1StateList(context.slr1SyntaxInfo.slr1StateList);
            //var slr1EdgeList = GetSLR1EdgeList(context.slr1SyntaxInfo.slr1EdgeList);
            {
                string template = File.ReadAllText(templateSyntaxMachineSLR1);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strSLR1SyntaxTable, slr1Table);
                template = template.Replace(strSLRSyntaxDiagram, slr1Diagram);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"SyntaxMachine.SLR(1).gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
            {
                //template = template.Replace(strSLR1States, slr1StateList);
                //template = template.Replace(strSLR1Edges, slr1EdgeList);
            }
        }
        private void GenerateMainLALR1(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            //var firstList = GetFIRSTList(context.nff.firstDict);
            //var followList = GetFOLLOWList(context.nff.followDict);
            var lalr1Table = GetSyntaxParsingTableMD(context.lalr1SyntaxInfo.table,
                context.grammar.VnRegulations, context.lalr1SyntaxInfo.stateList.States.Count);
            var lalr1Diagram = GetLALR1SyntaxDiagram(context.lalr1SyntaxInfo, context.grammar.VnRegulations);
            //var lalr1StateList = GetLALR1StateList(context.lalr1SyntaxInfo.lalr1StateList);
            //var lalr1EdgeList = GetLALR1EdgeList(context.lalr1SyntaxInfo.lalr1EdgeList);
            {
                string template = File.ReadAllText(templateSyntaxMachineLALR1);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strLALR1SyntaxTable, lalr1Table);
                template = template.Replace(strLALR1SyntaxDiagram, lalr1Diagram);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"SyntaxMachine.LALR(1).gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
            {
                //template = template.Replace(strLALR1States, lalr1StateList);
                //template = template.Replace(strLALR1Edges, lalr1EdgeList);
            }
        }

        private void GenerateMainLR1(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            var grammar = context.grammar.Print();
            //var firstList = GetFIRSTList(context.nff.firstDict);
            //var followList = GetFOLLOWList(context.nff.followDict);
            var lr1Table = GetSyntaxParsingTableMD(context.lr1SyntaxInfo.table,
                 context.grammar.VnRegulations, context.lr1SyntaxInfo.stateList.States.Count);
            var lr1Diagram = GetLR1SyntaxDiagram(context.lr1SyntaxInfo, context.grammar.VnRegulations);
            //var lr1StateList = GetLR1StateList(context.lr1SyntaxInfo.lr1StateList);
            //var lr1EdgeList = GetLR1EdgeList(context.lr1SyntaxInfo.lr1EdgeList);
            {
                string template = File.ReadAllText(templateSyntaxMachineLR1);
                template = template.Replace(strGrammarName, p.GrammarName);
                //template = template.Replace(strnow, now);
                template = template.Replace(strGrammar, grammar);
                template = template.Replace(strLR1SyntaxTable, lr1Table);
                template = template.Replace(strLR1SyntaxDiagram, lr1Diagram);
                string fullname = Path.Combine(p.generationDirectory, "doc", $"SyntaxMachine.LR(1).gen.md");
                var fileInfo = new FileInfo(fullname);
                var directory = fileInfo.DirectoryName;
                if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
                File.WriteAllText(fullname, template);
            }
            {
                //template = template.Replace(strLR1States, lr1StateList);
                //template = template.Replace(strLR1Edges, lr1EdgeList);
            }
        }
    }
}