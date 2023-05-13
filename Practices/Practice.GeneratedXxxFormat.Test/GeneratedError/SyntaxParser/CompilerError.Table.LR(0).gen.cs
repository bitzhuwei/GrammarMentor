using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ErrorFormat {
    partial class CompilerError {
        const int syntaxStateCount = 3;
        // NOTE: choose only one from CompilerError.TableLL(1).cs, CompilerError.TableLR(0).cs, CompilerError.TableSLR(1).cs, CompilerError.TableLALR(1).cs, CompilerError.TableLR(1).cs
        /// <summary>
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerError.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerError.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerError)}.syntaxStates[{i}]");
            }
            // 5 actions. 0 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.PreRegex, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.@refVt, new LRShiftInAction(syntaxStates[2]));/*Actions[1]*/
            // list[1]
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[2]*/
            // list[2]
            list[2].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[0]));/*Actions[3]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[4]*/

        }
    }
}
