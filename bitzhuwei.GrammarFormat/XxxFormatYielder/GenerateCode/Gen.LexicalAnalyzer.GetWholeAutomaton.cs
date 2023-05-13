using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {
        /// <summary>
        /// get <see cref="AutomatonInfo"/> of the whole complete ¦Å-NFA for lexical analyzing
        /// </summary>
        /// <param name="tokenScriptDict"><see cref="TokenDraft"/> -> Vt</param>
        /// <returns></returns>
        private AutomatonInfo GetWholeAutomaton(Dictionary<TokenDraft, string> tokenScriptDict) {
            // prepare dict for faster search.
            // <'Vt'> -> its tokenScript
            var regexInfoDict = new Dictionary<string/*Vt*/, eNFAInfo>();
            var wholeStart = new eNFAStateDraft(0, "wholeStart");
            var wholeEnd = new eNFAStateDraft(1, "wholeEnd"); wholeEnd.isEnd = true;
            //var wholeEnd = wholeStart;
            //var edgeTokenDraftDict = new ListedDict<eNFAEdgeDraft, TokenDraft>();
            //var stateTokenDraftDict = new ListedDict<eNFAStateDraft, TokenDraft>();
            var wholeeNFA = new eNFAInfo(wholeStart, wholeEnd);
            // connect all eNFAInfo together to make a whole complete ¦Å-NFA for lexical analyzing.
            int VtId = 1;
            var queue = new Queue<TokenDraft>(); foreach (var item in tokenScriptDict) { queue.Enqueue(item.Key); }
            var queue2 = new Queue<TokenDraft>(); bool updated = true;
            while (updated) {
                updated = false;
                while (queue.Count > 0) {
                    var tokenDraft = queue.Dequeue();
                    if (tokenDraft.preVt == CompilerPattern.defaultPreVt) {
                        var Vt = tokenScriptDict[tokenDraft];
                        var regexInfo = tokenDraft.regexInfo.Copy(VtId); var postInfo = tokenDraft.postInfo.Copy(VtId);
                        // connect preENFA & tokenScript
                        var closeStart = eNFAEdgeDraft.Connect(wholeStart, regexInfo.start);
                        // connect regex & postRegex (xxx/yyy)
                        var innerEdge = eNFAEdgeDraft.Connect(regexInfo.end, postInfo.start);
                        var closeEnd = eNFAEdgeDraft.Connect(postInfo.end, wholeEnd);//, ConditionHelper.otherSign);
                        // no need to: { closeStart.TryAttach(new TokenScript(Vt, ETokenScriptType.acceptPrevious), wholeeNFA); }
                        foreach (var edge in regexInfo.start.toEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.BeginToken), wholeeNFA); }
                        foreach (var edge in regexInfo.end.fromEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.ExtendToken), wholeeNFA); }
                        foreach (var edge in postInfo.start.toEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.CheckToken), wholeeNFA); }
                        foreach (var edge in postInfo.end.fromEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.AcceptToken), wholeeNFA); }
                        regexInfoDict.Add(Vt, regexInfo);
                        VtId++;
                        updated = true;
                    }
                    else if (regexInfoDict.TryGetValue(tokenDraft.preVt, out var preENFA)) {
                        var Vt = tokenScriptDict[tokenDraft];
                        var regexInfo = tokenDraft.regexInfo.Copy(VtId); var postInfo = tokenDraft.postInfo.Copy(VtId);
                        // connect preENFA and tokenScript
                        var closeStart = eNFAEdgeDraft.Connect(preENFA.end, regexInfo.start);
                        // connect regex postRegex (xxx/yyy)
                        var innerEdge = eNFAEdgeDraft.Connect(regexInfo.end, postInfo.start);
                        var closeEnd = eNFAEdgeDraft.Connect(postInfo.end, wholeEnd);//, ConditionHelper.otherSign);
                        { closeStart.TryAttach(new TokenScript(tokenDraft.preVt, ETokenScriptType.AcceptPrevious), wholeeNFA); }
                        foreach (var edge in regexInfo.start.toEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.BeginToken), wholeeNFA); }
                        foreach (var edge in regexInfo.end.fromEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.ExtendToken), wholeeNFA); }
                        foreach (var edge in postInfo.start.toEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.CheckToken), wholeeNFA); }
                        foreach (var edge in postInfo.end.fromEdges) { edge.TryAttach(new TokenScript(Vt, ETokenScriptType.AcceptToken), wholeeNFA); }
                        regexInfoDict.Add(Vt, regexInfo);
                        VtId++;
                        updated = true;
                    }
                    else {
                        queue2.Enqueue(tokenDraft);
                    }
                }

                queue = queue2;
            }
            if (queue.Count > 0) { // some token will never be collected
                var b = new StringBuilder();
                b.Append("These tokens will never be collected.");
                foreach (var item in queue) {
                    b.Append(item); b.AppendLine();
                }

                throw new Exception(b.ToString());
            }
            {
                //var closeWhole = eNFAEdgeDraft.Connect(wholeStart, wholeStart, ConditionHelper.otherSign);
            }

            var result = new AutomatonInfo(wholeeNFA);
            return result;
        }

    }
}

