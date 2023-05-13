using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat {
    partial class CompilerABB {
        const int syntaxStateCount = 6;
        // NOTE: choose only one from CompilerABB.TableLL(1).cs, CompilerABB.TableLR(0).cs, CompilerABB.TableSLR(1).cs, CompilerABB.TableLALR(1).cs, CompilerABB.TableLR(1).cs
        /// <summary>
        /// LALR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerABB.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerABB.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerABB)}.syntaxStates[{i}]");
            }
            // 12 actions. 0 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.A, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.@a, new LRShiftInAction(syntaxStates[2]));/*Actions[1]*/
            // list[1]
            list[1].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[3]*/
            // list[2]
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[4]*/
            list[2].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[1]));/*Actions[5]*/
            // list[3]
            list[3].actionDict.Add(EType.B, new LRGotoAction(syntaxStates[4]));/*Actions[6]*/
            list[3].actionDict.Add(EType.@b, new LRShiftInAction(syntaxStates[5]));/*Actions[7]*/
            // list[4]
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[8]*/
            list[4].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[0]));/*Actions[9]*/
            // list[5]
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[10]*/
            list[5].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[2]));/*Actions[11]*/

        }
    }
}
