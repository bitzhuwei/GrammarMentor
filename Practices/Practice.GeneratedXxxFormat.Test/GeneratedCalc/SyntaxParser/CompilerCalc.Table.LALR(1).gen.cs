using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    partial class CompilerCalc {
        const int syntaxStateCount = 16;
        // NOTE: choose only one from CompilerCalc.TableLL(1).cs, CompilerCalc.TableLR(0).cs, CompilerCalc.TableSLR(1).cs, CompilerCalc.TableLALR(1).cs, CompilerCalc.TableLR(1).cs
        /// <summary>
        /// LALR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerCalc.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerCalc.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerCalc)}.syntaxStates[{i}]");
            }
            // 78 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] FinalValue> : ⏳ Additive ; '￥' 
            // [0] Additive : ⏳ Additive '+' Multiplicative ; '￥' '+' '-' 
            // [1] Additive : ⏳ Additive '-' Multiplicative ; '￥' '+' '-' 
            // [2] Additive : ⏳ Multiplicative ; '￥' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; '￥' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; '￥' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; '￥' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' 
            list[0].actionDict.Add(EType.Additive, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[4]*/
            // syntaxStates[1]:
            // [-1] FinalValue> : Additive ⏳ ; '￥' 
            // [0] Additive : Additive ⏳ '+' Multiplicative ; '￥' '+' '-' 
            // [1] Additive : Additive ⏳ '-' Multiplicative ; '￥' '+' '-' 
            list[1].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[6]));/*Actions[5]*/
            list[1].actionDict.Add(EType.@Dash, new LRShiftInAction(syntaxStates[7]));/*Actions[6]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[7]*/
            // syntaxStates[2]:
            // [2] Additive : Multiplicative ⏳ ; '￥' '+' '-' ')' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; '￥' '+' '-' '*' '/' ')' 
            list[2].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[8]));/*Actions[8]*/
            list[2].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[9]));/*Actions[9]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[10]*/
            list[2].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[2]));/*Actions[11]*/
            list[2].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[2].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[2]));/*Actions[13]*/
            // syntaxStates[3]:
            // [5] Multiplicative : Primary ⏳ ; '￥' '+' '-' '*' '/' ')' 
            list[3].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[14]*/
            list[3].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[5]));/*Actions[15]*/
            list[3].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[5]));/*Actions[16]*/
            list[3].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[5]));/*Actions[17]*/
            list[3].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[5]));/*Actions[18]*/
            list[3].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[5]));/*Actions[19]*/
            // syntaxStates[4]:
            // [6] Primary : '(' ⏳ Additive ')' ; '￥' '+' '-' '*' '/' ')' 
            // [0] Additive : ⏳ Additive '+' Multiplicative ; ')' '+' '-' 
            // [1] Additive : ⏳ Additive '-' Multiplicative ; ')' '+' '-' 
            // [2] Additive : ⏳ Multiplicative ; ')' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; ')' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[4].actionDict.Add(EType.Additive, new LRGotoAction(syntaxStates[10]));/*Actions[20]*/
            list[4].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[2]));/*Actions[21]*/
            list[4].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[3]));/*Actions[22]*/
            list[4].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[23]*/
            list[4].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[24]*/
            // syntaxStates[5]:
            // [7] Primary : 'number' ⏳ ; '￥' '+' '-' '*' '/' ')' 
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[25]*/
            list[5].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[7]));/*Actions[26]*/
            list[5].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[7]));/*Actions[27]*/
            list[5].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[7]));/*Actions[28]*/
            list[5].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[7]));/*Actions[29]*/
            list[5].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[7]));/*Actions[30]*/
            // syntaxStates[6]:
            // [0] Additive : Additive '+' ⏳ Multiplicative ; '￥' '+' '-' ')' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [5] Multiplicative : ⏳ Primary ; '￥' '+' '-' '*' '/' ')' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' ')' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' ')' 
            list[6].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[11]));/*Actions[31]*/
            list[6].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[3]));/*Actions[32]*/
            list[6].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[33]*/
            list[6].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[34]*/
            // syntaxStates[7]:
            // [1] Additive : Additive '-' ⏳ Multiplicative ; '￥' '+' '-' ')' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [5] Multiplicative : ⏳ Primary ; '￥' '+' '-' '*' '/' ')' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' ')' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' ')' 
            list[7].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[12]));/*Actions[35]*/
            list[7].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[3]));/*Actions[36]*/
            list[7].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[37]*/
            list[7].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[38]*/
            // syntaxStates[8]:
            // [3] Multiplicative : Multiplicative '*' ⏳ Primary ; '￥' '+' '-' '*' '/' ')' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' ')' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' ')' 
            list[8].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[13]));/*Actions[39]*/
            list[8].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[40]*/
            list[8].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[41]*/
            // syntaxStates[9]:
            // [4] Multiplicative : Multiplicative '/' ⏳ Primary ; '￥' '+' '-' '*' '/' ')' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' ')' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' ')' 
            list[9].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[14]));/*Actions[42]*/
            list[9].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[43]*/
            list[9].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[44]*/
            // syntaxStates[10]:
            // [6] Primary : '(' Additive ⏳ ')' ; '￥' '+' '-' '*' '/' ')' 
            // [0] Additive : Additive ⏳ '+' Multiplicative ; ')' '+' '-' 
            // [1] Additive : Additive ⏳ '-' Multiplicative ; ')' '+' '-' 
            list[10].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[15]));/*Actions[45]*/
            list[10].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[6]));/*Actions[46]*/
            list[10].actionDict.Add(EType.@Dash, new LRShiftInAction(syntaxStates[7]));/*Actions[47]*/
            // syntaxStates[11]:
            // [0] Additive : Additive '+' Multiplicative ⏳ ; '￥' '+' '-' ')' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; '￥' '+' '-' '*' '/' ')' 
            list[11].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[8]));/*Actions[48]*/
            list[11].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[9]));/*Actions[49]*/
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[50]*/
            list[11].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[0]));/*Actions[51]*/
            list[11].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[0]));/*Actions[52]*/
            list[11].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[0]));/*Actions[53]*/
            // syntaxStates[12]:
            // [1] Additive : Additive '-' Multiplicative ⏳ ; '￥' '+' '-' ')' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; '￥' '+' '-' '*' '/' ')' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; '￥' '+' '-' '*' '/' ')' 
            list[12].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[8]));/*Actions[54]*/
            list[12].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[9]));/*Actions[55]*/
            list[12].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[56]*/
            list[12].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[1]));/*Actions[57]*/
            list[12].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[1]));/*Actions[58]*/
            list[12].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[1]));/*Actions[59]*/
            // syntaxStates[13]:
            // [3] Multiplicative : Multiplicative '*' Primary ⏳ ; '￥' '+' '-' '*' '/' ')' 
            list[13].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[60]*/
            list[13].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[3]));/*Actions[61]*/
            list[13].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[3]));/*Actions[62]*/
            list[13].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[3]));/*Actions[63]*/
            list[13].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[3]));/*Actions[64]*/
            list[13].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[3]));/*Actions[65]*/
            // syntaxStates[14]:
            // [4] Multiplicative : Multiplicative '/' Primary ⏳ ; '￥' '+' '-' '*' '/' ')' 
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[66]*/
            list[14].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[4]));/*Actions[67]*/
            list[14].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[4]));/*Actions[68]*/
            list[14].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[4]));/*Actions[69]*/
            list[14].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[4]));/*Actions[70]*/
            list[14].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[4]));/*Actions[71]*/
            // syntaxStates[15]:
            // [6] Primary : '(' Additive ')' ⏳ ; '￥' '+' '-' '*' '/' ')' 
            list[15].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[72]*/
            list[15].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[6]));/*Actions[73]*/
            list[15].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[6]));/*Actions[74]*/
            list[15].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[6]));/*Actions[75]*/
            list[15].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[6]));/*Actions[76]*/
            list[15].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[6]));/*Actions[77]*/

        }
    }
}
