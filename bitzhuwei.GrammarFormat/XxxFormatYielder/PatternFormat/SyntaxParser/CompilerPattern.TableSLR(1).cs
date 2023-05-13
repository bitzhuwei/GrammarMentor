using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        const int syntaxStateCount = 32;
        // NOTE: choose only one from CompilerPattern.TableLL(1).cs, CompilerPattern.TableLR(0).cs, CompilerPattern.TableSLR(1).cs, CompilerPattern.TableLALR(1).cs, CompilerPattern.TableLR(1).cs
        /// <summary>
        /// SLR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerPattern.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerPattern)}.syntaxStates[{i}]");
            }
            // 188 actions. 0 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.Pattern, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.PreRegex, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.refVt, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.char_, new LRReducitonAction(regulations[2]));/*Actions[3]*/
            list[0].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[2]));/*Actions[4]*/
            list[0].actionDict.Add(EType.scope, new LRReducitonAction(regulations[2]));/*Actions[5]*/
            list[0].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[2]));/*Actions[6]*/
            // list[1]
            list[1].actionDict.Add(EType.EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[7]*/
            // list[2]
            list[2].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[4]));/*Actions[8]*/
            list[2].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[9]*/
            list[2].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[10]*/
            list[2].actionDict.Add(EType.char_, new LRShiftInAction(syntaxStates[7]));/*Actions[11]*/
            list[2].actionDict.Add(EType.Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[12]*/
            list[2].actionDict.Add(EType.scope, new LRShiftInAction(syntaxStates[9]));/*Actions[13]*/
            list[2].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[14]*/
            // list[3]
            list[3].actionDict.Add(EType.char_, new LRReducitonAction(regulations[1]));/*Actions[15]*/
            list[3].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[1]));/*Actions[16]*/
            list[3].actionDict.Add(EType.scope, new LRReducitonAction(regulations[1]));/*Actions[17]*/
            list[3].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[1]));/*Actions[18]*/
            // list[4]
            list[4].actionDict.Add(EType.PostRegex, new LRGotoAction(syntaxStates[11]));/*Actions[19]*/
            list[4].actionDict.Add(EType.Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[20]*/
            list[4].actionDict.Add(EType.Slash, new LRShiftInAction(syntaxStates[13]));/*Actions[21]*/
            // list[5]
            list[5].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[22]*/
            list[5].actionDict.Add(EType.char_, new LRShiftInAction(syntaxStates[7]));/*Actions[23]*/
            list[5].actionDict.Add(EType.Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[24]*/
            list[5].actionDict.Add(EType.scope, new LRShiftInAction(syntaxStates[9]));/*Actions[25]*/
            list[5].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[26]*/
            list[5].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[6]));/*Actions[27]*/
            list[5].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[6]));/*Actions[28]*/
            list[5].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[6]));/*Actions[29]*/
            // list[6]
            list[6].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[8]));/*Actions[30]*/
            list[6].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[8]));/*Actions[31]*/
            list[6].actionDict.Add(EType.char_, new LRReducitonAction(regulations[8]));/*Actions[32]*/
            list[6].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[8]));/*Actions[33]*/
            list[6].actionDict.Add(EType.scope, new LRReducitonAction(regulations[8]));/*Actions[34]*/
            list[6].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[35]*/
            list[6].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[8]));/*Actions[36]*/
            // list[7]
            list[7].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[15]));/*Actions[37]*/
            list[7].actionDict.Add(EType.Question, new LRShiftInAction(syntaxStates[16]));/*Actions[38]*/
            list[7].actionDict.Add(EType.Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[39]*/
            list[7].actionDict.Add(EType.Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[40]*/
            list[7].actionDict.Add(EType.LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[41]*/
            list[7].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[17]));/*Actions[42]*/
            list[7].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[17]));/*Actions[43]*/
            list[7].actionDict.Add(EType.char_, new LRReducitonAction(regulations[17]));/*Actions[44]*/
            list[7].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[17]));/*Actions[45]*/
            list[7].actionDict.Add(EType.scope, new LRReducitonAction(regulations[17]));/*Actions[46]*/
            list[7].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[47]*/
            list[7].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[48]*/
            // list[8]
            list[8].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[20]));/*Actions[49]*/
            list[8].actionDict.Add(EType.Question, new LRShiftInAction(syntaxStates[16]));/*Actions[50]*/
            list[8].actionDict.Add(EType.Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[51]*/
            list[8].actionDict.Add(EType.Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[52]*/
            list[8].actionDict.Add(EType.LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[53]*/
            list[8].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[17]));/*Actions[54]*/
            list[8].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[17]));/*Actions[55]*/
            list[8].actionDict.Add(EType.char_, new LRReducitonAction(regulations[17]));/*Actions[56]*/
            list[8].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[17]));/*Actions[57]*/
            list[8].actionDict.Add(EType.scope, new LRReducitonAction(regulations[17]));/*Actions[58]*/
            list[8].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[59]*/
            list[8].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[60]*/
            // list[9]
            list[9].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[21]));/*Actions[61]*/
            list[9].actionDict.Add(EType.Question, new LRShiftInAction(syntaxStates[16]));/*Actions[62]*/
            list[9].actionDict.Add(EType.Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[63]*/
            list[9].actionDict.Add(EType.Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[64]*/
            list[9].actionDict.Add(EType.LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[65]*/
            list[9].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[17]));/*Actions[66]*/
            list[9].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[17]));/*Actions[67]*/
            list[9].actionDict.Add(EType.char_, new LRReducitonAction(regulations[17]));/*Actions[68]*/
            list[9].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[17]));/*Actions[69]*/
            list[9].actionDict.Add(EType.scope, new LRReducitonAction(regulations[17]));/*Actions[70]*/
            list[9].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[71]*/
            list[9].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[72]*/
            // list[10]
            list[10].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[22]));/*Actions[73]*/
            list[10].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[74]*/
            list[10].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[75]*/
            list[10].actionDict.Add(EType.char_, new LRShiftInAction(syntaxStates[7]));/*Actions[76]*/
            list[10].actionDict.Add(EType.Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[77]*/
            list[10].actionDict.Add(EType.scope, new LRShiftInAction(syntaxStates[9]));/*Actions[78]*/
            list[10].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[79]*/
            // list[11]
            list[11].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[80]*/
            // list[12]
            list[12].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[23]));/*Actions[81]*/
            list[12].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[82]*/
            list[12].actionDict.Add(EType.char_, new LRShiftInAction(syntaxStates[7]));/*Actions[83]*/
            list[12].actionDict.Add(EType.Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[84]*/
            list[12].actionDict.Add(EType.scope, new LRShiftInAction(syntaxStates[9]));/*Actions[85]*/
            list[12].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[86]*/
            // list[13]
            list[13].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[24]));/*Actions[87]*/
            list[13].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[88]*/
            list[13].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[89]*/
            list[13].actionDict.Add(EType.char_, new LRShiftInAction(syntaxStates[7]));/*Actions[90]*/
            list[13].actionDict.Add(EType.Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[91]*/
            list[13].actionDict.Add(EType.scope, new LRShiftInAction(syntaxStates[9]));/*Actions[92]*/
            list[13].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[93]*/
            // list[14]
            list[14].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[7]));/*Actions[94]*/
            list[14].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[7]));/*Actions[95]*/
            list[14].actionDict.Add(EType.char_, new LRReducitonAction(regulations[7]));/*Actions[96]*/
            list[14].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[7]));/*Actions[97]*/
            list[14].actionDict.Add(EType.scope, new LRReducitonAction(regulations[7]));/*Actions[98]*/
            list[14].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[99]*/
            list[14].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[7]));/*Actions[100]*/
            // list[15]
            list[15].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[9]));/*Actions[101]*/
            list[15].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[9]));/*Actions[102]*/
            list[15].actionDict.Add(EType.char_, new LRReducitonAction(regulations[9]));/*Actions[103]*/
            list[15].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[9]));/*Actions[104]*/
            list[15].actionDict.Add(EType.scope, new LRReducitonAction(regulations[9]));/*Actions[105]*/
            list[15].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[106]*/
            list[15].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[9]));/*Actions[107]*/
            // list[16]
            list[16].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[13]));/*Actions[108]*/
            list[16].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[13]));/*Actions[109]*/
            list[16].actionDict.Add(EType.char_, new LRReducitonAction(regulations[13]));/*Actions[110]*/
            list[16].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[13]));/*Actions[111]*/
            list[16].actionDict.Add(EType.scope, new LRReducitonAction(regulations[13]));/*Actions[112]*/
            list[16].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[13]));/*Actions[113]*/
            list[16].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[13]));/*Actions[114]*/
            // list[17]
            list[17].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[14]));/*Actions[115]*/
            list[17].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[14]));/*Actions[116]*/
            list[17].actionDict.Add(EType.char_, new LRReducitonAction(regulations[14]));/*Actions[117]*/
            list[17].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[14]));/*Actions[118]*/
            list[17].actionDict.Add(EType.scope, new LRReducitonAction(regulations[14]));/*Actions[119]*/
            list[17].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[14]));/*Actions[120]*/
            list[17].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[14]));/*Actions[121]*/
            // list[18]
            list[18].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[15]));/*Actions[122]*/
            list[18].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[15]));/*Actions[123]*/
            list[18].actionDict.Add(EType.char_, new LRReducitonAction(regulations[15]));/*Actions[124]*/
            list[18].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[15]));/*Actions[125]*/
            list[18].actionDict.Add(EType.scope, new LRReducitonAction(regulations[15]));/*Actions[126]*/
            list[18].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[15]));/*Actions[127]*/
            list[18].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[15]));/*Actions[128]*/
            // list[19]
            list[19].actionDict.Add(EType.min, new LRShiftInAction(syntaxStates[25]));/*Actions[129]*/
            // list[20]
            list[20].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[10]));/*Actions[130]*/
            list[20].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[10]));/*Actions[131]*/
            list[20].actionDict.Add(EType.char_, new LRReducitonAction(regulations[10]));/*Actions[132]*/
            list[20].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[10]));/*Actions[133]*/
            list[20].actionDict.Add(EType.scope, new LRReducitonAction(regulations[10]));/*Actions[134]*/
            list[20].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[10]));/*Actions[135]*/
            list[20].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[10]));/*Actions[136]*/
            // list[21]
            list[21].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[11]));/*Actions[137]*/
            list[21].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[11]));/*Actions[138]*/
            list[21].actionDict.Add(EType.char_, new LRReducitonAction(regulations[11]));/*Actions[139]*/
            list[21].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[11]));/*Actions[140]*/
            list[21].actionDict.Add(EType.scope, new LRReducitonAction(regulations[11]));/*Actions[141]*/
            list[21].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[11]));/*Actions[142]*/
            list[21].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[11]));/*Actions[143]*/
            // list[22]
            list[22].actionDict.Add(EType.RightParenthesis, new LRShiftInAction(syntaxStates[26]));/*Actions[144]*/
            list[22].actionDict.Add(EType.Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[145]*/
            // list[23]
            list[23].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[146]*/
            list[23].actionDict.Add(EType.char_, new LRShiftInAction(syntaxStates[7]));/*Actions[147]*/
            list[23].actionDict.Add(EType.Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[148]*/
            list[23].actionDict.Add(EType.scope, new LRShiftInAction(syntaxStates[9]));/*Actions[149]*/
            list[23].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[150]*/
            list[23].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[5]));/*Actions[151]*/
            list[23].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[5]));/*Actions[152]*/
            list[23].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[5]));/*Actions[153]*/
            // list[24]
            list[24].actionDict.Add(EType.Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[154]*/
            // list[25]
            list[25].actionDict.Add(EType.UpperBound, new LRGotoAction(syntaxStates[27]));/*Actions[155]*/
            list[25].actionDict.Add(EType.Comma, new LRShiftInAction(syntaxStates[28]));/*Actions[156]*/
            list[25].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[20]));/*Actions[157]*/
            // list[26]
            list[26].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[29]));/*Actions[158]*/
            list[26].actionDict.Add(EType.Question, new LRShiftInAction(syntaxStates[16]));/*Actions[159]*/
            list[26].actionDict.Add(EType.Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[160]*/
            list[26].actionDict.Add(EType.Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[161]*/
            list[26].actionDict.Add(EType.LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[162]*/
            list[26].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[17]));/*Actions[163]*/
            list[26].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[17]));/*Actions[164]*/
            list[26].actionDict.Add(EType.char_, new LRReducitonAction(regulations[17]));/*Actions[165]*/
            list[26].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[17]));/*Actions[166]*/
            list[26].actionDict.Add(EType.scope, new LRReducitonAction(regulations[17]));/*Actions[167]*/
            list[26].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[168]*/
            list[26].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[169]*/
            // list[27]
            list[27].actionDict.Add(EType.RightBrace, new LRShiftInAction(syntaxStates[30]));/*Actions[170]*/
            // list[28]
            list[28].actionDict.Add(EType.max, new LRShiftInAction(syntaxStates[31]));/*Actions[171]*/
            list[28].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[19]));/*Actions[172]*/
            // list[29]
            list[29].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[12]));/*Actions[173]*/
            list[29].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[12]));/*Actions[174]*/
            list[29].actionDict.Add(EType.char_, new LRReducitonAction(regulations[12]));/*Actions[175]*/
            list[29].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[12]));/*Actions[176]*/
            list[29].actionDict.Add(EType.scope, new LRReducitonAction(regulations[12]));/*Actions[177]*/
            list[29].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[12]));/*Actions[178]*/
            list[29].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[12]));/*Actions[179]*/
            // list[30]
            list[30].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[16]));/*Actions[180]*/
            list[30].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[16]));/*Actions[181]*/
            list[30].actionDict.Add(EType.char_, new LRReducitonAction(regulations[16]));/*Actions[182]*/
            list[30].actionDict.Add(EType.Dot, new LRReducitonAction(regulations[16]));/*Actions[183]*/
            list[30].actionDict.Add(EType.scope, new LRReducitonAction(regulations[16]));/*Actions[184]*/
            list[30].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[16]));/*Actions[185]*/
            list[30].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[16]));/*Actions[186]*/
            // list[31]
            list[31].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[18]));/*Actions[187]*/

        }
    }
}
