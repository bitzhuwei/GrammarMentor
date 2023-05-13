using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        const int syntaxStateCount = 67;
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        private static void InitializeSyntaxStates()
        {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++)
            {
                list[i] = new SyntaxState($"{nameof(CompilerWRL)}syntaxStates[{i}]");
            }
            // TODO: add LR1Item to comment.
            // list[0]
            list[0].actionDict.Add(EType.Separator, new LRShiftInAction(syntaxStates[2]));/*Actions[0]*/
            list[0].actionDict.Add(EType.SeparatorStart, new LRGotoAction(syntaxStates[1]));/*Actions[1]*/
            // list[1]
            list[1].actionDict.Add(EType.EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[2]*/
            // list[2]
            list[2].actionDict.Add(EType.LeftBrace, new LRShiftInAction(syntaxStates[3]));/*Actions[3]*/
            // list[3]
            list[3].actionDict.Add(EType.PropertyGroup, new LRGotoAction(syntaxStates[5]));/*Actions[4]*/
            list[3].actionDict.Add(EType.PropertyGroupList, new LRGotoAction(syntaxStates[4]));/*Actions[5]*/
            list[3].actionDict.Add(EType.identifier, new LRShiftInAction(syntaxStates[7]));/*Actions[6]*/
            list[3].actionDict.Add(EType.GroupName, new LRGotoAction(syntaxStates[6]));/*Actions[7]*/
            // list[4]
            list[4].actionDict.Add(EType.RightBrace, new LRShiftInAction(syntaxStates[9]));/*Actions[8]*/
            list[4].actionDict.Add(EType.GroupName, new LRGotoAction(syntaxStates[6]));/*Actions[9]*/
            list[4].actionDict.Add(EType.identifier, new LRShiftInAction(syntaxStates[7]));/*Actions[10]*/
            list[4].actionDict.Add(EType.PropertyGroup, new LRGotoAction(syntaxStates[8]));/*Actions[11]*/
            // list[5]
            list[5].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[2]));/*Actions[12]*/
            list[5].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[2]));/*Actions[13]*/
            // list[6]
            list[6].actionDict.Add(EType.LeftBrace, new LRShiftInAction(syntaxStates[10]));/*Actions[14]*/
            // list[7]
            list[7].actionDict.Add(EType.LeftBrace, new LRReducitonAction(regulations[4]));/*Actions[15]*/
            // list[8]
            list[8].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[1]));/*Actions[16]*/
            list[8].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[1]));/*Actions[17]*/
            // list[9]
            list[9].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[18]*/
            // list[10]
            list[10].actionDict.Add(EType.emissiveColor, new LRShiftInAction(syntaxStates[21]));/*Actions[19]*/
            list[10].actionDict.Add(EType.coordIndex, new LRShiftInAction(syntaxStates[20]));/*Actions[20]*/
            list[10].actionDict.Add(EType.specularColor, new LRShiftInAction(syntaxStates[19]));/*Actions[21]*/
            list[10].actionDict.Add(EType.Property, new LRGotoAction(syntaxStates[13]));/*Actions[22]*/
            list[10].actionDict.Add(EType.identifier, new LRShiftInAction(syntaxStates[15]));/*Actions[23]*/
            list[10].actionDict.Add(EType.PropertyList, new LRGotoAction(syntaxStates[16]));/*Actions[24]*/
            list[10].actionDict.Add(EType.shininess, new LRShiftInAction(syntaxStates[12]));/*Actions[25]*/
            list[10].actionDict.Add(EType.point, new LRShiftInAction(syntaxStates[18]));/*Actions[26]*/
            list[10].actionDict.Add(EType.ambientColor, new LRShiftInAction(syntaxStates[14]));/*Actions[27]*/
            list[10].actionDict.Add(EType.diffuseColor, new LRShiftInAction(syntaxStates[17]));/*Actions[28]*/
            list[10].actionDict.Add(EType.transparency, new LRShiftInAction(syntaxStates[11]));/*Actions[29]*/
            // list[11]
            list[11].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[22]));/*Actions[30]*/
            // list[12]
            list[12].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[23]));/*Actions[31]*/
            // list[13]
            list[13].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[6]));/*Actions[32]*/
            list[13].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[6]));/*Actions[33]*/
            list[13].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[6]));/*Actions[34]*/
            list[13].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[6]));/*Actions[35]*/
            list[13].actionDict.Add(EType.point, new LRReducitonAction(regulations[6]));/*Actions[36]*/
            list[13].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[6]));/*Actions[37]*/
            list[13].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[6]));/*Actions[38]*/
            list[13].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[6]));/*Actions[39]*/
            list[13].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[6]));/*Actions[40]*/
            list[13].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[6]));/*Actions[41]*/
            // list[14]
            list[14].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[24]));/*Actions[42]*/
            // list[15]
            list[15].actionDict.Add(EType.identifier, new LRShiftInAction(syntaxStates[25]));/*Actions[43]*/
            // list[16]
            list[16].actionDict.Add(EType.diffuseColor, new LRShiftInAction(syntaxStates[17]));/*Actions[44]*/
            list[16].actionDict.Add(EType.emissiveColor, new LRShiftInAction(syntaxStates[21]));/*Actions[45]*/
            list[16].actionDict.Add(EType.coordIndex, new LRShiftInAction(syntaxStates[20]));/*Actions[46]*/
            list[16].actionDict.Add(EType.transparency, new LRShiftInAction(syntaxStates[11]));/*Actions[47]*/
            list[16].actionDict.Add(EType.specularColor, new LRShiftInAction(syntaxStates[19]));/*Actions[48]*/
            list[16].actionDict.Add(EType.ambientColor, new LRShiftInAction(syntaxStates[14]));/*Actions[49]*/
            list[16].actionDict.Add(EType.RightBrace, new LRShiftInAction(syntaxStates[26]));/*Actions[50]*/
            list[16].actionDict.Add(EType.Property, new LRGotoAction(syntaxStates[27]));/*Actions[51]*/
            list[16].actionDict.Add(EType.point, new LRShiftInAction(syntaxStates[18]));/*Actions[52]*/
            list[16].actionDict.Add(EType.identifier, new LRShiftInAction(syntaxStates[15]));/*Actions[53]*/
            list[16].actionDict.Add(EType.shininess, new LRShiftInAction(syntaxStates[12]));/*Actions[54]*/
            // list[17]
            list[17].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[28]));/*Actions[55]*/
            // list[18]
            list[18].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[29]));/*Actions[56]*/
            // list[19]
            list[19].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[30]));/*Actions[57]*/
            // list[20]
            list[20].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[31]));/*Actions[58]*/
            // list[21]
            list[21].actionDict.Add(EType.LeftBracket, new LRShiftInAction(syntaxStates[32]));/*Actions[59]*/
            // list[22]
            list[22].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[33]));/*Actions[60]*/
            // list[23]
            list[23].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[34]));/*Actions[61]*/
            // list[24]
            list[24].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[35]));/*Actions[62]*/
            // list[25]
            list[25].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[7]));/*Actions[63]*/
            list[25].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[7]));/*Actions[64]*/
            list[25].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[7]));/*Actions[65]*/
            list[25].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[7]));/*Actions[66]*/
            list[25].actionDict.Add(EType.point, new LRReducitonAction(regulations[7]));/*Actions[67]*/
            list[25].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[7]));/*Actions[68]*/
            list[25].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[7]));/*Actions[69]*/
            list[25].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[7]));/*Actions[70]*/
            list[25].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[7]));/*Actions[71]*/
            list[25].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[7]));/*Actions[72]*/
            // list[26]
            list[26].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[3]));/*Actions[73]*/
            list[26].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[3]));/*Actions[74]*/
            // list[27]
            list[27].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[5]));/*Actions[75]*/
            list[27].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[5]));/*Actions[76]*/
            list[27].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[5]));/*Actions[77]*/
            list[27].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[5]));/*Actions[78]*/
            list[27].actionDict.Add(EType.point, new LRReducitonAction(regulations[5]));/*Actions[79]*/
            list[27].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[5]));/*Actions[80]*/
            list[27].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[5]));/*Actions[81]*/
            list[27].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[5]));/*Actions[82]*/
            list[27].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[5]));/*Actions[83]*/
            list[27].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[5]));/*Actions[84]*/
            // list[28]
            list[28].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[36]));/*Actions[85]*/
            // list[29]
            list[29].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[38]));/*Actions[86]*/
            list[29].actionDict.Add(EType.PointList, new LRGotoAction(syntaxStates[37]));/*Actions[87]*/
            list[29].actionDict.Add(EType.Point, new LRGotoAction(syntaxStates[39]));/*Actions[88]*/
            // list[30]
            list[30].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[40]));/*Actions[89]*/
            // list[31]
            list[31].actionDict.Add(EType.Integer, new LRShiftInAction(syntaxStates[43]));/*Actions[90]*/
            list[31].actionDict.Add(EType.CoordIndexList, new LRGotoAction(syntaxStates[42]));/*Actions[91]*/
            list[31].actionDict.Add(EType.CoordIndex, new LRGotoAction(syntaxStates[41]));/*Actions[92]*/
            // list[32]
            list[32].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[44]));/*Actions[93]*/
            // list[33]
            list[33].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[45]));/*Actions[94]*/
            // list[34]
            list[34].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[46]));/*Actions[95]*/
            // list[35]
            list[35].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[47]));/*Actions[96]*/
            // list[36]
            list[36].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[48]));/*Actions[97]*/
            // list[37]
            list[37].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[49]));/*Actions[98]*/
            list[37].actionDict.Add(EType.Comma, new LRShiftInAction(syntaxStates[50]));/*Actions[99]*/
            // list[38]
            list[38].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[51]));/*Actions[100]*/
            // list[39]
            list[39].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[17]));/*Actions[101]*/
            list[39].actionDict.Add(EType.RightBracket, new LRReducitonAction(regulations[17]));/*Actions[102]*/
            // list[40]
            list[40].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[52]));/*Actions[103]*/
            // list[41]
            list[41].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[20]));/*Actions[104]*/
            list[41].actionDict.Add(EType.RightBracket, new LRReducitonAction(regulations[20]));/*Actions[105]*/
            // list[42]
            list[42].actionDict.Add(EType.Comma, new LRShiftInAction(syntaxStates[54]));/*Actions[106]*/
            list[42].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[53]));/*Actions[107]*/
            // list[43]
            list[43].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[21]));/*Actions[108]*/
            list[43].actionDict.Add(EType.RightBracket, new LRReducitonAction(regulations[21]));/*Actions[109]*/
            // list[44]
            list[44].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[55]));/*Actions[110]*/
            // list[45]
            list[45].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[13]));/*Actions[111]*/
            list[45].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[13]));/*Actions[112]*/
            list[45].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[13]));/*Actions[113]*/
            list[45].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[13]));/*Actions[114]*/
            list[45].actionDict.Add(EType.point, new LRReducitonAction(regulations[13]));/*Actions[115]*/
            list[45].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[13]));/*Actions[116]*/
            list[45].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[13]));/*Actions[117]*/
            list[45].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[13]));/*Actions[118]*/
            list[45].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[13]));/*Actions[119]*/
            list[45].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[13]));/*Actions[120]*/
            // list[46]
            list[46].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[12]));/*Actions[121]*/
            list[46].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[12]));/*Actions[122]*/
            list[46].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[12]));/*Actions[123]*/
            list[46].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[12]));/*Actions[124]*/
            list[46].actionDict.Add(EType.point, new LRReducitonAction(regulations[12]));/*Actions[125]*/
            list[46].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[12]));/*Actions[126]*/
            list[46].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[12]));/*Actions[127]*/
            list[46].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[12]));/*Actions[128]*/
            list[46].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[12]));/*Actions[129]*/
            list[46].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[12]));/*Actions[130]*/
            // list[47]
            list[47].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[56]));/*Actions[131]*/
            // list[48]
            list[48].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[57]));/*Actions[132]*/
            // list[49]
            list[49].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[14]));/*Actions[133]*/
            list[49].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[14]));/*Actions[134]*/
            list[49].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[14]));/*Actions[135]*/
            list[49].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[14]));/*Actions[136]*/
            list[49].actionDict.Add(EType.point, new LRReducitonAction(regulations[14]));/*Actions[137]*/
            list[49].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[14]));/*Actions[138]*/
            list[49].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[14]));/*Actions[139]*/
            list[49].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[14]));/*Actions[140]*/
            list[49].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[14]));/*Actions[141]*/
            list[49].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[14]));/*Actions[142]*/
            // list[50]
            list[50].actionDict.Add(EType.Point, new LRGotoAction(syntaxStates[58]));/*Actions[143]*/
            list[50].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[38]));/*Actions[144]*/
            // list[51]
            list[51].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[59]));/*Actions[145]*/
            // list[52]
            list[52].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[60]));/*Actions[146]*/
            // list[53]
            list[53].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[15]));/*Actions[147]*/
            list[53].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[15]));/*Actions[148]*/
            list[53].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[15]));/*Actions[149]*/
            list[53].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[15]));/*Actions[150]*/
            list[53].actionDict.Add(EType.point, new LRReducitonAction(regulations[15]));/*Actions[151]*/
            list[53].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[15]));/*Actions[152]*/
            list[53].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[15]));/*Actions[153]*/
            list[53].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[15]));/*Actions[154]*/
            list[53].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[15]));/*Actions[155]*/
            list[53].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[15]));/*Actions[156]*/
            // list[54]
            list[54].actionDict.Add(EType.CoordIndex, new LRGotoAction(syntaxStates[61]));/*Actions[157]*/
            list[54].actionDict.Add(EType.Integer, new LRShiftInAction(syntaxStates[43]));/*Actions[158]*/
            // list[55]
            list[55].actionDict.Add(EType.Float, new LRShiftInAction(syntaxStates[62]));/*Actions[159]*/
            // list[56]
            list[56].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[63]));/*Actions[160]*/
            // list[57]
            list[57].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[64]));/*Actions[161]*/
            // list[58]
            list[58].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[16]));/*Actions[162]*/
            list[58].actionDict.Add(EType.RightBracket, new LRReducitonAction(regulations[16]));/*Actions[163]*/
            // list[59]
            list[59].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[18]));/*Actions[164]*/
            list[59].actionDict.Add(EType.RightBracket, new LRReducitonAction(regulations[18]));/*Actions[165]*/
            // list[60]
            list[60].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[65]));/*Actions[166]*/
            // list[61]
            list[61].actionDict.Add(EType.Comma, new LRReducitonAction(regulations[19]));/*Actions[167]*/
            list[61].actionDict.Add(EType.RightBracket, new LRReducitonAction(regulations[19]));/*Actions[168]*/
            // list[62]
            list[62].actionDict.Add(EType.RightBracket, new LRShiftInAction(syntaxStates[66]));/*Actions[169]*/
            // list[63]
            list[63].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[8]));/*Actions[170]*/
            list[63].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[8]));/*Actions[171]*/
            list[63].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[8]));/*Actions[172]*/
            list[63].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[8]));/*Actions[173]*/
            list[63].actionDict.Add(EType.point, new LRReducitonAction(regulations[8]));/*Actions[174]*/
            list[63].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[8]));/*Actions[175]*/
            list[63].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[8]));/*Actions[176]*/
            list[63].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[8]));/*Actions[177]*/
            list[63].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[8]));/*Actions[178]*/
            list[63].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[8]));/*Actions[179]*/
            // list[64]
            list[64].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[9]));/*Actions[180]*/
            list[64].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[9]));/*Actions[181]*/
            list[64].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[9]));/*Actions[182]*/
            list[64].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[9]));/*Actions[183]*/
            list[64].actionDict.Add(EType.point, new LRReducitonAction(regulations[9]));/*Actions[184]*/
            list[64].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[9]));/*Actions[185]*/
            list[64].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[9]));/*Actions[186]*/
            list[64].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[9]));/*Actions[187]*/
            list[64].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[9]));/*Actions[188]*/
            list[64].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[9]));/*Actions[189]*/
            // list[65]
            list[65].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[11]));/*Actions[190]*/
            list[65].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[11]));/*Actions[191]*/
            list[65].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[11]));/*Actions[192]*/
            list[65].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[11]));/*Actions[193]*/
            list[65].actionDict.Add(EType.point, new LRReducitonAction(regulations[11]));/*Actions[194]*/
            list[65].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[11]));/*Actions[195]*/
            list[65].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[11]));/*Actions[196]*/
            list[65].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[11]));/*Actions[197]*/
            list[65].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[11]));/*Actions[198]*/
            list[65].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[11]));/*Actions[199]*/
            // list[66]
            list[66].actionDict.Add(EType.diffuseColor, new LRReducitonAction(regulations[10]));/*Actions[200]*/
            list[66].actionDict.Add(EType.transparency, new LRReducitonAction(regulations[10]));/*Actions[201]*/
            list[66].actionDict.Add(EType.specularColor, new LRReducitonAction(regulations[10]));/*Actions[202]*/
            list[66].actionDict.Add(EType.emissiveColor, new LRReducitonAction(regulations[10]));/*Actions[203]*/
            list[66].actionDict.Add(EType.point, new LRReducitonAction(regulations[10]));/*Actions[204]*/
            list[66].actionDict.Add(EType.shininess, new LRReducitonAction(regulations[10]));/*Actions[205]*/
            list[66].actionDict.Add(EType.identifier, new LRReducitonAction(regulations[10]));/*Actions[206]*/
            list[66].actionDict.Add(EType.RightBrace, new LRReducitonAction(regulations[10]));/*Actions[207]*/
            list[66].actionDict.Add(EType.coordIndex, new LRReducitonAction(regulations[10]));/*Actions[208]*/
            list[66].actionDict.Add(EType.ambientColor, new LRReducitonAction(regulations[10]));/*Actions[209]*/
        }
    }
}
