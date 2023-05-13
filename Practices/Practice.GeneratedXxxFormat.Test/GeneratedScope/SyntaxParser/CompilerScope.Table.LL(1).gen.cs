using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        // const int VnCount = 3;
        // NOTE: choose only one from CompilerScope.TableLL(1).cs, CompilerScope.TableLR(0).cs, CompilerScope.TableSLR(1).cs, CompilerScope.TableLALR(1).cs, CompilerScope.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.Scope, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerScope.LL1SyntaxParsingTable;
            // 7 actions. 3 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //@LeftBracket repeated 2 times
                //@LeftBracketCaret repeated 2 times
                line.Add(EType.@LeftBracket, regulations[0]);/*Actions[0]*/
                line.Add(EType.@LeftBracket, regulations[2]);/*Actions[1]*/
                line.Add(EType.@LeftBracketCaret, regulations[1]);/*Actions[2]*/
                line.Add(EType.@LeftBracketCaret, regulations[3]);/*Actions[3]*/
                table.Add(EType.Scope, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                //@char repeated 2 times
                line.Add(EType.@char, regulations[4]);/*Actions[4]*/
                line.Add(EType.@char, regulations[5]);/*Actions[5]*/
                table.Add(EType.RangeItems, line);
            }
            { // table[2]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@char, regulations[6]);/*Actions[6]*/
                table.Add(EType.RangeItem, line);
            }

        }
    }
}
