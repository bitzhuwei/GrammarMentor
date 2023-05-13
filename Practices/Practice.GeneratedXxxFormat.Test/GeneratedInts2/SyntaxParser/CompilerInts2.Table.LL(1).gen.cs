using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.Ints2Format {
    partial class CompilerInts2 {
        // const int VnCount = 2;
        // NOTE: choose only one from CompilerInts2.TableLL(1).cs, CompilerInts2.TableLR(0).cs, CompilerInts2.TableSLR(1).cs, CompilerInts2.TableLALR(1).cs, CompilerInts2.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.Ints, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerInts2.LL1SyntaxParsingTable;
            // 3 actions. 1 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //@integer repeated 2 times
                line.Add(EType.@integer, regulations[0]);/*Actions[0]*/
                line.Add(EType.@integer, regulations[1]);/*Actions[1]*/
                table.Add(EType.Ints, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@integer, regulations[2]);/*Actions[2]*/
                table.Add(EType.Int, line);
            }

        }
    }
}
