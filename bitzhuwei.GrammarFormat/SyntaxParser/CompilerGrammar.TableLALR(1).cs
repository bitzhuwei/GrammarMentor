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
        /// LALR(1) syntax parsing table
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
            // 84 actions. 0 conflicts.
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
            list[2].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[1]));/*Actions[12]*/
            list[2].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[1]));/*Actions[13]*/
            list[2].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[1]));/*Actions[14]*/
            // list[3]
            list[3].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[2]));/*Actions[15]*/
            list[3].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[2]));/*Actions[16]*/
            list[3].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[2]));/*Actions[17]*/
            // list[4]
            list[4].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[18]*/
            list[4].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[3]));/*Actions[19]*/
            list[4].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[3]));/*Actions[20]*/
            // list[5]
            list[5].actionDict.Add(EType.Colon, new LRShiftInAction(syntaxStates[8]));/*Actions[21]*/
            // list[6]
            list[6].actionDict.Add(EType.Colon, new LRShiftInAction(syntaxStates[9]));/*Actions[22]*/
            // list[7]
            list[7].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[23]*/
            list[7].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[0]));/*Actions[24]*/
            list[7].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[0]));/*Actions[25]*/
            // list[8]
            list[8].actionDict.Add(EType.CandidateList, new LRGotoAction(syntaxStates[10]));/*Actions[26]*/
            list[8].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[11]));/*Actions[27]*/
            list[8].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[12]));/*Actions[28]*/
            list[8].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[29]*/
            list[8].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[30]*/
            list[8].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[31]*/
            // list[9]
            list[9].actionDict.Add(EType.pattern, new LRShiftInAction(syntaxStates[16]));/*Actions[32]*/
            // list[10]
            list[10].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[17]));/*Actions[33]*/
            list[10].actionDict.Add(EType.Pipe, new LRShiftInAction(syntaxStates[18]));/*Actions[34]*/
            // list[11]
            list[11].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[19]));/*Actions[35]*/
            list[11].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[36]*/
            list[11].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[37]*/
            list[11].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[38]*/
            list[11].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[6]));/*Actions[39]*/
            list[11].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[6]));/*Actions[40]*/
            // list[12]
            list[12].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[8]));/*Actions[41]*/
            list[12].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[8]));/*Actions[42]*/
            list[12].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[8]));/*Actions[43]*/
            list[12].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[8]));/*Actions[44]*/
            list[12].actionDict.Add(EType.empty, new LRReducitonAction(regulations[8]));/*Actions[45]*/
            // list[13]
            list[13].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[9]));/*Actions[46]*/
            list[13].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[9]));/*Actions[47]*/
            list[13].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[9]));/*Actions[48]*/
            list[13].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[9]));/*Actions[49]*/
            list[13].actionDict.Add(EType.empty, new LRReducitonAction(regulations[9]));/*Actions[50]*/
            // list[14]
            list[14].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[10]));/*Actions[51]*/
            list[14].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[10]));/*Actions[52]*/
            list[14].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[10]));/*Actions[53]*/
            list[14].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[10]));/*Actions[54]*/
            list[14].actionDict.Add(EType.empty, new LRReducitonAction(regulations[10]));/*Actions[55]*/
            // list[15]
            list[15].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[11]));/*Actions[56]*/
            list[15].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[11]));/*Actions[57]*/
            list[15].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[11]));/*Actions[58]*/
            list[15].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[11]));/*Actions[59]*/
            list[15].actionDict.Add(EType.empty, new LRReducitonAction(regulations[11]));/*Actions[60]*/
            // list[16]
            list[16].actionDict.Add(EType.Semicolon, new LRShiftInAction(syntaxStates[20]));/*Actions[61]*/
            // list[17]
            list[17].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[62]*/
            list[17].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[4]));/*Actions[63]*/
            list[17].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[4]));/*Actions[64]*/
            // list[18]
            list[18].actionDict.Add(EType.Candidate, new LRGotoAction(syntaxStates[21]));/*Actions[65]*/
            list[18].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[12]));/*Actions[66]*/
            list[18].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[67]*/
            list[18].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[68]*/
            list[18].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[69]*/
            // list[19]
            list[19].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[7]));/*Actions[70]*/
            list[19].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[7]));/*Actions[71]*/
            list[19].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[7]));/*Actions[72]*/
            list[19].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[7]));/*Actions[73]*/
            list[19].actionDict.Add(EType.empty, new LRReducitonAction(regulations[7]));/*Actions[74]*/
            // list[20]
            list[20].actionDict.Add(EType.EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[75]*/
            list[20].actionDict.Add(EType.Vn, new LRReducitonAction(regulations[12]));/*Actions[76]*/
            list[20].actionDict.Add(EType.Vt, new LRReducitonAction(regulations[12]));/*Actions[77]*/
            // list[21]
            list[21].actionDict.Add(EType.V, new LRGotoAction(syntaxStates[19]));/*Actions[78]*/
            list[21].actionDict.Add(EType.Vn, new LRShiftInAction(syntaxStates[13]));/*Actions[79]*/
            list[21].actionDict.Add(EType.Vt, new LRShiftInAction(syntaxStates[14]));/*Actions[80]*/
            list[21].actionDict.Add(EType.empty, new LRShiftInAction(syntaxStates[15]));/*Actions[81]*/
            list[21].actionDict.Add(EType.Semicolon, new LRReducitonAction(regulations[5]));/*Actions[82]*/
            list[21].actionDict.Add(EType.Pipe, new LRReducitonAction(regulations[5]));/*Actions[83]*/

        }
    }
}
