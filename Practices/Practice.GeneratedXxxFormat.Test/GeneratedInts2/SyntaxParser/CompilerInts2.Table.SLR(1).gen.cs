using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.Ints2Format {
    partial class CompilerInts2 {
        const int syntaxStateCount = 6;
        // NOTE: choose only one from CompilerInts2.TableLL(1).cs, CompilerInts2.TableLR(0).cs, CompilerInts2.TableSLR(1).cs, CompilerInts2.TableLALR(1).cs, CompilerInts2.TableLR(1).cs
        /// <summary>
        /// SLR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerInts2.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerInts2.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerInts2)}.syntaxStates[{i}]");
            }
            // 12 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] Ints2Array> : ⏳ Ints ;
            // [0] Ints : ⏳ Ints ',' Int ;
            // [1] Ints : ⏳ Int ;
            // [2] Int : ⏳ 'integer' ;
            list[0].actionDict.Add(EType.Ints, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Int, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@integer, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // syntaxStates[1]:
            // [-1] Ints2Array> : Ints ⏳ ;
            // [0] Ints : Ints ⏳ ',' Int ;
            list[1].actionDict.Add(EType.@Comma, new LRShiftInAction(syntaxStates[4]));/*Actions[3]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[4]*/
            // syntaxStates[2]:
            // [1] Ints : Int ⏳ ;
            list[2].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[1]));/*Actions[5]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[6]*/
            // syntaxStates[3]:
            // [2] Int : 'integer' ⏳ ;
            list[3].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[2]));/*Actions[7]*/
            // syntaxStates[4]:
            // [0] Ints : Ints ',' ⏳ Int ;
            // [2] Int : ⏳ 'integer' ;
            list[4].actionDict.Add(EType.Int, new LRGotoAction(syntaxStates[5]));/*Actions[8]*/
            list[4].actionDict.Add(EType.@integer, new LRShiftInAction(syntaxStates[3]));/*Actions[9]*/
            // syntaxStates[5]:
            // [0] Ints : Ints ',' Int ⏳ ;
            list[5].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[0]));/*Actions[10]*/
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[11]*/

        }
    }
}
