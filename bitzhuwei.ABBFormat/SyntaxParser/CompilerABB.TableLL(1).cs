using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat
{
    partial class CompilerABB
    {
        // NOTE: choose only one from CompilerABB.TableLL(1).cs, CompilerABB.TableLR(0).cs, CompilerABB.TableSLR(1).cs, CompilerABB.TableLALR(1).cs, CompilerABB.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.A, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates()
        {
            var table = LL1SyntaxParsingTable;
            // 3 actions. 1 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //a repeated 2 times
                line.Add(EType.a, regulations[0]);/*Actions[0]*/
                line.Add(EType.a, regulations[1]);/*Actions[1]*/
                table.Add(EType.A, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.b, regulations[2]);/*Actions[2]*/
                table.Add(EType.B, line);
            }

        }
    }
}
