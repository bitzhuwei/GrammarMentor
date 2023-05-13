using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
        // const int VnCount = 2;
        // NOTE: choose only one from CompilerPostfix.TableLL(1).cs, CompilerPostfix.TableLR(0).cs, CompilerPostfix.TableSLR(1).cs, CompilerPostfix.TableLALR(1).cs, CompilerPostfix.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.Items, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerPostfix.LL1SyntaxParsingTable;
            // 3 actions. 1 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //@entityId repeated 2 times
                line.Add(EType.@entityId, regulations[0]);/*Actions[0]*/
                line.Add(EType.@entityId, regulations[1]);/*Actions[1]*/
                table.Add(EType.Items, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@entityId, regulations[2]);/*Actions[2]*/
                table.Add(EType.Item, line);
            }

        }
    }
}
