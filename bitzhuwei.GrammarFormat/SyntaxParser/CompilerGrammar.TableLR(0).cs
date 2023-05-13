using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat
{
    partial class CompilerGrammar {
        const int syntaxStateCount = 22;
        // NOTE: choose only one from CompilerGrammar.TableLL(1).cs, CompilerGrammar.TableLR(0).cs, CompilerGrammar.TableSLR(1).cs, CompilerGrammar.TableLALR(1).cs, CompilerGrammar.TableLR(1).cs
        /// <summary>
        /// LR(0) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerGrammar.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerGrammar)}.syntaxStates[{i}]");
            }
            // 141 actions. 6 conflicts.
            // list[0]
            list[0].actionDict.Add(EType.StatementList, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Statement, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.SyntaxProduction, new LRGotoAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.LexiProduction, new LRGotoAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[5]));/*Actions[4]*/
            list[0].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[6]));/*Actions[5]*/
            // list[1]
            list[1].actionDict.Add(EType.Statement, new LRGotoAction(syntaxStates[7]));/*Actions[6]*/
            list[1].actionDict.Add(EType.SyntaxProduction, new LRGotoAction(syntaxStates[3]));/*Actions[7]*/
            list[1].actionDict.Add(EType.LexiProduction, new LRGotoAction(syntaxStates[4]));/*Actions[8]*/
            list[1].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[5]));/*Actions[9]*/
            list[1].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[6]));/*Actions[10]*/
            list[1].actionDict.Add(EType.EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[11]*/
            // list[2]
            list[2].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[1]));/*Actions[12]*/
            list[2].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[1]));/*Actions[13]*/
            list[2].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[1]));/*Actions[14]*/
            list[2].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[1]));/*Actions[15]*/
            list[2].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[1]));/*Actions[16]*/
            list[2].actionDict.Add(EType.empty, new LRReducitonAction(regulations[1]));/*Actions[17]*/
            list[2].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[1]));/*Actions[18]*/
            list[2].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[19]*/
            // list[3]
            list[3].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[2]));/*Actions[20]*/
            list[3].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[2]));/*Actions[21]*/
            list[3].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[2]));/*Actions[22]*/
            list[3].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[2]));/*Actions[23]*/
            list[3].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[2]));/*Actions[24]*/
            list[3].actionDict.Add(EType.empty, new LRReducitonAction(regulations[2]));/*Actions[25]*/
            list[3].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[2]));/*Actions[26]*/
            list[3].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[27]*/
            // list[4]
            list[4].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[3]));/*Actions[28]*/
            list[4].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[3]));/*Actions[29]*/
            list[4].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[3]));/*Actions[30]*/
            list[4].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[3]));/*Actions[31]*/
            list[4].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[3]));/*Actions[32]*/
            list[4].actionDict.Add(EType.empty, new LRReducitonAction(regulations[3]));/*Actions[33]*/
            list[4].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[3]));/*Actions[34]*/
            list[4].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[35]*/
            // list[5]
            list[5].actionDict.Add(EType.Colon, new LRShiftInAction(syntaxStates[8]));/*Actions[36]*/
            // list[6]
            list[6].actionDict.Add(EType.Colon, new LRShiftInAction(syntaxStates[9]));/*Actions[37]*/
            // list[7]
            list[7].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[0]));/*Actions[38]*/
            list[7].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[0]));/*Actions[39]*/
            list[7].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[0]));/*Actions[40]*/
            list[7].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[0]));/*Actions[41]*/
            list[7].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[0]));/*Actions[42]*/
            list[7].actionDict.Add(EType.empty, new LRReducitonAction(regulations[0]));/*Actions[43]*/
            list[7].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[0]));/*Actions[44]*/
            list[7].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[45]*/
            // list[8]
            list[8].actionDict.Add(EType.CandidateList, new LRGotoAction(syntaxStates[10]));/*Actions[46]*/
            list[8].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[11]));/*Actions[47]*/
            list[8].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[12]));/*Actions[48]*/
            list[8].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[49]*/
            list[8].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[50]*/
            list[8].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[51]*/
            // list[9]
            list[9].actionDict.Add(EType.pattern, new LRShiftInAction(syntaxStates[16]));/*Actions[52]*/
            // list[10]
            list[10].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[17]));/*Actions[53]*/
            list[10].actionDict.Add(EType.Pipe, new LRShiftInAction(syntaxStates[18]));/*Actions[54]*/
            // list[11]
            //Vn repeated 2 times
            //Vt repeated 2 times
            //empty repeated 2 times
            list[11].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[19]));/*Actions[55]*/
            list[11].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[56]*/
            list[11].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[6]));/*Actions[57]*/
            list[11].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[58]*/
            list[11].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[6]));/*Actions[59]*/
            list[11].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[60]*/
            list[11].actionDict.Add(EType.empty, new LRReducitonAction(regulations[6]));/*Actions[61]*/
            list[11].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[6]));/*Actions[62]*/
            list[11].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[6]));/*Actions[63]*/
            list[11].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[6]));/*Actions[64]*/
            list[11].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[6]));/*Actions[65]*/
            list[11].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[66]*/
            // list[12]
            list[12].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[8]));/*Actions[67]*/
            list[12].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[8]));/*Actions[68]*/
            list[12].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[8]));/*Actions[69]*/
            list[12].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[8]));/*Actions[70]*/
            list[12].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[8]));/*Actions[71]*/
            list[12].actionDict.Add(EType.empty, new LRReducitonAction(regulations[8]));/*Actions[72]*/
            list[12].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[8]));/*Actions[73]*/
            list[12].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[8]));/*Actions[74]*/
            // list[13]
            list[13].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[9]));/*Actions[75]*/
            list[13].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[9]));/*Actions[76]*/
            list[13].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[9]));/*Actions[77]*/
            list[13].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[9]));/*Actions[78]*/
            list[13].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[9]));/*Actions[79]*/
            list[13].actionDict.Add(EType.empty, new LRReducitonAction(regulations[9]));/*Actions[80]*/
            list[13].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[9]));/*Actions[81]*/
            list[13].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[9]));/*Actions[82]*/
            // list[14]
            list[14].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[10]));/*Actions[83]*/
            list[14].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[10]));/*Actions[84]*/
            list[14].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[10]));/*Actions[85]*/
            list[14].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[10]));/*Actions[86]*/
            list[14].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[10]));/*Actions[87]*/
            list[14].actionDict.Add(EType.empty, new LRReducitonAction(regulations[10]));/*Actions[88]*/
            list[14].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[10]));/*Actions[89]*/
            list[14].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[10]));/*Actions[90]*/
            // list[15]
            list[15].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[11]));/*Actions[91]*/
            list[15].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[11]));/*Actions[92]*/
            list[15].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[11]));/*Actions[93]*/
            list[15].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[11]));/*Actions[94]*/
            list[15].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[11]));/*Actions[95]*/
            list[15].actionDict.Add(EType.empty, new LRReducitonAction(regulations[11]));/*Actions[96]*/
            list[15].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[11]));/*Actions[97]*/
            list[15].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[11]));/*Actions[98]*/
            // list[16]
            list[16].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[20]));/*Actions[99]*/
            // list[17]
            list[17].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[4]));/*Actions[100]*/
            list[17].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[4]));/*Actions[101]*/
            list[17].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[4]));/*Actions[102]*/
            list[17].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[4]));/*Actions[103]*/
            list[17].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[4]));/*Actions[104]*/
            list[17].actionDict.Add(EType.empty, new LRReducitonAction(regulations[4]));/*Actions[105]*/
            list[17].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[4]));/*Actions[106]*/
            list[17].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[107]*/
            // list[18]
            list[18].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[21]));/*Actions[108]*/
            list[18].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[12]));/*Actions[109]*/
            list[18].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[110]*/
            list[18].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[111]*/
            list[18].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[112]*/
            // list[19]
            list[19].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[7]));/*Actions[113]*/
            list[19].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[7]));/*Actions[114]*/
            list[19].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[7]));/*Actions[115]*/
            list[19].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[7]));/*Actions[116]*/
            list[19].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[7]));/*Actions[117]*/
            list[19].actionDict.Add(EType.empty, new LRReducitonAction(regulations[7]));/*Actions[118]*/
            list[19].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[7]));/*Actions[119]*/
            list[19].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[120]*/
            // list[20]
            list[20].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[12]));/*Actions[121]*/
            list[20].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[12]));/*Actions[122]*/
            list[20].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[12]));/*Actions[123]*/
            list[20].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[12]));/*Actions[124]*/
            list[20].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[12]));/*Actions[125]*/
            list[20].actionDict.Add(EType.empty, new LRReducitonAction(regulations[12]));/*Actions[126]*/
            list[20].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[12]));/*Actions[127]*/
            list[20].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[128]*/
            // list[21]
            //Vn repeated 2 times
            //Vt repeated 2 times
            //empty repeated 2 times
            list[21].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[19]));/*Actions[129]*/
            list[21].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[130]*/
            list[21].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[5]));/*Actions[131]*/
            list[21].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[132]*/
            list[21].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[5]));/*Actions[133]*/
            list[21].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[134]*/
            list[21].actionDict.Add(EType.empty, new LRReducitonAction(regulations[5]));/*Actions[135]*/
            list[21].actionDict.Add(EType.Colon, new LRReducitonAction(regulations[5]));/*Actions[136]*/
            list[21].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[5]));/*Actions[137]*/
            list[21].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[5]));/*Actions[138]*/
            list[21].actionDict.Add(EType.pattern, new LRReducitonAction(regulations[5]));/*Actions[139]*/
            list[21].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[140]*/

        }
    }
}
