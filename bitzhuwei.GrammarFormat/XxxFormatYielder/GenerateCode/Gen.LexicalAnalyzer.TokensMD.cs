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

        private void GenerateLexicalAnalyzerTokensMD(YieldContext context) {
            var p = context.parameter;
            {
                var path = Path.Combine(p.generationDirectory, "doc");
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                int VtId = 1;
                foreach (var item in context.tokenDraftDict) {
                    var tokenDraft = item.Key; var Vt = item.Value;
                    string fullname = Path.Combine(path, $"T.{Vt.Vt2Name()}.gen.md");
                    using (var w = new StreamWriter(fullname)) {
                        w.Write($"# {Vt}"); w.WriteLine();
                        w.WriteLine();
                        var pattern = context.patternDict[Vt];
                        w.Write($"pattern: `{pattern}`"); w.WriteLine();
                        w.WriteLine();
                        //tokenDraft.ToMermaid(w);
                        var regex = tokenDraft.regexInfo.Copy(VtId);
                        var postRegex = tokenDraft.postInfo.Copy(VtId);
                        VtId++;
                        var innerEdge = eNFAEdgeDraft.Connect(regex.end, postRegex.start);
                        // TODO: tokenDraft.Copy()

                        var automaton = new AutomatonInfo(regex);
                        automaton.ToMermaid(w);
                    }
                }
            }
        }
    }
}