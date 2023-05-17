using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        const int syntaxStateCount = 15;
        // NOTE: choose only one from CompilerScope.TableLL(1).cs, CompilerScope.TableLR(0).cs, CompilerScope.TableSLR(1).cs, CompilerScope.TableLALR(1).cs, CompilerScope.TableLR(1).cs
        /// <summary>
        /// LR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerScope.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerScope.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerScope)}.syntaxStates[{i}]");
            }
            // 30 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] ResolvedScope> : ⏳ Scope ; '￥' 
            // [0] Scope : ⏳ '[' 'firstItem1' RangeItems ']' ; '￥' 
            // [1] Scope : ⏳ '[^' 'firstItem2' RangeItems ']' ; '￥' 
            // [2] Scope : ⏳ '[' 'firstItem1' ']' ; '￥' 
            // [3] Scope : ⏳ '[^' 'firstItem2' ']' ; '￥' 
            list[0].actionDict.Add(EType.Scope, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.@LeftBracket, new LRShiftInAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@LeftBracketCaret, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // syntaxStates[1]:
            // [-1] ResolvedScope> : Scope ⏳ ; '￥' 
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[3]*/
            // syntaxStates[2]:
            // [0] Scope : '[' ⏳ 'firstItem1' RangeItems ']' ; '￥' 
            // [2] Scope : '[' ⏳ 'firstItem1' ']' ; '￥' 
            list[2].actionDict.Add(EType.@firstItem1, new LRShiftInAction(syntaxStates[4]));/*Actions[4]*/
            // syntaxStates[3]:
            // [1] Scope : '[^' ⏳ 'firstItem2' RangeItems ']' ; '￥' 
            // [3] Scope : '[^' ⏳ 'firstItem2' ']' ; '￥' 
            list[3].actionDict.Add(EType.@firstItem2, new LRShiftInAction(syntaxStates[5]));/*Actions[5]*/
            // syntaxStates[4]:
            // [0] Scope : '[' 'firstItem1' ⏳ RangeItems ']' ; '￥' 
            // [2] Scope : '[' 'firstItem1' ⏳ ']' ; '￥' 
            // [4] RangeItems : ⏳ RangeItems RangeItem ; ']' 'char' 
            // [5] RangeItems : ⏳ RangeItem ; ']' 'char' 
            // [6] RangeItem : ⏳ 'char' ; ']' 'char' 
            list[4].actionDict.Add(EType.RangeItems, new LRGotoAction(syntaxStates[6]));/*Actions[6]*/
            list[4].actionDict.Add(EType.@RightBracket, new LRShiftInAction(syntaxStates[7]));/*Actions[7]*/
            list[4].actionDict.Add(EType.RangeItem, new LRGotoAction(syntaxStates[8]));/*Actions[8]*/
            list[4].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[9]));/*Actions[9]*/
            // syntaxStates[5]:
            // [1] Scope : '[^' 'firstItem2' ⏳ RangeItems ']' ; '￥' 
            // [3] Scope : '[^' 'firstItem2' ⏳ ']' ; '￥' 
            // [4] RangeItems : ⏳ RangeItems RangeItem ; ']' 'char' 
            // [5] RangeItems : ⏳ RangeItem ; ']' 'char' 
            // [6] RangeItem : ⏳ 'char' ; ']' 'char' 
            list[5].actionDict.Add(EType.RangeItems, new LRGotoAction(syntaxStates[10]));/*Actions[10]*/
            list[5].actionDict.Add(EType.@RightBracket, new LRShiftInAction(syntaxStates[11]));/*Actions[11]*/
            list[5].actionDict.Add(EType.RangeItem, new LRGotoAction(syntaxStates[8]));/*Actions[12]*/
            list[5].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[9]));/*Actions[13]*/
            // syntaxStates[6]:
            // [0] Scope : '[' 'firstItem1' RangeItems ⏳ ']' ; '￥' 
            // [4] RangeItems : RangeItems ⏳ RangeItem ; ']' 'char' 
            // [6] RangeItem : ⏳ 'char' ; ']' 'char' 
            list[6].actionDict.Add(EType.@RightBracket, new LRShiftInAction(syntaxStates[12]));/*Actions[14]*/
            list[6].actionDict.Add(EType.RangeItem, new LRGotoAction(syntaxStates[13]));/*Actions[15]*/
            list[6].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[9]));/*Actions[16]*/
            // syntaxStates[7]:
            // [2] Scope : '[' 'firstItem1' ']' ⏳ ; '￥' 
            list[7].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[17]*/
            // syntaxStates[8]:
            // [5] RangeItems : RangeItem ⏳ ; ']' 'char' 
            list[8].actionDict.Add(EType.@RightBracket, new LRReducitonAction(regulations[5]));/*Actions[18]*/
            list[8].actionDict.Add(EType.@char, new LRReducitonAction(regulations[5]));/*Actions[19]*/
            // syntaxStates[9]:
            // [6] RangeItem : 'char' ⏳ ; ']' 'char' 
            list[9].actionDict.Add(EType.@RightBracket, new LRReducitonAction(regulations[6]));/*Actions[20]*/
            list[9].actionDict.Add(EType.@char, new LRReducitonAction(regulations[6]));/*Actions[21]*/
            // syntaxStates[10]:
            // [1] Scope : '[^' 'firstItem2' RangeItems ⏳ ']' ; '￥' 
            // [4] RangeItems : RangeItems ⏳ RangeItem ; ']' 'char' 
            // [6] RangeItem : ⏳ 'char' ; ']' 'char' 
            list[10].actionDict.Add(EType.@RightBracket, new LRShiftInAction(syntaxStates[14]));/*Actions[22]*/
            list[10].actionDict.Add(EType.RangeItem, new LRGotoAction(syntaxStates[13]));/*Actions[23]*/
            list[10].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[9]));/*Actions[24]*/
            // syntaxStates[11]:
            // [3] Scope : '[^' 'firstItem2' ']' ⏳ ; '￥' 
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[25]*/
            // syntaxStates[12]:
            // [0] Scope : '[' 'firstItem1' RangeItems ']' ⏳ ; '￥' 
            list[12].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[26]*/
            // syntaxStates[13]:
            // [4] RangeItems : RangeItems RangeItem ⏳ ; ']' 'char' 
            list[13].actionDict.Add(EType.@RightBracket, new LRReducitonAction(regulations[4]));/*Actions[27]*/
            list[13].actionDict.Add(EType.@char, new LRReducitonAction(regulations[4]));/*Actions[28]*/
            // syntaxStates[14]:
            // [1] Scope : '[^' 'firstItem2' RangeItems ']' ⏳ ; '￥' 
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[29]*/

        }
    }
}
