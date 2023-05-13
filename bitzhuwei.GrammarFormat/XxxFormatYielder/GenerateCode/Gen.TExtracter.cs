using bitzhuwei.Compiler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateTExtracter(YieldContext context) {
            var p = context.parameter;
            {
                var eVn = context.GetExtendedStartNode();
                var extracterDictAddList = GetExtracterDictAddList(context.grammar.VnRegulations, eVn, p);
                string template = File.ReadAllText(templateTExtracter);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strExtractedType, p.ExtractedType);
                template = template.Replace(strExtractedType_var, p.ExtractedType_var);
                template = template.Replace(strextracterDict_Add_List, extracterDictAddList);

                var path = Path.Combine(p.generationDirectory, "TExtracter");
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                string fullname = Path.Combine(path, $"{p.GrammarName}Extracter.Init.gen.cs");
                File.WriteAllText(fullname, template);
            }
            {
                string template = File.ReadAllText(templateTExtracterREADME);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strExtractedType, p.ExtractedType);

                var path = Path.Combine(p.generationDirectory, "TExtracter");
                if (!Directory.Exists(path)) {
                    Directory.CreateDirectory(path);
                }
                string fullname = Path.Combine(path, $"README.md");
                File.WriteAllText(fullname, template);
            }
        }

        private static string GetExtracterDictAddList(VnRegulationDraft[] regulations, string eVn, YieldParameter p) {
            var ExtractedType = p.ExtractedType;
            var compilerName = $"Compiler{p.GrammarName}";
            const int tab1 = 4 * 3, tab2 = 4 * 4, tab3 = 4 * 5;
            var b = new StringBuilder();
            // Vt
            var Vts = regulations.GetVtNodes();
            for (int i = 0; i < Vts.Length; i++) {
                var Vt = Vts[i];
                var name = Vt.Vt2Name();
                //b.PrintLine(tab1, $"extracterDict.Add(EType.{name},");
                //b.PrintLine(tab1, @"(node, context) => {");
                //b.PrintLine(tab2, "var token = context.tokens[node.tokenIndex];");
                //b.PrintLine(tab2, "context.objStack.Push(token.value);");
                //b.PrintLine(tab1, "});");
                b.PrintLine(tab1, $"extracterDict.Add(EType.{name}, VtHandler);");
            }
            // external Vt: EType.EndOfTokenList
            {
                var regulation = regulations[0];
                var leftVarName = regulation.left.Type2VarName(addPrefix: true);
                var extractedTypeName = ExtractedType.Type2VarName(addPrefix: true);
                b.PrintLine(tab1, $"extracterDict.Add(EType.EndOfTokenList,");
                b.PrintLine(tab1, @"(node, context) => {");
                b.PrintLine(tab2, $"// -1: {eVn} : {regulation.left} ;");
                b.PrintLine(tab2, $"var {leftVarName} = context.objStack.Pop() as {regulation.left};");
                b.PrintLine(tab2, $"var {extractedTypeName} = new {ExtractedType}(/*{leftVarName}*/);");
                b.PrintLine(tab2, $"context.result = {extractedTypeName}; // final step, no need to push into stack.");
                b.PrintLine(tab1, "});");
            }
            // Vn
            var Vns = regulations.GetVnNodes();
            for (int i = 0; i < Vns.Length; i++) {
                var Vn = Vns[i];
                b.PrintLine(tab1, $"extracterDict.Add(EType.{Vn},");
                b.PrintLine(tab1, @"(node, context) => {");
                /*
                 * if (node.regulation == CompilerXxx.regulations[{index}]) {
                 *     // {index} : A : X y Z ;
                 *     var x = context.objStack.Pop() as X;
                 *     var y = context.objStack.Pop() as Token;
                 *     var z = context.objStack.Pop() as Z;
                 *     var a = new A(x, y, z);
                 *     context.objStack.Push(a);
                 * else if (node.regulation == CompilerXxx.regulations[{index}] {
                 *     ...
                 * }
                 * else if ( .. ) { ... }
                 * else { throw new NotImplementedException(); }
                 */
                var syntaxStatement = regulations.GetVnRegulations(Vn);
                {
                    var regulation = syntaxStatement[0];
                    var index = Array.IndexOf(regulations, regulation);
                    b.PrintLine(tab2, $"if (node.regulation == {compilerName}.regulations[{index}]) {{");
                    {
                        b.Tab(tab3); b.AppendLine($"// {index}: {regulation}");
                        NormalImplementaion(tab3, b, regulation);
                    }
                    b.PrintLine(tab2, "}");
                }
                for (int j = 1; j < syntaxStatement.Length; j++) {
                    var regulation = syntaxStatement[j];
                    var index = Array.IndexOf(regulations, regulation);
                    b.PrintLine(tab2, $"else if (node.regulation == {compilerName}.regulations[{index}]) {{");
                    {
                        b.Tab(tab3); b.AppendLine($"// {index}: {regulation}");
                        NormalImplementaion(tab3, b, regulation);
                    }
                    b.PrintLine(tab2, "}");
                }
                {
                    b.PrintLine(tab2, "else { throw new NotImplementedException(); }");
                }
                b.PrintLine(tab1, "});");
            }

            var result = b.ToString();
            return result;
        }

        private static void NormalImplementaion(int tab, StringBuilder b, VnRegulationDraft regulation) {
            var stack = new Stack<string>(); foreach (var v in regulation.Right) { stack.Push(v); }
            var stackVarName = new Stack<string>(); int tail = 0;
            while (stack.Count > 0) {
                var V = stack.Pop();
                if (V == CompilerGrammar.keywordEmpty) {
                    b.PrintLine(tab, $"// Generation Error: No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(VnRegulationDraft.Right)}");
                    var varName = CompilerGrammar.keywordEmpty + tail++; stackVarName.Push(varName);
                    b.PrintLine(tab, $"object {varName} = null;");
                    throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(VnRegulationDraft.Right)}");
                }
                else if (V.IsVt()) {
                    var varName = V.Vt2Name().Type2VarName() + tail++; stackVarName.Push(varName);
                    b.PrintLine(tab, $"var {varName} = context.objStack.Pop() as {nameof(Token)};");
                }
                else // Vn
                {
                    var varName = V.Type2VarName() + tail++; stackVarName.Push(varName);
                    b.PrintLine(tab, $"var {varName} = context.objStack.Pop() as {V};");
                }
            }
            var leftVarName = regulation.left.Type2VarName(addPrefix: true);
            b.Print(tab, $"var {leftVarName} = new {regulation.left}(/*");
            while (stackVarName.Count > 1) {
                var varName = stackVarName.Pop();
                b.Append($"{varName}, ");
            }
            if (stackVarName.Count > 0) {
                var varName = stackVarName.Pop();
                b.Append($"{varName}");
            }
            b.AppendLine("*/);");
            b.PrintLine(tab, $"context.objStack.Push({leftVarName});");
        }
    }
}