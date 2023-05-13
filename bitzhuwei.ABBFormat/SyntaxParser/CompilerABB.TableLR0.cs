using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat
{
    partial class CompilerABB
    {
        const int syntaxStateCount = 6;
        // NOTE: choose only one from CompilerABB.TableLR0.cs, CompilerABB.TableSLR.cs, CompilerABB.TableLALR1.cs, CompilerABB.TableLR1.cs
        /// <summary>
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        private static void InitializeSyntaxStates()
        {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++)
            {
                list[i] = new SyntaxState($"{nameof(CompilerABB)}.syntaxStates[i]");
            }
            // 18 actions. 0 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.A, new LR1GotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.a, new LR1ShiftInAction(syntaxStates[2]));/*Actions[1]*/
            // list[1]
            list[1].actionDict.Add(EType.Plus, new LR1ShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[1].actionDict.Add(EType.EndOfTokenList, new LR1AcceptAction(/*no param*/));/*Actions[3]*/
            // list[2]
            list[2].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[1]));/*Actions[4]*/
            list[2].actionDict.Add(EType.Plus, new LR1ReducitonAction(regulations[1]));/*Actions[5]*/
            list[2].actionDict.Add(EType.a, new LR1ReducitonAction(regulations[1]));/*Actions[6]*/
            list[2].actionDict.Add(EType.b, new LR1ReducitonAction(regulations[1]));/*Actions[7]*/
            // list[3]
            list[3].actionDict.Add(EType.B, new LR1GotoAction(syntaxStates[4]));/*Actions[8]*/
            list[3].actionDict.Add(EType.b, new LR1ShiftInAction(syntaxStates[5]));/*Actions[9]*/
            // list[4]
            list[4].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[0]));/*Actions[10]*/
            list[4].actionDict.Add(EType.Plus, new LR1ReducitonAction(regulations[0]));/*Actions[11]*/
            list[4].actionDict.Add(EType.a, new LR1ReducitonAction(regulations[0]));/*Actions[12]*/
            list[4].actionDict.Add(EType.b, new LR1ReducitonAction(regulations[0]));/*Actions[13]*/
            // list[5]
            list[5].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[2]));/*Actions[14]*/
            list[5].actionDict.Add(EType.Plus, new LR1ReducitonAction(regulations[2]));/*Actions[15]*/
            list[5].actionDict.Add(EType.a, new LR1ReducitonAction(regulations[2]));/*Actions[16]*/
            list[5].actionDict.Add(EType.b, new LR1ReducitonAction(regulations[2]));/*Actions[17]*/

        }
    }
}
