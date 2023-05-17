using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    partial class CompilerCalc {
        const int syntaxStateCount = 30;
        // NOTE: choose only one from CompilerCalc.TableLL(1).cs, CompilerCalc.TableLR(0).cs, CompilerCalc.TableSLR(1).cs, CompilerCalc.TableLALR(1).cs, CompilerCalc.TableLR(1).cs
        /// <summary>
        /// LR(1) syntax parsing table
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
            // 132 actions. 0 conflicts.
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
            // [2] Additive : Multiplicative ⏳ ; '￥' '+' '-' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; '￥' '+' '-' '*' '/' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; '￥' '+' '-' '*' '/' 
            list[2].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[8]));/*Actions[8]*/
            list[2].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[9]));/*Actions[9]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[10]*/
            list[2].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[2]));/*Actions[11]*/
            list[2].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            // syntaxStates[3]:
            // [5] Multiplicative : Primary ⏳ ; '￥' '+' '-' '*' '/' 
            list[3].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[13]*/
            list[3].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[5]));/*Actions[14]*/
            list[3].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[5]));/*Actions[15]*/
            list[3].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[5]));/*Actions[16]*/
            list[3].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[5]));/*Actions[17]*/
            // syntaxStates[4]:
            // [6] Primary : '(' ⏳ Additive ')' ; '￥' '+' '-' '*' '/' 
            // [0] Additive : ⏳ Additive '+' Multiplicative ; ')' '+' '-' 
            // [1] Additive : ⏳ Additive '-' Multiplicative ; ')' '+' '-' 
            // [2] Additive : ⏳ Multiplicative ; ')' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; ')' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[4].actionDict.Add(EType.Additive, new LRGotoAction(syntaxStates[10]));/*Actions[18]*/
            list[4].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[11]));/*Actions[19]*/
            list[4].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[12]));/*Actions[20]*/
            list[4].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[13]));/*Actions[21]*/
            list[4].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[14]));/*Actions[22]*/
            // syntaxStates[5]:
            // [7] Primary : 'number' ⏳ ; '￥' '+' '-' '*' '/' 
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[23]*/
            list[5].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[7]));/*Actions[24]*/
            list[5].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[7]));/*Actions[25]*/
            list[5].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[7]));/*Actions[26]*/
            list[5].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[7]));/*Actions[27]*/
            // syntaxStates[6]:
            // [0] Additive : Additive '+' ⏳ Multiplicative ; '￥' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; '￥' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; '￥' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; '￥' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' 
            list[6].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[15]));/*Actions[28]*/
            list[6].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[3]));/*Actions[29]*/
            list[6].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[30]*/
            list[6].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[31]*/
            // syntaxStates[7]:
            // [1] Additive : Additive '-' ⏳ Multiplicative ; '￥' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; '￥' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; '￥' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; '￥' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' 
            list[7].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[16]));/*Actions[32]*/
            list[7].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[3]));/*Actions[33]*/
            list[7].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[34]*/
            list[7].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[35]*/
            // syntaxStates[8]:
            // [3] Multiplicative : Multiplicative '*' ⏳ Primary ; '￥' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' 
            list[8].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[17]));/*Actions[36]*/
            list[8].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[37]*/
            list[8].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[38]*/
            // syntaxStates[9]:
            // [4] Multiplicative : Multiplicative '/' ⏳ Primary ; '￥' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; '￥' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; '￥' '+' '-' '*' '/' 
            list[9].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[18]));/*Actions[39]*/
            list[9].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[4]));/*Actions[40]*/
            list[9].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[5]));/*Actions[41]*/
            // syntaxStates[10]:
            // [6] Primary : '(' Additive ⏳ ')' ; '￥' '+' '-' '*' '/' 
            // [0] Additive : Additive ⏳ '+' Multiplicative ; ')' '+' '-' 
            // [1] Additive : Additive ⏳ '-' Multiplicative ; ')' '+' '-' 
            list[10].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[19]));/*Actions[42]*/
            list[10].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[20]));/*Actions[43]*/
            list[10].actionDict.Add(EType.@Dash, new LRShiftInAction(syntaxStates[21]));/*Actions[44]*/
            // syntaxStates[11]:
            // [2] Additive : Multiplicative ⏳ ; ')' '+' '-' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; ')' '+' '-' '*' '/' 
            list[11].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[22]));/*Actions[45]*/
            list[11].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[23]));/*Actions[46]*/
            list[11].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[2]));/*Actions[47]*/
            list[11].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[2]));/*Actions[48]*/
            list[11].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[2]));/*Actions[49]*/
            // syntaxStates[12]:
            // [5] Multiplicative : Primary ⏳ ; ')' '+' '-' '*' '/' 
            list[12].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[5]));/*Actions[50]*/
            list[12].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[5]));/*Actions[51]*/
            list[12].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[5]));/*Actions[52]*/
            list[12].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[5]));/*Actions[53]*/
            list[12].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[5]));/*Actions[54]*/
            // syntaxStates[13]:
            // [6] Primary : '(' ⏳ Additive ')' ; ')' '+' '-' '*' '/' 
            // [0] Additive : ⏳ Additive '+' Multiplicative ; ')' '+' '-' 
            // [1] Additive : ⏳ Additive '-' Multiplicative ; ')' '+' '-' 
            // [2] Additive : ⏳ Multiplicative ; ')' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; ')' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[13].actionDict.Add(EType.Additive, new LRGotoAction(syntaxStates[24]));/*Actions[55]*/
            list[13].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[11]));/*Actions[56]*/
            list[13].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[12]));/*Actions[57]*/
            list[13].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[13]));/*Actions[58]*/
            list[13].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[14]));/*Actions[59]*/
            // syntaxStates[14]:
            // [7] Primary : 'number' ⏳ ; ')' '+' '-' '*' '/' 
            list[14].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[7]));/*Actions[60]*/
            list[14].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[7]));/*Actions[61]*/
            list[14].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[7]));/*Actions[62]*/
            list[14].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[7]));/*Actions[63]*/
            list[14].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[7]));/*Actions[64]*/
            // syntaxStates[15]:
            // [0] Additive : Additive '+' Multiplicative ⏳ ; '￥' '+' '-' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; '￥' '+' '-' '*' '/' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; '￥' '+' '-' '*' '/' 
            list[15].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[8]));/*Actions[65]*/
            list[15].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[9]));/*Actions[66]*/
            list[15].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[67]*/
            list[15].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[0]));/*Actions[68]*/
            list[15].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[0]));/*Actions[69]*/
            // syntaxStates[16]:
            // [1] Additive : Additive '-' Multiplicative ⏳ ; '￥' '+' '-' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; '￥' '+' '-' '*' '/' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; '￥' '+' '-' '*' '/' 
            list[16].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[8]));/*Actions[70]*/
            list[16].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[9]));/*Actions[71]*/
            list[16].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[72]*/
            list[16].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[1]));/*Actions[73]*/
            list[16].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[1]));/*Actions[74]*/
            // syntaxStates[17]:
            // [3] Multiplicative : Multiplicative '*' Primary ⏳ ; '￥' '+' '-' '*' '/' 
            list[17].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[75]*/
            list[17].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[3]));/*Actions[76]*/
            list[17].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[3]));/*Actions[77]*/
            list[17].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[3]));/*Actions[78]*/
            list[17].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[3]));/*Actions[79]*/
            // syntaxStates[18]:
            // [4] Multiplicative : Multiplicative '/' Primary ⏳ ; '￥' '+' '-' '*' '/' 
            list[18].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[80]*/
            list[18].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[4]));/*Actions[81]*/
            list[18].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[4]));/*Actions[82]*/
            list[18].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[4]));/*Actions[83]*/
            list[18].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[4]));/*Actions[84]*/
            // syntaxStates[19]:
            // [6] Primary : '(' Additive ')' ⏳ ; '￥' '+' '-' '*' '/' 
            list[19].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[85]*/
            list[19].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[6]));/*Actions[86]*/
            list[19].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[6]));/*Actions[87]*/
            list[19].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[6]));/*Actions[88]*/
            list[19].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[6]));/*Actions[89]*/
            // syntaxStates[20]:
            // [0] Additive : Additive '+' ⏳ Multiplicative ; ')' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; ')' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[20].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[25]));/*Actions[90]*/
            list[20].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[12]));/*Actions[91]*/
            list[20].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[13]));/*Actions[92]*/
            list[20].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[14]));/*Actions[93]*/
            // syntaxStates[21]:
            // [1] Additive : Additive '-' ⏳ Multiplicative ; ')' '+' '-' 
            // [3] Multiplicative : ⏳ Multiplicative '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : ⏳ Multiplicative '/' Primary ; ')' '+' '-' '*' '/' 
            // [5] Multiplicative : ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[21].actionDict.Add(EType.Multiplicative, new LRGotoAction(syntaxStates[26]));/*Actions[94]*/
            list[21].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[12]));/*Actions[95]*/
            list[21].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[13]));/*Actions[96]*/
            list[21].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[14]));/*Actions[97]*/
            // syntaxStates[22]:
            // [3] Multiplicative : Multiplicative '*' ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[22].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[27]));/*Actions[98]*/
            list[22].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[13]));/*Actions[99]*/
            list[22].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[14]));/*Actions[100]*/
            // syntaxStates[23]:
            // [4] Multiplicative : Multiplicative '/' ⏳ Primary ; ')' '+' '-' '*' '/' 
            // [6] Primary : ⏳ '(' Additive ')' ; ')' '+' '-' '*' '/' 
            // [7] Primary : ⏳ 'number' ; ')' '+' '-' '*' '/' 
            list[23].actionDict.Add(EType.Primary, new LRGotoAction(syntaxStates[28]));/*Actions[101]*/
            list[23].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[13]));/*Actions[102]*/
            list[23].actionDict.Add(EType.@number, new LRShiftInAction(syntaxStates[14]));/*Actions[103]*/
            // syntaxStates[24]:
            // [6] Primary : '(' Additive ⏳ ')' ; ')' '+' '-' '*' '/' 
            // [0] Additive : Additive ⏳ '+' Multiplicative ; ')' '+' '-' 
            // [1] Additive : Additive ⏳ '-' Multiplicative ; ')' '+' '-' 
            list[24].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[29]));/*Actions[104]*/
            list[24].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[20]));/*Actions[105]*/
            list[24].actionDict.Add(EType.@Dash, new LRShiftInAction(syntaxStates[21]));/*Actions[106]*/
            // syntaxStates[25]:
            // [0] Additive : Additive '+' Multiplicative ⏳ ; ')' '+' '-' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; ')' '+' '-' '*' '/' 
            list[25].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[22]));/*Actions[107]*/
            list[25].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[23]));/*Actions[108]*/
            list[25].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[0]));/*Actions[109]*/
            list[25].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[0]));/*Actions[110]*/
            list[25].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[0]));/*Actions[111]*/
            // syntaxStates[26]:
            // [1] Additive : Additive '-' Multiplicative ⏳ ; ')' '+' '-' 
            // [3] Multiplicative : Multiplicative ⏳ '*' Primary ; ')' '+' '-' '*' '/' 
            // [4] Multiplicative : Multiplicative ⏳ '/' Primary ; ')' '+' '-' '*' '/' 
            list[26].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[22]));/*Actions[112]*/
            list[26].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[23]));/*Actions[113]*/
            list[26].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[1]));/*Actions[114]*/
            list[26].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[1]));/*Actions[115]*/
            list[26].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[1]));/*Actions[116]*/
            // syntaxStates[27]:
            // [3] Multiplicative : Multiplicative '*' Primary ⏳ ; ')' '+' '-' '*' '/' 
            list[27].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[3]));/*Actions[117]*/
            list[27].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[3]));/*Actions[118]*/
            list[27].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[3]));/*Actions[119]*/
            list[27].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[3]));/*Actions[120]*/
            list[27].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[3]));/*Actions[121]*/
            // syntaxStates[28]:
            // [4] Multiplicative : Multiplicative '/' Primary ⏳ ; ')' '+' '-' '*' '/' 
            list[28].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[4]));/*Actions[122]*/
            list[28].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[4]));/*Actions[123]*/
            list[28].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[4]));/*Actions[124]*/
            list[28].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[4]));/*Actions[125]*/
            list[28].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[4]));/*Actions[126]*/
            // syntaxStates[29]:
            // [6] Primary : '(' Additive ')' ⏳ ; ')' '+' '-' '*' '/' 
            list[29].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[6]));/*Actions[127]*/
            list[29].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[6]));/*Actions[128]*/
            list[29].actionDict.Add(EType.@Dash, new LRReducitonAction(regulations[6]));/*Actions[129]*/
            list[29].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[6]));/*Actions[130]*/
            list[29].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[6]));/*Actions[131]*/

        }
    }
}
