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
        /// LR(1) syntax parsing table
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
            // 76 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] GrammarDraft> : ⏳ StatementList ; '￥' 
            // [0] StatementList : ⏳ StatementList Statement ; '￥' 'Vn' 'Vt' 
            // [1] StatementList : ⏳ Statement ; '￥' 'Vn' 'Vt' 
            // [2] Statement : ⏳ SyntaxProduction ; '￥' 'Vn' 'Vt' 
            // [3] Statement : ⏳ LexiProduction ; '￥' 'Vn' 'Vt' 
            // [4] SyntaxProduction : ⏳ 'Vn' ':' CandidateList ';' ; '￥' 'Vn' 'Vt' 
            // [13] LexiProduction : ⏳ 'Vt' ':' 'pattern' ';' ; '￥' 'Vn' 'Vt' 
            list[0].actionDict.Add(EType.StatementList, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.Statement, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.SyntaxProduction, new LRGotoAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.LexiProduction, new LRGotoAction(syntaxStates[4]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[5]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[6]));/*Actions[5]*/
            // syntaxStates[1]:
            // [-1] GrammarDraft> : StatementList ⏳ ; '￥' 
            // [0] StatementList : StatementList ⏳ Statement ; '￥' 'Vn' 'Vt' 
            // [2] Statement : ⏳ SyntaxProduction ; '￥' 'Vn' 'Vt' 
            // [3] Statement : ⏳ LexiProduction ; '￥' 'Vn' 'Vt' 
            // [4] SyntaxProduction : ⏳ 'Vn' ':' CandidateList ';' ; '￥' 'Vn' 'Vt' 
            // [13] LexiProduction : ⏳ 'Vt' ':' 'pattern' ';' ; '￥' 'Vn' 'Vt' 
            list[1].actionDict.Add(EType.Statement, new LRGotoAction(syntaxStates[7]));/*Actions[6]*/
            list[1].actionDict.Add(EType.SyntaxProduction, new LRGotoAction(syntaxStates[3]));/*Actions[7]*/
            list[1].actionDict.Add(EType.LexiProduction, new LRGotoAction(syntaxStates[4]));/*Actions[8]*/
            list[1].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[5]));/*Actions[9]*/
            list[1].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[6]));/*Actions[10]*/
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[11]*/
            // syntaxStates[2]:
            // [1] StatementList : Statement ⏳ ; '￥' 'Vn' 'Vt' 
            list[2].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[12]*/
            list[2].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[1]));/*Actions[13]*/
            list[2].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[1]));/*Actions[14]*/
            // syntaxStates[3]:
            // [2] Statement : SyntaxProduction ⏳ ; '￥' 'Vn' 'Vt' 
            list[3].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[15]*/
            list[3].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[2]));/*Actions[16]*/
            list[3].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[2]));/*Actions[17]*/
            // syntaxStates[4]:
            // [3] Statement : LexiProduction ⏳ ; '￥' 'Vn' 'Vt' 
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[18]*/
            list[4].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[3]));/*Actions[19]*/
            list[4].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[3]));/*Actions[20]*/
            // syntaxStates[5]:
            // [4] SyntaxProduction : 'Vn' ⏳ ':' CandidateList ';' ; '￥' 'Vn' 'Vt' 
            list[5].actionDict.Add(EType.@Colon, new LRShiftInAction(syntaxStates[8]));/*Actions[21]*/
            // syntaxStates[6]:
            // [13] LexiProduction : 'Vt' ⏳ ':' 'pattern' ';' ; '￥' 'Vn' 'Vt' 
            list[6].actionDict.Add(EType.@Colon, new LRShiftInAction(syntaxStates[9]));/*Actions[22]*/
            // syntaxStates[7]:
            // [0] StatementList : StatementList Statement ⏳ ; '￥' 'Vn' 'Vt' 
            list[7].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[23]*/
            list[7].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[0]));/*Actions[24]*/
            list[7].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[0]));/*Actions[25]*/
            // syntaxStates[8]:
            // [4] SyntaxProduction : 'Vn' ':' ⏳ CandidateList ';' ; '￥' 'Vn' 'Vt' 
            // [5] CandidateList : ⏳ CandidateList '|' Candidate ; ';' '|' 
            // [6] CandidateList : ⏳ Candidate ; ';' '|' 
            // [7] Candidate : ⏳ VList ; ';' '|' 
            // [8] Candidate : ⏳ 'empty' ; ';' '|' 
            // [9] VList : ⏳ VList V ; ';' '|' 'Vn' 'Vt' 
            // [10] VList : ⏳ V ; ';' '|' 'Vn' 'Vt' 
            // [11] V : ⏳ 'Vn' ; ';' '|' 'Vn' 'Vt' 
            // [12] V : ⏳ 'Vt' ; ';' '|' 'Vn' 'Vt' 
            list[8].actionDict.Add(EType.CandidateList, new LRGotoAction(syntaxStates[10]));/*Actions[26]*/
            list[8].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[11]));/*Actions[27]*/
            list[8].actionDict.Add(EType.VList, new LRGotoAction(syntaxStates[12]));/*Actions[28]*/
            list[8].actionDict.Add(EType.@empty, new LRShiftInAction(syntaxStates[13]));/*Actions[29]*/
            list[8].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[14]));/*Actions[30]*/
            list[8].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[15]));/*Actions[31]*/
            list[8].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[16]));/*Actions[32]*/
            // syntaxStates[9]:
            // [13] LexiProduction : 'Vt' ':' ⏳ 'pattern' ';' ; '￥' 'Vn' 'Vt' 
            list[9].actionDict.Add(EType.@pattern, new LRShiftInAction(syntaxStates[17]));/*Actions[33]*/
            // syntaxStates[10]:
            // [4] SyntaxProduction : 'Vn' ':' CandidateList ⏳ ';' ; '￥' 'Vn' 'Vt' 
            // [5] CandidateList : CandidateList ⏳ '|' Candidate ; ';' '|' 
            list[10].actionDict.Add(EType.@Semicolon, new LRShiftInAction(syntaxStates[18]));/*Actions[34]*/
            list[10].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[19]));/*Actions[35]*/
            // syntaxStates[11]:
            // [6] CandidateList : Candidate ⏳ ; ';' '|' 
            list[11].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[6]));/*Actions[36]*/
            list[11].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[37]*/
            // syntaxStates[12]:
            // [7] Candidate : VList ⏳ ; ';' '|' 
            // [9] VList : VList ⏳ V ; ';' '|' 'Vn' 'Vt' 
            // [11] V : ⏳ 'Vn' ; ';' '|' 'Vn' 'Vt' 
            // [12] V : ⏳ 'Vt' ; ';' '|' 'Vn' 'Vt' 
            list[12].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[20]));/*Actions[38]*/
            list[12].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[15]));/*Actions[39]*/
            list[12].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[16]));/*Actions[40]*/
            list[12].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[7]));/*Actions[41]*/
            list[12].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[42]*/
            // syntaxStates[13]:
            // [8] Candidate : 'empty' ⏳ ; ';' '|' 
            list[13].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[8]));/*Actions[43]*/
            list[13].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[44]*/
            // syntaxStates[14]:
            // [10] VList : V ⏳ ; ';' '|' 'Vn' 'Vt' 
            list[14].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[10]));/*Actions[45]*/
            list[14].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[46]*/
            list[14].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[10]));/*Actions[47]*/
            list[14].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[10]));/*Actions[48]*/
            // syntaxStates[15]:
            // [11] V : 'Vn' ⏳ ; ';' '|' 'Vn' 'Vt' 
            list[15].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[11]));/*Actions[49]*/
            list[15].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[50]*/
            list[15].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[11]));/*Actions[51]*/
            list[15].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[11]));/*Actions[52]*/
            // syntaxStates[16]:
            // [12] V : 'Vt' ⏳ ; ';' '|' 'Vn' 'Vt' 
            list[16].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[12]));/*Actions[53]*/
            list[16].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[54]*/
            list[16].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[12]));/*Actions[55]*/
            list[16].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[12]));/*Actions[56]*/
            // syntaxStates[17]:
            // [13] LexiProduction : 'Vt' ':' 'pattern' ⏳ ';' ; '￥' 'Vn' 'Vt' 
            list[17].actionDict.Add(EType.@Semicolon, new LRShiftInAction(syntaxStates[21]));/*Actions[57]*/
            // syntaxStates[18]:
            // [4] SyntaxProduction : 'Vn' ':' CandidateList ';' ⏳ ; '￥' 'Vn' 'Vt' 
            list[18].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[58]*/
            list[18].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[4]));/*Actions[59]*/
            list[18].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[4]));/*Actions[60]*/
            // syntaxStates[19]:
            // [5] CandidateList : CandidateList '|' ⏳ Candidate ; ';' '|' 
            // [7] Candidate : ⏳ VList ; ';' '|' 
            // [8] Candidate : ⏳ 'empty' ; ';' '|' 
            // [9] VList : ⏳ VList V ; ';' '|' 'Vn' 'Vt' 
            // [10] VList : ⏳ V ; ';' '|' 'Vn' 'Vt' 
            // [11] V : ⏳ 'Vn' ; ';' '|' 'Vn' 'Vt' 
            // [12] V : ⏳ 'Vt' ; ';' '|' 'Vn' 'Vt' 
            list[19].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[22]));/*Actions[61]*/
            list[19].actionDict.Add(EType.VList, new LRGotoAction(syntaxStates[12]));/*Actions[62]*/
            list[19].actionDict.Add(EType.@empty, new LRShiftInAction(syntaxStates[13]));/*Actions[63]*/
            list[19].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[14]));/*Actions[64]*/
            list[19].actionDict.Add(EType.@Vn, new LRShiftInAction(syntaxStates[15]));/*Actions[65]*/
            list[19].actionDict.Add(EType.@Vt, new LRShiftInAction(syntaxStates[16]));/*Actions[66]*/
            // syntaxStates[20]:
            // [9] VList : VList V ⏳ ; ';' '|' 'Vn' 'Vt' 
            list[20].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[9]));/*Actions[67]*/
            list[20].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[68]*/
            list[20].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[9]));/*Actions[69]*/
            list[20].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[9]));/*Actions[70]*/
            // syntaxStates[21]:
            // [13] LexiProduction : 'Vt' ':' 'pattern' ';' ⏳ ; '￥' 'Vn' 'Vt' 
            list[21].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[13]));/*Actions[71]*/
            list[21].actionDict.Add(EType.@Vn, new LRReducitonAction(regulations[13]));/*Actions[72]*/
            list[21].actionDict.Add(EType.@Vt, new LRReducitonAction(regulations[13]));/*Actions[73]*/
            // syntaxStates[22]:
            // [5] CandidateList : CandidateList '|' Candidate ⏳ ; ';' '|' 
            list[22].actionDict.Add(EType.@Semicolon, new LRReducitonAction(regulations[5]));/*Actions[74]*/
            list[22].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[75]*/

        }
    }
}
