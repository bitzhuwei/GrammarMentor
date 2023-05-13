using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        /// <summary>
        /// get the dict: <see cref="eNFAInfo"/> of some <see cref="Token"/> -> Vt
        /// </summary>
        /// <param name="patternDict"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static Dictionary<TokenDraft, string/*Vt or 'mc' or 'sc'*/ > GetTokenDraftDict(Dictionary<string, string> patternDict) {
            var compiler = new CompilerPattern();
            var result = new Dictionary<TokenDraft, string>();
            foreach (var item in patternDict) {
                var Vt = item.Key;

                var pattern = item.Value;
                var tokens = compiler.Analyze(pattern);
                var node = compiler.Parse(tokens);
                var tokenDraft = compiler.Extract(node, tokens);
                tokenDraft.regexInfo.Traverse(state => {
                    state.Vt = Vt;
                    state.pattern = pattern;
                },
                null);
                tokenDraft.postInfo.Traverse(state => {
                    state.Vt = Vt;
                    state.pattern = pattern;
                },
                null);

                result.Add(tokenDraft, Vt);
            }

            return result;
        }
    }
}

