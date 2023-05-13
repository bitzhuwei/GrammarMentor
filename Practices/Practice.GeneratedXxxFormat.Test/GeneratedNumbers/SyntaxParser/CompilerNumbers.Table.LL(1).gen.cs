using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.NumbersFormat {
    partial class CompilerNumbers {
        // const int VnCount = 2;
        // NOTE: choose only one from CompilerNumbers.TableLL(1).cs, CompilerNumbers.TableLR(0).cs, CompilerNumbers.TableSLR(1).cs, CompilerNumbers.TableLALR(1).cs, CompilerNumbers.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.Numbers, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerNumbers.LL1SyntaxParsingTable;
            // 6 actions. 2 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //@integer repeated 2 times
                //@float repeated 2 times
                line.Add(EType.@integer, regulations[0]);/*Actions[0]*/
                line.Add(EType.@integer, regulations[1]);/*Actions[1]*/
                line.Add(EType.@float, regulations[0]);/*Actions[2]*/
                line.Add(EType.@float, regulations[1]);/*Actions[3]*/
                table.Add(EType.Numbers, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@integer, regulations[2]);/*Actions[4]*/
                line.Add(EType.@float, regulations[3]);/*Actions[5]*/
                table.Add(EType.Number, line);
            }

        }
    }
}
