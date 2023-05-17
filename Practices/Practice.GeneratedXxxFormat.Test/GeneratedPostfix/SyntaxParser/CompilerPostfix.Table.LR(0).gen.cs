using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
        const int syntaxStateCount = 7;
        // NOTE: choose only one from CompilerPostfix.TableLL(1).cs, CompilerPostfix.TableLR(0).cs, CompilerPostfix.TableSLR(1).cs, CompilerPostfix.TableLALR(1).cs, CompilerPostfix.TableLR(1).cs
        /// <summary>
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerPostfix.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerPostfix.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerPostfix)}.syntaxStates[{i}]");
            }
            // 20 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] Postfix2> : ⏳ Items ;
            // [0] Items : ⏳ Items Item ;
            // [1] Items : ⏳ Item ;
            // [2] Item : ⏳ 'entityId' '=' 'refEntity' ;
            list[0].actionDict.Add(EType.Items, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Item, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@entityId, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // syntaxStates[1]:
            // [-1] Postfix2> : Items ⏳ ;
            // [0] Items : Items ⏳ Item ;
            // [2] Item : ⏳ 'entityId' '=' 'refEntity' ;
            list[1].actionDict.Add(EType.Item, new LRGotoAction(syntaxStates[4]));/*Actions[3]*/
            list[1].actionDict.Add(EType.@entityId, new LRShiftInAction(syntaxStates[3]));/*Actions[4]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[5]*/
            // syntaxStates[2]:
            // [1] Items : Item ⏳ ;
            list[2].actionDict.Add(EType.@entityId, new LRReducitonAction(regulations[1]));/*Actions[6]*/
            list[2].actionDict.Add(EType.@Equal, new LRReducitonAction(regulations[1]));/*Actions[7]*/
            list[2].actionDict.Add(EType.@refEntity, new LRReducitonAction(regulations[1]));/*Actions[8]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[9]*/
            // syntaxStates[3]:
            // [2] Item : 'entityId' ⏳ '=' 'refEntity' ;
            list[3].actionDict.Add(EType.@Equal, new LRShiftInAction(syntaxStates[5]));/*Actions[10]*/
            // syntaxStates[4]:
            // [0] Items : Items Item ⏳ ;
            list[4].actionDict.Add(EType.@entityId, new LRReducitonAction(regulations[0]));/*Actions[11]*/
            list[4].actionDict.Add(EType.@Equal, new LRReducitonAction(regulations[0]));/*Actions[12]*/
            list[4].actionDict.Add(EType.@refEntity, new LRReducitonAction(regulations[0]));/*Actions[13]*/
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[14]*/
            // syntaxStates[5]:
            // [2] Item : 'entityId' '=' ⏳ 'refEntity' ;
            list[5].actionDict.Add(EType.@refEntity, new LRShiftInAction(syntaxStates[6]));/*Actions[15]*/
            // syntaxStates[6]:
            // [2] Item : 'entityId' '=' 'refEntity' ⏳ ;
            list[6].actionDict.Add(EType.@entityId, new LRReducitonAction(regulations[2]));/*Actions[16]*/
            list[6].actionDict.Add(EType.@Equal, new LRReducitonAction(regulations[2]));/*Actions[17]*/
            list[6].actionDict.Add(EType.@refEntity, new LRReducitonAction(regulations[2]));/*Actions[18]*/
            list[6].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[19]*/

        }
    }
}
