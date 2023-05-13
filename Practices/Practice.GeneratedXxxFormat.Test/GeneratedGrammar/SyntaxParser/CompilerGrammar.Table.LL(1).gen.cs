using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        // const int VnCount = 8;
        // NOTE: choose only one from CompilerGrammar.TableLL(1).cs, CompilerGrammar.TableLR(0).cs, CompilerGrammar.TableSLR(1).cs, CompilerGrammar.TableLALR(1).cs, CompilerGrammar.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.StatementList, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerGrammar.LL1SyntaxParsingTable;
            // 23 actions. 7 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //@Vn repeated 2 times
                //@Vt repeated 2 times
                line.Add(EType.@Vn, regulations[0]);/*Actions[0]*/
                line.Add(EType.@Vn, regulations[1]);/*Actions[1]*/
                line.Add(EType.@Vt, regulations[0]);/*Actions[2]*/
                line.Add(EType.@Vt, regulations[1]);/*Actions[3]*/
                table.Add(EType.StatementList, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@Vn, regulations[2]);/*Actions[4]*/
                line.Add(EType.@Vt, regulations[3]);/*Actions[5]*/
                table.Add(EType.Statement, line);
            }
            { // table[2]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@Vn, regulations[4]);/*Actions[6]*/
                table.Add(EType.SyntaxProduction, line);
            }
            { // table[3]
                var line = new Dictionary<string, Regulation>();
                //@empty repeated 2 times
                //@Vn repeated 2 times
                //@Vt repeated 2 times
                line.Add(EType.@empty, regulations[5]);/*Actions[7]*/
                line.Add(EType.@empty, regulations[6]);/*Actions[8]*/
                line.Add(EType.@Vn, regulations[5]);/*Actions[9]*/
                line.Add(EType.@Vn, regulations[6]);/*Actions[10]*/
                line.Add(EType.@Vt, regulations[5]);/*Actions[11]*/
                line.Add(EType.@Vt, regulations[6]);/*Actions[12]*/
                table.Add(EType.CandidateList, line);
            }
            { // table[4]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@Vn, regulations[7]);/*Actions[13]*/
                line.Add(EType.@Vt, regulations[7]);/*Actions[14]*/
                line.Add(EType.@empty, regulations[8]);/*Actions[15]*/
                table.Add(EType.Candidate, line);
            }
            { // table[5]
                var line = new Dictionary<string, Regulation>();
                //@Vn repeated 2 times
                //@Vt repeated 2 times
                line.Add(EType.@Vn, regulations[9]);/*Actions[16]*/
                line.Add(EType.@Vn, regulations[10]);/*Actions[17]*/
                line.Add(EType.@Vt, regulations[9]);/*Actions[18]*/
                line.Add(EType.@Vt, regulations[10]);/*Actions[19]*/
                table.Add(EType.VList, line);
            }
            { // table[6]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@Vn, regulations[11]);/*Actions[20]*/
                line.Add(EType.@Vt, regulations[12]);/*Actions[21]*/
                table.Add(EType.V, line);
            }
            { // table[7]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@Vt, regulations[13]);/*Actions[22]*/
                table.Add(EType.LexiProduction, line);
            }

        }
    }
}
