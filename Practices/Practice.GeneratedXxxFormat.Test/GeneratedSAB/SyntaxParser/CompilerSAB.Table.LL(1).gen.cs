using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SABFormat {
    partial class CompilerSAB {
        // const int VnCount = 3;
        // NOTE: choose only one from CompilerSAB.TableLL(1).cs, CompilerSAB.TableLR(0).cs, CompilerSAB.TableSLR(1).cs, CompilerSAB.TableLALR(1).cs, CompilerSAB.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.S, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerSAB.LL1SyntaxParsingTable;
            // 7 actions. 0 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@a, regulations[0]);/*Actions[0]*/
                line.Add(EType.@c, regulations[1]);/*Actions[1]*/
                line.Add(EType.@b, regulations[1]);/*Actions[2]*/
                line.Add(EType.@d, regulations[2]);/*Actions[3]*/
                table.Add(EType.S, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@a, regulations[3]);/*Actions[4]*/
                table.Add(EType.A, line);
            }
            { // table[2]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@c, regulations[4]);/*Actions[5]*/
                line.Add(EType.@b, regulations[5]);/*Actions[6]*/
                table.Add(EType.B, line);
            }

        }
    }
}
