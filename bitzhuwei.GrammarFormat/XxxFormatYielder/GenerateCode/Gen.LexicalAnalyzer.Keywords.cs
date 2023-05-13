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

        private void GenerateLexicalAnalyzerKeywords(YieldContext context) {
            var p = context.parameter;
            {
                var keywordDelcaration_List = GetkeywordDelcarationList(context.grammar);
                var CheckKeywordCases = GetCheckKeywordCases(context.grammar);

                string template = File.ReadAllText(templateLexicalKeywords);
                template = template.Replace(strGrammarName, p.GrammarName);
                template = template.Replace(strkeywordDelcaration_List, keywordDelcaration_List);
                template = template.Replace(strCheckKeywordCases, CheckKeywordCases);

                var path = Path.Combine(p.generationDirectory, "LexicalAnalyzer");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                string fullname = Path.Combine(path, $"Compiler{p.GrammarName}.LexicalKeywords.gen.cs");
                File.WriteAllText(fullname, template);
            }
        }

        private string GetCheckKeywordCases(GrammarDraft grammar) {
            var result = new Dictionary<string, string>();
            var Vts = grammar.VnRegulations.GetVtNodes();
            foreach (var Vt in Vts) {
                var inner = Vt.VtInner(); var name = Vt.Vt2Name();
                if (inner != name.Substring(1)) { continue; }

                var found = false;
                foreach (var VtPattern in grammar.VtPatterns) {
                    if (VtPattern.Vt == Vt) {
                        var pattern = VtPattern.pattern.Substring(2, VtPattern.pattern.Length - "%%%%".Length);
                        // TODO: not really started coding this part yet. This '==' is huge project.
                        if (inner == pattern) {
                            result.Add(Vt, pattern);
                        }
                        found = true;
                        break;
                    }
                }
                if (!found) {
                    result.Add(Vt, name);
                }
            }
            const int tab = 4 * 3;
            var b = new StringBuilder();
            foreach (var item in result) {
                var Vt = item.Key;
                var inner = Vt.VtInner(); // 'xxx' -> xxx
                var name = Vt.Vt2Name();  // 'xxx' -> xxx -> @abcde
                b.Tab(tab); b.AppendLine($"case {name}keyword: token.type = EType.{name}; isKeyword = true; break;");
            }

            return b.ToString();
        }

        private string GetkeywordDelcarationList(GrammarDraft grammar) {
            var result = new Dictionary<string, string>();
            var Vts = grammar.VnRegulations.GetVtNodes();
            foreach (var Vt in Vts) {
                var inner = Vt.VtInner(); var name = Vt.Vt2Name();
                if (inner != name.Substring(1)) { continue; }

                var found = false;
                foreach (var VtPattern in grammar.VtPatterns) {
                    if (VtPattern.Vt == Vt) {
                        var pattern = VtPattern.pattern.Substring(2, VtPattern.pattern.Length - "%%%%".Length);
                        // TODO: not really started coding this part yet. This '==' is huge project.
                        if (inner == pattern) {
                            result.Add(Vt, pattern);
                        }
                        found = true;
                        break;
                    }
                }
                if (!found) {
                    result.Add(Vt, name);
                }
            }
            const int tab = 4 * 2;
            var b = new StringBuilder();
            foreach (var item in result) {
                var Vt = item.Key;
                var inner = Vt.VtInner(); // 'xxx' -> xxx
                var name = Vt.Vt2Name();  // 'xxx' -> xxx -> @abcde
                b.Tab(tab); b.AppendLine("/// <summary>");
                b.Tab(tab); b.AppendLine($"/// {inner}");
                b.Tab(tab); b.AppendLine($"/// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>");
                b.Tab(tab); b.AppendLine($"/// <para>because it requires regular exprssion parsing.</para>");
                b.Tab(tab); b.AppendLine($"/// <para>I will get this done later(2023年4月3日16:03:41).</para>");
                b.Tab(tab); b.AppendLine($"/// <para>Partly solved(2023年5月3日21:37:07).</para>");
                b.Tab(tab); b.AppendLine("/// </summary>");
                b.Tab(tab); b.AppendLine($"public const string {name}keyword = \"{inner}\";");
            }

            return b.ToString();
        }

        //private string GetkeywordDelcarationList(VnRegulationDraft[] regulations) {
        //    // TODO: not really started coding this part yet. This is huge project.
        //    const int tab = 4 * 2;
        //    var b = new StringBuilder();
        //    var Vts = regulations.GetVtNodes();
        //    for (int i = 0; i < Vts.Length; i++) {
        //        var Vt = Vts[i];
        //        var inner = Vt.VtInner(); // 'xxx' -> xxx
        //        var name = Vt.Vt2Name();  // 'xxx' -> xxx -> @abcde
        //        b.Tab(tab); b.AppendLine("/// <summary>");
        //        b.Tab(tab); b.AppendLine($"/// {inner}");
        //        b.Tab(tab); b.AppendLine($"/// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>");
        //        b.Tab(tab); b.AppendLine($"/// <para>because it requires regular exprssion parsing.</para>");
        //        b.Tab(tab); b.AppendLine($"/// <para>I will get this done later(2023年4月3日16:03:41).</para>");
        //        b.Tab(tab); b.AppendLine("/// </summary>");
        //        b.Tab(tab); b.AppendLine($"public const string {name}keyword = \"{inner}\";");
        //    }

        //    return b.ToString();
        //}
    }
}