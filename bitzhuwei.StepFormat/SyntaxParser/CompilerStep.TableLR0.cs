using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        const int syntaxStateCount = 76;
        // NOTE: choose only one from CompilerStep.TableLR0.cs, CompilerStep.TableSLR.cs, CompilerStep.TableLALR1.cs, CompilerStep.TableLR1.cs
        /// <summary>
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        private static void InitializeSyntaxStates()
        {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++)
            {
                list[i] = new SyntaxState($"{nameof(CompilerStep)}.syntaxStates[i]");
            }
            // 900 actions. 2 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.STEP, new LR1ShiftInAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.StepFile, new LR1GotoAction(syntaxStates[2]));/*Actions[1]*/
            // list[1]
            list[1].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // list[2]
            list[2].actionDict.Add(EType.EndOfTokenList, new LR1AcceptAction(/*no param*/));/*Actions[3]*/
            // list[3]
            list[3].actionDict.Add(EType.HEADER, new LR1ShiftInAction(syntaxStates[4]));/*Actions[4]*/
            // list[4]
            list[4].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[5]));/*Actions[5]*/
            // list[5]
            list[5].actionDict.Add(EType.HeadLine, new LR1GotoAction(syntaxStates[7]));/*Actions[6]*/
            list[5].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[9]));/*Actions[7]*/
            list[5].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[8]*/
            list[5].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[8]));/*Actions[9]*/
            // list[6]
            list[6].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[10]));/*Actions[10]*/
            list[6].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[11]));/*Actions[11]*/
            // list[7]
            list[7].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[13]));/*Actions[12]*/
            list[7].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[12]));/*Actions[13]*/
            list[7].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[14]*/
            // list[8]
            list[8].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[14]));/*Actions[15]*/
            // list[9]
            list[9].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[15]));/*Actions[16]*/
            // list[10]
            list[10].actionDict.Add(EType.Enum, new LR1ShiftInAction(syntaxStates[18]));/*Actions[17]*/
            list[10].actionDict.Add(EType.Args, new LR1GotoAction(syntaxStates[19]));/*Actions[18]*/
            list[10].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[27]));/*Actions[19]*/
            list[10].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[20]*/
            list[10].actionDict.Add(EType.Integer, new LR1ShiftInAction(syntaxStates[21]));/*Actions[21]*/
            list[10].actionDict.Add(EType.String, new LR1ShiftInAction(syntaxStates[24]));/*Actions[22]*/
            list[10].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[26]));/*Actions[23]*/
            list[10].actionDict.Add(EType.Float, new LR1ShiftInAction(syntaxStates[20]));/*Actions[24]*/
            list[10].actionDict.Add(EType.Asterisk, new LR1ShiftInAction(syntaxStates[22]));/*Actions[25]*/
            list[10].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[25]));/*Actions[26]*/
            list[10].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[16]));/*Actions[27]*/
            list[10].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[10]));/*Actions[28]*/
            list[10].actionDict.Add(EType.Dollar, new LR1ShiftInAction(syntaxStates[23]));/*Actions[29]*/
            list[10].actionDict.Add(EType.Hexadecimal, new LR1ShiftInAction(syntaxStates[28]));/*Actions[30]*/
            list[10].actionDict.Add(EType.Arg, new LR1GotoAction(syntaxStates[17]));/*Actions[31]*/
            // list[11]
            list[11].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[14]));/*Actions[32]*/
            list[11].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[14]));/*Actions[33]*/
            list[11].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[14]));/*Actions[34]*/
            list[11].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[14]));/*Actions[35]*/
            list[11].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[14]));/*Actions[36]*/
            list[11].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[14]));/*Actions[37]*/
            list[11].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[14]));/*Actions[38]*/
            list[11].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[14]));/*Actions[39]*/
            list[11].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[14]));/*Actions[40]*/
            list[11].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[14]));/*Actions[41]*/
            list[11].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[14]));/*Actions[42]*/
            list[11].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[14]));/*Actions[43]*/
            list[11].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[14]));/*Actions[44]*/
            list[11].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[14]));/*Actions[45]*/
            list[11].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[14]));/*Actions[46]*/
            list[11].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[14]));/*Actions[47]*/
            list[11].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[14]));/*Actions[48]*/
            list[11].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[14]));/*Actions[49]*/
            list[11].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[14]));/*Actions[50]*/
            list[11].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[14]));/*Actions[51]*/
            list[11].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[14]));/*Actions[52]*/
            list[11].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[14]));/*Actions[53]*/
            list[11].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[14]));/*Actions[54]*/
            list[11].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[14]));/*Actions[55]*/
            // list[12]
            list[12].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[29]));/*Actions[56]*/
            // list[13]
            list[13].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[30]));/*Actions[57]*/
            // list[14]
            list[14].actionDict.Add(EType.DATA, new LR1ShiftInAction(syntaxStates[31]));/*Actions[58]*/
            // list[15]
            list[15].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[18]));/*Actions[59]*/
            list[15].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[18]));/*Actions[60]*/
            list[15].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[18]));/*Actions[61]*/
            list[15].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[18]));/*Actions[62]*/
            list[15].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[18]));/*Actions[63]*/
            list[15].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[18]));/*Actions[64]*/
            list[15].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[18]));/*Actions[65]*/
            list[15].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[18]));/*Actions[66]*/
            list[15].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[18]));/*Actions[67]*/
            list[15].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[18]));/*Actions[68]*/
            list[15].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[18]));/*Actions[69]*/
            list[15].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[18]));/*Actions[70]*/
            list[15].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[18]));/*Actions[71]*/
            list[15].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[18]));/*Actions[72]*/
            list[15].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[18]));/*Actions[73]*/
            list[15].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[18]));/*Actions[74]*/
            list[15].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[18]));/*Actions[75]*/
            list[15].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[18]));/*Actions[76]*/
            list[15].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[18]));/*Actions[77]*/
            list[15].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[18]));/*Actions[78]*/
            list[15].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[18]));/*Actions[79]*/
            list[15].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[18]));/*Actions[80]*/
            list[15].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[18]));/*Actions[81]*/
            list[15].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[18]));/*Actions[82]*/
            // list[16]
            list[16].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[31]));/*Actions[83]*/
            list[16].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[31]));/*Actions[84]*/
            list[16].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[31]));/*Actions[85]*/
            list[16].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[31]));/*Actions[86]*/
            list[16].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[31]));/*Actions[87]*/
            list[16].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[31]));/*Actions[88]*/
            list[16].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[31]));/*Actions[89]*/
            list[16].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[31]));/*Actions[90]*/
            list[16].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[31]));/*Actions[91]*/
            list[16].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[31]));/*Actions[92]*/
            list[16].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[31]));/*Actions[93]*/
            list[16].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[31]));/*Actions[94]*/
            list[16].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[31]));/*Actions[95]*/
            list[16].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[31]));/*Actions[96]*/
            list[16].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[31]));/*Actions[97]*/
            list[16].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[31]));/*Actions[98]*/
            list[16].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[31]));/*Actions[99]*/
            list[16].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[31]));/*Actions[100]*/
            list[16].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[31]));/*Actions[101]*/
            list[16].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[31]));/*Actions[102]*/
            list[16].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[31]));/*Actions[103]*/
            list[16].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[31]));/*Actions[104]*/
            list[16].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[31]));/*Actions[105]*/
            list[16].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[31]));/*Actions[106]*/
            // list[17]
            list[17].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[22]));/*Actions[107]*/
            list[17].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[22]));/*Actions[108]*/
            list[17].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[22]));/*Actions[109]*/
            list[17].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[22]));/*Actions[110]*/
            list[17].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[22]));/*Actions[111]*/
            list[17].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[22]));/*Actions[112]*/
            list[17].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[22]));/*Actions[113]*/
            list[17].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[22]));/*Actions[114]*/
            list[17].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[22]));/*Actions[115]*/
            list[17].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[22]));/*Actions[116]*/
            list[17].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[22]));/*Actions[117]*/
            list[17].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[22]));/*Actions[118]*/
            list[17].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[22]));/*Actions[119]*/
            list[17].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[22]));/*Actions[120]*/
            list[17].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[22]));/*Actions[121]*/
            list[17].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[22]));/*Actions[122]*/
            list[17].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[22]));/*Actions[123]*/
            list[17].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[22]));/*Actions[124]*/
            list[17].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[22]));/*Actions[125]*/
            list[17].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[22]));/*Actions[126]*/
            list[17].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[22]));/*Actions[127]*/
            list[17].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[22]));/*Actions[128]*/
            list[17].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[22]));/*Actions[129]*/
            list[17].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[22]));/*Actions[130]*/
            // list[18]
            list[18].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[30]));/*Actions[131]*/
            list[18].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[30]));/*Actions[132]*/
            list[18].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[30]));/*Actions[133]*/
            list[18].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[30]));/*Actions[134]*/
            list[18].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[30]));/*Actions[135]*/
            list[18].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[30]));/*Actions[136]*/
            list[18].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[30]));/*Actions[137]*/
            list[18].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[30]));/*Actions[138]*/
            list[18].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[30]));/*Actions[139]*/
            list[18].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[30]));/*Actions[140]*/
            list[18].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[30]));/*Actions[141]*/
            list[18].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[30]));/*Actions[142]*/
            list[18].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[30]));/*Actions[143]*/
            list[18].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[30]));/*Actions[144]*/
            list[18].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[30]));/*Actions[145]*/
            list[18].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[30]));/*Actions[146]*/
            list[18].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[30]));/*Actions[147]*/
            list[18].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[30]));/*Actions[148]*/
            list[18].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[30]));/*Actions[149]*/
            list[18].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[30]));/*Actions[150]*/
            list[18].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[30]));/*Actions[151]*/
            list[18].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[30]));/*Actions[152]*/
            list[18].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[30]));/*Actions[153]*/
            list[18].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[30]));/*Actions[154]*/
            // list[19]
            list[19].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[33]));/*Actions[155]*/
            list[19].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[32]));/*Actions[156]*/
            // list[20]
            list[20].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[28]));/*Actions[157]*/
            list[20].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[28]));/*Actions[158]*/
            list[20].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[28]));/*Actions[159]*/
            list[20].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[28]));/*Actions[160]*/
            list[20].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[28]));/*Actions[161]*/
            list[20].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[28]));/*Actions[162]*/
            list[20].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[28]));/*Actions[163]*/
            list[20].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[28]));/*Actions[164]*/
            list[20].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[28]));/*Actions[165]*/
            list[20].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[28]));/*Actions[166]*/
            list[20].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[28]));/*Actions[167]*/
            list[20].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[28]));/*Actions[168]*/
            list[20].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[28]));/*Actions[169]*/
            list[20].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[28]));/*Actions[170]*/
            list[20].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[28]));/*Actions[171]*/
            list[20].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[28]));/*Actions[172]*/
            list[20].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[28]));/*Actions[173]*/
            list[20].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[28]));/*Actions[174]*/
            list[20].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[28]));/*Actions[175]*/
            list[20].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[28]));/*Actions[176]*/
            list[20].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[28]));/*Actions[177]*/
            list[20].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[28]));/*Actions[178]*/
            list[20].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[28]));/*Actions[179]*/
            list[20].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[28]));/*Actions[180]*/
            // list[21]
            list[21].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[27]));/*Actions[181]*/
            list[21].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[27]));/*Actions[182]*/
            list[21].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[27]));/*Actions[183]*/
            list[21].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[27]));/*Actions[184]*/
            list[21].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[27]));/*Actions[185]*/
            list[21].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[27]));/*Actions[186]*/
            list[21].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[27]));/*Actions[187]*/
            list[21].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[27]));/*Actions[188]*/
            list[21].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[27]));/*Actions[189]*/
            list[21].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[27]));/*Actions[190]*/
            list[21].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[27]));/*Actions[191]*/
            list[21].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[27]));/*Actions[192]*/
            list[21].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[27]));/*Actions[193]*/
            list[21].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[27]));/*Actions[194]*/
            list[21].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[27]));/*Actions[195]*/
            list[21].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[27]));/*Actions[196]*/
            list[21].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[27]));/*Actions[197]*/
            list[21].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[27]));/*Actions[198]*/
            list[21].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[27]));/*Actions[199]*/
            list[21].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[27]));/*Actions[200]*/
            list[21].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[27]));/*Actions[201]*/
            list[21].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[27]));/*Actions[202]*/
            list[21].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[27]));/*Actions[203]*/
            list[21].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[27]));/*Actions[204]*/
            // list[22]
            list[22].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[25]));/*Actions[205]*/
            list[22].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[25]));/*Actions[206]*/
            list[22].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[25]));/*Actions[207]*/
            list[22].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[25]));/*Actions[208]*/
            list[22].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[25]));/*Actions[209]*/
            list[22].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[25]));/*Actions[210]*/
            list[22].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[25]));/*Actions[211]*/
            list[22].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[25]));/*Actions[212]*/
            list[22].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[25]));/*Actions[213]*/
            list[22].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[25]));/*Actions[214]*/
            list[22].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[25]));/*Actions[215]*/
            list[22].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[25]));/*Actions[216]*/
            list[22].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[25]));/*Actions[217]*/
            list[22].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[25]));/*Actions[218]*/
            list[22].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[25]));/*Actions[219]*/
            list[22].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[25]));/*Actions[220]*/
            list[22].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[25]));/*Actions[221]*/
            list[22].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[25]));/*Actions[222]*/
            list[22].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[25]));/*Actions[223]*/
            list[22].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[25]));/*Actions[224]*/
            list[22].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[25]));/*Actions[225]*/
            list[22].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[25]));/*Actions[226]*/
            list[22].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[25]));/*Actions[227]*/
            list[22].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[25]));/*Actions[228]*/
            // list[23]
            list[23].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[24]));/*Actions[229]*/
            list[23].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[24]));/*Actions[230]*/
            list[23].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[24]));/*Actions[231]*/
            list[23].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[24]));/*Actions[232]*/
            list[23].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[24]));/*Actions[233]*/
            list[23].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[24]));/*Actions[234]*/
            list[23].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[24]));/*Actions[235]*/
            list[23].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[24]));/*Actions[236]*/
            list[23].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[24]));/*Actions[237]*/
            list[23].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[24]));/*Actions[238]*/
            list[23].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[24]));/*Actions[239]*/
            list[23].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[24]));/*Actions[240]*/
            list[23].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[24]));/*Actions[241]*/
            list[23].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[24]));/*Actions[242]*/
            list[23].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[24]));/*Actions[243]*/
            list[23].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[24]));/*Actions[244]*/
            list[23].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[24]));/*Actions[245]*/
            list[23].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[24]));/*Actions[246]*/
            list[23].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[24]));/*Actions[247]*/
            list[23].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[24]));/*Actions[248]*/
            list[23].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[24]));/*Actions[249]*/
            list[23].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[24]));/*Actions[250]*/
            list[23].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[24]));/*Actions[251]*/
            list[23].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[24]));/*Actions[252]*/
            // list[24]
            list[24].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[26]));/*Actions[253]*/
            list[24].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[26]));/*Actions[254]*/
            list[24].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[26]));/*Actions[255]*/
            list[24].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[26]));/*Actions[256]*/
            list[24].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[26]));/*Actions[257]*/
            list[24].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[26]));/*Actions[258]*/
            list[24].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[26]));/*Actions[259]*/
            list[24].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[26]));/*Actions[260]*/
            list[24].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[26]));/*Actions[261]*/
            list[24].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[26]));/*Actions[262]*/
            list[24].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[26]));/*Actions[263]*/
            list[24].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[26]));/*Actions[264]*/
            list[24].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[26]));/*Actions[265]*/
            list[24].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[26]));/*Actions[266]*/
            list[24].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[26]));/*Actions[267]*/
            list[24].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[26]));/*Actions[268]*/
            list[24].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[26]));/*Actions[269]*/
            list[24].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[26]));/*Actions[270]*/
            list[24].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[26]));/*Actions[271]*/
            list[24].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[26]));/*Actions[272]*/
            list[24].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[26]));/*Actions[273]*/
            list[24].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[26]));/*Actions[274]*/
            list[24].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[26]));/*Actions[275]*/
            list[24].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[26]));/*Actions[276]*/
            // list[25]
            list[25].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[32]));/*Actions[277]*/
            list[25].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[32]));/*Actions[278]*/
            list[25].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[32]));/*Actions[279]*/
            list[25].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[32]));/*Actions[280]*/
            list[25].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[32]));/*Actions[281]*/
            list[25].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[32]));/*Actions[282]*/
            list[25].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[32]));/*Actions[283]*/
            list[25].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[32]));/*Actions[284]*/
            list[25].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[32]));/*Actions[285]*/
            list[25].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[32]));/*Actions[286]*/
            list[25].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[32]));/*Actions[287]*/
            list[25].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[32]));/*Actions[288]*/
            list[25].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[32]));/*Actions[289]*/
            list[25].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[32]));/*Actions[290]*/
            list[25].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[32]));/*Actions[291]*/
            list[25].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[32]));/*Actions[292]*/
            list[25].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[32]));/*Actions[293]*/
            list[25].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[32]));/*Actions[294]*/
            list[25].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[32]));/*Actions[295]*/
            list[25].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[32]));/*Actions[296]*/
            list[25].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[32]));/*Actions[297]*/
            list[25].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[32]));/*Actions[298]*/
            list[25].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[32]));/*Actions[299]*/
            list[25].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[32]));/*Actions[300]*/
            // list[26]
            list[26].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[20]));/*Actions[301]*/
            list[26].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[20]));/*Actions[302]*/
            list[26].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[20]));/*Actions[303]*/
            list[26].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[20]));/*Actions[304]*/
            list[26].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[20]));/*Actions[305]*/
            list[26].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[20]));/*Actions[306]*/
            list[26].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[20]));/*Actions[307]*/
            list[26].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[20]));/*Actions[308]*/
            list[26].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[20]));/*Actions[309]*/
            list[26].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[20]));/*Actions[310]*/
            list[26].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[20]));/*Actions[311]*/
            list[26].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[20]));/*Actions[312]*/
            list[26].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[20]));/*Actions[313]*/
            list[26].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[20]));/*Actions[314]*/
            list[26].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[20]));/*Actions[315]*/
            list[26].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[20]));/*Actions[316]*/
            list[26].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[20]));/*Actions[317]*/
            list[26].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[20]));/*Actions[318]*/
            list[26].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[20]));/*Actions[319]*/
            list[26].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[20]));/*Actions[320]*/
            list[26].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[20]));/*Actions[321]*/
            list[26].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[20]));/*Actions[322]*/
            list[26].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[20]));/*Actions[323]*/
            list[26].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[20]));/*Actions[324]*/
            // list[27]
            list[27].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[23]));/*Actions[325]*/
            list[27].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[23]));/*Actions[326]*/
            list[27].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[23]));/*Actions[327]*/
            list[27].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[23]));/*Actions[328]*/
            list[27].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[23]));/*Actions[329]*/
            list[27].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[23]));/*Actions[330]*/
            list[27].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[23]));/*Actions[331]*/
            list[27].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[23]));/*Actions[332]*/
            list[27].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[23]));/*Actions[333]*/
            list[27].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[23]));/*Actions[334]*/
            list[27].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[23]));/*Actions[335]*/
            list[27].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[23]));/*Actions[336]*/
            list[27].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[23]));/*Actions[337]*/
            list[27].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[23]));/*Actions[338]*/
            list[27].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[23]));/*Actions[339]*/
            list[27].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[23]));/*Actions[340]*/
            list[27].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[23]));/*Actions[341]*/
            list[27].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[23]));/*Actions[342]*/
            list[27].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[23]));/*Actions[343]*/
            list[27].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[23]));/*Actions[344]*/
            list[27].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[23]));/*Actions[345]*/
            list[27].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[23]));/*Actions[346]*/
            list[27].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[23]));/*Actions[347]*/
            list[27].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[23]));/*Actions[348]*/
            // list[28]
            list[28].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[29]));/*Actions[349]*/
            list[28].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[29]));/*Actions[350]*/
            list[28].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[29]));/*Actions[351]*/
            list[28].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[29]));/*Actions[352]*/
            list[28].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[29]));/*Actions[353]*/
            list[28].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[29]));/*Actions[354]*/
            list[28].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[29]));/*Actions[355]*/
            list[28].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[29]));/*Actions[356]*/
            list[28].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[29]));/*Actions[357]*/
            list[28].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[29]));/*Actions[358]*/
            list[28].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[29]));/*Actions[359]*/
            list[28].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[29]));/*Actions[360]*/
            list[28].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[29]));/*Actions[361]*/
            list[28].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[29]));/*Actions[362]*/
            list[28].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[29]));/*Actions[363]*/
            list[28].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[29]));/*Actions[364]*/
            list[28].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[29]));/*Actions[365]*/
            list[28].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[29]));/*Actions[366]*/
            list[28].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[29]));/*Actions[367]*/
            list[28].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[29]));/*Actions[368]*/
            list[28].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[29]));/*Actions[369]*/
            list[28].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[29]));/*Actions[370]*/
            list[28].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[29]));/*Actions[371]*/
            list[28].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[29]));/*Actions[372]*/
            // list[29]
            list[29].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[17]));/*Actions[373]*/
            list[29].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[17]));/*Actions[374]*/
            list[29].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[17]));/*Actions[375]*/
            list[29].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[17]));/*Actions[376]*/
            list[29].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[17]));/*Actions[377]*/
            list[29].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[17]));/*Actions[378]*/
            list[29].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[17]));/*Actions[379]*/
            list[29].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[17]));/*Actions[380]*/
            list[29].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[17]));/*Actions[381]*/
            list[29].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[17]));/*Actions[382]*/
            list[29].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[17]));/*Actions[383]*/
            list[29].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[17]));/*Actions[384]*/
            list[29].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[17]));/*Actions[385]*/
            list[29].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[17]));/*Actions[386]*/
            list[29].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[17]));/*Actions[387]*/
            list[29].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[17]));/*Actions[388]*/
            list[29].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[17]));/*Actions[389]*/
            list[29].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[17]));/*Actions[390]*/
            list[29].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[17]));/*Actions[391]*/
            list[29].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[17]));/*Actions[392]*/
            list[29].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[17]));/*Actions[393]*/
            list[29].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[17]));/*Actions[394]*/
            list[29].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[17]));/*Actions[395]*/
            list[29].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[17]));/*Actions[396]*/
            // list[30]
            list[30].actionDict.Add(EType.DATA, new LR1ShiftInAction(syntaxStates[34]));/*Actions[397]*/
            // list[31]
            list[31].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[35]));/*Actions[398]*/
            // list[32]
            list[32].actionDict.Add(EType.Enum, new LR1ShiftInAction(syntaxStates[18]));/*Actions[399]*/
            list[32].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[27]));/*Actions[400]*/
            list[32].actionDict.Add(EType.String, new LR1ShiftInAction(syntaxStates[24]));/*Actions[401]*/
            list[32].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[16]));/*Actions[402]*/
            list[32].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[403]*/
            list[32].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[10]));/*Actions[404]*/
            list[32].actionDict.Add(EType.Integer, new LR1ShiftInAction(syntaxStates[21]));/*Actions[405]*/
            list[32].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[25]));/*Actions[406]*/
            list[32].actionDict.Add(EType.Dollar, new LR1ShiftInAction(syntaxStates[23]));/*Actions[407]*/
            list[32].actionDict.Add(EType.Float, new LR1ShiftInAction(syntaxStates[20]));/*Actions[408]*/
            list[32].actionDict.Add(EType.Hexadecimal, new LR1ShiftInAction(syntaxStates[28]));/*Actions[409]*/
            list[32].actionDict.Add(EType.Asterisk, new LR1ShiftInAction(syntaxStates[22]));/*Actions[410]*/
            list[32].actionDict.Add(EType.Arg, new LR1GotoAction(syntaxStates[36]));/*Actions[411]*/
            // list[33]
            list[33].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[19]));/*Actions[412]*/
            list[33].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[19]));/*Actions[413]*/
            list[33].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[19]));/*Actions[414]*/
            list[33].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[19]));/*Actions[415]*/
            list[33].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[19]));/*Actions[416]*/
            list[33].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[19]));/*Actions[417]*/
            list[33].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[19]));/*Actions[418]*/
            list[33].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[19]));/*Actions[419]*/
            list[33].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[19]));/*Actions[420]*/
            list[33].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[19]));/*Actions[421]*/
            list[33].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[19]));/*Actions[422]*/
            list[33].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[19]));/*Actions[423]*/
            list[33].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[19]));/*Actions[424]*/
            list[33].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[19]));/*Actions[425]*/
            list[33].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[19]));/*Actions[426]*/
            list[33].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[19]));/*Actions[427]*/
            list[33].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[19]));/*Actions[428]*/
            list[33].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[19]));/*Actions[429]*/
            list[33].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[19]));/*Actions[430]*/
            list[33].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[19]));/*Actions[431]*/
            list[33].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[19]));/*Actions[432]*/
            list[33].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[19]));/*Actions[433]*/
            list[33].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[19]));/*Actions[434]*/
            list[33].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[19]));/*Actions[435]*/
            // list[34]
            list[34].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[37]));/*Actions[436]*/
            // list[35]
            list[35].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[38]));/*Actions[437]*/
            list[35].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[40]));/*Actions[438]*/
            list[35].actionDict.Add(EType.Model, new LR1GotoAction(syntaxStates[39]));/*Actions[439]*/
            // list[36]
            list[36].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[21]));/*Actions[440]*/
            list[36].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[21]));/*Actions[441]*/
            list[36].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[21]));/*Actions[442]*/
            list[36].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[21]));/*Actions[443]*/
            list[36].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[21]));/*Actions[444]*/
            list[36].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[21]));/*Actions[445]*/
            list[36].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[21]));/*Actions[446]*/
            list[36].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[21]));/*Actions[447]*/
            list[36].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[21]));/*Actions[448]*/
            list[36].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[21]));/*Actions[449]*/
            list[36].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[21]));/*Actions[450]*/
            list[36].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[21]));/*Actions[451]*/
            list[36].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[21]));/*Actions[452]*/
            list[36].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[21]));/*Actions[453]*/
            list[36].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[21]));/*Actions[454]*/
            list[36].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[21]));/*Actions[455]*/
            list[36].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[21]));/*Actions[456]*/
            list[36].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[21]));/*Actions[457]*/
            list[36].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[21]));/*Actions[458]*/
            list[36].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[21]));/*Actions[459]*/
            list[36].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[21]));/*Actions[460]*/
            list[36].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[21]));/*Actions[461]*/
            list[36].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[21]));/*Actions[462]*/
            list[36].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[21]));/*Actions[463]*/
            // list[37]
            list[37].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[38]));/*Actions[464]*/
            list[37].actionDict.Add(EType.Model, new LR1GotoAction(syntaxStates[41]));/*Actions[465]*/
            list[37].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[40]));/*Actions[466]*/
            // list[38]
            list[38].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[2]));/*Actions[467]*/
            list[38].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[2]));/*Actions[468]*/
            list[38].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[2]));/*Actions[469]*/
            list[38].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[2]));/*Actions[470]*/
            list[38].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[2]));/*Actions[471]*/
            list[38].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[2]));/*Actions[472]*/
            list[38].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[2]));/*Actions[473]*/
            list[38].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[2]));/*Actions[474]*/
            list[38].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[2]));/*Actions[475]*/
            list[38].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[2]));/*Actions[476]*/
            list[38].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[2]));/*Actions[477]*/
            list[38].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[2]));/*Actions[478]*/
            list[38].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[2]));/*Actions[479]*/
            list[38].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[2]));/*Actions[480]*/
            list[38].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[2]));/*Actions[481]*/
            list[38].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[2]));/*Actions[482]*/
            list[38].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[2]));/*Actions[483]*/
            list[38].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[2]));/*Actions[484]*/
            list[38].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[2]));/*Actions[485]*/
            list[38].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[2]));/*Actions[486]*/
            list[38].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[2]));/*Actions[487]*/
            list[38].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[2]));/*Actions[488]*/
            list[38].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[2]));/*Actions[489]*/
            list[38].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[2]));/*Actions[490]*/
            // list[39]
            list[39].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[43]));/*Actions[491]*/
            list[39].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[40]));/*Actions[492]*/
            list[39].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[42]));/*Actions[493]*/
            // list[40]
            list[40].actionDict.Add(EType.Equal, new LR1ShiftInAction(syntaxStates[44]));/*Actions[494]*/
            // list[41]
            list[41].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[40]));/*Actions[495]*/
            list[41].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[45]));/*Actions[496]*/
            list[41].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[42]));/*Actions[497]*/
            // list[42]
            list[42].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[3]));/*Actions[498]*/
            list[42].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[3]));/*Actions[499]*/
            list[42].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[3]));/*Actions[500]*/
            list[42].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[3]));/*Actions[501]*/
            list[42].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[3]));/*Actions[502]*/
            list[42].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[3]));/*Actions[503]*/
            list[42].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[3]));/*Actions[504]*/
            list[42].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[3]));/*Actions[505]*/
            list[42].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[3]));/*Actions[506]*/
            list[42].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[3]));/*Actions[507]*/
            list[42].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[3]));/*Actions[508]*/
            list[42].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[3]));/*Actions[509]*/
            list[42].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[3]));/*Actions[510]*/
            list[42].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[3]));/*Actions[511]*/
            list[42].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[3]));/*Actions[512]*/
            list[42].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[3]));/*Actions[513]*/
            list[42].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[3]));/*Actions[514]*/
            list[42].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[3]));/*Actions[515]*/
            list[42].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[3]));/*Actions[516]*/
            list[42].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[3]));/*Actions[517]*/
            list[42].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[3]));/*Actions[518]*/
            list[42].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[3]));/*Actions[519]*/
            list[42].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[3]));/*Actions[520]*/
            list[42].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[3]));/*Actions[521]*/
            // list[43]
            list[43].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[46]));/*Actions[522]*/
            // list[44]
            list[44].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[523]*/
            list[44].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[49]));/*Actions[524]*/
            list[44].actionDict.Add(EType.EntityBody, new LR1GotoAction(syntaxStates[51]));/*Actions[525]*/
            list[44].actionDict.Add(EType.ScopeBlock, new LR1GotoAction(syntaxStates[48]));/*Actions[526]*/
            list[44].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[50]));/*Actions[527]*/
            list[44].actionDict.Add(EType.SCOPE, new LR1ShiftInAction(syntaxStates[47]));/*Actions[528]*/
            // list[45]
            list[45].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[52]));/*Actions[529]*/
            // list[46]
            list[46].actionDict.Add(EType.ENDSTEP, new LR1ShiftInAction(syntaxStates[53]));/*Actions[530]*/
            // list[47]
            list[47].actionDict.Add(EType.Model, new LR1GotoAction(syntaxStates[55]));/*Actions[531]*/
            list[47].actionDict.Add(EType.ENDSCOPE, new LR1ShiftInAction(syntaxStates[54]));/*Actions[532]*/
            list[47].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[40]));/*Actions[533]*/
            list[47].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[38]));/*Actions[534]*/
            // list[48]
            list[48].actionDict.Add(EType.EntityBody, new LR1GotoAction(syntaxStates[56]));/*Actions[535]*/
            list[48].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[49]));/*Actions[536]*/
            list[48].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[537]*/
            list[48].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[50]));/*Actions[538]*/
            // list[49]
            list[49].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[57]));/*Actions[539]*/
            list[49].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[540]*/
            list[49].actionDict.Add(EType.Complex, new LR1GotoAction(syntaxStates[58]));/*Actions[541]*/
            // list[50]
            list[50].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[12]));/*Actions[542]*/
            list[50].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[12]));/*Actions[543]*/
            list[50].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[12]));/*Actions[544]*/
            list[50].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[12]));/*Actions[545]*/
            list[50].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[12]));/*Actions[546]*/
            list[50].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[12]));/*Actions[547]*/
            list[50].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[12]));/*Actions[548]*/
            list[50].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[12]));/*Actions[549]*/
            list[50].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[12]));/*Actions[550]*/
            list[50].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[12]));/*Actions[551]*/
            list[50].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[12]));/*Actions[552]*/
            list[50].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[12]));/*Actions[553]*/
            list[50].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[12]));/*Actions[554]*/
            list[50].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[12]));/*Actions[555]*/
            list[50].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[12]));/*Actions[556]*/
            list[50].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[12]));/*Actions[557]*/
            list[50].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[12]));/*Actions[558]*/
            list[50].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[12]));/*Actions[559]*/
            list[50].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[12]));/*Actions[560]*/
            list[50].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[12]));/*Actions[561]*/
            list[50].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[12]));/*Actions[562]*/
            list[50].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[12]));/*Actions[563]*/
            list[50].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[12]));/*Actions[564]*/
            list[50].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[12]));/*Actions[565]*/
            // list[51]
            list[51].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[59]));/*Actions[566]*/
            // list[52]
            list[52].actionDict.Add(EType.ENDSTEP, new LR1ShiftInAction(syntaxStates[60]));/*Actions[567]*/
            // list[53]
            list[53].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[61]));/*Actions[568]*/
            // list[54]
            //'/' repeated 2 times
            //'/' repeated 2 times
            list[54].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[62]));/*Actions[569]*/
            list[54].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[9]));/*Actions[570]*/
            list[54].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[9]));/*Actions[571]*/
            list[54].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[9]));/*Actions[572]*/
            list[54].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[9]));/*Actions[573]*/
            list[54].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[9]));/*Actions[574]*/
            list[54].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[9]));/*Actions[575]*/
            list[54].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[9]));/*Actions[576]*/
            list[54].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[9]));/*Actions[577]*/
            list[54].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[9]));/*Actions[578]*/
            list[54].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[9]));/*Actions[579]*/
            list[54].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[9]));/*Actions[580]*/
            list[54].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[9]));/*Actions[581]*/
            list[54].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[9]));/*Actions[582]*/
            list[54].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[9]));/*Actions[583]*/
            list[54].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[9]));/*Actions[584]*/
            list[54].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[9]));/*Actions[585]*/
            list[54].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[9]));/*Actions[586]*/
            list[54].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[9]));/*Actions[587]*/
            list[54].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[9]));/*Actions[588]*/
            list[54].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[9]));/*Actions[589]*/
            list[54].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[9]));/*Actions[590]*/
            list[54].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[9]));/*Actions[591]*/
            list[54].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[9]));/*Actions[592]*/
            list[54].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[9]));/*Actions[593]*/
            // list[55]
            list[55].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[42]));/*Actions[594]*/
            list[55].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[40]));/*Actions[595]*/
            list[55].actionDict.Add(EType.ENDSCOPE, new LR1ShiftInAction(syntaxStates[63]));/*Actions[596]*/
            // list[56]
            list[56].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[64]));/*Actions[597]*/
            // list[57]
            list[57].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[16]));/*Actions[598]*/
            list[57].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[16]));/*Actions[599]*/
            list[57].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[16]));/*Actions[600]*/
            list[57].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[16]));/*Actions[601]*/
            list[57].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[16]));/*Actions[602]*/
            list[57].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[16]));/*Actions[603]*/
            list[57].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[16]));/*Actions[604]*/
            list[57].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[16]));/*Actions[605]*/
            list[57].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[16]));/*Actions[606]*/
            list[57].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[16]));/*Actions[607]*/
            list[57].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[16]));/*Actions[608]*/
            list[57].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[16]));/*Actions[609]*/
            list[57].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[16]));/*Actions[610]*/
            list[57].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[16]));/*Actions[611]*/
            list[57].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[16]));/*Actions[612]*/
            list[57].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[16]));/*Actions[613]*/
            list[57].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[16]));/*Actions[614]*/
            list[57].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[16]));/*Actions[615]*/
            list[57].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[16]));/*Actions[616]*/
            list[57].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[16]));/*Actions[617]*/
            list[57].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[16]));/*Actions[618]*/
            list[57].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[16]));/*Actions[619]*/
            list[57].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[16]));/*Actions[620]*/
            list[57].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[16]));/*Actions[621]*/
            // list[58]
            list[58].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[66]));/*Actions[622]*/
            list[58].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[65]));/*Actions[623]*/
            list[58].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[624]*/
            // list[59]
            list[59].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[5]));/*Actions[625]*/
            list[59].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[5]));/*Actions[626]*/
            list[59].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[5]));/*Actions[627]*/
            list[59].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[5]));/*Actions[628]*/
            list[59].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[5]));/*Actions[629]*/
            list[59].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[5]));/*Actions[630]*/
            list[59].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[5]));/*Actions[631]*/
            list[59].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[5]));/*Actions[632]*/
            list[59].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[5]));/*Actions[633]*/
            list[59].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[5]));/*Actions[634]*/
            list[59].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[5]));/*Actions[635]*/
            list[59].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[5]));/*Actions[636]*/
            list[59].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[5]));/*Actions[637]*/
            list[59].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[5]));/*Actions[638]*/
            list[59].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[5]));/*Actions[639]*/
            list[59].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[5]));/*Actions[640]*/
            list[59].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[5]));/*Actions[641]*/
            list[59].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[5]));/*Actions[642]*/
            list[59].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[5]));/*Actions[643]*/
            list[59].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[5]));/*Actions[644]*/
            list[59].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[5]));/*Actions[645]*/
            list[59].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[5]));/*Actions[646]*/
            list[59].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[5]));/*Actions[647]*/
            list[59].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[5]));/*Actions[648]*/
            // list[60]
            list[60].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[67]));/*Actions[649]*/
            // list[61]
            list[61].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[1]));/*Actions[650]*/
            list[61].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[1]));/*Actions[651]*/
            list[61].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[1]));/*Actions[652]*/
            list[61].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[1]));/*Actions[653]*/
            list[61].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[1]));/*Actions[654]*/
            list[61].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[1]));/*Actions[655]*/
            list[61].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[1]));/*Actions[656]*/
            list[61].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[1]));/*Actions[657]*/
            list[61].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[1]));/*Actions[658]*/
            list[61].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[1]));/*Actions[659]*/
            list[61].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[1]));/*Actions[660]*/
            list[61].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[1]));/*Actions[661]*/
            list[61].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[1]));/*Actions[662]*/
            list[61].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[1]));/*Actions[663]*/
            list[61].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[1]));/*Actions[664]*/
            list[61].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[1]));/*Actions[665]*/
            list[61].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[1]));/*Actions[666]*/
            list[61].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[1]));/*Actions[667]*/
            list[61].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[1]));/*Actions[668]*/
            list[61].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[1]));/*Actions[669]*/
            list[61].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[1]));/*Actions[670]*/
            list[61].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[1]));/*Actions[671]*/
            list[61].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[1]));/*Actions[672]*/
            list[61].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[1]));/*Actions[673]*/
            // list[62]
            list[62].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[69]));/*Actions[674]*/
            list[62].actionDict.Add(EType.IdList, new LR1GotoAction(syntaxStates[68]));/*Actions[675]*/
            // list[63]
            //'/' repeated 2 times
            //'/' repeated 2 times
            list[63].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[70]));/*Actions[676]*/
            list[63].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[7]));/*Actions[677]*/
            list[63].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[7]));/*Actions[678]*/
            list[63].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[7]));/*Actions[679]*/
            list[63].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[7]));/*Actions[680]*/
            list[63].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[7]));/*Actions[681]*/
            list[63].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[7]));/*Actions[682]*/
            list[63].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[7]));/*Actions[683]*/
            list[63].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[7]));/*Actions[684]*/
            list[63].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[7]));/*Actions[685]*/
            list[63].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[7]));/*Actions[686]*/
            list[63].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[7]));/*Actions[687]*/
            list[63].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[7]));/*Actions[688]*/
            list[63].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[7]));/*Actions[689]*/
            list[63].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[7]));/*Actions[690]*/
            list[63].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[7]));/*Actions[691]*/
            list[63].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[7]));/*Actions[692]*/
            list[63].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[7]));/*Actions[693]*/
            list[63].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[7]));/*Actions[694]*/
            list[63].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[7]));/*Actions[695]*/
            list[63].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[7]));/*Actions[696]*/
            list[63].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[7]));/*Actions[697]*/
            list[63].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[7]));/*Actions[698]*/
            list[63].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[7]));/*Actions[699]*/
            list[63].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[7]));/*Actions[700]*/
            // list[64]
            list[64].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[4]));/*Actions[701]*/
            list[64].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[4]));/*Actions[702]*/
            list[64].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[4]));/*Actions[703]*/
            list[64].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[4]));/*Actions[704]*/
            list[64].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[4]));/*Actions[705]*/
            list[64].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[4]));/*Actions[706]*/
            list[64].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[4]));/*Actions[707]*/
            list[64].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[4]));/*Actions[708]*/
            list[64].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[4]));/*Actions[709]*/
            list[64].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[4]));/*Actions[710]*/
            list[64].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[4]));/*Actions[711]*/
            list[64].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[4]));/*Actions[712]*/
            list[64].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[4]));/*Actions[713]*/
            list[64].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[4]));/*Actions[714]*/
            list[64].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[4]));/*Actions[715]*/
            list[64].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[4]));/*Actions[716]*/
            list[64].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[4]));/*Actions[717]*/
            list[64].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[4]));/*Actions[718]*/
            list[64].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[4]));/*Actions[719]*/
            list[64].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[4]));/*Actions[720]*/
            list[64].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[4]));/*Actions[721]*/
            list[64].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[4]));/*Actions[722]*/
            list[64].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[4]));/*Actions[723]*/
            list[64].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[4]));/*Actions[724]*/
            // list[65]
            list[65].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[13]));/*Actions[725]*/
            list[65].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[13]));/*Actions[726]*/
            list[65].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[13]));/*Actions[727]*/
            list[65].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[13]));/*Actions[728]*/
            list[65].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[13]));/*Actions[729]*/
            list[65].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[13]));/*Actions[730]*/
            list[65].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[13]));/*Actions[731]*/
            list[65].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[13]));/*Actions[732]*/
            list[65].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[13]));/*Actions[733]*/
            list[65].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[13]));/*Actions[734]*/
            list[65].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[13]));/*Actions[735]*/
            list[65].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[13]));/*Actions[736]*/
            list[65].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[13]));/*Actions[737]*/
            list[65].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[13]));/*Actions[738]*/
            list[65].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[13]));/*Actions[739]*/
            list[65].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[13]));/*Actions[740]*/
            list[65].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[13]));/*Actions[741]*/
            list[65].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[13]));/*Actions[742]*/
            list[65].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[13]));/*Actions[743]*/
            list[65].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[13]));/*Actions[744]*/
            list[65].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[13]));/*Actions[745]*/
            list[65].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[13]));/*Actions[746]*/
            list[65].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[13]));/*Actions[747]*/
            list[65].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[13]));/*Actions[748]*/
            // list[66]
            list[66].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[15]));/*Actions[749]*/
            list[66].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[15]));/*Actions[750]*/
            list[66].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[15]));/*Actions[751]*/
            list[66].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[15]));/*Actions[752]*/
            list[66].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[15]));/*Actions[753]*/
            list[66].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[15]));/*Actions[754]*/
            list[66].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[15]));/*Actions[755]*/
            list[66].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[15]));/*Actions[756]*/
            list[66].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[15]));/*Actions[757]*/
            list[66].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[15]));/*Actions[758]*/
            list[66].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[15]));/*Actions[759]*/
            list[66].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[15]));/*Actions[760]*/
            list[66].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[15]));/*Actions[761]*/
            list[66].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[15]));/*Actions[762]*/
            list[66].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[15]));/*Actions[763]*/
            list[66].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[15]));/*Actions[764]*/
            list[66].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[15]));/*Actions[765]*/
            list[66].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[15]));/*Actions[766]*/
            list[66].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[15]));/*Actions[767]*/
            list[66].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[15]));/*Actions[768]*/
            list[66].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[15]));/*Actions[769]*/
            list[66].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[15]));/*Actions[770]*/
            list[66].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[15]));/*Actions[771]*/
            list[66].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[15]));/*Actions[772]*/
            // list[67]
            list[67].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[0]));/*Actions[773]*/
            list[67].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[0]));/*Actions[774]*/
            list[67].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[0]));/*Actions[775]*/
            list[67].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[0]));/*Actions[776]*/
            list[67].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[0]));/*Actions[777]*/
            list[67].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[0]));/*Actions[778]*/
            list[67].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[0]));/*Actions[779]*/
            list[67].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[0]));/*Actions[780]*/
            list[67].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[0]));/*Actions[781]*/
            list[67].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[0]));/*Actions[782]*/
            list[67].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[0]));/*Actions[783]*/
            list[67].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[0]));/*Actions[784]*/
            list[67].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[0]));/*Actions[785]*/
            list[67].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[0]));/*Actions[786]*/
            list[67].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[0]));/*Actions[787]*/
            list[67].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[0]));/*Actions[788]*/
            list[67].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[0]));/*Actions[789]*/
            list[67].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[0]));/*Actions[790]*/
            list[67].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[0]));/*Actions[791]*/
            list[67].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[0]));/*Actions[792]*/
            list[67].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[0]));/*Actions[793]*/
            list[67].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[0]));/*Actions[794]*/
            list[67].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[0]));/*Actions[795]*/
            list[67].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[0]));/*Actions[796]*/
            // list[68]
            list[68].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[72]));/*Actions[797]*/
            list[68].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[71]));/*Actions[798]*/
            // list[69]
            list[69].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[11]));/*Actions[799]*/
            list[69].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[11]));/*Actions[800]*/
            list[69].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[11]));/*Actions[801]*/
            list[69].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[11]));/*Actions[802]*/
            list[69].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[11]));/*Actions[803]*/
            list[69].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[11]));/*Actions[804]*/
            list[69].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[11]));/*Actions[805]*/
            list[69].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[11]));/*Actions[806]*/
            list[69].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[11]));/*Actions[807]*/
            list[69].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[11]));/*Actions[808]*/
            list[69].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[11]));/*Actions[809]*/
            list[69].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[11]));/*Actions[810]*/
            list[69].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[11]));/*Actions[811]*/
            list[69].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[11]));/*Actions[812]*/
            list[69].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[11]));/*Actions[813]*/
            list[69].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[11]));/*Actions[814]*/
            list[69].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[11]));/*Actions[815]*/
            list[69].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[11]));/*Actions[816]*/
            list[69].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[11]));/*Actions[817]*/
            list[69].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[11]));/*Actions[818]*/
            list[69].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[11]));/*Actions[819]*/
            list[69].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[11]));/*Actions[820]*/
            list[69].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[11]));/*Actions[821]*/
            list[69].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[11]));/*Actions[822]*/
            // list[70]
            list[70].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[69]));/*Actions[823]*/
            list[70].actionDict.Add(EType.IdList, new LR1GotoAction(syntaxStates[73]));/*Actions[824]*/
            // list[71]
            list[71].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[8]));/*Actions[825]*/
            list[71].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[8]));/*Actions[826]*/
            list[71].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[8]));/*Actions[827]*/
            list[71].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[8]));/*Actions[828]*/
            list[71].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[8]));/*Actions[829]*/
            list[71].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[8]));/*Actions[830]*/
            list[71].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[8]));/*Actions[831]*/
            list[71].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[8]));/*Actions[832]*/
            list[71].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[8]));/*Actions[833]*/
            list[71].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[8]));/*Actions[834]*/
            list[71].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[8]));/*Actions[835]*/
            list[71].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[8]));/*Actions[836]*/
            list[71].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[8]));/*Actions[837]*/
            list[71].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[8]));/*Actions[838]*/
            list[71].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[8]));/*Actions[839]*/
            list[71].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[8]));/*Actions[840]*/
            list[71].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[8]));/*Actions[841]*/
            list[71].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[8]));/*Actions[842]*/
            list[71].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[8]));/*Actions[843]*/
            list[71].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[8]));/*Actions[844]*/
            list[71].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[8]));/*Actions[845]*/
            list[71].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[8]));/*Actions[846]*/
            list[71].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[8]));/*Actions[847]*/
            list[71].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[8]));/*Actions[848]*/
            // list[72]
            list[72].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[74]));/*Actions[849]*/
            // list[73]
            list[73].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[72]));/*Actions[850]*/
            list[73].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[75]));/*Actions[851]*/
            // list[74]
            list[74].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[10]));/*Actions[852]*/
            list[74].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[10]));/*Actions[853]*/
            list[74].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[10]));/*Actions[854]*/
            list[74].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[10]));/*Actions[855]*/
            list[74].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[10]));/*Actions[856]*/
            list[74].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[10]));/*Actions[857]*/
            list[74].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[10]));/*Actions[858]*/
            list[74].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[10]));/*Actions[859]*/
            list[74].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[10]));/*Actions[860]*/
            list[74].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[10]));/*Actions[861]*/
            list[74].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[10]));/*Actions[862]*/
            list[74].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[10]));/*Actions[863]*/
            list[74].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[10]));/*Actions[864]*/
            list[74].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[10]));/*Actions[865]*/
            list[74].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[10]));/*Actions[866]*/
            list[74].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[10]));/*Actions[867]*/
            list[74].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[10]));/*Actions[868]*/
            list[74].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[10]));/*Actions[869]*/
            list[74].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[10]));/*Actions[870]*/
            list[74].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[10]));/*Actions[871]*/
            list[74].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[10]));/*Actions[872]*/
            list[74].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[10]));/*Actions[873]*/
            list[74].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[10]));/*Actions[874]*/
            list[74].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[10]));/*Actions[875]*/
            // list[75]
            list[75].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[6]));/*Actions[876]*/
            list[75].actionDict.Add(EType.STEP, new LR1ReducitonAction(regulations[6]));/*Actions[877]*/
            list[75].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[6]));/*Actions[878]*/
            list[75].actionDict.Add(EType.HEADER, new LR1ReducitonAction(regulations[6]));/*Actions[879]*/
            list[75].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[6]));/*Actions[880]*/
            list[75].actionDict.Add(EType.DATA, new LR1ReducitonAction(regulations[6]));/*Actions[881]*/
            list[75].actionDict.Add(EType.ENDSTEP, new LR1ReducitonAction(regulations[6]));/*Actions[882]*/
            list[75].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[6]));/*Actions[883]*/
            list[75].actionDict.Add(EType.Equal, new LR1ReducitonAction(regulations[6]));/*Actions[884]*/
            list[75].actionDict.Add(EType.SCOPE, new LR1ReducitonAction(regulations[6]));/*Actions[885]*/
            list[75].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[6]));/*Actions[886]*/
            list[75].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[6]));/*Actions[887]*/
            list[75].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[6]));/*Actions[888]*/
            list[75].actionDict.Add(EType.Identity, new LR1ReducitonAction(regulations[6]));/*Actions[889]*/
            list[75].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[6]));/*Actions[890]*/
            list[75].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[6]));/*Actions[891]*/
            list[75].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[6]));/*Actions[892]*/
            list[75].actionDict.Add(EType.Dollar, new LR1ReducitonAction(regulations[6]));/*Actions[893]*/
            list[75].actionDict.Add(EType.Asterisk, new LR1ReducitonAction(regulations[6]));/*Actions[894]*/
            list[75].actionDict.Add(EType.String, new LR1ReducitonAction(regulations[6]));/*Actions[895]*/
            list[75].actionDict.Add(EType.Integer, new LR1ReducitonAction(regulations[6]));/*Actions[896]*/
            list[75].actionDict.Add(EType.Float, new LR1ReducitonAction(regulations[6]));/*Actions[897]*/
            list[75].actionDict.Add(EType.Hexadecimal, new LR1ReducitonAction(regulations[6]));/*Actions[898]*/
            list[75].actionDict.Add(EType.Enum, new LR1ReducitonAction(regulations[6]));/*Actions[899]*/

        }
    }
}
