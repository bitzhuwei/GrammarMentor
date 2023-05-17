using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SABFormat {
    partial class CompilerSAB {
        const int syntaxStateCount = 11;
        // NOTE: choose only one from CompilerSAB.TableLL(1).cs, CompilerSAB.TableLR(0).cs, CompilerSAB.TableSLR(1).cs, CompilerSAB.TableLALR(1).cs, CompilerSAB.TableLR(1).cs
        /// <summary>
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerSAB.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerSAB.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerSAB)}.syntaxStates[{i}]");
            }
            // 47 actions. 3 conflicts.
            // syntaxStates[0]:
            // [-1] SAB2> : ⏳ S ;
            // [0] S : ⏳ A 'a' 's' ;
            // [1] S : ⏳ B 'b' 's' ;
            // [2] S : ⏳ 'd' ;
            // [3] A : ⏳ 'a' ;
            // [4] B : ⏳ 'c' ;
            // [5] B : ⏳ ;
            //@d repeated 2 times
            //@a repeated 2 times
            //@c repeated 2 times
            list[0].actionDict.Add(EType.S, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.A, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.B, new LRGotoAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@d, new LRShiftInAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@d, new LRReducitonAction(regulations[5]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@a, new LRShiftInAction(syntaxStates[5]));/*Actions[5]*/
            list[0].actionDict.Add(EType.@a, new LRReducitonAction(regulations[5]));/*Actions[6]*/
            list[0].actionDict.Add(EType.@c, new LRShiftInAction(syntaxStates[6]));/*Actions[7]*/
            list[0].actionDict.Add(EType.@c, new LRReducitonAction(regulations[5]));/*Actions[8]*/
            list[0].actionDict.Add(EType.@s, new LRReducitonAction(regulations[5]));/*Actions[9]*/
            list[0].actionDict.Add(EType.@b, new LRReducitonAction(regulations[5]));/*Actions[10]*/
            list[0].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[11]*/
            // syntaxStates[1]:
            // [-1] SAB2> : S ⏳ ;
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[12]*/
            // syntaxStates[2]:
            // [0] S : A ⏳ 'a' 's' ;
            list[2].actionDict.Add(EType.@a, new LRShiftInAction(syntaxStates[7]));/*Actions[13]*/
            // syntaxStates[3]:
            // [1] S : B ⏳ 'b' 's' ;
            list[3].actionDict.Add(EType.@b, new LRShiftInAction(syntaxStates[8]));/*Actions[14]*/
            // syntaxStates[4]:
            // [2] S : 'd' ⏳ ;
            list[4].actionDict.Add(EType.@a, new LRReducitonAction(regulations[2]));/*Actions[15]*/
            list[4].actionDict.Add(EType.@s, new LRReducitonAction(regulations[2]));/*Actions[16]*/
            list[4].actionDict.Add(EType.@b, new LRReducitonAction(regulations[2]));/*Actions[17]*/
            list[4].actionDict.Add(EType.@d, new LRReducitonAction(regulations[2]));/*Actions[18]*/
            list[4].actionDict.Add(EType.@c, new LRReducitonAction(regulations[2]));/*Actions[19]*/
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[20]*/
            // syntaxStates[5]:
            // [3] A : 'a' ⏳ ;
            list[5].actionDict.Add(EType.@a, new LRReducitonAction(regulations[3]));/*Actions[21]*/
            list[5].actionDict.Add(EType.@s, new LRReducitonAction(regulations[3]));/*Actions[22]*/
            list[5].actionDict.Add(EType.@b, new LRReducitonAction(regulations[3]));/*Actions[23]*/
            list[5].actionDict.Add(EType.@d, new LRReducitonAction(regulations[3]));/*Actions[24]*/
            list[5].actionDict.Add(EType.@c, new LRReducitonAction(regulations[3]));/*Actions[25]*/
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[26]*/
            // syntaxStates[6]:
            // [4] B : 'c' ⏳ ;
            list[6].actionDict.Add(EType.@a, new LRReducitonAction(regulations[4]));/*Actions[27]*/
            list[6].actionDict.Add(EType.@s, new LRReducitonAction(regulations[4]));/*Actions[28]*/
            list[6].actionDict.Add(EType.@b, new LRReducitonAction(regulations[4]));/*Actions[29]*/
            list[6].actionDict.Add(EType.@d, new LRReducitonAction(regulations[4]));/*Actions[30]*/
            list[6].actionDict.Add(EType.@c, new LRReducitonAction(regulations[4]));/*Actions[31]*/
            list[6].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[32]*/
            // syntaxStates[7]:
            // [0] S : A 'a' ⏳ 's' ;
            list[7].actionDict.Add(EType.@s, new LRShiftInAction(syntaxStates[9]));/*Actions[33]*/
            // syntaxStates[8]:
            // [1] S : B 'b' ⏳ 's' ;
            list[8].actionDict.Add(EType.@s, new LRShiftInAction(syntaxStates[10]));/*Actions[34]*/
            // syntaxStates[9]:
            // [0] S : A 'a' 's' ⏳ ;
            list[9].actionDict.Add(EType.@a, new LRReducitonAction(regulations[0]));/*Actions[35]*/
            list[9].actionDict.Add(EType.@s, new LRReducitonAction(regulations[0]));/*Actions[36]*/
            list[9].actionDict.Add(EType.@b, new LRReducitonAction(regulations[0]));/*Actions[37]*/
            list[9].actionDict.Add(EType.@d, new LRReducitonAction(regulations[0]));/*Actions[38]*/
            list[9].actionDict.Add(EType.@c, new LRReducitonAction(regulations[0]));/*Actions[39]*/
            list[9].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[40]*/
            // syntaxStates[10]:
            // [1] S : B 'b' 's' ⏳ ;
            list[10].actionDict.Add(EType.@a, new LRReducitonAction(regulations[1]));/*Actions[41]*/
            list[10].actionDict.Add(EType.@s, new LRReducitonAction(regulations[1]));/*Actions[42]*/
            list[10].actionDict.Add(EType.@b, new LRReducitonAction(regulations[1]));/*Actions[43]*/
            list[10].actionDict.Add(EType.@d, new LRReducitonAction(regulations[1]));/*Actions[44]*/
            list[10].actionDict.Add(EType.@c, new LRReducitonAction(regulations[1]));/*Actions[45]*/
            list[10].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[46]*/

        }
    }
}
