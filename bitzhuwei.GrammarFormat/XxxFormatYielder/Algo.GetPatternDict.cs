using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public static partial class Algorithm {
        // Vt -> xxx in %%xxx%%
        // '{' -> {
        // 'min' -> [0-9]+
        // 'max' -> [0-9]+
        /// <summary>
        /// pattern of all Vt nodes and 'multipleLineComment' and 'singleLineComment'.
        /// <para>Dictionary<string/*Vt*/, string/*xxx in %%xxx%%*/></para>
        /// </summary>
        /// <param name="grammar"></param>
        /// <returns>Dictionary<string/*Vt*/, string/*xxx in %%xxx%%*/></returns>
        public static Dictionary<string/*Vt*/, string/*xxx in %%xxx%%*/> GetPatternDict(this GrammarDraft grammar) {
            var result = new Dictionary<string, string>();
            var firstIndex = "%%".Length;
            var boundaryLength = "%%%%".Length;
            foreach (var VtPattern in grammar.VtPatterns) {
                var Vt = VtPattern.Vt; var pattern = VtPattern.pattern;
                var text = pattern.Substring(firstIndex, pattern.Length - boundaryLength);
                result.Add(Vt, text);
            }
            var Vts = grammar.VnRegulations.GetVtNodes();
            foreach (var Vt in Vts) {
                if (!result.TryGetValue(Vt, out var text)) {
                    var inner = Vt.VtInner();
                    var b = new StringBuilder();
                    using (var w = new StringWriter(b)) {
                        foreach (var item in inner) {
                            //b.Append('['); b.Append(item.regexAppear()); b.Append(']');
                            item.regexAppear(w);
                        }
                    }
                    text = b.ToString();
                    result.Add(Vt, text);
                }
            }
            // TODO: support comments.
            //if (!result.ContainsKey(CompilerGrammar.keywordMultipleLineComment)) {
            //    result.Add(CompilerGrammar.keywordMultipleLineComment, @"\/\*([^*]|[*][^\/])*\*\/");
            //}
            //if (!result.ContainsKey(CompilerGrammar.keywordSingleLineComment)) {
            //    result.Add(CompilerGrammar.keywordSingleLineComment, @"\/\/.*");
            //}

            return result;
        }
    }
}

