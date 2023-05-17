using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        const int syntaxStateCount = 15;
        // NOTE: choose only one from CompilerSES.TableLL(1).cs, CompilerSES.TableLR(0).cs, CompilerSES.TableSLR(1).cs, CompilerSES.TableLALR(1).cs, CompilerSES.TableLR(1).cs
        /// <summary>
        /// LR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerSES.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerSES.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerSES)}.syntaxStates[{i}]");
            }
            // 36 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] SES2> : ⏳ S ; '￥' 
            // [0] S : ⏳ N V N ; '￥' 
            // [1] N : ⏳ 's' ; 'e' 'd' 
            // [2] N : ⏳ 't' ; 'e' 'd' 
            // [3] N : ⏳ 'g' ; 'e' 'd' 
            // [4] N : ⏳ 'w' ; 'e' 'd' 
            list[0].actionDict.Add(EType.S, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.N, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@s, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@t, new LRShiftInAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@g, new LRShiftInAction(syntaxStates[5]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@w, new LRShiftInAction(syntaxStates[6]));/*Actions[5]*/
            // syntaxStates[1]:
            // [-1] SES2> : S ⏳ ; '￥' 
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[6]*/
            // syntaxStates[2]:
            // [0] S : N ⏳ V N ; '￥' 
            // [5] V : ⏳ 'e' ; 's' 't' 'g' 'w' 
            // [6] V : ⏳ 'd' ; 's' 't' 'g' 'w' 
            list[2].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[7]));/*Actions[7]*/
            list[2].actionDict.Add(EType.@e, new LRShiftInAction(syntaxStates[8]));/*Actions[8]*/
            list[2].actionDict.Add(EType.@d, new LRShiftInAction(syntaxStates[9]));/*Actions[9]*/
            // syntaxStates[3]:
            // [1] N : 's' ⏳ ; 'e' 'd' 
            list[3].actionDict.Add(EType.@e, new LRReducitonAction(regulations[1]));/*Actions[10]*/
            list[3].actionDict.Add(EType.@d, new LRReducitonAction(regulations[1]));/*Actions[11]*/
            // syntaxStates[4]:
            // [2] N : 't' ⏳ ; 'e' 'd' 
            list[4].actionDict.Add(EType.@e, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[4].actionDict.Add(EType.@d, new LRReducitonAction(regulations[2]));/*Actions[13]*/
            // syntaxStates[5]:
            // [3] N : 'g' ⏳ ; 'e' 'd' 
            list[5].actionDict.Add(EType.@e, new LRReducitonAction(regulations[3]));/*Actions[14]*/
            list[5].actionDict.Add(EType.@d, new LRReducitonAction(regulations[3]));/*Actions[15]*/
            // syntaxStates[6]:
            // [4] N : 'w' ⏳ ; 'e' 'd' 
            list[6].actionDict.Add(EType.@e, new LRReducitonAction(regulations[4]));/*Actions[16]*/
            list[6].actionDict.Add(EType.@d, new LRReducitonAction(regulations[4]));/*Actions[17]*/
            // syntaxStates[7]:
            // [0] S : N V ⏳ N ; '￥' 
            // [1] N : ⏳ 's' ; '￥' 
            // [2] N : ⏳ 't' ; '￥' 
            // [3] N : ⏳ 'g' ; '￥' 
            // [4] N : ⏳ 'w' ; '￥' 
            list[7].actionDict.Add(EType.N, new LRGotoAction(syntaxStates[10]));/*Actions[18]*/
            list[7].actionDict.Add(EType.@s, new LRShiftInAction(syntaxStates[11]));/*Actions[19]*/
            list[7].actionDict.Add(EType.@t, new LRShiftInAction(syntaxStates[12]));/*Actions[20]*/
            list[7].actionDict.Add(EType.@g, new LRShiftInAction(syntaxStates[13]));/*Actions[21]*/
            list[7].actionDict.Add(EType.@w, new LRShiftInAction(syntaxStates[14]));/*Actions[22]*/
            // syntaxStates[8]:
            // [5] V : 'e' ⏳ ; 's' 't' 'g' 'w' 
            list[8].actionDict.Add(EType.@s, new LRReducitonAction(regulations[5]));/*Actions[23]*/
            list[8].actionDict.Add(EType.@t, new LRReducitonAction(regulations[5]));/*Actions[24]*/
            list[8].actionDict.Add(EType.@g, new LRReducitonAction(regulations[5]));/*Actions[25]*/
            list[8].actionDict.Add(EType.@w, new LRReducitonAction(regulations[5]));/*Actions[26]*/
            // syntaxStates[9]:
            // [6] V : 'd' ⏳ ; 's' 't' 'g' 'w' 
            list[9].actionDict.Add(EType.@s, new LRReducitonAction(regulations[6]));/*Actions[27]*/
            list[9].actionDict.Add(EType.@t, new LRReducitonAction(regulations[6]));/*Actions[28]*/
            list[9].actionDict.Add(EType.@g, new LRReducitonAction(regulations[6]));/*Actions[29]*/
            list[9].actionDict.Add(EType.@w, new LRReducitonAction(regulations[6]));/*Actions[30]*/
            // syntaxStates[10]:
            // [0] S : N V N ⏳ ; '￥' 
            list[10].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[31]*/
            // syntaxStates[11]:
            // [1] N : 's' ⏳ ; '￥' 
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[32]*/
            // syntaxStates[12]:
            // [2] N : 't' ⏳ ; '￥' 
            list[12].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[33]*/
            // syntaxStates[13]:
            // [3] N : 'g' ⏳ ; '￥' 
            list[13].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[34]*/
            // syntaxStates[14]:
            // [4] N : 'w' ⏳ ; '￥' 
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[35]*/

        }
    }
}
