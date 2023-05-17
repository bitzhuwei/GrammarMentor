using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        const int syntaxStateCount = 32;
        // NOTE: choose only one from CompilerPattern.TableLL(1).cs, CompilerPattern.TableLR(0).cs, CompilerPattern.TableSLR(1).cs, CompilerPattern.TableLALR(1).cs, CompilerPattern.TableLR(1).cs
        /// <summary>
        /// LALR(1) syntax parsing table
        /// </summary>
        private static readonly SyntaxState[] syntaxStates = new SyntaxState[syntaxStateCount];
        /// <summary>
        /// <see cref="Token"/> list to syntax tree(<see cref="Node"/>).
        /// </summary>
        private readonly LRSyntaxParser syntaxParser = new LRSyntaxParser(CompilerPattern.syntaxStates[0], new Token(-1, -1, -1) { type = EType.EndOfTokenList, value = "[EOT]" });

        private static void InitializeSyntaxStates() {
            var list = CompilerPattern.syntaxStates;
            for (int i = 0; i < syntaxStateCount; i++) {
                list[i] = new SyntaxState($"{nameof(CompilerPattern)}.syntaxStates[{i}]");
            }
            // 206 actions. 0 conflicts.
            // syntaxStates[0]:
            // [-1] TokenDraft> : ⏳ Pattern ; '￥' 
            // [0] Pattern : ⏳ PreRegex Regex PostRegex ; '￥' 
            // [1] PreRegex : ⏳ 'refVt' ; 'char' '.' 'scope' '(' 
            // [2] PreRegex : ⏳ ; 'char' '.' 'scope' '(' 
            list[0].actionDict.Add(EType.Pattern, new LRGotoAction(syntaxStates[1]));/*Actions[0]*/
            list[0].actionDict.Add(EType.PreRegex, new LRGotoAction(syntaxStates[2]));/*Actions[1]*/
            list[0].actionDict.Add(EType.@refVt, new LRShiftInAction(syntaxStates[3]));/*Actions[2]*/
            list[0].actionDict.Add(EType.@char, new LRReducitonAction(regulations[2]));/*Actions[3]*/
            list[0].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[2]));/*Actions[4]*/
            list[0].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[2]));/*Actions[5]*/
            list[0].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[2]));/*Actions[6]*/
            // syntaxStates[1]:
            // [-1] TokenDraft> : Pattern ⏳ ; '￥' 
            list[1].actionDict.Add(EType.@EndOfTokenList, new LRAcceptAction(/*no param*/));/*Actions[7]*/
            // syntaxStates[2]:
            // [0] Pattern : PreRegex ⏳ Regex PostRegex ; '￥' 
            // [5] Regex : ⏳ Regex '|' Bunch ; '/' '￥' '|' 
            // [6] Regex : ⏳ Bunch ; '/' '￥' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[2].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[4]));/*Actions[8]*/
            list[2].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[9]*/
            list[2].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[10]*/
            list[2].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[11]*/
            list[2].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[12]*/
            list[2].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[13]*/
            list[2].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[14]*/
            // syntaxStates[3]:
            // [1] PreRegex : 'refVt' ⏳ ; 'char' '.' 'scope' '(' 
            list[3].actionDict.Add(EType.@char, new LRReducitonAction(regulations[1]));/*Actions[15]*/
            list[3].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[1]));/*Actions[16]*/
            list[3].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[1]));/*Actions[17]*/
            list[3].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[1]));/*Actions[18]*/
            // syntaxStates[4]:
            // [0] Pattern : PreRegex Regex ⏳ PostRegex ; '￥' 
            // [5] Regex : Regex ⏳ '|' Bunch ; '/' '￥' '|' 
            // [3] PostRegex : ⏳ '/' Regex ; '￥' 
            // [4] PostRegex : ⏳ ; '￥' 
            list[4].actionDict.Add(EType.PostRegex, new LRGotoAction(syntaxStates[11]));/*Actions[19]*/
            list[4].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[20]*/
            list[4].actionDict.Add(EType.@Slash, new LRShiftInAction(syntaxStates[13]));/*Actions[21]*/
            list[4].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[4]));/*Actions[22]*/
            // syntaxStates[5]:
            // [6] Regex : Bunch ⏳ ; '/' '￥' '|' ')' 
            // [7] Bunch : Bunch ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[5].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[23]*/
            list[5].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[24]*/
            list[5].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[25]*/
            list[5].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[26]*/
            list[5].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[27]*/
            list[5].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[6]));/*Actions[28]*/
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[29]*/
            list[5].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[30]*/
            list[5].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[6]));/*Actions[31]*/
            // syntaxStates[6]:
            // [8] Bunch : Unit ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[6].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[8]));/*Actions[32]*/
            list[6].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[8]));/*Actions[33]*/
            list[6].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[34]*/
            list[6].actionDict.Add(EType.@char, new LRReducitonAction(regulations[8]));/*Actions[35]*/
            list[6].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[8]));/*Actions[36]*/
            list[6].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[8]));/*Actions[37]*/
            list[6].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[38]*/
            list[6].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[8]));/*Actions[39]*/
            // syntaxStates[7]:
            // [9] Unit : 'char' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[7].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[15]));/*Actions[40]*/
            list[7].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[41]*/
            list[7].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[42]*/
            list[7].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[43]*/
            list[7].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[44]*/
            list[7].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[45]*/
            list[7].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[46]*/
            list[7].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[47]*/
            list[7].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[48]*/
            list[7].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[49]*/
            list[7].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[50]*/
            list[7].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[51]*/
            list[7].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[52]*/
            // syntaxStates[8]:
            // [10] Unit : '.' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[8].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[20]));/*Actions[53]*/
            list[8].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[54]*/
            list[8].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[55]*/
            list[8].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[56]*/
            list[8].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[57]*/
            list[8].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[58]*/
            list[8].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[59]*/
            list[8].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[60]*/
            list[8].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[61]*/
            list[8].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[62]*/
            list[8].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[63]*/
            list[8].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[64]*/
            list[8].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[65]*/
            // syntaxStates[9]:
            // [11] Unit : 'scope' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[9].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[21]));/*Actions[66]*/
            list[9].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[67]*/
            list[9].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[68]*/
            list[9].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[69]*/
            list[9].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[70]*/
            list[9].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[71]*/
            list[9].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[72]*/
            list[9].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[73]*/
            list[9].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[74]*/
            list[9].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[75]*/
            list[9].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[76]*/
            list[9].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[77]*/
            list[9].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[78]*/
            // syntaxStates[10]:
            // [12] Unit : '(' ⏳ Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [5] Regex : ⏳ Regex '|' Bunch ; ')' '|' 
            // [6] Regex : ⏳ Bunch ; ')' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[10].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[22]));/*Actions[79]*/
            list[10].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[80]*/
            list[10].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[81]*/
            list[10].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[82]*/
            list[10].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[83]*/
            list[10].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[84]*/
            list[10].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[85]*/
            // syntaxStates[11]:
            // [0] Pattern : PreRegex Regex PostRegex ⏳ ; '￥' 
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[86]*/
            // syntaxStates[12]:
            // [5] Regex : Regex '|' ⏳ Bunch ; '/' '￥' '|' ')' 
            // [7] Bunch : ⏳ Bunch Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [8] Bunch : ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[12].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[23]));/*Actions[87]*/
            list[12].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[88]*/
            list[12].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[89]*/
            list[12].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[90]*/
            list[12].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[91]*/
            list[12].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[92]*/
            // syntaxStates[13]:
            // [3] PostRegex : '/' ⏳ Regex ; '￥' 
            // [5] Regex : ⏳ Regex '|' Bunch ; '￥' '|' 
            // [6] Regex : ⏳ Bunch ; '￥' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; '￥' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            list[13].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[24]));/*Actions[93]*/
            list[13].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[5]));/*Actions[94]*/
            list[13].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[95]*/
            list[13].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[96]*/
            list[13].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[97]*/
            list[13].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[98]*/
            list[13].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[99]*/
            // syntaxStates[14]:
            // [7] Bunch : Bunch Unit ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[14].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[7]));/*Actions[100]*/
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[101]*/
            list[14].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[102]*/
            list[14].actionDict.Add(EType.@char, new LRReducitonAction(regulations[7]));/*Actions[103]*/
            list[14].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[7]));/*Actions[104]*/
            list[14].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[7]));/*Actions[105]*/
            list[14].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[106]*/
            list[14].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[7]));/*Actions[107]*/
            // syntaxStates[15]:
            // [9] Unit : 'char' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[15].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[9]));/*Actions[108]*/
            list[15].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[9]));/*Actions[109]*/
            list[15].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[110]*/
            list[15].actionDict.Add(EType.@char, new LRReducitonAction(regulations[9]));/*Actions[111]*/
            list[15].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[9]));/*Actions[112]*/
            list[15].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[9]));/*Actions[113]*/
            list[15].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[114]*/
            list[15].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[9]));/*Actions[115]*/
            // syntaxStates[16]:
            // [13] Repeat : '?' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[16].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[13]));/*Actions[116]*/
            list[16].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[13]));/*Actions[117]*/
            list[16].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[13]));/*Actions[118]*/
            list[16].actionDict.Add(EType.@char, new LRReducitonAction(regulations[13]));/*Actions[119]*/
            list[16].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[13]));/*Actions[120]*/
            list[16].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[13]));/*Actions[121]*/
            list[16].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[13]));/*Actions[122]*/
            list[16].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[13]));/*Actions[123]*/
            // syntaxStates[17]:
            // [14] Repeat : '+' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[17].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[14]));/*Actions[124]*/
            list[17].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[14]));/*Actions[125]*/
            list[17].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[14]));/*Actions[126]*/
            list[17].actionDict.Add(EType.@char, new LRReducitonAction(regulations[14]));/*Actions[127]*/
            list[17].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[14]));/*Actions[128]*/
            list[17].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[14]));/*Actions[129]*/
            list[17].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[14]));/*Actions[130]*/
            list[17].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[14]));/*Actions[131]*/
            // syntaxStates[18]:
            // [15] Repeat : '*' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[18].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[15]));/*Actions[132]*/
            list[18].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[15]));/*Actions[133]*/
            list[18].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[15]));/*Actions[134]*/
            list[18].actionDict.Add(EType.@char, new LRReducitonAction(regulations[15]));/*Actions[135]*/
            list[18].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[15]));/*Actions[136]*/
            list[18].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[15]));/*Actions[137]*/
            list[18].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[15]));/*Actions[138]*/
            list[18].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[15]));/*Actions[139]*/
            // syntaxStates[19]:
            // [16] Repeat : '{' ⏳ 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[19].actionDict.Add(EType.@min, new LRShiftInAction(syntaxStates[25]));/*Actions[140]*/
            // syntaxStates[20]:
            // [10] Unit : '.' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[20].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[10]));/*Actions[141]*/
            list[20].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[10]));/*Actions[142]*/
            list[20].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[143]*/
            list[20].actionDict.Add(EType.@char, new LRReducitonAction(regulations[10]));/*Actions[144]*/
            list[20].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[10]));/*Actions[145]*/
            list[20].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[10]));/*Actions[146]*/
            list[20].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[10]));/*Actions[147]*/
            list[20].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[10]));/*Actions[148]*/
            // syntaxStates[21]:
            // [11] Unit : 'scope' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[21].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[11]));/*Actions[149]*/
            list[21].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[11]));/*Actions[150]*/
            list[21].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[151]*/
            list[21].actionDict.Add(EType.@char, new LRReducitonAction(regulations[11]));/*Actions[152]*/
            list[21].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[11]));/*Actions[153]*/
            list[21].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[11]));/*Actions[154]*/
            list[21].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[11]));/*Actions[155]*/
            list[21].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[11]));/*Actions[156]*/
            // syntaxStates[22]:
            // [12] Unit : '(' Regex ⏳ ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [5] Regex : Regex ⏳ '|' Bunch ; ')' '|' 
            list[22].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[26]));/*Actions[157]*/
            list[22].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[158]*/
            // syntaxStates[23]:
            // [5] Regex : Regex '|' Bunch ⏳ ; '/' '￥' '|' ')' 
            // [7] Bunch : Bunch ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[23].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[159]*/
            list[23].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[160]*/
            list[23].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[161]*/
            list[23].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[162]*/
            list[23].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[163]*/
            list[23].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[5]));/*Actions[164]*/
            list[23].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[165]*/
            list[23].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[166]*/
            list[23].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[5]));/*Actions[167]*/
            // syntaxStates[24]:
            // [3] PostRegex : '/' Regex ⏳ ; '￥' 
            // [5] Regex : Regex ⏳ '|' Bunch ; '￥' '|' 
            list[24].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[12]));/*Actions[168]*/
            list[24].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[169]*/
            // syntaxStates[25]:
            // [16] Repeat : '{' 'min' ⏳ UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [18] UpperBound : ⏳ ',' 'max' ; '}' 
            // [19] UpperBound : ⏳ ',' ; '}' 
            // [20] UpperBound : ⏳ ; '}' 
            list[25].actionDict.Add(EType.UpperBound, new LRGotoAction(syntaxStates[27]));/*Actions[170]*/
            list[25].actionDict.Add(EType.@Comma, new LRShiftInAction(syntaxStates[28]));/*Actions[171]*/
            list[25].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[20]));/*Actions[172]*/
            // syntaxStates[26]:
            // [12] Unit : '(' Regex ')' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[26].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[29]));/*Actions[173]*/
            list[26].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[174]*/
            list[26].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[175]*/
            list[26].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[176]*/
            list[26].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[177]*/
            list[26].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[178]*/
            list[26].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[179]*/
            list[26].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[180]*/
            list[26].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[181]*/
            list[26].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[182]*/
            list[26].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[183]*/
            list[26].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[184]*/
            list[26].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[185]*/
            // syntaxStates[27]:
            // [16] Repeat : '{' 'min' UpperBound ⏳ '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[27].actionDict.Add(EType.@RightBrace, new LRShiftInAction(syntaxStates[30]));/*Actions[186]*/
            // syntaxStates[28]:
            // [18] UpperBound : ',' ⏳ 'max' ; '}' 
            // [19] UpperBound : ',' ⏳ ; '}' 
            list[28].actionDict.Add(EType.@max, new LRShiftInAction(syntaxStates[31]));/*Actions[187]*/
            list[28].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[19]));/*Actions[188]*/
            // syntaxStates[29]:
            // [12] Unit : '(' Regex ')' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[29].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[12]));/*Actions[189]*/
            list[29].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[190]*/
            list[29].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[191]*/
            list[29].actionDict.Add(EType.@char, new LRReducitonAction(regulations[12]));/*Actions[192]*/
            list[29].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[12]));/*Actions[193]*/
            list[29].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[12]));/*Actions[194]*/
            list[29].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[12]));/*Actions[195]*/
            list[29].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[12]));/*Actions[196]*/
            // syntaxStates[30]:
            // [16] Repeat : '{' 'min' UpperBound '}' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' ')' 
            list[30].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[16]));/*Actions[197]*/
            list[30].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[16]));/*Actions[198]*/
            list[30].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[16]));/*Actions[199]*/
            list[30].actionDict.Add(EType.@char, new LRReducitonAction(regulations[16]));/*Actions[200]*/
            list[30].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[16]));/*Actions[201]*/
            list[30].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[16]));/*Actions[202]*/
            list[30].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[16]));/*Actions[203]*/
            list[30].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[16]));/*Actions[204]*/
            // syntaxStates[31]:
            // [18] UpperBound : ',' 'max' ⏳ ; '}' 
            list[31].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[18]));/*Actions[205]*/

        }
    }
}
