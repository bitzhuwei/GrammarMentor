using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ErrorFormat {
    partial class CompilerError {
        // const int VnCount = 1;
        // NOTE: choose only one from CompilerError.TableLL(1).cs, CompilerError.TableLR(0).cs, CompilerError.TableSLR(1).cs, CompilerError.TableLALR(1).cs, CompilerError.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.PreRegex, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerError.LL1SyntaxParsingTable;
            // 1 actions. 0 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@refVt, regulations[0]);/*Actions[0]*/
                table.Add(EType.PreRegex, line);
            }

        }
    }
}
