using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.IntsFormat {
    partial class CompilerInts {
        const int syntaxStateCount = 5;
        // NOTE: choose only one from CompilerInts.TableLL(1).cs, CompilerInts.TableLR(0).cs, CompilerInts.TableSLR(1).cs, CompilerInts.TableLALR(1).cs, CompilerInts.TableLR(1).cs
        /// <summary>
        /// SLR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerInts.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerInts.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerInts)}.syntaxStates[{i}]");
            }
            // 11 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] IntArray> : ⏳ Ints ;
            // [0] Ints : ⏳ Ints Int ;
            // [1] Ints : ⏳ Int ;
            // [2] Int : ⏳ 'integer' ;
            list[0].actionDict.Add(EType.Ints, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Int, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@integer, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // syntaxStates[1]:
            // [-1] IntArray> : Ints ⏳ ;
            // [0] Ints : Ints ⏳ Int ;
            // [2] Int : ⏳ 'integer' ;
            list[1].actionDict.Add(EType.Int, new LRGotoAction(syntaxStates[4]));/*Actions[3]*/
            list[1].actionDict.Add(EType.@integer, new LRShiftInAction(syntaxStates[3]));/*Actions[4]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[5]*/
            // syntaxStates[2]:
            // [1] Ints : Int ⏳ ;
            list[2].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[1]));/*Actions[6]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[7]*/
            // syntaxStates[3]:
            // [2] Int : 'integer' ⏳ ;
            list[3].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[2]));/*Actions[8]*/
            // syntaxStates[4]:
            // [0] Ints : Ints Int ⏳ ;
            list[4].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[0]));/*Actions[9]*/
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[10]*/

        }
    }
}
