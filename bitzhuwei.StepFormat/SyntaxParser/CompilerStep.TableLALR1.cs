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
        /// LALR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        private static void InitializeSyntaxStates()
        {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++)
            {
                list[i] = new SyntaxState($"{nameof(CompilerStep)}.syntaxStates[i]");
            }
            // 180 actions. 0 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.StepFile, new LRGotoAction(syntaxStates[2]));/*Actions[0]*/
            list[0].actionDict.Add(EType.STEP, new LRShiftInAction(syntaxStates[1]));/*Actions[1]*/
            // list[1]
            list[1].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            // list[2]
            list[2].actionDict.Add(EType.EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[3]*/
            // list[3]
            list[3].actionDict.Add(EType.HEADER, new LRShiftInAction(syntaxStates[4]));/*Actions[4]*/
            // list[4]
            list[4].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[5]));/*Actions[5]*/
            // list[5]
            list[5].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[9]));/*Actions[6]*/
            list[5].actionDict.Add(EType.HeadLine, new LRGotoAction(syntaxStates[7]));/*Actions[7]*/
            list[5].actionDict.Add(EType.ENDSEC, new LRShiftInAction(syntaxStates[8]));/*Actions[8]*/
            list[5].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[9]*/
            // list[6]
            list[6].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[10]*/
            list[6].actionDict.Add(EType.LArgsJ, new LRGotoAction(syntaxStates[11]));/*Actions[11]*/
            // list[7]
            list[7].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[12]));/*Actions[12]*/
            list[7].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[13]*/
            list[7].actionDict.Add(EType.ENDSEC, new LRShiftInAction(syntaxStates[13]));/*Actions[14]*/
            // list[8]
            list[8].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[14]));/*Actions[15]*/
            // list[9]
            list[9].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[15]));/*Actions[16]*/
            // list[10]
            list[10].actionDict.Add(EType.Asterisk, new LRShiftInAction(syntaxStates[22]));/*Actions[17]*/
            list[10].actionDict.Add(EType.Dollar, new LRShiftInAction(syntaxStates[23]));/*Actions[18]*/
            list[10].actionDict.Add(EType.Identity, new LRShiftInAction(syntaxStates[27]));/*Actions[19]*/
            list[10].actionDict.Add(EType.LArgsJ, new LRGotoAction(syntaxStates[16]));/*Actions[20]*/
            list[10].actionDict.Add(EType.Arg, new LRGotoAction(syntaxStates[17]));/*Actions[21]*/
            list[10].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[20]));/*Actions[22]*/
            list[10].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[23]*/
            list[10].actionDict.Add(EType.Integer, new LRShiftInAction(syntaxStates[21]));/*Actions[24]*/
            list[10].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[25]));/*Actions[25]*/
            list[10].actionDict.Add(EType.RightParenthesis, new LRShiftInAction(syntaxStates[26]));/*Actions[26]*/
            list[10].actionDict.Add(EType.Args, new LRGotoAction(syntaxStates[19]));/*Actions[27]*/
            list[10].actionDict.Add(EType.String, new LRShiftInAction(syntaxStates[24]));/*Actions[28]*/
            list[10].actionDict.Add(EType.Enum, new LRShiftInAction(syntaxStates[18]));/*Actions[29]*/
            list[10].actionDict.Add(EType.Hexadecimal, new LRShiftInAction(syntaxStates[28]));/*Actions[30]*/
            list[10].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[31]*/
            // list[11]
            list[11].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[14]));/*Actions[32]*/
            list[11].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[14]));/*Actions[33]*/
            list[11].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[14]));/*Actions[34]*/
            list[11].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[14]));/*Actions[35]*/
            // list[12]
            list[12].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[29]));/*Actions[36]*/
            // list[13]
            list[13].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[30]));/*Actions[37]*/
            // list[14]
            list[14].actionDict.Add(EType.DATA, new LRShiftInAction(syntaxStates[31]));/*Actions[38]*/
            // list[15]
            list[15].actionDict.Add(EType.ENDSEC, new LRReducitonAction(regulations[18]));/*Actions[39]*/
            list[15].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[18]));/*Actions[40]*/
            // list[16]
            list[16].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[31]));/*Actions[41]*/
            list[16].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[31]));/*Actions[42]*/
            // list[17]
            list[17].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[22]));/*Actions[43]*/
            list[17].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[22]));/*Actions[44]*/
            // list[18]
            list[18].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[30]));/*Actions[45]*/
            list[18].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[30]));/*Actions[46]*/
            // list[19]
            list[19].actionDict.Add(EType.Comma, new LRShiftInAction(syntaxStates[32]));/*Actions[47]*/
            list[19].actionDict.Add(EType.RightParenthesis, new LRShiftInAction(syntaxStates[33]));/*Actions[48]*/
            // list[20]
            list[20].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[28]));/*Actions[49]*/
            list[20].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[28]));/*Actions[50]*/
            // list[21]
            list[21].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[27]));/*Actions[51]*/
            list[21].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[27]));/*Actions[52]*/
            // list[22]
            list[22].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[25]));/*Actions[53]*/
            list[22].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[25]));/*Actions[54]*/
            // list[23]
            list[23].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[24]));/*Actions[55]*/
            list[23].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[24]));/*Actions[56]*/
            // list[24]
            list[24].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[26]));/*Actions[57]*/
            list[24].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[26]));/*Actions[58]*/
            // list[25]
            list[25].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[32]));/*Actions[59]*/
            list[25].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[32]));/*Actions[60]*/
            // list[26]
            list[26].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[20]));/*Actions[61]*/
            list[26].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[20]));/*Actions[62]*/
            list[26].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[20]));/*Actions[63]*/
            list[26].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[20]));/*Actions[64]*/
            // list[27]
            list[27].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[23]));/*Actions[65]*/
            list[27].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[23]));/*Actions[66]*/
            // list[28]
            list[28].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[29]));/*Actions[67]*/
            list[28].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[29]));/*Actions[68]*/
            // list[29]
            list[29].actionDict.Add(EType.ENDSEC, new LRReducitonAction(regulations[17]));/*Actions[69]*/
            list[29].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[17]));/*Actions[70]*/
            // list[30]
            list[30].actionDict.Add(EType.DATA, new LRShiftInAction(syntaxStates[34]));/*Actions[71]*/
            // list[31]
            list[31].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[35]));/*Actions[72]*/
            // list[32]
            list[32].actionDict.Add(EType.Integer, new LRShiftInAction(syntaxStates[21]));/*Actions[73]*/
            list[32].actionDict.Add(EType.LArgsJ, new LRGotoAction(syntaxStates[16]));/*Actions[74]*/
            list[32].actionDict.Add(EType.Asterisk, new LRShiftInAction(syntaxStates[22]));/*Actions[75]*/
            list[32].actionDict.Add(EType.Dollar, new LRShiftInAction(syntaxStates[23]));/*Actions[76]*/
            list[32].actionDict.Add(EType.Identity, new LRShiftInAction(syntaxStates[27]));/*Actions[77]*/
            list[32].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[78]*/
            list[32].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[20]));/*Actions[79]*/
            list[32].actionDict.Add(EType.Hexadecimal, new LRShiftInAction(syntaxStates[28]));/*Actions[80]*/
            list[32].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[25]));/*Actions[81]*/
            list[32].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[82]*/
            list[32].actionDict.Add(EType.String, new LRShiftInAction(syntaxStates[24]));/*Actions[83]*/
            list[32].actionDict.Add(EType.Arg, new LRGotoAction(syntaxStates[36]));/*Actions[84]*/
            list[32].actionDict.Add(EType.Enum, new LRShiftInAction(syntaxStates[18]));/*Actions[85]*/
            // list[33]
            list[33].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[19]));/*Actions[86]*/
            list[33].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[19]));/*Actions[87]*/
            list[33].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[19]));/*Actions[88]*/
            list[33].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[19]));/*Actions[89]*/
            // list[34]
            list[34].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[37]));/*Actions[90]*/
            // list[35]
            list[35].actionDict.Add(EType.Model, new LRGotoAction(syntaxStates[39]));/*Actions[91]*/
            list[35].actionDict.Add(EType.Entity, new LRGotoAction(syntaxStates[38]));/*Actions[92]*/
            list[35].actionDict.Add(EType.EntityId, new LRShiftInAction(syntaxStates[40]));/*Actions[93]*/
            // list[36]
            list[36].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[21]));/*Actions[94]*/
            list[36].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[21]));/*Actions[95]*/
            // list[37]
            list[37].actionDict.Add(EType.Entity, new LRGotoAction(syntaxStates[38]));/*Actions[96]*/
            list[37].actionDict.Add(EType.EntityId, new LRShiftInAction(syntaxStates[40]));/*Actions[97]*/
            list[37].actionDict.Add(EType.Model, new LRGotoAction(syntaxStates[41]));/*Actions[98]*/
            // list[38]
            list[38].actionDict.Add(EType.ENDSCOPE, new LRReducitonAction(regulations[2]));/*Actions[99]*/
            list[38].actionDict.Add(EType.ENDSEC, new LRReducitonAction(regulations[2]));/*Actions[100]*/
            list[38].actionDict.Add(EType.EntityId, new LRReducitonAction(regulations[2]));/*Actions[101]*/
            // list[39]
            list[39].actionDict.Add(EType.Entity, new LRGotoAction(syntaxStates[42]));/*Actions[102]*/
            list[39].actionDict.Add(EType.ENDSEC, new LRShiftInAction(syntaxStates[43]));/*Actions[103]*/
            list[39].actionDict.Add(EType.EntityId, new LRShiftInAction(syntaxStates[40]));/*Actions[104]*/
            // list[40]
            list[40].actionDict.Add(EType.Equal, new LRShiftInAction(syntaxStates[44]));/*Actions[105]*/
            // list[41]
            list[41].actionDict.Add(EType.EntityId, new LRShiftInAction(syntaxStates[40]));/*Actions[106]*/
            list[41].actionDict.Add(EType.Entity, new LRGotoAction(syntaxStates[42]));/*Actions[107]*/
            list[41].actionDict.Add(EType.ENDSEC, new LRShiftInAction(syntaxStates[45]));/*Actions[108]*/
            // list[42]
            list[42].actionDict.Add(EType.ENDSCOPE, new LRReducitonAction(regulations[3]));/*Actions[109]*/
            list[42].actionDict.Add(EType.ENDSEC, new LRReducitonAction(regulations[3]));/*Actions[110]*/
            list[42].actionDict.Add(EType.EntityId, new LRReducitonAction(regulations[3]));/*Actions[111]*/
            // list[43]
            list[43].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[46]));/*Actions[112]*/
            // list[44]
            list[44].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[50]));/*Actions[113]*/
            list[44].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[114]*/
            list[44].actionDict.Add(EType.SCOPE, new LRShiftInAction(syntaxStates[47]));/*Actions[115]*/
            list[44].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[49]));/*Actions[116]*/
            list[44].actionDict.Add(EType.EntityBody, new LRGotoAction(syntaxStates[51]));/*Actions[117]*/
            list[44].actionDict.Add(EType.ScopeBlock, new LRGotoAction(syntaxStates[48]));/*Actions[118]*/
            // list[45]
            list[45].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[52]));/*Actions[119]*/
            // list[46]
            list[46].actionDict.Add(EType.ENDSTEP, new LRShiftInAction(syntaxStates[53]));/*Actions[120]*/
            // list[47]
            list[47].actionDict.Add(EType.EntityId, new LRShiftInAction(syntaxStates[40]));/*Actions[121]*/
            list[47].actionDict.Add(EType.Entity, new LRGotoAction(syntaxStates[38]));/*Actions[122]*/
            list[47].actionDict.Add(EType.ENDSCOPE, new LRShiftInAction(syntaxStates[54]));/*Actions[123]*/
            list[47].actionDict.Add(EType.Model, new LRGotoAction(syntaxStates[55]));/*Actions[124]*/
            // list[48]
            list[48].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[50]));/*Actions[125]*/
            list[48].actionDict.Add(EType.LeftParenthesis, new LRShiftInAction(syntaxStates[49]));/*Actions[126]*/
            list[48].actionDict.Add(EType.EntityBody, new LRGotoAction(syntaxStates[56]));/*Actions[127]*/
            list[48].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[128]*/
            // list[49]
            list[49].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[129]*/
            list[49].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[57]));/*Actions[130]*/
            list[49].actionDict.Add(EType.Complex, new LRGotoAction(syntaxStates[58]));/*Actions[131]*/
            // list[50]
            list[50].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[12]));/*Actions[132]*/
            // list[51]
            list[51].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[59]));/*Actions[133]*/
            // list[52]
            list[52].actionDict.Add(EType.ENDSTEP, new LRShiftInAction(syntaxStates[60]));/*Actions[134]*/
            // list[53]
            list[53].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[61]));/*Actions[135]*/
            // list[54]
            list[54].actionDict.Add(EType.Slash, new LRShiftInAction(syntaxStates[62]));/*Actions[136]*/
            list[54].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[137]*/
            list[54].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[9]));/*Actions[138]*/
            // list[55]
            list[55].actionDict.Add(EType.ENDSCOPE, new LRShiftInAction(syntaxStates[63]));/*Actions[139]*/
            list[55].actionDict.Add(EType.Entity, new LRGotoAction(syntaxStates[42]));/*Actions[140]*/
            list[55].actionDict.Add(EType.EntityId, new LRShiftInAction(syntaxStates[40]));/*Actions[141]*/
            // list[56]
            list[56].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[64]));/*Actions[142]*/
            // list[57]
            list[57].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[16]));/*Actions[143]*/
            list[57].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[16]));/*Actions[144]*/
            // list[58]
            list[58].actionDict.Add(EType.RightParenthesis, new LRShiftInAction(syntaxStates[65]));/*Actions[145]*/
            list[58].actionDict.Add(EType.TypeObj, new LRGotoAction(syntaxStates[66]));/*Actions[146]*/
            list[58].actionDict.Add(EType.TypeName, new LRShiftInAction(syntaxStates[6]));/*Actions[147]*/
            // list[59]
            list[59].actionDict.Add(EType.ENDSCOPE, new LRReducitonAction(regulations[5]));/*Actions[148]*/
            list[59].actionDict.Add(EType.ENDSEC, new LRReducitonAction(regulations[5]));/*Actions[149]*/
            list[59].actionDict.Add(EType.EntityId, new LRReducitonAction(regulations[5]));/*Actions[150]*/
            // list[60]
            list[60].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[67]));/*Actions[151]*/
            // list[61]
            list[61].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[152]*/
            // list[62]
            list[62].actionDict.Add(EType.IdList, new LRGotoAction(syntaxStates[68]));/*Actions[153]*/
            list[62].actionDict.Add(EType.Identity, new LRShiftInAction(syntaxStates[69]));/*Actions[154]*/
            // list[63]
            list[63].actionDict.Add(EType.Slash, new LRShiftInAction(syntaxStates[70]));/*Actions[155]*/
            list[63].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[156]*/
            list[63].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[7]));/*Actions[157]*/
            // list[64]
            list[64].actionDict.Add(EType.ENDSCOPE, new LRReducitonAction(regulations[4]));/*Actions[158]*/
            list[64].actionDict.Add(EType.ENDSEC, new LRReducitonAction(regulations[4]));/*Actions[159]*/
            list[64].actionDict.Add(EType.EntityId, new LRReducitonAction(regulations[4]));/*Actions[160]*/
            // list[65]
            list[65].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[13]));/*Actions[161]*/
            // list[66]
            list[66].actionDict.Add(EType.RightParenthesis, new LRReducitonAction(regulations[15]));/*Actions[162]*/
            list[66].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[15]));/*Actions[163]*/
            // list[67]
            list[67].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[164]*/
            // list[68]
            list[68].actionDict.Add(EType.Slash, new LRShiftInAction(syntaxStates[71]));/*Actions[165]*/
            list[68].actionDict.Add(EType.Comma, new LRShiftInAction(syntaxStates[72]));/*Actions[166]*/
            // list[69]
            list[69].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[11]));/*Actions[167]*/
            list[69].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[11]));/*Actions[168]*/
            // list[70]
            list[70].actionDict.Add(EType.Identity, new LRShiftInAction(syntaxStates[69]));/*Actions[169]*/
            list[70].actionDict.Add(EType.IdList, new LRGotoAction(syntaxStates[73]));/*Actions[170]*/
            // list[71]
            list[71].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[171]*/
            list[71].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[8]));/*Actions[172]*/
            // list[72]
            list[72].actionDict.Add(EType.Identity, new LRShiftInAction(syntaxStates[74]));/*Actions[173]*/
            // list[73]
            list[73].actionDict.Add(EType.Comma, new LRShiftInAction(syntaxStates[72]));/*Actions[174]*/
            list[73].actionDict.Add(EType.Slash, new LRShiftInAction(syntaxStates[75]));/*Actions[175]*/
            // list[74]
            list[74].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[10]));/*Actions[176]*/
            list[74].actionDict.Add(EType.Slash, new LRReducitonAction(regulations[10]));/*Actions[177]*/
            // list[75]
            list[75].actionDict.Add(EType.LeftParenthesis, new LRReducitonAction(regulations[6]));/*Actions[178]*/
            list[75].actionDict.Add(EType.TypeName, new LRReducitonAction(regulations[6]));/*Actions[179]*/

        }
    }
}
