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
        const int syntaxStateCount = 97;
        // NOTE: choose only one from CompilerStep.TableLR0.cs, CompilerStep.TableSLR.cs, CompilerStep.TableLALR1.cs, CompilerStep.TableLR1.cs
        /// <summary>
        /// LR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        private static void InitializeSyntaxStates()
        {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++)
            {
                list[i] = new SyntaxState($"{nameof(CompilerStep)}.syntaxStates[i]");
            }
            // 238 actions. 0 conflicts.
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
            list[5].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[8]));/*Actions[6]*/
            list[5].actionDict.Add(EType.HeadLine, new LR1GotoAction(syntaxStates[7]));/*Actions[7]*/
            list[5].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[8]*/
            list[5].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[9]));/*Actions[9]*/
            // list[6]
            list[6].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[11]));/*Actions[10]*/
            list[6].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[10]));/*Actions[11]*/
            // list[7]
            list[7].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[13]));/*Actions[12]*/
            list[7].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[13]*/
            list[7].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[12]));/*Actions[14]*/
            // list[8]
            list[8].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[14]));/*Actions[15]*/
            // list[9]
            list[9].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[15]));/*Actions[16]*/
            // list[10]
            list[10].actionDict.Add(EType.Float, new LR1ShiftInAction(syntaxStates[21]));/*Actions[17]*/
            list[10].actionDict.Add(EType.Hexadecimal, new LR1ShiftInAction(syntaxStates[30]));/*Actions[18]*/
            list[10].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[26]));/*Actions[19]*/
            list[10].actionDict.Add(EType.Args, new LR1GotoAction(syntaxStates[20]));/*Actions[20]*/
            list[10].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[29]));/*Actions[21]*/
            list[10].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[28]));/*Actions[22]*/
            list[10].actionDict.Add(EType.Enum, new LR1ShiftInAction(syntaxStates[18]));/*Actions[23]*/
            list[10].actionDict.Add(EType.Dollar, new LR1ShiftInAction(syntaxStates[24]));/*Actions[24]*/
            list[10].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[16]));/*Actions[25]*/
            list[10].actionDict.Add(EType.String, new LR1ShiftInAction(syntaxStates[25]));/*Actions[26]*/
            list[10].actionDict.Add(EType.Asterisk, new LR1ShiftInAction(syntaxStates[23]));/*Actions[27]*/
            list[10].actionDict.Add(EType.Arg, new LR1GotoAction(syntaxStates[17]));/*Actions[28]*/
            list[10].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[19]));/*Actions[29]*/
            list[10].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[27]));/*Actions[30]*/
            list[10].actionDict.Add(EType.Integer, new LR1ShiftInAction(syntaxStates[22]));/*Actions[31]*/
            // list[11]
            list[11].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[14]));/*Actions[32]*/
            // list[12]
            list[12].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[31]));/*Actions[33]*/
            // list[13]
            list[13].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[32]));/*Actions[34]*/
            // list[14]
            list[14].actionDict.Add(EType.DATA, new LR1ShiftInAction(syntaxStates[33]));/*Actions[35]*/
            // list[15]
            list[15].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[18]));/*Actions[36]*/
            list[15].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[18]));/*Actions[37]*/
            // list[16]
            list[16].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[31]));/*Actions[38]*/
            list[16].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[31]));/*Actions[39]*/
            // list[17]
            list[17].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[22]));/*Actions[40]*/
            list[17].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[22]));/*Actions[41]*/
            // list[18]
            list[18].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[30]));/*Actions[42]*/
            list[18].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[30]));/*Actions[43]*/
            // list[19]
            list[19].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[28]));/*Actions[44]*/
            list[19].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[34]));/*Actions[45]*/
            // list[20]
            list[20].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[36]));/*Actions[46]*/
            list[20].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[35]));/*Actions[47]*/
            // list[21]
            list[21].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[28]));/*Actions[48]*/
            list[21].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[28]));/*Actions[49]*/
            // list[22]
            list[22].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[27]));/*Actions[50]*/
            list[22].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[27]));/*Actions[51]*/
            // list[23]
            list[23].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[25]));/*Actions[52]*/
            list[23].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[25]));/*Actions[53]*/
            // list[24]
            list[24].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[24]));/*Actions[54]*/
            list[24].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[24]));/*Actions[55]*/
            // list[25]
            list[25].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[26]));/*Actions[56]*/
            list[25].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[26]));/*Actions[57]*/
            // list[26]
            list[26].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[32]));/*Actions[58]*/
            list[26].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[32]));/*Actions[59]*/
            // list[27]
            list[27].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[20]));/*Actions[60]*/
            // list[28]
            list[28].actionDict.Add(EType.Arg, new LR1GotoAction(syntaxStates[17]));/*Actions[61]*/
            list[28].actionDict.Add(EType.Dollar, new LR1ShiftInAction(syntaxStates[24]));/*Actions[62]*/
            list[28].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[19]));/*Actions[63]*/
            list[28].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[29]));/*Actions[64]*/
            list[28].actionDict.Add(EType.String, new LR1ShiftInAction(syntaxStates[25]));/*Actions[65]*/
            list[28].actionDict.Add(EType.Integer, new LR1ShiftInAction(syntaxStates[22]));/*Actions[66]*/
            list[28].actionDict.Add(EType.Hexadecimal, new LR1ShiftInAction(syntaxStates[30]));/*Actions[67]*/
            list[28].actionDict.Add(EType.Args, new LR1GotoAction(syntaxStates[37]));/*Actions[68]*/
            list[28].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[16]));/*Actions[69]*/
            list[28].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[26]));/*Actions[70]*/
            list[28].actionDict.Add(EType.Enum, new LR1ShiftInAction(syntaxStates[18]));/*Actions[71]*/
            list[28].actionDict.Add(EType.Asterisk, new LR1ShiftInAction(syntaxStates[23]));/*Actions[72]*/
            list[28].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[28]));/*Actions[73]*/
            list[28].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[38]));/*Actions[74]*/
            list[28].actionDict.Add(EType.Float, new LR1ShiftInAction(syntaxStates[21]));/*Actions[75]*/
            // list[29]
            list[29].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[23]));/*Actions[76]*/
            list[29].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[23]));/*Actions[77]*/
            // list[30]
            list[30].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[29]));/*Actions[78]*/
            list[30].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[29]));/*Actions[79]*/
            // list[31]
            list[31].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[17]));/*Actions[80]*/
            list[31].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[17]));/*Actions[81]*/
            // list[32]
            list[32].actionDict.Add(EType.DATA, new LR1ShiftInAction(syntaxStates[39]));/*Actions[82]*/
            // list[33]
            list[33].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[40]));/*Actions[83]*/
            // list[34]
            list[34].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[14]));/*Actions[84]*/
            list[34].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[14]));/*Actions[85]*/
            // list[35]
            list[35].actionDict.Add(EType.Float, new LR1ShiftInAction(syntaxStates[21]));/*Actions[86]*/
            list[35].actionDict.Add(EType.Dollar, new LR1ShiftInAction(syntaxStates[24]));/*Actions[87]*/
            list[35].actionDict.Add(EType.Asterisk, new LR1ShiftInAction(syntaxStates[23]));/*Actions[88]*/
            list[35].actionDict.Add(EType.Hexadecimal, new LR1ShiftInAction(syntaxStates[30]));/*Actions[89]*/
            list[35].actionDict.Add(EType.Arg, new LR1GotoAction(syntaxStates[41]));/*Actions[90]*/
            list[35].actionDict.Add(EType.Enum, new LR1ShiftInAction(syntaxStates[18]));/*Actions[91]*/
            list[35].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[16]));/*Actions[92]*/
            list[35].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[29]));/*Actions[93]*/
            list[35].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[28]));/*Actions[94]*/
            list[35].actionDict.Add(EType.String, new LR1ShiftInAction(syntaxStates[25]));/*Actions[95]*/
            list[35].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[19]));/*Actions[96]*/
            list[35].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[26]));/*Actions[97]*/
            list[35].actionDict.Add(EType.Integer, new LR1ShiftInAction(syntaxStates[22]));/*Actions[98]*/
            // list[36]
            list[36].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[19]));/*Actions[99]*/
            // list[37]
            list[37].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[35]));/*Actions[100]*/
            list[37].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[42]));/*Actions[101]*/
            // list[38]
            list[38].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[20]));/*Actions[102]*/
            list[38].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[20]));/*Actions[103]*/
            // list[39]
            list[39].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[43]));/*Actions[104]*/
            // list[40]
            list[40].actionDict.Add(EType.Model, new LR1GotoAction(syntaxStates[45]));/*Actions[105]*/
            list[40].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[44]));/*Actions[106]*/
            list[40].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[46]));/*Actions[107]*/
            // list[41]
            list[41].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[21]));/*Actions[108]*/
            list[41].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[21]));/*Actions[109]*/
            // list[42]
            list[42].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[19]));/*Actions[110]*/
            list[42].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[19]));/*Actions[111]*/
            // list[43]
            list[43].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[44]));/*Actions[112]*/
            list[43].actionDict.Add(EType.Model, new LR1GotoAction(syntaxStates[47]));/*Actions[113]*/
            list[43].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[46]));/*Actions[114]*/
            // list[44]
            list[44].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[2]));/*Actions[115]*/
            list[44].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[2]));/*Actions[116]*/
            // list[45]
            list[45].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[46]));/*Actions[117]*/
            list[45].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[48]));/*Actions[118]*/
            list[45].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[49]));/*Actions[119]*/
            // list[46]
            list[46].actionDict.Add(EType.Equal, new LR1ShiftInAction(syntaxStates[50]));/*Actions[120]*/
            // list[47]
            list[47].actionDict.Add(EType.ENDSEC, new LR1ShiftInAction(syntaxStates[51]));/*Actions[121]*/
            list[47].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[48]));/*Actions[122]*/
            list[47].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[46]));/*Actions[123]*/
            // list[48]
            list[48].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[3]));/*Actions[124]*/
            list[48].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[3]));/*Actions[125]*/
            // list[49]
            list[49].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[52]));/*Actions[126]*/
            // list[50]
            list[50].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[56]));/*Actions[127]*/
            list[50].actionDict.Add(EType.ScopeBlock, new LR1GotoAction(syntaxStates[54]));/*Actions[128]*/
            list[50].actionDict.Add(EType.EntityBody, new LR1GotoAction(syntaxStates[57]));/*Actions[129]*/
            list[50].actionDict.Add(EType.SCOPE, new LR1ShiftInAction(syntaxStates[53]));/*Actions[130]*/
            list[50].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[131]*/
            list[50].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[55]));/*Actions[132]*/
            // list[51]
            list[51].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[58]));/*Actions[133]*/
            // list[52]
            list[52].actionDict.Add(EType.ENDSTEP, new LR1ShiftInAction(syntaxStates[59]));/*Actions[134]*/
            // list[53]
            list[53].actionDict.Add(EType.ENDSCOPE, new LR1ShiftInAction(syntaxStates[60]));/*Actions[135]*/
            list[53].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[63]));/*Actions[136]*/
            list[53].actionDict.Add(EType.Model, new LR1GotoAction(syntaxStates[61]));/*Actions[137]*/
            list[53].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[62]));/*Actions[138]*/
            // list[54]
            list[54].actionDict.Add(EType.EntityBody, new LR1GotoAction(syntaxStates[64]));/*Actions[139]*/
            list[54].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[140]*/
            list[54].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[55]));/*Actions[141]*/
            list[54].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[56]));/*Actions[142]*/
            // list[55]
            list[55].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[66]));/*Actions[143]*/
            list[55].actionDict.Add(EType.Complex, new LR1GotoAction(syntaxStates[67]));/*Actions[144]*/
            list[55].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[65]));/*Actions[145]*/
            // list[56]
            list[56].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[12]));/*Actions[146]*/
            // list[57]
            list[57].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[68]));/*Actions[147]*/
            // list[58]
            list[58].actionDict.Add(EType.ENDSTEP, new LR1ShiftInAction(syntaxStates[69]));/*Actions[148]*/
            // list[59]
            list[59].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[70]));/*Actions[149]*/
            // list[60]
            list[60].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[71]));/*Actions[150]*/
            list[60].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[9]));/*Actions[151]*/
            list[60].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[9]));/*Actions[152]*/
            // list[61]
            list[61].actionDict.Add(EType.ENDSCOPE, new LR1ShiftInAction(syntaxStates[73]));/*Actions[153]*/
            list[61].actionDict.Add(EType.Entity, new LR1GotoAction(syntaxStates[72]));/*Actions[154]*/
            list[61].actionDict.Add(EType.EntityId, new LR1ShiftInAction(syntaxStates[63]));/*Actions[155]*/
            // list[62]
            list[62].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[2]));/*Actions[156]*/
            list[62].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[2]));/*Actions[157]*/
            // list[63]
            list[63].actionDict.Add(EType.Equal, new LR1ShiftInAction(syntaxStates[74]));/*Actions[158]*/
            // list[64]
            list[64].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[75]));/*Actions[159]*/
            // list[65]
            list[65].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[77]));/*Actions[160]*/
            list[65].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[76]));/*Actions[161]*/
            // list[66]
            list[66].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[16]));/*Actions[162]*/
            list[66].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[16]));/*Actions[163]*/
            // list[67]
            list[67].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[79]));/*Actions[164]*/
            list[67].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[65]));/*Actions[165]*/
            list[67].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[78]));/*Actions[166]*/
            // list[68]
            list[68].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[5]));/*Actions[167]*/
            list[68].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[5]));/*Actions[168]*/
            // list[69]
            list[69].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[80]));/*Actions[169]*/
            // list[70]
            list[70].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[1]));/*Actions[170]*/
            // list[71]
            list[71].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[82]));/*Actions[171]*/
            list[71].actionDict.Add(EType.IdList, new LR1GotoAction(syntaxStates[81]));/*Actions[172]*/
            // list[72]
            list[72].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[3]));/*Actions[173]*/
            list[72].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[3]));/*Actions[174]*/
            // list[73]
            list[73].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[83]));/*Actions[175]*/
            list[73].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[7]));/*Actions[176]*/
            list[73].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[7]));/*Actions[177]*/
            // list[74]
            list[74].actionDict.Add(EType.EntityBody, new LR1GotoAction(syntaxStates[85]));/*Actions[178]*/
            list[74].actionDict.Add(EType.ScopeBlock, new LR1GotoAction(syntaxStates[84]));/*Actions[179]*/
            list[74].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[180]*/
            list[74].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[56]));/*Actions[181]*/
            list[74].actionDict.Add(EType.SCOPE, new LR1ShiftInAction(syntaxStates[53]));/*Actions[182]*/
            list[74].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[55]));/*Actions[183]*/
            // list[75]
            list[75].actionDict.Add(EType.ENDSEC, new LR1ReducitonAction(regulations[4]));/*Actions[184]*/
            list[75].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[4]));/*Actions[185]*/
            // list[76]
            list[76].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[87]));/*Actions[186]*/
            list[76].actionDict.Add(EType.Integer, new LR1ShiftInAction(syntaxStates[22]));/*Actions[187]*/
            list[76].actionDict.Add(EType.Args, new LR1GotoAction(syntaxStates[86]));/*Actions[188]*/
            list[76].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[26]));/*Actions[189]*/
            list[76].actionDict.Add(EType.Enum, new LR1ShiftInAction(syntaxStates[18]));/*Actions[190]*/
            list[76].actionDict.Add(EType.Asterisk, new LR1ShiftInAction(syntaxStates[23]));/*Actions[191]*/
            list[76].actionDict.Add(EType.Float, new LR1ShiftInAction(syntaxStates[21]));/*Actions[192]*/
            list[76].actionDict.Add(EType.Arg, new LR1GotoAction(syntaxStates[17]));/*Actions[193]*/
            list[76].actionDict.Add(EType.Dollar, new LR1ShiftInAction(syntaxStates[24]));/*Actions[194]*/
            list[76].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[29]));/*Actions[195]*/
            list[76].actionDict.Add(EType.String, new LR1ShiftInAction(syntaxStates[25]));/*Actions[196]*/
            list[76].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[19]));/*Actions[197]*/
            list[76].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[28]));/*Actions[198]*/
            list[76].actionDict.Add(EType.LArgsJ, new LR1GotoAction(syntaxStates[16]));/*Actions[199]*/
            list[76].actionDict.Add(EType.Hexadecimal, new LR1ShiftInAction(syntaxStates[30]));/*Actions[200]*/
            // list[77]
            list[77].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[14]));/*Actions[201]*/
            list[77].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[14]));/*Actions[202]*/
            // list[78]
            list[78].actionDict.Add(EType.Semicolon, new LR1ReducitonAction(regulations[13]));/*Actions[203]*/
            // list[79]
            list[79].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[15]));/*Actions[204]*/
            list[79].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[15]));/*Actions[205]*/
            // list[80]
            list[80].actionDict.Add(EType.EndOfTokenList, new LR1ReducitonAction(regulations[0]));/*Actions[206]*/
            // list[81]
            list[81].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[88]));/*Actions[207]*/
            list[81].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[89]));/*Actions[208]*/
            // list[82]
            list[82].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[11]));/*Actions[209]*/
            list[82].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[11]));/*Actions[210]*/
            // list[83]
            list[83].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[82]));/*Actions[211]*/
            list[83].actionDict.Add(EType.IdList, new LR1GotoAction(syntaxStates[90]));/*Actions[212]*/
            // list[84]
            list[84].actionDict.Add(EType.LeftParenthesis, new LR1ShiftInAction(syntaxStates[55]));/*Actions[213]*/
            list[84].actionDict.Add(EType.TypeName, new LR1ShiftInAction(syntaxStates[6]));/*Actions[214]*/
            list[84].actionDict.Add(EType.TypeObj, new LR1GotoAction(syntaxStates[56]));/*Actions[215]*/
            list[84].actionDict.Add(EType.EntityBody, new LR1GotoAction(syntaxStates[91]));/*Actions[216]*/
            // list[85]
            list[85].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[92]));/*Actions[217]*/
            // list[86]
            list[86].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[35]));/*Actions[218]*/
            list[86].actionDict.Add(EType.RightParenthesis, new LR1ShiftInAction(syntaxStates[93]));/*Actions[219]*/
            // list[87]
            list[87].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[20]));/*Actions[220]*/
            list[87].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[20]));/*Actions[221]*/
            // list[88]
            list[88].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[8]));/*Actions[222]*/
            list[88].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[8]));/*Actions[223]*/
            // list[89]
            list[89].actionDict.Add(EType.Identity, new LR1ShiftInAction(syntaxStates[94]));/*Actions[224]*/
            // list[90]
            list[90].actionDict.Add(EType.Comma, new LR1ShiftInAction(syntaxStates[89]));/*Actions[225]*/
            list[90].actionDict.Add(EType.Slash, new LR1ShiftInAction(syntaxStates[95]));/*Actions[226]*/
            // list[91]
            list[91].actionDict.Add(EType.Semicolon, new LR1ShiftInAction(syntaxStates[96]));/*Actions[227]*/
            // list[92]
            list[92].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[5]));/*Actions[228]*/
            list[92].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[5]));/*Actions[229]*/
            // list[93]
            list[93].actionDict.Add(EType.RightParenthesis, new LR1ReducitonAction(regulations[19]));/*Actions[230]*/
            list[93].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[19]));/*Actions[231]*/
            // list[94]
            list[94].actionDict.Add(EType.Comma, new LR1ReducitonAction(regulations[10]));/*Actions[232]*/
            list[94].actionDict.Add(EType.Slash, new LR1ReducitonAction(regulations[10]));/*Actions[233]*/
            // list[95]
            list[95].actionDict.Add(EType.LeftParenthesis, new LR1ReducitonAction(regulations[6]));/*Actions[234]*/
            list[95].actionDict.Add(EType.TypeName, new LR1ReducitonAction(regulations[6]));/*Actions[235]*/
            // list[96]
            list[96].actionDict.Add(EType.ENDSCOPE, new LR1ReducitonAction(regulations[4]));/*Actions[236]*/
            list[96].actionDict.Add(EType.EntityId, new LR1ReducitonAction(regulations[4]));/*Actions[237]*/

        }
    }
}
