using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    partial class CompilerCalc {
        // const int VnCount = 3;
        // NOTE: choose only one from CompilerCalc.TableLL(1).cs, CompilerCalc.TableLR(0).cs, CompilerCalc.TableSLR(1).cs, CompilerCalc.TableLALR(1).cs, CompilerCalc.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.Additive, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = CompilerCalc.LL1SyntaxParsingTable;
            // 14 actions. 8 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                //@LeftParenthesis repeated 3 times
                //@number repeated 3 times
                line.Add(EType.@LeftParenthesis, regulations[0]);/*Actions[0]*/
                line.Add(EType.@LeftParenthesis, regulations[1]);/*Actions[1]*/
                line.Add(EType.@LeftParenthesis, regulations[2]);/*Actions[2]*/
                line.Add(EType.@number, regulations[0]);/*Actions[3]*/
                line.Add(EType.@number, regulations[1]);/*Actions[4]*/
                line.Add(EType.@number, regulations[2]);/*Actions[5]*/
                table.Add(EType.Additive, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                //@LeftParenthesis repeated 3 times
                //@number repeated 3 times
                line.Add(EType.@LeftParenthesis, regulations[3]);/*Actions[6]*/
                line.Add(EType.@LeftParenthesis, regulations[4]);/*Actions[7]*/
                line.Add(EType.@LeftParenthesis, regulations[5]);/*Actions[8]*/
                line.Add(EType.@number, regulations[3]);/*Actions[9]*/
                line.Add(EType.@number, regulations[4]);/*Actions[10]*/
                line.Add(EType.@number, regulations[5]);/*Actions[11]*/
                table.Add(EType.Multiplicative, line);
            }
            { // table[2]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.@LeftParenthesis, regulations[6]);/*Actions[12]*/
                line.Add(EType.@number, regulations[7]);/*Actions[13]*/
                table.Add(EType.Primary, line);
            }

        }
    }
}
