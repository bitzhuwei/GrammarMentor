using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PrefixFormat {
    partial class CompilerPrefix {
        const int syntaxStateCount = 7;
        // NOTE: choose only one from CompilerPrefix.TableLL(1).cs, CompilerPrefix.TableLR(0).cs, CompilerPrefix.TableSLR(1).cs, CompilerPrefix.TableLALR(1).cs, CompilerPrefix.TableLR(1).cs
        /// <summary>
        /// LR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerPrefix.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerPrefix.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerPrefix)}.syntaxStates[{i}]");
            }
            // 14 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] Prefix2> : ⏳ Items ; '￥' 
            // [0] Items : ⏳ Items Item ; '￥' 'entityId' 
            // [1] Items : ⏳ Item ; '￥' 'entityId' 
            // [2] Item : ⏳ 'entityId' '=' 'refEntity' ; '￥' 'entityId' 
            list[0].actionDict.Add(EType.Items, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Item, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@entityId, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // syntaxStates[1]:
            // [-1] Prefix2> : Items ⏳ ; '￥' 
            // [0] Items : Items ⏳ Item ; '￥' 'entityId' 
            // [2] Item : ⏳ 'entityId' '=' 'refEntity' ; '￥' 'entityId' 
            list[1].actionDict.Add(EType.Item, new LRGotoAction(syntaxStates[4]));/*Actions[3]*/
            list[1].actionDict.Add(EType.@entityId, new LRShiftInAction(syntaxStates[3]));/*Actions[4]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[5]*/
            // syntaxStates[2]:
            // [1] Items : Item ⏳ ; '￥' 'entityId' 
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[6]*/
            list[2].actionDict.Add(EType.@entityId, new LRReducitonAction(regulations[1]));/*Actions[7]*/
            // syntaxStates[3]:
            // [2] Item : 'entityId' ⏳ '=' 'refEntity' ; '￥' 'entityId' 
            list[3].actionDict.Add(EType.@Equal, new LRShiftInAction(syntaxStates[5]));/*Actions[8]*/
            // syntaxStates[4]:
            // [0] Items : Items Item ⏳ ; '￥' 'entityId' 
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[9]*/
            list[4].actionDict.Add(EType.@entityId, new LRReducitonAction(regulations[0]));/*Actions[10]*/
            // syntaxStates[5]:
            // [2] Item : 'entityId' '=' ⏳ 'refEntity' ; '￥' 'entityId' 
            list[5].actionDict.Add(EType.@refEntity, new LRShiftInAction(syntaxStates[6]));/*Actions[11]*/
            // syntaxStates[6]:
            // [2] Item : 'entityId' '=' 'refEntity' ⏳ ; '￥' 'entityId' 
            list[6].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[6].actionDict.Add(EType.@entityId, new LRReducitonAction(regulations[2]));/*Actions[13]*/

        }
    }
}
