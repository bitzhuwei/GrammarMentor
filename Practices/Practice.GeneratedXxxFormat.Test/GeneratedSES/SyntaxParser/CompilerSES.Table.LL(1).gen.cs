using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        // const int VnCount = 3;
        // NOTE: choose only one from CompilerSES.TableLL(1).cs, CompilerSES.TableLR(0).cs, CompilerSES.TableSLR(1).cs, CompilerSES.TableLALR(1).cs, CompilerSES.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.S, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerSES.LL1SyntaxParsingTable;
            // 10 actions. 0 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@s, regulations[0]);/*Actions[0]*/
                line.Add(EType.@t, regulations[0]);/*Actions[1]*/
                line.Add(EType.@g, regulations[0]);/*Actions[2]*/
                line.Add(EType.@w, regulations[0]);/*Actions[3]*/
                table.Add(EType.S, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@s, regulations[1]);/*Actions[4]*/
                line.Add(EType.@t, regulations[2]);/*Actions[5]*/
                line.Add(EType.@g, regulations[3]);/*Actions[6]*/
                line.Add(EType.@w, regulations[4]);/*Actions[7]*/
                table.Add(EType.N, line);
            }
            { // table[2]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@e, regulations[5]);/*Actions[8]*/
                line.Add(EType.@d, regulations[6]);/*Actions[9]*/
                table.Add(EType.V, line);
            }

        }
    }
}
