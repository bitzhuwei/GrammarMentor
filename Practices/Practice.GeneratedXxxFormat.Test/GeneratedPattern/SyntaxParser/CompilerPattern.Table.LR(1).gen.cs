using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        const int syntaxStateCount = 76;
        // NOTE: choose only one from CompilerPattern.TableLL(1).cs, CompilerPattern.TableLR(0).cs, CompilerPattern.TableSLR(1).cs, CompilerPattern.TableLALR(1).cs, CompilerPattern.TableLR(1).cs
        /// <summary>
        /// LR(1) syntax parsing table
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
            // 466 actions. 0 conflicts.
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
            // [6] Regex : Bunch ⏳ ; '/' '￥' '|' 
            // [7] Bunch : Bunch ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[5].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[23]*/
            list[5].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[24]*/
            list[5].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[25]*/
            list[5].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[26]*/
            list[5].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[27]*/
            list[5].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[6]));/*Actions[28]*/
            list[5].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[29]*/
            list[5].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[30]*/
            // syntaxStates[6]:
            // [8] Bunch : Unit ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[6].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[8]));/*Actions[31]*/
            list[6].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[8]));/*Actions[32]*/
            list[6].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[33]*/
            list[6].actionDict.Add(EType.@char, new LRReducitonAction(regulations[8]));/*Actions[34]*/
            list[6].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[8]));/*Actions[35]*/
            list[6].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[8]));/*Actions[36]*/
            list[6].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[37]*/
            // syntaxStates[7]:
            // [9] Unit : 'char' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[7].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[15]));/*Actions[38]*/
            list[7].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[39]*/
            list[7].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[40]*/
            list[7].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[41]*/
            list[7].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[42]*/
            list[7].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[43]*/
            list[7].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[44]*/
            list[7].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[45]*/
            list[7].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[46]*/
            list[7].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[47]*/
            list[7].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[48]*/
            list[7].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[49]*/
            // syntaxStates[8]:
            // [10] Unit : '.' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[8].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[20]));/*Actions[50]*/
            list[8].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[51]*/
            list[8].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[52]*/
            list[8].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[53]*/
            list[8].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[54]*/
            list[8].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[55]*/
            list[8].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[56]*/
            list[8].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[57]*/
            list[8].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[58]*/
            list[8].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[59]*/
            list[8].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[60]*/
            list[8].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[61]*/
            // syntaxStates[9]:
            // [11] Unit : 'scope' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[9].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[21]));/*Actions[62]*/
            list[9].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[63]*/
            list[9].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[64]*/
            list[9].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[65]*/
            list[9].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[66]*/
            list[9].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[67]*/
            list[9].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[68]*/
            list[9].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[69]*/
            list[9].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[70]*/
            list[9].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[71]*/
            list[9].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[72]*/
            list[9].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[73]*/
            // syntaxStates[10]:
            // [12] Unit : '(' ⏳ Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [5] Regex : ⏳ Regex '|' Bunch ; ')' '|' 
            // [6] Regex : ⏳ Bunch ; ')' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[10].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[22]));/*Actions[74]*/
            list[10].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[23]));/*Actions[75]*/
            list[10].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[24]));/*Actions[76]*/
            list[10].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[25]));/*Actions[77]*/
            list[10].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[26]));/*Actions[78]*/
            list[10].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[27]));/*Actions[79]*/
            list[10].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[28]));/*Actions[80]*/
            // syntaxStates[11]:
            // [0] Pattern : PreRegex Regex PostRegex ⏳ ; '￥' 
            list[11].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[0]));/*Actions[81]*/
            // syntaxStates[12]:
            // [5] Regex : Regex '|' ⏳ Bunch ; '/' '￥' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[12].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[29]));/*Actions[82]*/
            list[12].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[6]));/*Actions[83]*/
            list[12].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[84]*/
            list[12].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[85]*/
            list[12].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[86]*/
            list[12].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[87]*/
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
            list[13].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[30]));/*Actions[88]*/
            list[13].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[31]));/*Actions[89]*/
            list[13].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[32]));/*Actions[90]*/
            list[13].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[33]));/*Actions[91]*/
            list[13].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[34]));/*Actions[92]*/
            list[13].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[35]));/*Actions[93]*/
            list[13].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[36]));/*Actions[94]*/
            // syntaxStates[14]:
            // [7] Bunch : Bunch Unit ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[14].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[7]));/*Actions[95]*/
            list[14].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[96]*/
            list[14].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[97]*/
            list[14].actionDict.Add(EType.@char, new LRReducitonAction(regulations[7]));/*Actions[98]*/
            list[14].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[7]));/*Actions[99]*/
            list[14].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[7]));/*Actions[100]*/
            list[14].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[101]*/
            // syntaxStates[15]:
            // [9] Unit : 'char' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[15].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[9]));/*Actions[102]*/
            list[15].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[9]));/*Actions[103]*/
            list[15].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[104]*/
            list[15].actionDict.Add(EType.@char, new LRReducitonAction(regulations[9]));/*Actions[105]*/
            list[15].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[9]));/*Actions[106]*/
            list[15].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[9]));/*Actions[107]*/
            list[15].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[108]*/
            // syntaxStates[16]:
            // [13] Repeat : '?' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[16].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[13]));/*Actions[109]*/
            list[16].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[13]));/*Actions[110]*/
            list[16].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[13]));/*Actions[111]*/
            list[16].actionDict.Add(EType.@char, new LRReducitonAction(regulations[13]));/*Actions[112]*/
            list[16].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[13]));/*Actions[113]*/
            list[16].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[13]));/*Actions[114]*/
            list[16].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[13]));/*Actions[115]*/
            // syntaxStates[17]:
            // [14] Repeat : '+' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[17].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[14]));/*Actions[116]*/
            list[17].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[14]));/*Actions[117]*/
            list[17].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[14]));/*Actions[118]*/
            list[17].actionDict.Add(EType.@char, new LRReducitonAction(regulations[14]));/*Actions[119]*/
            list[17].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[14]));/*Actions[120]*/
            list[17].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[14]));/*Actions[121]*/
            list[17].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[14]));/*Actions[122]*/
            // syntaxStates[18]:
            // [15] Repeat : '*' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[18].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[15]));/*Actions[123]*/
            list[18].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[15]));/*Actions[124]*/
            list[18].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[15]));/*Actions[125]*/
            list[18].actionDict.Add(EType.@char, new LRReducitonAction(regulations[15]));/*Actions[126]*/
            list[18].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[15]));/*Actions[127]*/
            list[18].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[15]));/*Actions[128]*/
            list[18].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[15]));/*Actions[129]*/
            // syntaxStates[19]:
            // [16] Repeat : '{' ⏳ 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[19].actionDict.Add(EType.@min, new LRShiftInAction(syntaxStates[37]));/*Actions[130]*/
            // syntaxStates[20]:
            // [10] Unit : '.' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[20].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[10]));/*Actions[131]*/
            list[20].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[10]));/*Actions[132]*/
            list[20].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[133]*/
            list[20].actionDict.Add(EType.@char, new LRReducitonAction(regulations[10]));/*Actions[134]*/
            list[20].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[10]));/*Actions[135]*/
            list[20].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[10]));/*Actions[136]*/
            list[20].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[10]));/*Actions[137]*/
            // syntaxStates[21]:
            // [11] Unit : 'scope' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[21].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[11]));/*Actions[138]*/
            list[21].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[11]));/*Actions[139]*/
            list[21].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[140]*/
            list[21].actionDict.Add(EType.@char, new LRReducitonAction(regulations[11]));/*Actions[141]*/
            list[21].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[11]));/*Actions[142]*/
            list[21].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[11]));/*Actions[143]*/
            list[21].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[11]));/*Actions[144]*/
            // syntaxStates[22]:
            // [12] Unit : '(' Regex ⏳ ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [5] Regex : Regex ⏳ '|' Bunch ; ')' '|' 
            list[22].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[38]));/*Actions[145]*/
            list[22].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[39]));/*Actions[146]*/
            // syntaxStates[23]:
            // [6] Regex : Bunch ⏳ ; ')' '|' 
            // [7] Bunch : Bunch ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[23].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[40]));/*Actions[147]*/
            list[23].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[25]));/*Actions[148]*/
            list[23].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[26]));/*Actions[149]*/
            list[23].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[27]));/*Actions[150]*/
            list[23].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[28]));/*Actions[151]*/
            list[23].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[6]));/*Actions[152]*/
            list[23].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[153]*/
            // syntaxStates[24]:
            // [8] Bunch : Unit ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[24].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[8]));/*Actions[154]*/
            list[24].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[155]*/
            list[24].actionDict.Add(EType.@char, new LRReducitonAction(regulations[8]));/*Actions[156]*/
            list[24].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[8]));/*Actions[157]*/
            list[24].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[8]));/*Actions[158]*/
            list[24].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[159]*/
            // syntaxStates[25]:
            // [9] Unit : 'char' ⏳ Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; ')' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; ')' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; ')' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; ')' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[25].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[41]));/*Actions[160]*/
            list[25].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[42]));/*Actions[161]*/
            list[25].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[43]));/*Actions[162]*/
            list[25].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[44]));/*Actions[163]*/
            list[25].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[45]));/*Actions[164]*/
            list[25].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[165]*/
            list[25].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[166]*/
            list[25].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[167]*/
            list[25].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[168]*/
            list[25].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[169]*/
            list[25].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[170]*/
            // syntaxStates[26]:
            // [10] Unit : '.' ⏳ Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; ')' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; ')' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; ')' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; ')' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[26].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[46]));/*Actions[171]*/
            list[26].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[42]));/*Actions[172]*/
            list[26].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[43]));/*Actions[173]*/
            list[26].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[44]));/*Actions[174]*/
            list[26].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[45]));/*Actions[175]*/
            list[26].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[176]*/
            list[26].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[177]*/
            list[26].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[178]*/
            list[26].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[179]*/
            list[26].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[180]*/
            list[26].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[181]*/
            // syntaxStates[27]:
            // [11] Unit : 'scope' ⏳ Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; ')' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; ')' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; ')' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; ')' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[27].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[47]));/*Actions[182]*/
            list[27].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[42]));/*Actions[183]*/
            list[27].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[43]));/*Actions[184]*/
            list[27].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[44]));/*Actions[185]*/
            list[27].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[45]));/*Actions[186]*/
            list[27].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[187]*/
            list[27].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[188]*/
            list[27].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[189]*/
            list[27].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[190]*/
            list[27].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[191]*/
            list[27].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[192]*/
            // syntaxStates[28]:
            // [12] Unit : '(' ⏳ Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [5] Regex : ⏳ Regex '|' Bunch ; ')' '|' 
            // [6] Regex : ⏳ Bunch ; ')' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[28].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[48]));/*Actions[193]*/
            list[28].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[23]));/*Actions[194]*/
            list[28].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[24]));/*Actions[195]*/
            list[28].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[25]));/*Actions[196]*/
            list[28].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[26]));/*Actions[197]*/
            list[28].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[27]));/*Actions[198]*/
            list[28].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[28]));/*Actions[199]*/
            // syntaxStates[29]:
            // [5] Regex : Regex '|' Bunch ⏳ ; '/' '￥' '|' 
            // [7] Bunch : Bunch ⏳ Unit ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[29].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[14]));/*Actions[200]*/
            list[29].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[7]));/*Actions[201]*/
            list[29].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[8]));/*Actions[202]*/
            list[29].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[9]));/*Actions[203]*/
            list[29].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[10]));/*Actions[204]*/
            list[29].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[5]));/*Actions[205]*/
            list[29].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[206]*/
            list[29].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[207]*/
            // syntaxStates[30]:
            // [3] PostRegex : '/' Regex ⏳ ; '￥' 
            // [5] Regex : Regex ⏳ '|' Bunch ; '￥' '|' 
            list[30].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[49]));/*Actions[208]*/
            list[30].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[3]));/*Actions[209]*/
            // syntaxStates[31]:
            // [6] Regex : Bunch ⏳ ; '￥' '|' 
            // [7] Bunch : Bunch ⏳ Unit ; '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            list[31].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[50]));/*Actions[210]*/
            list[31].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[33]));/*Actions[211]*/
            list[31].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[34]));/*Actions[212]*/
            list[31].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[35]));/*Actions[213]*/
            list[31].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[36]));/*Actions[214]*/
            list[31].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[6]));/*Actions[215]*/
            list[31].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[6]));/*Actions[216]*/
            // syntaxStates[32]:
            // [8] Bunch : Unit ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[32].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[8]));/*Actions[217]*/
            list[32].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[8]));/*Actions[218]*/
            list[32].actionDict.Add(EType.@char, new LRReducitonAction(regulations[8]));/*Actions[219]*/
            list[32].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[8]));/*Actions[220]*/
            list[32].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[8]));/*Actions[221]*/
            list[32].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[8]));/*Actions[222]*/
            // syntaxStates[33]:
            // [9] Unit : 'char' ⏳ Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[33].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[51]));/*Actions[223]*/
            list[33].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[52]));/*Actions[224]*/
            list[33].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[53]));/*Actions[225]*/
            list[33].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[54]));/*Actions[226]*/
            list[33].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[55]));/*Actions[227]*/
            list[33].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[228]*/
            list[33].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[229]*/
            list[33].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[230]*/
            list[33].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[231]*/
            list[33].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[232]*/
            list[33].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[233]*/
            // syntaxStates[34]:
            // [10] Unit : '.' ⏳ Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[34].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[56]));/*Actions[234]*/
            list[34].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[52]));/*Actions[235]*/
            list[34].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[53]));/*Actions[236]*/
            list[34].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[54]));/*Actions[237]*/
            list[34].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[55]));/*Actions[238]*/
            list[34].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[239]*/
            list[34].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[240]*/
            list[34].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[241]*/
            list[34].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[242]*/
            list[34].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[243]*/
            list[34].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[244]*/
            // syntaxStates[35]:
            // [11] Unit : 'scope' ⏳ Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[35].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[57]));/*Actions[245]*/
            list[35].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[52]));/*Actions[246]*/
            list[35].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[53]));/*Actions[247]*/
            list[35].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[54]));/*Actions[248]*/
            list[35].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[55]));/*Actions[249]*/
            list[35].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[250]*/
            list[35].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[251]*/
            list[35].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[252]*/
            list[35].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[253]*/
            list[35].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[254]*/
            list[35].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[255]*/
            // syntaxStates[36]:
            // [12] Unit : '(' ⏳ Regex ')' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [5] Regex : ⏳ Regex '|' Bunch ; ')' '|' 
            // [6] Regex : ⏳ Bunch ; ')' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[36].actionDict.Add(EType.Regex, new LRGotoAction(syntaxStates[58]));/*Actions[256]*/
            list[36].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[23]));/*Actions[257]*/
            list[36].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[24]));/*Actions[258]*/
            list[36].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[25]));/*Actions[259]*/
            list[36].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[26]));/*Actions[260]*/
            list[36].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[27]));/*Actions[261]*/
            list[36].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[28]));/*Actions[262]*/
            // syntaxStates[37]:
            // [16] Repeat : '{' 'min' ⏳ UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [18] UpperBound : ⏳ ',' 'max' ; '}' 
            // [19] UpperBound : ⏳ ',' ; '}' 
            // [20] UpperBound : ⏳ ; '}' 
            list[37].actionDict.Add(EType.UpperBound, new LRGotoAction(syntaxStates[59]));/*Actions[263]*/
            list[37].actionDict.Add(EType.@Comma, new LRShiftInAction(syntaxStates[60]));/*Actions[264]*/
            list[37].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[20]));/*Actions[265]*/
            // syntaxStates[38]:
            // [12] Unit : '(' Regex ')' ⏳ Repeat ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[38].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[61]));/*Actions[266]*/
            list[38].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[16]));/*Actions[267]*/
            list[38].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[17]));/*Actions[268]*/
            list[38].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[18]));/*Actions[269]*/
            list[38].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[19]));/*Actions[270]*/
            list[38].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[17]));/*Actions[271]*/
            list[38].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[272]*/
            list[38].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[273]*/
            list[38].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[274]*/
            list[38].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[275]*/
            list[38].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[276]*/
            list[38].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[277]*/
            // syntaxStates[39]:
            // [5] Regex : Regex '|' ⏳ Bunch ; ')' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[39].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[62]));/*Actions[278]*/
            list[39].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[24]));/*Actions[279]*/
            list[39].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[25]));/*Actions[280]*/
            list[39].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[26]));/*Actions[281]*/
            list[39].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[27]));/*Actions[282]*/
            list[39].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[28]));/*Actions[283]*/
            // syntaxStates[40]:
            // [7] Bunch : Bunch Unit ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[40].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[7]));/*Actions[284]*/
            list[40].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[285]*/
            list[40].actionDict.Add(EType.@char, new LRReducitonAction(regulations[7]));/*Actions[286]*/
            list[40].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[7]));/*Actions[287]*/
            list[40].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[7]));/*Actions[288]*/
            list[40].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[289]*/
            // syntaxStates[41]:
            // [9] Unit : 'char' Repeat ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[41].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[9]));/*Actions[290]*/
            list[41].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[291]*/
            list[41].actionDict.Add(EType.@char, new LRReducitonAction(regulations[9]));/*Actions[292]*/
            list[41].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[9]));/*Actions[293]*/
            list[41].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[9]));/*Actions[294]*/
            list[41].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[295]*/
            // syntaxStates[42]:
            // [13] Repeat : '?' ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[42].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[13]));/*Actions[296]*/
            list[42].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[13]));/*Actions[297]*/
            list[42].actionDict.Add(EType.@char, new LRReducitonAction(regulations[13]));/*Actions[298]*/
            list[42].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[13]));/*Actions[299]*/
            list[42].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[13]));/*Actions[300]*/
            list[42].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[13]));/*Actions[301]*/
            // syntaxStates[43]:
            // [14] Repeat : '+' ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[43].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[14]));/*Actions[302]*/
            list[43].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[14]));/*Actions[303]*/
            list[43].actionDict.Add(EType.@char, new LRReducitonAction(regulations[14]));/*Actions[304]*/
            list[43].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[14]));/*Actions[305]*/
            list[43].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[14]));/*Actions[306]*/
            list[43].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[14]));/*Actions[307]*/
            // syntaxStates[44]:
            // [15] Repeat : '*' ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[44].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[15]));/*Actions[308]*/
            list[44].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[15]));/*Actions[309]*/
            list[44].actionDict.Add(EType.@char, new LRReducitonAction(regulations[15]));/*Actions[310]*/
            list[44].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[15]));/*Actions[311]*/
            list[44].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[15]));/*Actions[312]*/
            list[44].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[15]));/*Actions[313]*/
            // syntaxStates[45]:
            // [16] Repeat : '{' ⏳ 'min' UpperBound '}' ; ')' '|' 'char' '.' 'scope' '(' 
            list[45].actionDict.Add(EType.@min, new LRShiftInAction(syntaxStates[63]));/*Actions[314]*/
            // syntaxStates[46]:
            // [10] Unit : '.' Repeat ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[46].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[10]));/*Actions[315]*/
            list[46].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[316]*/
            list[46].actionDict.Add(EType.@char, new LRReducitonAction(regulations[10]));/*Actions[317]*/
            list[46].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[10]));/*Actions[318]*/
            list[46].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[10]));/*Actions[319]*/
            list[46].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[10]));/*Actions[320]*/
            // syntaxStates[47]:
            // [11] Unit : 'scope' Repeat ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[47].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[11]));/*Actions[321]*/
            list[47].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[322]*/
            list[47].actionDict.Add(EType.@char, new LRReducitonAction(regulations[11]));/*Actions[323]*/
            list[47].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[11]));/*Actions[324]*/
            list[47].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[11]));/*Actions[325]*/
            list[47].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[11]));/*Actions[326]*/
            // syntaxStates[48]:
            // [12] Unit : '(' Regex ⏳ ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [5] Regex : Regex ⏳ '|' Bunch ; ')' '|' 
            list[48].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[64]));/*Actions[327]*/
            list[48].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[39]));/*Actions[328]*/
            // syntaxStates[49]:
            // [5] Regex : Regex '|' ⏳ Bunch ; '￥' '|' 
            // [7] Bunch : ⏳ Bunch Unit ; '￥' '|' 'char' '.' 'scope' '(' 
            // [8] Bunch : ⏳ Unit ; '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            list[49].actionDict.Add(EType.Bunch, new LRGotoAction(syntaxStates[65]));/*Actions[329]*/
            list[49].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[32]));/*Actions[330]*/
            list[49].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[33]));/*Actions[331]*/
            list[49].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[34]));/*Actions[332]*/
            list[49].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[35]));/*Actions[333]*/
            list[49].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[36]));/*Actions[334]*/
            // syntaxStates[50]:
            // [7] Bunch : Bunch Unit ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[50].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[7]));/*Actions[335]*/
            list[50].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[7]));/*Actions[336]*/
            list[50].actionDict.Add(EType.@char, new LRReducitonAction(regulations[7]));/*Actions[337]*/
            list[50].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[7]));/*Actions[338]*/
            list[50].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[7]));/*Actions[339]*/
            list[50].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[7]));/*Actions[340]*/
            // syntaxStates[51]:
            // [9] Unit : 'char' Repeat ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[51].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[9]));/*Actions[341]*/
            list[51].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[9]));/*Actions[342]*/
            list[51].actionDict.Add(EType.@char, new LRReducitonAction(regulations[9]));/*Actions[343]*/
            list[51].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[9]));/*Actions[344]*/
            list[51].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[9]));/*Actions[345]*/
            list[51].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[9]));/*Actions[346]*/
            // syntaxStates[52]:
            // [13] Repeat : '?' ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[52].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[13]));/*Actions[347]*/
            list[52].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[13]));/*Actions[348]*/
            list[52].actionDict.Add(EType.@char, new LRReducitonAction(regulations[13]));/*Actions[349]*/
            list[52].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[13]));/*Actions[350]*/
            list[52].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[13]));/*Actions[351]*/
            list[52].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[13]));/*Actions[352]*/
            // syntaxStates[53]:
            // [14] Repeat : '+' ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[53].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[14]));/*Actions[353]*/
            list[53].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[14]));/*Actions[354]*/
            list[53].actionDict.Add(EType.@char, new LRReducitonAction(regulations[14]));/*Actions[355]*/
            list[53].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[14]));/*Actions[356]*/
            list[53].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[14]));/*Actions[357]*/
            list[53].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[14]));/*Actions[358]*/
            // syntaxStates[54]:
            // [15] Repeat : '*' ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[54].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[15]));/*Actions[359]*/
            list[54].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[15]));/*Actions[360]*/
            list[54].actionDict.Add(EType.@char, new LRReducitonAction(regulations[15]));/*Actions[361]*/
            list[54].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[15]));/*Actions[362]*/
            list[54].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[15]));/*Actions[363]*/
            list[54].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[15]));/*Actions[364]*/
            // syntaxStates[55]:
            // [16] Repeat : '{' ⏳ 'min' UpperBound '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            list[55].actionDict.Add(EType.@min, new LRShiftInAction(syntaxStates[66]));/*Actions[365]*/
            // syntaxStates[56]:
            // [10] Unit : '.' Repeat ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[56].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[10]));/*Actions[366]*/
            list[56].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[10]));/*Actions[367]*/
            list[56].actionDict.Add(EType.@char, new LRReducitonAction(regulations[10]));/*Actions[368]*/
            list[56].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[10]));/*Actions[369]*/
            list[56].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[10]));/*Actions[370]*/
            list[56].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[10]));/*Actions[371]*/
            // syntaxStates[57]:
            // [11] Unit : 'scope' Repeat ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[57].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[11]));/*Actions[372]*/
            list[57].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[11]));/*Actions[373]*/
            list[57].actionDict.Add(EType.@char, new LRReducitonAction(regulations[11]));/*Actions[374]*/
            list[57].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[11]));/*Actions[375]*/
            list[57].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[11]));/*Actions[376]*/
            list[57].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[11]));/*Actions[377]*/
            // syntaxStates[58]:
            // [12] Unit : '(' Regex ⏳ ')' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [5] Regex : Regex ⏳ '|' Bunch ; ')' '|' 
            list[58].actionDict.Add(EType.@RightParenthesis, new LRShiftInAction(syntaxStates[67]));/*Actions[378]*/
            list[58].actionDict.Add(EType.@Pipe, new LRShiftInAction(syntaxStates[39]));/*Actions[379]*/
            // syntaxStates[59]:
            // [16] Repeat : '{' 'min' UpperBound ⏳ '}' ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[59].actionDict.Add(EType.@RightBrace, new LRShiftInAction(syntaxStates[68]));/*Actions[380]*/
            // syntaxStates[60]:
            // [18] UpperBound : ',' ⏳ 'max' ; '}' 
            // [19] UpperBound : ',' ⏳ ; '}' 
            list[60].actionDict.Add(EType.@max, new LRShiftInAction(syntaxStates[69]));/*Actions[381]*/
            list[60].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[19]));/*Actions[382]*/
            // syntaxStates[61]:
            // [12] Unit : '(' Regex ')' Repeat ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[61].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[12]));/*Actions[383]*/
            list[61].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[384]*/
            list[61].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[385]*/
            list[61].actionDict.Add(EType.@char, new LRReducitonAction(regulations[12]));/*Actions[386]*/
            list[61].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[12]));/*Actions[387]*/
            list[61].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[12]));/*Actions[388]*/
            list[61].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[12]));/*Actions[389]*/
            // syntaxStates[62]:
            // [5] Regex : Regex '|' Bunch ⏳ ; ')' '|' 
            // [7] Bunch : Bunch ⏳ Unit ; ')' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            list[62].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[40]));/*Actions[390]*/
            list[62].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[25]));/*Actions[391]*/
            list[62].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[26]));/*Actions[392]*/
            list[62].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[27]));/*Actions[393]*/
            list[62].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[28]));/*Actions[394]*/
            list[62].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[5]));/*Actions[395]*/
            list[62].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[396]*/
            // syntaxStates[63]:
            // [16] Repeat : '{' 'min' ⏳ UpperBound '}' ; ')' '|' 'char' '.' 'scope' '(' 
            // [18] UpperBound : ⏳ ',' 'max' ; '}' 
            // [19] UpperBound : ⏳ ',' ; '}' 
            // [20] UpperBound : ⏳ ; '}' 
            list[63].actionDict.Add(EType.UpperBound, new LRGotoAction(syntaxStates[70]));/*Actions[397]*/
            list[63].actionDict.Add(EType.@Comma, new LRShiftInAction(syntaxStates[60]));/*Actions[398]*/
            list[63].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[20]));/*Actions[399]*/
            // syntaxStates[64]:
            // [12] Unit : '(' Regex ')' ⏳ Repeat ; ')' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; ')' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; ')' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; ')' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; ')' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[64].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[71]));/*Actions[400]*/
            list[64].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[42]));/*Actions[401]*/
            list[64].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[43]));/*Actions[402]*/
            list[64].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[44]));/*Actions[403]*/
            list[64].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[45]));/*Actions[404]*/
            list[64].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[17]));/*Actions[405]*/
            list[64].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[406]*/
            list[64].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[407]*/
            list[64].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[408]*/
            list[64].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[409]*/
            list[64].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[410]*/
            // syntaxStates[65]:
            // [5] Regex : Regex '|' Bunch ⏳ ; '￥' '|' 
            // [7] Bunch : Bunch ⏳ Unit ; '￥' '|' 'char' '.' 'scope' '(' 
            // [9] Unit : ⏳ 'char' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [10] Unit : ⏳ '.' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [11] Unit : ⏳ 'scope' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [12] Unit : ⏳ '(' Regex ')' Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            list[65].actionDict.Add(EType.Unit, new LRGotoAction(syntaxStates[50]));/*Actions[411]*/
            list[65].actionDict.Add(EType.@char, new LRShiftInAction(syntaxStates[33]));/*Actions[412]*/
            list[65].actionDict.Add(EType.@Dot, new LRShiftInAction(syntaxStates[34]));/*Actions[413]*/
            list[65].actionDict.Add(EType.@scope, new LRShiftInAction(syntaxStates[35]));/*Actions[414]*/
            list[65].actionDict.Add(EType.@LeftParenthesis, new LRShiftInAction(syntaxStates[36]));/*Actions[415]*/
            list[65].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[5]));/*Actions[416]*/
            list[65].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[5]));/*Actions[417]*/
            // syntaxStates[66]:
            // [16] Repeat : '{' 'min' ⏳ UpperBound '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [18] UpperBound : ⏳ ',' 'max' ; '}' 
            // [19] UpperBound : ⏳ ',' ; '}' 
            // [20] UpperBound : ⏳ ; '}' 
            list[66].actionDict.Add(EType.UpperBound, new LRGotoAction(syntaxStates[72]));/*Actions[418]*/
            list[66].actionDict.Add(EType.@Comma, new LRShiftInAction(syntaxStates[60]));/*Actions[419]*/
            list[66].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[20]));/*Actions[420]*/
            // syntaxStates[67]:
            // [12] Unit : '(' Regex ')' ⏳ Repeat ; '￥' '|' 'char' '.' 'scope' '(' 
            // [13] Repeat : ⏳ '?' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [14] Repeat : ⏳ '+' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [15] Repeat : ⏳ '*' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [16] Repeat : ⏳ '{' 'min' UpperBound '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            // [17] Repeat : ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[67].actionDict.Add(EType.Repeat, new LRGotoAction(syntaxStates[73]));/*Actions[421]*/
            list[67].actionDict.Add(EType.@Question, new LRShiftInAction(syntaxStates[52]));/*Actions[422]*/
            list[67].actionDict.Add(EType.@Plus, new LRShiftInAction(syntaxStates[53]));/*Actions[423]*/
            list[67].actionDict.Add(EType.@Asterisk, new LRShiftInAction(syntaxStates[54]));/*Actions[424]*/
            list[67].actionDict.Add(EType.@LeftBrace, new LRShiftInAction(syntaxStates[55]));/*Actions[425]*/
            list[67].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[17]));/*Actions[426]*/
            list[67].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[17]));/*Actions[427]*/
            list[67].actionDict.Add(EType.@char, new LRReducitonAction(regulations[17]));/*Actions[428]*/
            list[67].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[17]));/*Actions[429]*/
            list[67].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[17]));/*Actions[430]*/
            list[67].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[17]));/*Actions[431]*/
            // syntaxStates[68]:
            // [16] Repeat : '{' 'min' UpperBound '}' ⏳ ; '/' '￥' '|' 'char' '.' 'scope' '(' 
            list[68].actionDict.Add(EType.@Slash, new LRReducitonAction(regulations[16]));/*Actions[432]*/
            list[68].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[16]));/*Actions[433]*/
            list[68].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[16]));/*Actions[434]*/
            list[68].actionDict.Add(EType.@char, new LRReducitonAction(regulations[16]));/*Actions[435]*/
            list[68].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[16]));/*Actions[436]*/
            list[68].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[16]));/*Actions[437]*/
            list[68].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[16]));/*Actions[438]*/
            // syntaxStates[69]:
            // [18] UpperBound : ',' 'max' ⏳ ; '}' 
            list[69].actionDict.Add(EType.@RightBrace, new LRReducitonAction(regulations[18]));/*Actions[439]*/
            // syntaxStates[70]:
            // [16] Repeat : '{' 'min' UpperBound ⏳ '}' ; ')' '|' 'char' '.' 'scope' '(' 
            list[70].actionDict.Add(EType.@RightBrace, new LRShiftInAction(syntaxStates[74]));/*Actions[440]*/
            // syntaxStates[71]:
            // [12] Unit : '(' Regex ')' Repeat ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[71].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[12]));/*Actions[441]*/
            list[71].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[442]*/
            list[71].actionDict.Add(EType.@char, new LRReducitonAction(regulations[12]));/*Actions[443]*/
            list[71].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[12]));/*Actions[444]*/
            list[71].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[12]));/*Actions[445]*/
            list[71].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[12]));/*Actions[446]*/
            // syntaxStates[72]:
            // [16] Repeat : '{' 'min' UpperBound ⏳ '}' ; '￥' '|' 'char' '.' 'scope' '(' 
            list[72].actionDict.Add(EType.@RightBrace, new LRShiftInAction(syntaxStates[75]));/*Actions[447]*/
            // syntaxStates[73]:
            // [12] Unit : '(' Regex ')' Repeat ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[73].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[12]));/*Actions[448]*/
            list[73].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[12]));/*Actions[449]*/
            list[73].actionDict.Add(EType.@char, new LRReducitonAction(regulations[12]));/*Actions[450]*/
            list[73].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[12]));/*Actions[451]*/
            list[73].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[12]));/*Actions[452]*/
            list[73].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[12]));/*Actions[453]*/
            // syntaxStates[74]:
            // [16] Repeat : '{' 'min' UpperBound '}' ⏳ ; ')' '|' 'char' '.' 'scope' '(' 
            list[74].actionDict.Add(EType.@RightParenthesis, new LRReducitonAction(regulations[16]));/*Actions[454]*/
            list[74].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[16]));/*Actions[455]*/
            list[74].actionDict.Add(EType.@char, new LRReducitonAction(regulations[16]));/*Actions[456]*/
            list[74].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[16]));/*Actions[457]*/
            list[74].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[16]));/*Actions[458]*/
            list[74].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[16]));/*Actions[459]*/
            // syntaxStates[75]:
            // [16] Repeat : '{' 'min' UpperBound '}' ⏳ ; '￥' '|' 'char' '.' 'scope' '(' 
            list[75].actionDict.Add(EType.@EndOfTokenList, new LRReducitonAction(regulations[16]));/*Actions[460]*/
            list[75].actionDict.Add(EType.@Pipe, new LRReducitonAction(regulations[16]));/*Actions[461]*/
            list[75].actionDict.Add(EType.@char, new LRReducitonAction(regulations[16]));/*Actions[462]*/
            list[75].actionDict.Add(EType.@Dot, new LRReducitonAction(regulations[16]));/*Actions[463]*/
            list[75].actionDict.Add(EType.@scope, new LRReducitonAction(regulations[16]));/*Actions[464]*/
            list[75].actionDict.Add(EType.@LeftParenthesis, new LRReducitonAction(regulations[16]));/*Actions[465]*/

        }
    }
}
