using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        const int syntaxStateCount = 23;
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
            var list = CompilerGrammar.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerGrammar)}.syntaxStates[{i}]");
            }
            // 146 actions. 2 conflicts.
            // syntaxStates[0]:
            // [-1] GrammarDraft> : ⏳ StatementList ;
            // [0] StatementList : ⏳ StatementList Statement ;
            // [1] StatementList : ⏳ Statement ;
            // [2] Statement : ⏳ SyntaxProduction ;
            // [3] Statement : ⏳ LexiProduction ;
            // [4] SyntaxProduction : ⏳ 'Vn' ':' CandidateList ';' ;
            // [13] LexiProduction : ⏳ 'Vt' ':' 'pattern' ';' ;
            list[0].actionDict.Add(EType.StatementList, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Statement, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.SyntaxProduction, new LRGotoAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.LexiProduction, new LRGotoAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[5]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[6]));/*Actions[5]*/
            // syntaxStates[1]:
            // [-1] GrammarDraft> : StatementList ⏳ ;
            // [0] StatementList : StatementList ⏳ Statement ;
            // [2] Statement : ⏳ SyntaxProduction ;
            // [3] Statement : ⏳ LexiProduction ;
            // [4] SyntaxProduction : ⏳ 'Vn' ':' CandidateList ';' ;
            // [13] LexiProduction : ⏳ 'Vt' ':' 'pattern' ';' ;
            list[1].actionDict.Add(EType.Statement, new LRGotoAction(syntaxStates[7]));/*Actions[6]*/
            list[1].actionDict.Add(EType.SyntaxProduction, new LRGotoAction(syntaxStates[3]));/*Actions[7]*/
            list[1].actionDict.Add(EType.LexiProduction, new LRGotoAction(syntaxStates[4]));/*Actions[8]*/
            list[1].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[5]));/*Actions[9]*/
            list[1].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[6]));/*Actions[10]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[11]*/
            // syntaxStates[2]:
            // [1] StatementList : Statement ⏳ ;
            list[2].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[1]));/*Actions[12]*/
            list[2].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[1]));/*Actions[13]*/
            list[2].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[1]));/*Actions[14]*/
            list[2].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[1]));/*Actions[15]*/
            list[2].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[1]));/*Actions[16]*/
            list[2].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[1]));/*Actions[17]*/
            list[2].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[1]));/*Actions[18]*/
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[19]*/
            // syntaxStates[3]:
            // [2] Statement : SyntaxProduction ⏳ ;
            list[3].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[2]));/*Actions[20]*/
            list[3].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[2]));/*Actions[21]*/
            list[3].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[2]));/*Actions[22]*/
            list[3].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[2]));/*Actions[23]*/
            list[3].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[2]));/*Actions[24]*/
            list[3].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[2]));/*Actions[25]*/
            list[3].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[2]));/*Actions[26]*/
            list[3].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[27]*/
            // syntaxStates[4]:
            // [3] Statement : LexiProduction ⏳ ;
            list[4].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[3]));/*Actions[28]*/
            list[4].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[3]));/*Actions[29]*/
            list[4].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[3]));/*Actions[30]*/
            list[4].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[3]));/*Actions[31]*/
            list[4].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[3]));/*Actions[32]*/
            list[4].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[3]));/*Actions[33]*/
            list[4].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[3]));/*Actions[34]*/
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[35]*/
            // syntaxStates[5]:
            // [4] SyntaxProduction : 'Vn' ⏳ ':' CandidateList ';' ;
            list[5].actionDict.Add(EType.@Colon, new LRShiftInAction(syntaxStates[8]));/*Actions[36]*/
            // syntaxStates[6]:
            // [13] LexiProduction : 'Vt' ⏳ ':' 'pattern' ';' ;
            list[6].actionDict.Add(EType.@Colon, new LRShiftInAction(syntaxStates[9]));/*Actions[37]*/
            // syntaxStates[7]:
            // [0] StatementList : StatementList Statement ⏳ ;
            list[7].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[0]));/*Actions[38]*/
            list[7].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[0]));/*Actions[39]*/
            list[7].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[0]));/*Actions[40]*/
            list[7].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[0]));/*Actions[41]*/
            list[7].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[0]));/*Actions[42]*/
            list[7].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[0]));/*Actions[43]*/
            list[7].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[0]));/*Actions[44]*/
            list[7].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[45]*/
            // syntaxStates[8]:
            // [4] SyntaxProduction : 'Vn' ':' ⏳ CandidateList ';' ;
            // [5] CandidateList : ⏳ CandidateList '|' Candidate ;
            // [6] CandidateList : ⏳ Candidate ;
            // [7] Candidate : ⏳ VList ;
            // [8] Candidate : ⏳ 'empty' ;
            // [9] VList : ⏳ VList V ;
            // [10] VList : ⏳ V ;
            // [11] V : ⏳ 'Vn' ;
            // [12] V : ⏳ 'Vt' ;
            list[8].actionDict.Add(EType.CandidateList, new LRGotoAction(syntaxStates[10]));/*Actions[46]*/
            list[8].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[11]));/*Actions[47]*/
            list[8].actionDict.Add(EType.VList, new LRGotoAction(syntaxStates[12]));/*Actions[48]*/
            list[8].actionDict.Add(EType.@empty, new LRShiftInAction(syntaxStates[13]));/*Actions[49]*/
            list[8].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[14]));/*Actions[50]*/
            list[8].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[15]));/*Actions[51]*/
            list[8].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[16]));/*Actions[52]*/
            // syntaxStates[9]:
            // [13] LexiProduction : 'Vt' ':' ⏳ 'pattern' ';' ;
            list[9].actionDict.Add(EType.@pattern, new LRShiftInAction(syntaxStates[17]));/*Actions[53]*/
            // syntaxStates[10]:
            // [4] SyntaxProduction : 'Vn' ':' CandidateList ⏳ ';' ;
            // [5] CandidateList : CandidateList ⏳ '|' Candidate ;
            list[10].actionDict.Add(EType.@Semicolon, new LRShiftInAction(syntaxStates[18]));/*Actions[54]*/
            list[10].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[19]));/*Actions[55]*/
            // syntaxStates[11]:
            // [6] CandidateList : Candidate ⏳ ;
            list[11].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[6]));/*Actions[56]*/
            list[11].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[6]));/*Actions[57]*/
            list[11].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[6]));/*Actions[58]*/
            list[11].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[59]*/
            list[11].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[6]));/*Actions[60]*/
            list[11].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[6]));/*Actions[61]*/
            list[11].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[6]));/*Actions[62]*/
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[63]*/
            // syntaxStates[12]:
            // [7] Candidate : VList ⏳ ;
            // [9] VList : VList ⏳ V ;
            // [11] V : ⏳ 'Vn' ;
            // [12] V : ⏳ 'Vt' ;
            //@Vn repeated 2 times
            //@Vt repeated 2 times
            list[12].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[20]));/*Actions[64]*/
            list[12].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[15]));/*Actions[65]*/
            list[12].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[7]));/*Actions[66]*/
            list[12].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[16]));/*Actions[67]*/
            list[12].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[7]));/*Actions[68]*/
            list[12].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[7]));/*Actions[69]*/
            list[12].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[7]));/*Actions[70]*/
            list[12].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[71]*/
            list[12].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[7]));/*Actions[72]*/
            list[12].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[7]));/*Actions[73]*/
            list[12].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[74]*/
            // syntaxStates[13]:
            // [8] Candidate : 'empty' ⏳ ;
            list[13].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[8]));/*Actions[75]*/
            list[13].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[8]));/*Actions[76]*/
            list[13].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[8]));/*Actions[77]*/
            list[13].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[78]*/
            list[13].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[8]));/*Actions[79]*/
            list[13].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[8]));/*Actions[80]*/
            list[13].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[8]));/*Actions[81]*/
            list[13].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[8]));/*Actions[82]*/
            // syntaxStates[14]:
            // [10] VList : V ⏳ ;
            list[14].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[10]));/*Actions[83]*/
            list[14].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[10]));/*Actions[84]*/
            list[14].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[10]));/*Actions[85]*/
            list[14].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[86]*/
            list[14].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[10]));/*Actions[87]*/
            list[14].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[10]));/*Actions[88]*/
            list[14].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[10]));/*Actions[89]*/
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[10]));/*Actions[90]*/
            // syntaxStates[15]:
            // [11] V : 'Vn' ⏳ ;
            list[15].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[11]));/*Actions[91]*/
            list[15].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[11]));/*Actions[92]*/
            list[15].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[11]));/*Actions[93]*/
            list[15].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[94]*/
            list[15].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[11]));/*Actions[95]*/
            list[15].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[11]));/*Actions[96]*/
            list[15].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[11]));/*Actions[97]*/
            list[15].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[11]));/*Actions[98]*/
            // syntaxStates[16]:
            // [12] V : 'Vt' ⏳ ;
            list[16].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[12]));/*Actions[99]*/
            list[16].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[12]));/*Actions[100]*/
            list[16].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[12]));/*Actions[101]*/
            list[16].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[102]*/
            list[16].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[12]));/*Actions[103]*/
            list[16].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[12]));/*Actions[104]*/
            list[16].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[12]));/*Actions[105]*/
            list[16].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[106]*/
            // syntaxStates[17]:
            // [13] LexiProduction : 'Vt' ':' 'pattern' ⏳ ';' ;
            list[17].actionDict.Add(EType.@Semicolon, new LRShiftInAction(syntaxStates[21]));/*Actions[107]*/
            // syntaxStates[18]:
            // [4] SyntaxProduction : 'Vn' ':' CandidateList ';' ⏳ ;
            list[18].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[4]));/*Actions[108]*/
            list[18].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[4]));/*Actions[109]*/
            list[18].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[4]));/*Actions[110]*/
            list[18].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[4]));/*Actions[111]*/
            list[18].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[4]));/*Actions[112]*/
            list[18].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[4]));/*Actions[113]*/
            list[18].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[4]));/*Actions[114]*/
            list[18].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[115]*/
            // syntaxStates[19]:
            // [5] CandidateList : CandidateList '|' ⏳ Candidate ;
            // [7] Candidate : ⏳ VList ;
            // [8] Candidate : ⏳ 'empty' ;
            // [9] VList : ⏳ VList V ;
            // [10] VList : ⏳ V ;
            // [11] V : ⏳ 'Vn' ;
            // [12] V : ⏳ 'Vt' ;
            list[19].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[22]));/*Actions[116]*/
            list[19].actionDict.Add(EType.VList, new LRGotoAction(syntaxStates[12]));/*Actions[117]*/
            list[19].actionDict.Add(EType.@empty, new LRShiftInAction(syntaxStates[13]));/*Actions[118]*/
            list[19].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[14]));/*Actions[119]*/
            list[19].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[15]));/*Actions[120]*/
            list[19].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[16]));/*Actions[121]*/
            // syntaxStates[20]:
            // [9] VList : VList V ⏳ ;
            list[20].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[9]));/*Actions[122]*/
            list[20].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[9]));/*Actions[123]*/
            list[20].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[9]));/*Actions[124]*/
            list[20].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[125]*/
            list[20].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[9]));/*Actions[126]*/
            list[20].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[9]));/*Actions[127]*/
            list[20].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[9]));/*Actions[128]*/
            list[20].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[9]));/*Actions[129]*/
            // syntaxStates[21]:
            // [13] LexiProduction : 'Vt' ':' 'pattern' ';' ⏳ ;
            list[21].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[13]));/*Actions[130]*/
            list[21].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[13]));/*Actions[131]*/
            list[21].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[13]));/*Actions[132]*/
            list[21].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[13]));/*Actions[133]*/
            list[21].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[13]));/*Actions[134]*/
            list[21].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[13]));/*Actions[135]*/
            list[21].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[13]));/*Actions[136]*/
            list[21].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[13]));/*Actions[137]*/
            // syntaxStates[22]:
            // [5] CandidateList : CandidateList '|' Candidate ⏳ ;
            list[22].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[5]));/*Actions[138]*/
            list[22].actionDict.Add(EType.@Colon, new LRReducitonAction(regulations[5]));/*Actions[139]*/
            list[22].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[5]));/*Actions[140]*/
            list[22].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[141]*/
            list[22].actionDict.Add(EType.@empty, new LRReducitonAction(regulations[5]));/*Actions[142]*/
            list[22].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[5]));/*Actions[143]*/
            list[22].actionDict.Add(EType.@pattern, new LRReducitonAction(regulations[5]));/*Actions[144]*/
            list[22].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[145]*/

        }
    }
}
