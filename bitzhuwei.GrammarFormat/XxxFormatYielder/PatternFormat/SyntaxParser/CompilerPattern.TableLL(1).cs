using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        // const int VnCount = 8;
        // NOTE: choose only one from CompilerPattern.TableLL(1).cs, CompilerPattern.TableLR(0).cs, CompilerPattern.TableSLR(1).cs, CompilerPattern.TableLALR(1).cs, CompilerPattern.TableLR(1).cs
        /// <summary>
        /// LL(1) syntax parsing table
        /// </summary>
        private static readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable = new Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>>();
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LLSyntaxParser syntaxParser = new LLSyntaxParser(EType.Pattern, LL1SyntaxParsingTable, new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var table = LL1SyntaxParsingTable;
            // 45 actions. 9 conflicts.
            { // table[0]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.refVt, regulations[0]);/*Actions[0]*/
                line.Add(EType.char_, regulations[0]);/*Actions[1]*/
                line.Add(EType.Dot, regulations[0]);/*Actions[2]*/
                line.Add(EType.scope, regulations[0]);/*Actions[3]*/
                line.Add(EType.LeftParenthesis, regulations[0]);/*Actions[4]*/
                table.Add(EType.Pattern, line);
            }
            { // table[1]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.refVt, regulations[1]);/*Actions[5]*/
                line.Add(EType.char_, regulations[2]);/*Actions[6]*/
                line.Add(EType.Dot, regulations[2]);/*Actions[7]*/
                line.Add(EType.scope, regulations[2]);/*Actions[8]*/
                line.Add(EType.LeftParenthesis, regulations[2]);/*Actions[9]*/
                table.Add(EType.PreRegex, line);
            }
            { // table[2]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.Slash, regulations[3]);/*Actions[10]*/
                table.Add(EType.PostRegex, line);
            }
            { // table[3]
                var line = new Dictionary<string, Regulation>();
                //char_ repeated 2 times
                //Dot repeated 2 times
                //scope repeated 2 times
                //LeftParenthesis repeated 2 times
                line.Add(EType.char_, regulations[5]);/*Actions[11]*/
                line.Add(EType.char_, regulations[6]);/*Actions[12]*/
                line.Add(EType.Dot, regulations[5]);/*Actions[13]*/
                line.Add(EType.Dot, regulations[6]);/*Actions[14]*/
                line.Add(EType.scope, regulations[5]);/*Actions[15]*/
                line.Add(EType.scope, regulations[6]);/*Actions[16]*/
                line.Add(EType.LeftParenthesis, regulations[5]);/*Actions[17]*/
                line.Add(EType.LeftParenthesis, regulations[6]);/*Actions[18]*/
                table.Add(EType.Regex, line);
            }
            { // table[4]
                var line = new Dictionary<string, Regulation>();
                //char_ repeated 2 times
                //Dot repeated 2 times
                //scope repeated 2 times
                //LeftParenthesis repeated 2 times
                line.Add(EType.char_, regulations[7]);/*Actions[19]*/
                line.Add(EType.char_, regulations[8]);/*Actions[20]*/
                line.Add(EType.Dot, regulations[7]);/*Actions[21]*/
                line.Add(EType.Dot, regulations[8]);/*Actions[22]*/
                line.Add(EType.scope, regulations[7]);/*Actions[23]*/
                line.Add(EType.scope, regulations[8]);/*Actions[24]*/
                line.Add(EType.LeftParenthesis, regulations[7]);/*Actions[25]*/
                line.Add(EType.LeftParenthesis, regulations[8]);/*Actions[26]*/
                table.Add(EType.Bunch, line);
            }
            { // table[5]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.char_, regulations[9]);/*Actions[27]*/
                line.Add(EType.Dot, regulations[10]);/*Actions[28]*/
                line.Add(EType.scope, regulations[11]);/*Actions[29]*/
                line.Add(EType.LeftParenthesis, regulations[12]);/*Actions[30]*/
                table.Add(EType.Unit, line);
            }
            { // table[6]
                var line = new Dictionary<string, Regulation>();
                line.Add(EType.Question, regulations[13]);/*Actions[31]*/
                line.Add(EType.Plus, regulations[14]);/*Actions[32]*/
                line.Add(EType.Asterisk, regulations[15]);/*Actions[33]*/
                line.Add(EType.LeftBrace, regulations[16]);/*Actions[34]*/
                line.Add(EType.Slash, regulations[17]);/*Actions[35]*/
                line.Add(EType.Pipe, regulations[17]);/*Actions[36]*/
                line.Add(EType.char_, regulations[17]);/*Actions[37]*/
                line.Add(EType.Dot, regulations[17]);/*Actions[38]*/
                line.Add(EType.scope, regulations[17]);/*Actions[39]*/
                line.Add(EType.LeftParenthesis, regulations[17]);/*Actions[40]*/
                line.Add(EType.RightParenthesis, regulations[17]);/*Actions[41]*/
                table.Add(EType.Repeat, line);
            }
            { // table[7]
                var line = new Dictionary<string, Regulation>();
                //Comma repeated 2 times
                line.Add(EType.Comma, regulations[18]);/*Actions[42]*/
                line.Add(EType.Comma, regulations[19]);/*Actions[43]*/
                line.Add(EType.RightBrace, regulations[20]);/*Actions[44]*/
                table.Add(EType.UpperBound, line);
            }

        }
    }
}
