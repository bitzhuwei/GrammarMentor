using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.PatternFormat {
    public partial class CompilerPattern {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{TokenDraft}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<TokenDraft>>> tokenDraftExtracterDict = new Dictionary<string, Action<Node, TContext<TokenDraft>>>();

        private static readonly Action<Node, TContext<TokenDraft>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeTokenDraftExtracterDict() {
            var extracterDict = tokenDraftExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, context) => {
            // nothing to do.
            //});
            //extracterDict.Add(EType.MultipleLineComment,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, context) => {
            // not needed.
            //});
            extracterDict.Add(EType.@refVt, VtHandler);
            extracterDict.Add(EType.@Slash, VtHandler);
            extracterDict.Add(EType.@Pipe, VtHandler);
            extracterDict.Add(EType.@char, VtHandler);
            extracterDict.Add(EType.@Dot, VtHandler);
            extracterDict.Add(EType.@scope, VtHandler);
            extracterDict.Add(EType.@LeftParenthesis, VtHandler);
            extracterDict.Add(EType.@RightParenthesis, VtHandler);
            extracterDict.Add(EType.@Question, VtHandler);
            extracterDict.Add(EType.@Plus, VtHandler);
            extracterDict.Add(EType.@Asterisk, VtHandler);
            extracterDict.Add(EType.@LeftBrace, VtHandler);
            extracterDict.Add(EType.@min, VtHandler);
            extracterDict.Add(EType.@RightBrace, VtHandler);
            extracterDict.Add(EType.@Comma, VtHandler);
            extracterDict.Add(EType.@max, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: TokenDraft> : Pattern ;
                var pattern = context.objStack.Pop() as Pattern;
                var tokenDraft = new TokenDraft(/*pattern*/);
                context.result = tokenDraft; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Pattern,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[0]) {
                    // 0: Pattern : PreRegex Regex PostRegex ;
                    var postRegex0 = context.objStack.Pop() as PostRegex;
                    var regex1 = context.objStack.Pop() as Regex;
                    var preRegex2 = context.objStack.Pop() as PreRegex;
                    var pattern = new Pattern(/*preRegex2, regex1, postRegex0*/);
                    context.objStack.Push(pattern);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PreRegex,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[1]) {
                    // 1: PreRegex : 'refVt' ;
                    var @refVt0 = context.objStack.Pop() as Token;
                    var preRegex = new PreRegex(/*@refVt0*/);
                    context.objStack.Push(preRegex);
                }
                else if (node.regulation == CompilerPattern.regulations[2]) {
                    // 2: PreRegex : ;
                    var preRegex = new PreRegex(/**/);
                    context.objStack.Push(preRegex);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.PostRegex,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[3]) {
                    // 3: PostRegex : '/' Regex ;
                    var regex0 = context.objStack.Pop() as Regex;
                    var @Slash1 = context.objStack.Pop() as Token;
                    var postRegex = new PostRegex(/*@Slash1, regex0*/);
                    context.objStack.Push(postRegex);
                }
                else if (node.regulation == CompilerPattern.regulations[4]) {
                    // 4: PostRegex : ;
                    var postRegex = new PostRegex(/**/);
                    context.objStack.Push(postRegex);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Regex,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[5]) {
                    // 5: Regex : Regex '|' Bunch ;
                    var bunch0 = context.objStack.Pop() as Bunch;
                    var @Pipe1 = context.objStack.Pop() as Token;
                    var regex2 = context.objStack.Pop() as Regex;
                    var regex = new Regex(/*regex2, @Pipe1, bunch0*/);
                    context.objStack.Push(regex);
                }
                else if (node.regulation == CompilerPattern.regulations[6]) {
                    // 6: Regex : Bunch ;
                    var bunch0 = context.objStack.Pop() as Bunch;
                    var regex = new Regex(/*bunch0*/);
                    context.objStack.Push(regex);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Bunch,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[7]) {
                    // 7: Bunch : Bunch Unit ;
                    var unit0 = context.objStack.Pop() as Unit;
                    var bunch1 = context.objStack.Pop() as Bunch;
                    var bunch = new Bunch(/*bunch1, unit0*/);
                    context.objStack.Push(bunch);
                }
                else if (node.regulation == CompilerPattern.regulations[8]) {
                    // 8: Bunch : Unit ;
                    var unit0 = context.objStack.Pop() as Unit;
                    var bunch = new Bunch(/*unit0*/);
                    context.objStack.Push(bunch);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Unit,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[9]) {
                    // 9: Unit : 'char' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var @char1 = context.objStack.Pop() as Token;
                    var unit = new Unit(/*@char1, repeat0*/);
                    context.objStack.Push(unit);
                }
                else if (node.regulation == CompilerPattern.regulations[10]) {
                    // 10: Unit : '.' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var @Dot1 = context.objStack.Pop() as Token;
                    var unit = new Unit(/*@Dot1, repeat0*/);
                    context.objStack.Push(unit);
                }
                else if (node.regulation == CompilerPattern.regulations[11]) {
                    // 11: Unit : 'scope' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var @scope1 = context.objStack.Pop() as Token;
                    var unit = new Unit(/*@scope1, repeat0*/);
                    context.objStack.Push(unit);
                }
                else if (node.regulation == CompilerPattern.regulations[12]) {
                    // 12: Unit : '(' Regex ')' Repeat ;
                    var repeat0 = context.objStack.Pop() as Repeat;
                    var @RightParenthesis1 = context.objStack.Pop() as Token;
                    var regex2 = context.objStack.Pop() as Regex;
                    var @LeftParenthesis3 = context.objStack.Pop() as Token;
                    var unit = new Unit(/*@LeftParenthesis3, regex2, @RightParenthesis1, repeat0*/);
                    context.objStack.Push(unit);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Repeat,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[13]) {
                    // 13: Repeat : '?' ;
                    var @Question0 = context.objStack.Pop() as Token;
                    var repeat = new Repeat(/*@Question0*/);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[14]) {
                    // 14: Repeat : '+' ;
                    var @Plus0 = context.objStack.Pop() as Token;
                    var repeat = new Repeat(/*@Plus0*/);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[15]) {
                    // 15: Repeat : '*' ;
                    var @Asterisk0 = context.objStack.Pop() as Token;
                    var repeat = new Repeat(/*@Asterisk0*/);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[16]) {
                    // 16: Repeat : '{' 'min' UpperBound '}' ;
                    var @RightBrace0 = context.objStack.Pop() as Token;
                    var upperBound1 = context.objStack.Pop() as UpperBound;
                    var @min2 = context.objStack.Pop() as Token;
                    var @LeftBrace3 = context.objStack.Pop() as Token;
                    var repeat = new Repeat(/*@LeftBrace3, @min2, upperBound1, @RightBrace0*/);
                    context.objStack.Push(repeat);
                }
                else if (node.regulation == CompilerPattern.regulations[17]) {
                    // 17: Repeat : ;
                    var repeat = new Repeat(/**/);
                    context.objStack.Push(repeat);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.UpperBound,
            (node, context) => {
                if (node.regulation == CompilerPattern.regulations[18]) {
                    // 18: UpperBound : ',' 'max' ;
                    var @max0 = context.objStack.Pop() as Token;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var upperBound = new UpperBound(/*@Comma1, @max0*/);
                    context.objStack.Push(upperBound);
                }
                else if (node.regulation == CompilerPattern.regulations[19]) {
                    // 19: UpperBound : ',' ;
                    var @Comma0 = context.objStack.Pop() as Token;
                    var upperBound = new UpperBound(/*@Comma0*/);
                    context.objStack.Push(upperBound);
                }
                else if (node.regulation == CompilerPattern.regulations[20]) {
                    // 20: UpperBound : ;
                    var upperBound = new UpperBound(/**/);
                    context.objStack.Push(upperBound);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}