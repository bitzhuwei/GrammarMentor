using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.VFormat {
    partial class CompilerV {
        // const int VnCount = 1;
        // NOTE: choose only one from CompilerV.TableLL(1).cs, CompilerV.TableLR(0).cs, CompilerV.TableSLR(1).cs, CompilerV.TableLALR(1).cs, CompilerV.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.V, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerV.LL1SyntaxParsingTable;
            // 1 actions. 0 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@Vt, regulations[0]);/*Actions[0]*/
                table.Add(EType.V, line);
            }

        }
    }
}
