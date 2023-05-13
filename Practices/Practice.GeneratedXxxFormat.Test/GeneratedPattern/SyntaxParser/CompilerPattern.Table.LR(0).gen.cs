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
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerPattern.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerPattern.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerPattern)}.syntaxStates[{i}]");
            }
            // 480 actions. 30 conflicts.
            // list[0]
            //@refVt repeated 2 times
            list[0].actionDict.Add(EType.Pattern, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.PreRegex, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@refVt, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[2]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[2]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[2]));/*Actions[5]*/
            list[0].actionDict.Add(EType.@char, new LRReducitonAction(regulations[2]));/*Actions[6]*/
            list[0].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[2]));/*Actions[7]*/
            list[0].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[2]));/*Actions[8]*/
            list[0].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[2]));/*Actions[9]*/
            list[0].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[2]));/*Actions[10]*/
            list[0].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[2]));/*Actions[11]*/
            list[0].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[0].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[2]));/*Actions[13]*/
            list[0].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[2]));/*Actions[14]*/
            list[0].actionDict.Add(EType.@min, new LRReducitonAction(regulations[2]));/*Actions[15]*/
            list[0].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[2]));/*Actions[16]*/
            list[0].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[2]));/*Actions[17]*/
            list[0].actionDict.Add(EType.@max, new LRReducitonAction(regulations[2]));/*Actions[18]*/
            list[0].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[19]*/
            // list[1]
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[20]*/
            // list[2]
            list[2].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[4]));/*Actions[21]*/
            list[2].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[22]*/
            list[2].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[23]*/
            list[2].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[24]*/
            list[2].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[25]*/
            list[2].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[26]*/
            list[2].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[27]*/
            // list[3]
            list[3].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[1]));/*Actions[28]*/
            list[3].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[1]));/*Actions[29]*/
            list[3].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[1]));/*Actions[30]*/
            list[3].actionDict.Add(EType.@char, new LRReducitonAction(regulations[1]));/*Actions[31]*/
            list[3].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[1]));/*Actions[32]*/
            list[3].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[1]));/*Actions[33]*/
            list[3].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[1]));/*Actions[34]*/
            list[3].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[1]));/*Actions[35]*/
            list[3].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[1]));/*Actions[36]*/
            list[3].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[1]));/*Actions[37]*/
            list[3].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[1]));/*Actions[38]*/
            list[3].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[1]));/*Actions[39]*/
            list[3].actionDict.Add(EType.@min, new LRReducitonAction(regulations[1]));/*Actions[40]*/
            list[3].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[1]));/*Actions[41]*/
            list[3].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[1]));/*Actions[42]*/
            list[3].actionDict.Add(EType.@max, new LRReducitonAction(regulations[1]));/*Actions[43]*/
            list[3].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[44]*/
            // list[4]
            //@Pipe repeated 2 times
            //@Slash repeated 2 times
            list[4].actionDict.Add(EType.PostRegex, new LRGotoAction(syntaxStates[11]));/*Actions[45]*/
            list[4].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[46]*/
            list[4].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[4]));/*Actions[47]*/
            list[4].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[13]));/*Actions[48]*/
            list[4].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[4]));/*Actions[49]*/
            list[4].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[4]));/*Actions[50]*/
            list[4].actionDict.Add(EType.@char, new LRReducitonAction(regulations[4]));/*Actions[51]*/
            list[4].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[4]));/*Actions[52]*/
            list[4].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[4]));/*Actions[53]*/
            list[4].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[4]));/*Actions[54]*/
            list[4].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[4]));/*Actions[55]*/
            list[4].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[4]));/*Actions[56]*/
            list[4].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[4]));/*Actions[57]*/
            list[4].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[4]));/*Actions[58]*/
            list[4].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[4]));/*Actions[59]*/
            list[4].actionDict.Add(EType.@min, new LRReducitonAction(regulations[4]));/*Actions[60]*/
            list[4].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[4]));/*Actions[61]*/
            list[4].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[4]));/*Actions[62]*/
            list[4].actionDict.Add(EType.@max, new LRReducitonAction(regulations[4]));/*Actions[63]*/
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[64]*/
            // list[5]
            //@char repeated 2 times
            //@Dot repeated 2 times
            //@scope repeated 2 times
            //@LeftParenthesis repeated 2 times
            list[5].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[65]*/
            list[5].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[66]*/
            list[5].actionDict.Add(EType.@char, new LRReducitonAction(regulations[6]));/*Actions[67]*/
            list[5].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[68]*/
            list[5].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[6]));/*Actions[69]*/
            list[5].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[70]*/
            list[5].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[6]));/*Actions[71]*/
            list[5].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[72]*/
            list[5].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[6]));/*Actions[73]*/
            list[5].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[6]));/*Actions[74]*/
            list[5].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[6]));/*Actions[75]*/
            list[5].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[76]*/
            list[5].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[6]));/*Actions[77]*/
            list[5].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[6]));/*Actions[78]*/
            list[5].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[6]));/*Actions[79]*/
            list[5].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[6]));/*Actions[80]*/
            list[5].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[6]));/*Actions[81]*/
            list[5].actionDict.Add(EType.@min, new LRReducitonAction(regulations[6]));/*Actions[82]*/
            list[5].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[6]));/*Actions[83]*/
            list[5].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[6]));/*Actions[84]*/
            list[5].actionDict.Add(EType.@max, new LRReducitonAction(regulations[6]));/*Actions[85]*/
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[86]*/
            // list[6]
            list[6].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[8]));/*Actions[87]*/
            list[6].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[8]));/*Actions[88]*/
            list[6].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[89]*/
            list[6].actionDict.Add(EType.@char, new LRReducitonAction(regulations[8]));/*Actions[90]*/
            list[6].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[8]));/*Actions[91]*/
            list[6].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[8]));/*Actions[92]*/
            list[6].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[93]*/
            list[6].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[8]));/*Actions[94]*/
            list[6].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[8]));/*Actions[95]*/
            list[6].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[8]));/*Actions[96]*/
            list[6].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[8]));/*Actions[97]*/
            list[6].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[8]));/*Actions[98]*/
            list[6].actionDict.Add(EType.@min, new LRReducitonAction(regulations[8]));/*Actions[99]*/
            list[6].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[8]));/*Actions[100]*/
            list[6].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[8]));/*Actions[101]*/
            list[6].actionDict.Add(EType.@max, new LRReducitonAction(regulations[8]));/*Actions[102]*/
            list[6].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[8]));/*Actions[103]*/
            // list[7]
            //@Question repeated 2 times
            //@Plus repeated 2 times
            //@Asterisk repeated 2 times
            //@LeftBrace repeated 2 times
            list[7].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[15]));/*Actions[104]*/
            list[7].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[105]*/
            list[7].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[17]));/*Actions[106]*/
            list[7].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[107]*/
            list[7].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[17]));/*Actions[108]*/
            list[7].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[109]*/
            list[7].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[17]));/*Actions[110]*/
            list[7].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[111]*/
            list[7].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[17]));/*Actions[112]*/
            list[7].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[17]));/*Actions[113]*/
            list[7].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[114]*/
            list[7].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[115]*/
            list[7].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[116]*/
            list[7].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[117]*/
            list[7].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[118]*/
            list[7].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[119]*/
            list[7].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[120]*/
            list[7].actionDict.Add(EType.@min, new LRReducitonAction(regulations[17]));/*Actions[121]*/
            list[7].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[17]));/*Actions[122]*/
            list[7].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[17]));/*Actions[123]*/
            list[7].actionDict.Add(EType.@max, new LRReducitonAction(regulations[17]));/*Actions[124]*/
            list[7].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[125]*/
            // list[8]
            //@Question repeated 2 times
            //@Plus repeated 2 times
            //@Asterisk repeated 2 times
            //@LeftBrace repeated 2 times
            list[8].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[20]));/*Actions[126]*/
            list[8].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[127]*/
            list[8].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[17]));/*Actions[128]*/
            list[8].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[129]*/
            list[8].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[17]));/*Actions[130]*/
            list[8].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[131]*/
            list[8].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[17]));/*Actions[132]*/
            list[8].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[133]*/
            list[8].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[17]));/*Actions[134]*/
            list[8].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[17]));/*Actions[135]*/
            list[8].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[136]*/
            list[8].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[137]*/
            list[8].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[138]*/
            list[8].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[139]*/
            list[8].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[140]*/
            list[8].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[141]*/
            list[8].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[142]*/
            list[8].actionDict.Add(EType.@min, new LRReducitonAction(regulations[17]));/*Actions[143]*/
            list[8].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[17]));/*Actions[144]*/
            list[8].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[17]));/*Actions[145]*/
            list[8].actionDict.Add(EType.@max, new LRReducitonAction(regulations[17]));/*Actions[146]*/
            list[8].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[147]*/
            // list[9]
            //@Question repeated 2 times
            //@Plus repeated 2 times
            //@Asterisk repeated 2 times
            //@LeftBrace repeated 2 times
            list[9].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[21]));/*Actions[148]*/
            list[9].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[149]*/
            list[9].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[17]));/*Actions[150]*/
            list[9].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[151]*/
            list[9].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[17]));/*Actions[152]*/
            list[9].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[153]*/
            list[9].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[17]));/*Actions[154]*/
            list[9].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[155]*/
            list[9].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[17]));/*Actions[156]*/
            list[9].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[17]));/*Actions[157]*/
            list[9].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[158]*/
            list[9].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[159]*/
            list[9].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[160]*/
            list[9].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[161]*/
            list[9].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[162]*/
            list[9].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[163]*/
            list[9].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[164]*/
            list[9].actionDict.Add(EType.@min, new LRReducitonAction(regulations[17]));/*Actions[165]*/
            list[9].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[17]));/*Actions[166]*/
            list[9].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[17]));/*Actions[167]*/
            list[9].actionDict.Add(EType.@max, new LRReducitonAction(regulations[17]));/*Actions[168]*/
            list[9].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[169]*/
            // list[10]
            list[10].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[22]));/*Actions[170]*/
            list[10].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[171]*/
            list[10].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[172]*/
            list[10].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[173]*/
            list[10].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[174]*/
            list[10].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[175]*/
            list[10].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[176]*/
            // list[11]
            list[11].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[0]));/*Actions[177]*/
            list[11].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[0]));/*Actions[178]*/
            list[11].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[0]));/*Actions[179]*/
            list[11].actionDict.Add(EType.@char, new LRReducitonAction(regulations[0]));/*Actions[180]*/
            list[11].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[0]));/*Actions[181]*/
            list[11].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[0]));/*Actions[182]*/
            list[11].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[0]));/*Actions[183]*/
            list[11].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[0]));/*Actions[184]*/
            list[11].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[0]));/*Actions[185]*/
            list[11].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[0]));/*Actions[186]*/
            list[11].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[0]));/*Actions[187]*/
            list[11].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[0]));/*Actions[188]*/
            list[11].actionDict.Add(EType.@min, new LRReducitonAction(regulations[0]));/*Actions[189]*/
            list[11].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[0]));/*Actions[190]*/
            list[11].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[0]));/*Actions[191]*/
            list[11].actionDict.Add(EType.@max, new LRReducitonAction(regulations[0]));/*Actions[192]*/
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[193]*/
            // list[12]
            list[12].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[23]));/*Actions[194]*/
            list[12].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[195]*/
            list[12].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[196]*/
            list[12].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[197]*/
            list[12].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[198]*/
            list[12].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[199]*/
            // list[13]
            list[13].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[24]));/*Actions[200]*/
            list[13].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[201]*/
            list[13].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[202]*/
            list[13].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[203]*/
            list[13].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[204]*/
            list[13].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[205]*/
            list[13].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[206]*/
            // list[14]
            list[14].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[7]));/*Actions[207]*/
            list[14].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[7]));/*Actions[208]*/
            list[14].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[209]*/
            list[14].actionDict.Add(EType.@char, new LRReducitonAction(regulations[7]));/*Actions[210]*/
            list[14].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[7]));/*Actions[211]*/
            list[14].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[7]));/*Actions[212]*/
            list[14].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[213]*/
            list[14].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[7]));/*Actions[214]*/
            list[14].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[7]));/*Actions[215]*/
            list[14].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[7]));/*Actions[216]*/
            list[14].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[7]));/*Actions[217]*/
            list[14].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[7]));/*Actions[218]*/
            list[14].actionDict.Add(EType.@min, new LRReducitonAction(regulations[7]));/*Actions[219]*/
            list[14].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[7]));/*Actions[220]*/
            list[14].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[7]));/*Actions[221]*/
            list[14].actionDict.Add(EType.@max, new LRReducitonAction(regulations[7]));/*Actions[222]*/
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[223]*/
            // list[15]
            list[15].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[9]));/*Actions[224]*/
            list[15].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[9]));/*Actions[225]*/
            list[15].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[226]*/
            list[15].actionDict.Add(EType.@char, new LRReducitonAction(regulations[9]));/*Actions[227]*/
            list[15].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[9]));/*Actions[228]*/
            list[15].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[9]));/*Actions[229]*/
            list[15].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[230]*/
            list[15].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[9]));/*Actions[231]*/
            list[15].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[9]));/*Actions[232]*/
            list[15].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[9]));/*Actions[233]*/
            list[15].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[9]));/*Actions[234]*/
            list[15].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[9]));/*Actions[235]*/
            list[15].actionDict.Add(EType.@min, new LRReducitonAction(regulations[9]));/*Actions[236]*/
            list[15].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[9]));/*Actions[237]*/
            list[15].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[9]));/*Actions[238]*/
            list[15].actionDict.Add(EType.@max, new LRReducitonAction(regulations[9]));/*Actions[239]*/
            list[15].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[9]));/*Actions[240]*/
            // list[16]
            list[16].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[13]));/*Actions[241]*/
            list[16].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[13]));/*Actions[242]*/
            list[16].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[13]));/*Actions[243]*/
            list[16].actionDict.Add(EType.@char, new LRReducitonAction(regulations[13]));/*Actions[244]*/
            list[16].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[13]));/*Actions[245]*/
            list[16].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[13]));/*Actions[246]*/
            list[16].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[13]));/*Actions[247]*/
            list[16].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[13]));/*Actions[248]*/
            list[16].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[13]));/*Actions[249]*/
            list[16].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[13]));/*Actions[250]*/
            list[16].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[13]));/*Actions[251]*/
            list[16].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[13]));/*Actions[252]*/
            list[16].actionDict.Add(EType.@min, new LRReducitonAction(regulations[13]));/*Actions[253]*/
            list[16].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[13]));/*Actions[254]*/
            list[16].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[13]));/*Actions[255]*/
            list[16].actionDict.Add(EType.@max, new LRReducitonAction(regulations[13]));/*Actions[256]*/
            list[16].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[13]));/*Actions[257]*/
            // list[17]
            list[17].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[14]));/*Actions[258]*/
            list[17].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[14]));/*Actions[259]*/
            list[17].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[14]));/*Actions[260]*/
            list[17].actionDict.Add(EType.@char, new LRReducitonAction(regulations[14]));/*Actions[261]*/
            list[17].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[14]));/*Actions[262]*/
            list[17].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[14]));/*Actions[263]*/
            list[17].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[14]));/*Actions[264]*/
            list[17].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[14]));/*Actions[265]*/
            list[17].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[14]));/*Actions[266]*/
            list[17].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[14]));/*Actions[267]*/
            list[17].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[14]));/*Actions[268]*/
            list[17].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[14]));/*Actions[269]*/
            list[17].actionDict.Add(EType.@min, new LRReducitonAction(regulations[14]));/*Actions[270]*/
            list[17].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[14]));/*Actions[271]*/
            list[17].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[14]));/*Actions[272]*/
            list[17].actionDict.Add(EType.@max, new LRReducitonAction(regulations[14]));/*Actions[273]*/
            list[17].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[14]));/*Actions[274]*/
            // list[18]
            list[18].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[15]));/*Actions[275]*/
            list[18].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[15]));/*Actions[276]*/
            list[18].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[15]));/*Actions[277]*/
            list[18].actionDict.Add(EType.@char, new LRReducitonAction(regulations[15]));/*Actions[278]*/
            list[18].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[15]));/*Actions[279]*/
            list[18].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[15]));/*Actions[280]*/
            list[18].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[15]));/*Actions[281]*/
            list[18].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[15]));/*Actions[282]*/
            list[18].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[15]));/*Actions[283]*/
            list[18].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[15]));/*Actions[284]*/
            list[18].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[15]));/*Actions[285]*/
            list[18].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[15]));/*Actions[286]*/
            list[18].actionDict.Add(EType.@min, new LRReducitonAction(regulations[15]));/*Actions[287]*/
            list[18].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[15]));/*Actions[288]*/
            list[18].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[15]));/*Actions[289]*/
            list[18].actionDict.Add(EType.@max, new LRReducitonAction(regulations[15]));/*Actions[290]*/
            list[18].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[15]));/*Actions[291]*/
            // list[19]
            list[19].actionDict.Add(EType.@min, new LRShiftInAction(syntaxStates[25]));/*Actions[292]*/
            // list[20]
            list[20].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[10]));/*Actions[293]*/
            list[20].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[10]));/*Actions[294]*/
            list[20].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[295]*/
            list[20].actionDict.Add(EType.@char, new LRReducitonAction(regulations[10]));/*Actions[296]*/
            list[20].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[10]));/*Actions[297]*/
            list[20].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[10]));/*Actions[298]*/
            list[20].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[10]));/*Actions[299]*/
            list[20].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[10]));/*Actions[300]*/
            list[20].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[10]));/*Actions[301]*/
            list[20].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[10]));/*Actions[302]*/
            list[20].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[10]));/*Actions[303]*/
            list[20].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[10]));/*Actions[304]*/
            list[20].actionDict.Add(EType.@min, new LRReducitonAction(regulations[10]));/*Actions[305]*/
            list[20].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[10]));/*Actions[306]*/
            list[20].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[10]));/*Actions[307]*/
            list[20].actionDict.Add(EType.@max, new LRReducitonAction(regulations[10]));/*Actions[308]*/
            list[20].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[10]));/*Actions[309]*/
            // list[21]
            list[21].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[11]));/*Actions[310]*/
            list[21].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[11]));/*Actions[311]*/
            list[21].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[312]*/
            list[21].actionDict.Add(EType.@char, new LRReducitonAction(regulations[11]));/*Actions[313]*/
            list[21].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[11]));/*Actions[314]*/
            list[21].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[11]));/*Actions[315]*/
            list[21].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[11]));/*Actions[316]*/
            list[21].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[11]));/*Actions[317]*/
            list[21].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[11]));/*Actions[318]*/
            list[21].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[11]));/*Actions[319]*/
            list[21].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[11]));/*Actions[320]*/
            list[21].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[11]));/*Actions[321]*/
            list[21].actionDict.Add(EType.@min, new LRReducitonAction(regulations[11]));/*Actions[322]*/
            list[21].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[11]));/*Actions[323]*/
            list[21].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[11]));/*Actions[324]*/
            list[21].actionDict.Add(EType.@max, new LRReducitonAction(regulations[11]));/*Actions[325]*/
            list[21].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[11]));/*Actions[326]*/
            // list[22]
            list[22].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[26]));/*Actions[327]*/
            list[22].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[328]*/
            // list[23]
            //@char repeated 2 times
            //@Dot repeated 2 times
            //@scope repeated 2 times
            //@LeftParenthesis repeated 2 times
            list[23].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[329]*/
            list[23].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[330]*/
            list[23].actionDict.Add(EType.@char, new LRReducitonAction(regulations[5]));/*Actions[331]*/
            list[23].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[332]*/
            list[23].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[5]));/*Actions[333]*/
            list[23].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[334]*/
            list[23].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[5]));/*Actions[335]*/
            list[23].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[336]*/
            list[23].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[5]));/*Actions[337]*/
            list[23].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[5]));/*Actions[338]*/
            list[23].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[5]));/*Actions[339]*/
            list[23].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[340]*/
            list[23].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[5]));/*Actions[341]*/
            list[23].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[5]));/*Actions[342]*/
            list[23].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[5]));/*Actions[343]*/
            list[23].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[5]));/*Actions[344]*/
            list[23].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[5]));/*Actions[345]*/
            list[23].actionDict.Add(EType.@min, new LRReducitonAction(regulations[5]));/*Actions[346]*/
            list[23].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[5]));/*Actions[347]*/
            list[23].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[5]));/*Actions[348]*/
            list[23].actionDict.Add(EType.@max, new LRReducitonAction(regulations[5]));/*Actions[349]*/
            list[23].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[350]*/
            // list[24]
            //@Pipe repeated 2 times
            list[24].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[351]*/
            list[24].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[3]));/*Actions[352]*/
            list[24].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[3]));/*Actions[353]*/
            list[24].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[3]));/*Actions[354]*/
            list[24].actionDict.Add(EType.@char, new LRReducitonAction(regulations[3]));/*Actions[355]*/
            list[24].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[3]));/*Actions[356]*/
            list[24].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[3]));/*Actions[357]*/
            list[24].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[3]));/*Actions[358]*/
            list[24].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[3]));/*Actions[359]*/
            list[24].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[3]));/*Actions[360]*/
            list[24].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[3]));/*Actions[361]*/
            list[24].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[3]));/*Actions[362]*/
            list[24].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[3]));/*Actions[363]*/
            list[24].actionDict.Add(EType.@min, new LRReducitonAction(regulations[3]));/*Actions[364]*/
            list[24].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[3]));/*Actions[365]*/
            list[24].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[3]));/*Actions[366]*/
            list[24].actionDict.Add(EType.@max, new LRReducitonAction(regulations[3]));/*Actions[367]*/
            list[24].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[368]*/
            // list[25]
            //@Comma repeated 2 times
            list[25].actionDict.Add(EType.UpperBound, new LRGotoAction(syntaxStates[27]));/*Actions[369]*/
            list[25].actionDict.Add(EType.@Comma, new LRShiftInAction(syntaxStates[28]));/*Actions[370]*/
            list[25].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[20]));/*Actions[371]*/
            list[25].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[20]));/*Actions[372]*/
            list[25].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[20]));/*Actions[373]*/
            list[25].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[20]));/*Actions[374]*/
            list[25].actionDict.Add(EType.@char, new LRReducitonAction(regulations[20]));/*Actions[375]*/
            list[25].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[20]));/*Actions[376]*/
            list[25].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[20]));/*Actions[377]*/
            list[25].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[20]));/*Actions[378]*/
            list[25].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[20]));/*Actions[379]*/
            list[25].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[20]));/*Actions[380]*/
            list[25].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[20]));/*Actions[381]*/
            list[25].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[20]));/*Actions[382]*/
            list[25].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[20]));/*Actions[383]*/
            list[25].actionDict.Add(EType.@min, new LRReducitonAction(regulations[20]));/*Actions[384]*/
            list[25].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[20]));/*Actions[385]*/
            list[25].actionDict.Add(EType.@max, new LRReducitonAction(regulations[20]));/*Actions[386]*/
            list[25].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[20]));/*Actions[387]*/
            // list[26]
            //@Question repeated 2 times
            //@Plus repeated 2 times
            //@Asterisk repeated 2 times
            //@LeftBrace repeated 2 times
            list[26].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[29]));/*Actions[388]*/
            list[26].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[389]*/
            list[26].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[17]));/*Actions[390]*/
            list[26].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[391]*/
            list[26].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[17]));/*Actions[392]*/
            list[26].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[393]*/
            list[26].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[17]));/*Actions[394]*/
            list[26].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[395]*/
            list[26].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[17]));/*Actions[396]*/
            list[26].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[17]));/*Actions[397]*/
            list[26].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[398]*/
            list[26].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[399]*/
            list[26].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[400]*/
            list[26].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[401]*/
            list[26].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[402]*/
            list[26].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[403]*/
            list[26].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[404]*/
            list[26].actionDict.Add(EType.@min, new LRReducitonAction(regulations[17]));/*Actions[405]*/
            list[26].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[17]));/*Actions[406]*/
            list[26].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[17]));/*Actions[407]*/
            list[26].actionDict.Add(EType.@max, new LRReducitonAction(regulations[17]));/*Actions[408]*/
            list[26].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[409]*/
            // list[27]
            list[27].actionDict.Add(EType.@RightBrace, new LRShiftInAction(syntaxStates[30]));/*Actions[410]*/
            // list[28]
            //@max repeated 2 times
            list[28].actionDict.Add(EType.@max, new LRShiftInAction(syntaxStates[31]));/*Actions[411]*/
            list[28].actionDict.Add(EType.@max, new LRReducitonAction(regulations[19]));/*Actions[412]*/
            list[28].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[19]));/*Actions[413]*/
            list[28].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[19]));/*Actions[414]*/
            list[28].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[19]));/*Actions[415]*/
            list[28].actionDict.Add(EType.@char, new LRReducitonAction(regulations[19]));/*Actions[416]*/
            list[28].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[19]));/*Actions[417]*/
            list[28].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[19]));/*Actions[418]*/
            list[28].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[19]));/*Actions[419]*/
            list[28].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[19]));/*Actions[420]*/
            list[28].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[19]));/*Actions[421]*/
            list[28].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[19]));/*Actions[422]*/
            list[28].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[19]));/*Actions[423]*/
            list[28].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[19]));/*Actions[424]*/
            list[28].actionDict.Add(EType.@min, new LRReducitonAction(regulations[19]));/*Actions[425]*/
            list[28].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[19]));/*Actions[426]*/
            list[28].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[19]));/*Actions[427]*/
            list[28].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[19]));/*Actions[428]*/
            // list[29]
            list[29].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[12]));/*Actions[429]*/
            list[29].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[12]));/*Actions[430]*/
            list[29].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[431]*/
            list[29].actionDict.Add(EType.@char, new LRReducitonAction(regulations[12]));/*Actions[432]*/
            list[29].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[12]));/*Actions[433]*/
            list[29].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[12]));/*Actions[434]*/
            list[29].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[12]));/*Actions[435]*/
            list[29].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[12]));/*Actions[436]*/
            list[29].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[12]));/*Actions[437]*/
            list[29].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[12]));/*Actions[438]*/
            list[29].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[12]));/*Actions[439]*/
            list[29].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[12]));/*Actions[440]*/
            list[29].actionDict.Add(EType.@min, new LRReducitonAction(regulations[12]));/*Actions[441]*/
            list[29].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[12]));/*Actions[442]*/
            list[29].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[12]));/*Actions[443]*/
            list[29].actionDict.Add(EType.@max, new LRReducitonAction(regulations[12]));/*Actions[444]*/
            list[29].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[445]*/
            // list[30]
            list[30].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[16]));/*Actions[446]*/
            list[30].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[16]));/*Actions[447]*/
            list[30].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[16]));/*Actions[448]*/
            list[30].actionDict.Add(EType.@char, new LRReducitonAction(regulations[16]));/*Actions[449]*/
            list[30].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[16]));/*Actions[450]*/
            list[30].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[16]));/*Actions[451]*/
            list[30].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[16]));/*Actions[452]*/
            list[30].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[16]));/*Actions[453]*/
            list[30].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[16]));/*Actions[454]*/
            list[30].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[16]));/*Actions[455]*/
            list[30].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[16]));/*Actions[456]*/
            list[30].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[16]));/*Actions[457]*/
            list[30].actionDict.Add(EType.@min, new LRReducitonAction(regulations[16]));/*Actions[458]*/
            list[30].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[16]));/*Actions[459]*/
            list[30].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[16]));/*Actions[460]*/
            list[30].actionDict.Add(EType.@max, new LRReducitonAction(regulations[16]));/*Actions[461]*/
            list[30].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[16]));/*Actions[462]*/
            // list[31]
            list[31].actionDict.Add(EType.@refVt, new LRReducitonAction(regulations[18]));/*Actions[463]*/
            list[31].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[18]));/*Actions[464]*/
            list[31].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[18]));/*Actions[465]*/
            list[31].actionDict.Add(EType.@char, new LRReducitonAction(regulations[18]));/*Actions[466]*/
            list[31].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[18]));/*Actions[467]*/
            list[31].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[18]));/*Actions[468]*/
            list[31].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[18]));/*Actions[469]*/
            list[31].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[18]));/*Actions[470]*/
            list[31].actionDict.Add(EType.@Question, new LRReducitonAction(regulations[18]));/*Actions[471]*/
            list[31].actionDict.Add(EType.@Plus, new LRReducitonAction(regulations[18]));/*Actions[472]*/
            list[31].actionDict.Add(EType.@Asterisk, new LRReducitonAction(regulations[18]));/*Actions[473]*/
            list[31].actionDict.Add(EType.@LeftBrace, new LRReducitonAction(regulations[18]));/*Actions[474]*/
            list[31].actionDict.Add(EType.@min, new LRReducitonAction(regulations[18]));/*Actions[475]*/
            list[31].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[18]));/*Actions[476]*/
            list[31].actionDict.Add(EType.@Comma, new LRReducitonAction(regulations[18]));/*Actions[477]*/
            list[31].actionDict.Add(EType.@max, new LRReducitonAction(regulations[18]));/*Actions[478]*/
            list[31].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[18]));/*Actions[479]*/

        }
    }
}
