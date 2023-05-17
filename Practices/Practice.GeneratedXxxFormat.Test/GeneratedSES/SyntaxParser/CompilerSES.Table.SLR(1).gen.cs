using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        const int syntaxStateCount = 11;
        // NOTE: choose only one from CompilerSES.TableLL(1).cs, CompilerSES.TableLR(0).cs, CompilerSES.TableSLR(1).cs, CompilerSES.TableLALR(1).cs, CompilerSES.TableLR(1).cs
        /// <summary>
        /// SLR(1) syntax parsing table
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
            // 32 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] SES2> : ⏳ S ;
            // [0] S : ⏳ N V N ;
            // [1] N : ⏳ 's' ;
            // [2] N : ⏳ 't' ;
            // [3] N : ⏳ 'g' ;
            // [4] N : ⏳ 'w' ;
            list[0].actionDict.Add(EType.S, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.N, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@s, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@t, new LRShiftInAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@g, new LRShiftInAction(syntaxStates[5]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@w, new LRShiftInAction(syntaxStates[6]));/*Actions[5]*/
            // syntaxStates[1]:
            // [-1] SES2> : S ⏳ ;
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[6]*/
            // syntaxStates[2]:
            // [0] S : N ⏳ V N ;
            // [5] V : ⏳ 'e' ;
            // [6] V : ⏳ 'd' ;
            list[2].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[7]));/*Actions[7]*/
            list[2].actionDict.Add(EType.@e, new LRShiftInAction(syntaxStates[8]));/*Actions[8]*/
            list[2].actionDict.Add(EType.@d, new LRShiftInAction(syntaxStates[9]));/*Actions[9]*/
            // syntaxStates[3]:
            // [1] N : 's' ⏳ ;
            list[3].actionDict.Add(EType.@e, new LRReducitonAction(regulations[1]));/*Actions[10]*/
            list[3].actionDict.Add(EType.@d, new LRReducitonAction(regulations[1]));/*Actions[11]*/
            // syntaxStates[4]:
            // [2] N : 't' ⏳ ;
            list[4].actionDict.Add(EType.@e, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[4].actionDict.Add(EType.@d, new LRReducitonAction(regulations[2]));/*Actions[13]*/
            // syntaxStates[5]:
            // [3] N : 'g' ⏳ ;
            list[5].actionDict.Add(EType.@e, new LRReducitonAction(regulations[3]));/*Actions[14]*/
            list[5].actionDict.Add(EType.@d, new LRReducitonAction(regulations[3]));/*Actions[15]*/
            // syntaxStates[6]:
            // [4] N : 'w' ⏳ ;
            list[6].actionDict.Add(EType.@e, new LRReducitonAction(regulations[4]));/*Actions[16]*/
            list[6].actionDict.Add(EType.@d, new LRReducitonAction(regulations[4]));/*Actions[17]*/
            // syntaxStates[7]:
            // [0] S : N V ⏳ N ;
            // [1] N : ⏳ 's' ;
            // [2] N : ⏳ 't' ;
            // [3] N : ⏳ 'g' ;
            // [4] N : ⏳ 'w' ;
            list[7].actionDict.Add(EType.N, new LRGotoAction(syntaxStates[10]));/*Actions[18]*/
            list[7].actionDict.Add(EType.@s, new LRShiftInAction(syntaxStates[3]));/*Actions[19]*/
            list[7].actionDict.Add(EType.@t, new LRShiftInAction(syntaxStates[4]));/*Actions[20]*/
            list[7].actionDict.Add(EType.@g, new LRShiftInAction(syntaxStates[5]));/*Actions[21]*/
            list[7].actionDict.Add(EType.@w, new LRShiftInAction(syntaxStates[6]));/*Actions[22]*/
            // syntaxStates[8]:
            // [5] V : 'e' ⏳ ;
            list[8].actionDict.Add(EType.@s, new LRReducitonAction(regulations[5]));/*Actions[23]*/
            list[8].actionDict.Add(EType.@t, new LRReducitonAction(regulations[5]));/*Actions[24]*/
            list[8].actionDict.Add(EType.@g, new LRReducitonAction(regulations[5]));/*Actions[25]*/
            list[8].actionDict.Add(EType.@w, new LRReducitonAction(regulations[5]));/*Actions[26]*/
            // syntaxStates[9]:
            // [6] V : 'd' ⏳ ;
            list[9].actionDict.Add(EType.@s, new LRReducitonAction(regulations[6]));/*Actions[27]*/
            list[9].actionDict.Add(EType.@t, new LRReducitonAction(regulations[6]));/*Actions[28]*/
            list[9].actionDict.Add(EType.@g, new LRReducitonAction(regulations[6]));/*Actions[29]*/
            list[9].actionDict.Add(EType.@w, new LRReducitonAction(regulations[6]));/*Actions[30]*/
            // syntaxStates[10]:
            // [0] S : N V N ⏳ ;
            list[10].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[31]*/

        }
    }
}
