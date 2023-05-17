using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.NumbersFormat {
    partial class CompilerNumbers {
        const int syntaxStateCount = 6;
        // NOTE: choose only one from CompilerNumbers.TableLL(1).cs, CompilerNumbers.TableLR(0).cs, CompilerNumbers.TableSLR(1).cs, CompilerNumbers.TableLALR(1).cs, CompilerNumbers.TableLR(1).cs
        /// <summary>
        /// LALR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerNumbers.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerNumbers.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerNumbers)}.syntaxStates[{i}]");
            }
            // 20 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] NumberArray> : ⏳ Numbers ; '￥' 
            // [0] Numbers : ⏳ Numbers Number ; '￥' 'integer' 'float' 
            // [1] Numbers : ⏳ Number ; '￥' 'integer' 'float' 
            // [2] Number : ⏳ 'integer' ; '￥' 'integer' 'float' 
            // [3] Number : ⏳ 'float' ; '￥' 'integer' 'float' 
            list[0].actionDict.Add(EType.Numbers, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Number, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@integer, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@float, new LRShiftInAction(syntaxStates[4]));/*Actions[3]*/
            // syntaxStates[1]:
            // [-1] NumberArray> : Numbers ⏳ ; '￥' 
            // [0] Numbers : Numbers ⏳ Number ; '￥' 'integer' 'float' 
            // [2] Number : ⏳ 'integer' ; '￥' 'integer' 'float' 
            // [3] Number : ⏳ 'float' ; '￥' 'integer' 'float' 
            list[1].actionDict.Add(EType.Number, new LRGotoAction(syntaxStates[5]));/*Actions[4]*/
            list[1].actionDict.Add(EType.@integer, new LRShiftInAction(syntaxStates[3]));/*Actions[5]*/
            list[1].actionDict.Add(EType.@float, new LRShiftInAction(syntaxStates[4]));/*Actions[6]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[7]*/
            // syntaxStates[2]:
            // [1] Numbers : Number ⏳ ; '￥' 'integer' 'float' 
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[8]*/
            list[2].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[1]));/*Actions[9]*/
            list[2].actionDict.Add(EType.@float, new LRReducitonAction(regulations[1]));/*Actions[10]*/
            // syntaxStates[3]:
            // [2] Number : 'integer' ⏳ ; '￥' 'integer' 'float' 
            list[3].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[11]*/
            list[3].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[3].actionDict.Add(EType.@float, new LRReducitonAction(regulations[2]));/*Actions[13]*/
            // syntaxStates[4]:
            // [3] Number : 'float' ⏳ ; '￥' 'integer' 'float' 
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[14]*/
            list[4].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[3]));/*Actions[15]*/
            list[4].actionDict.Add(EType.@float, new LRReducitonAction(regulations[3]));/*Actions[16]*/
            // syntaxStates[5]:
            // [0] Numbers : Numbers Number ⏳ ; '￥' 'integer' 'float' 
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[17]*/
            list[5].actionDict.Add(EType.@integer, new LRReducitonAction(regulations[0]));/*Actions[18]*/
            list[5].actionDict.Add(EType.@float, new LRReducitonAction(regulations[0]));/*Actions[19]*/

        }
    }
}
