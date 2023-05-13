//using bitzhuwei.Compiler;
//using System.Collections.Generic;
//using System;
//using System.Diagnostics.Eventing.Reader;
//using System.Collections;
//using System.Data;
//using System.Net.Http.Headers;

//namespace bitzhuwei.PatternFormat {
//    public partial class CompilerPattern {
//        /// <summary>
//        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{SomeToken}}"/>
//        /// </summary>
//        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<SomeToken>>> someTokenExtracterDict = new Dictionary<string, Action<Node, TContext<SomeToken>>>();

//        /// <summary>
//        /// initialize dict for extracter.
//        /// </summary>
//        private static void InitializeSomeTokenExtracterDict() {
//            var extracterDict = someTokenExtracterDict;
//            //extracterDict.Add(EType.NotYet,
//            //(node, context) => {
//            // not needed.
//            //});
//            //extracterDict.Add(EType.Error,
//            //(node, context) => {
//            // nothing to do.
//            //});
//            //extracterDict.Add(EType.MultipleLineComment,
//            //(node, context) => {
//            // not needed.
//            //});
//            //extracterDict.Add(EType.SingleLineComment,
//            //(node, context) => {
//            // not needed.
//            //});
//            extracterDict.Add(EType.refVt,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Slash,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Pipe,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.char_,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Dot,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.scope,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.LeftParenthesis,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.RightParenthesis,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Question,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Plus,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Asterisk,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.LeftBrace,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.min,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.RightBrace,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.Comma,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.max,
//            (node, context) => {
//                var token = context.tokens[node.tokenIndex];
//                context.objStack.Push(token.value);
//            });
//            extracterDict.Add(EType.EndOfTokenList,
//            (node, context) => {
//                // -1: SomeToken> : Pattern ;
//                var pattern = context.objStack.Pop() as Pattern;
//                var someToken = new SomeToken(/*pattern*/);
//                context.result = someToken; // final step, no need to push into stack.
//            });
//            extracterDict.Add(EType.Pattern,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[0])
//                {
//                    // 0: Pattern : PreRegex Regex PostRegex ;
//                    var postRegex0 = context.objStack.Pop() as PostRegex;
//                    var regex1 = context.objStack.Pop() as Regex;
//                    var preRegex2 = context.objStack.Pop() as PreRegex;
//                    var pattern = new Pattern(/*preRegex2, regex1, postRegex0*/);
//                    context.objStack.Push(pattern);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.PreRegex,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[1])
//                {
//                    // 1: PreRegex : 'refVt' ;
//                    var refVt0 = context.objStack.Pop() as string;
//                    var preRegex = new PreRegex(/*refVt0*/);
//                    context.objStack.Push(preRegex);
//                }
//                else if (node.regulation == CompilerPattern.regulations[2])
//                {
//                    // 2: PreRegex : ;
//                    var preRegex = new PreRegex(/**/);
//                    context.objStack.Push(preRegex);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.PostRegex,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[3])
//                {
//                    // 3: PostRegex : '/' Regex ;
//                    var regex0 = context.objStack.Pop() as Regex;
//                    var slash1 = context.objStack.Pop() as string;
//                    var postRegex = new PostRegex(/*slash1, regex0*/);
//                    context.objStack.Push(postRegex);
//                }
//                else if (node.regulation == CompilerPattern.regulations[4])
//                {
//                    // 4: PostRegex : ;
//                    var postRegex = new PostRegex(/**/);
//                    context.objStack.Push(postRegex);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.Regex,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[5])
//                {
//                    // 5: Regex : Regex '|' Bunch ;
//                    var bunch0 = context.objStack.Pop() as Bunch;
//                    var pipe1 = context.objStack.Pop() as string;
//                    var regex2 = context.objStack.Pop() as Regex;
//                    var regex = new Regex(/*regex2, pipe1, bunch0*/);
//                    context.objStack.Push(regex);
//                }
//                else if (node.regulation == CompilerPattern.regulations[6])
//                {
//                    // 6: Regex : Bunch ;
//                    var bunch0 = context.objStack.Pop() as Bunch;
//                    var regex = new Regex(/*bunch0*/);
//                    context.objStack.Push(regex);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.Bunch,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[7])
//                {
//                    // 7: Bunch : Bunch Unit ;
//                    var unit0 = context.objStack.Pop() as Unit;
//                    var bunch1 = context.objStack.Pop() as Bunch;
//                    var bunch = new Bunch(/*bunch1, unit0*/);
//                    context.objStack.Push(bunch);
//                }
//                else if (node.regulation == CompilerPattern.regulations[8])
//                {
//                    // 8: Bunch : Unit ;
//                    var unit0 = context.objStack.Pop() as Unit;
//                    var bunch = new Bunch(/*unit0*/);
//                    context.objStack.Push(bunch);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.Unit,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[9])
//                {
//                    // 9: Unit : 'char' Repeat ;
//                    var repeat0 = context.objStack.Pop() as Repeat;
//                    var char_1 = context.objStack.Pop() as string;
//                    var unit = new Unit(/*char_1, repeat0*/);
//                    context.objStack.Push(unit);
//                }
//                else if (node.regulation == CompilerPattern.regulations[10])
//                {
//                    // 10: Unit : '.' Repeat ;
//                    var repeat0 = context.objStack.Pop() as Repeat;
//                    var dot1 = context.objStack.Pop() as string;
//                    var unit = new Unit(/*dot1, repeat0*/);
//                    context.objStack.Push(unit);
//                }
//                else if (node.regulation == CompilerPattern.regulations[11])
//                {
//                    // 11: Unit : 'scope' Repeat ;
//                    var repeat0 = context.objStack.Pop() as Repeat;
//                    var scope1 = context.objStack.Pop() as string;
//                    var unit = new Unit(/*scope1, repeat0*/);
//                    context.objStack.Push(unit);
//                }
//                else if (node.regulation == CompilerPattern.regulations[12])
//                {
//                    // 12: Unit : '(' Regex ')' Repeat ;
//                    var repeat0 = context.objStack.Pop() as Repeat;
//                    var rightParenthesis1 = context.objStack.Pop() as string;
//                    var regex2 = context.objStack.Pop() as Regex;
//                    var leftParenthesis3 = context.objStack.Pop() as string;
//                    var unit = new Unit(/*leftParenthesis3, regex2, rightParenthesis1, repeat0*/);
//                    context.objStack.Push(unit);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.Repeat,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[13])
//                {
//                    // 13: Repeat : '?' ;
//                    var question0 = context.objStack.Pop() as string;
//                    var repeat = new Repeat(/*question0*/);
//                    context.objStack.Push(repeat);
//                }
//                else if (node.regulation == CompilerPattern.regulations[14])
//                {
//                    // 14: Repeat : '+' ;
//                    var plus0 = context.objStack.Pop() as string;
//                    var repeat = new Repeat(/*plus0*/);
//                    context.objStack.Push(repeat);
//                }
//                else if (node.regulation == CompilerPattern.regulations[15])
//                {
//                    // 15: Repeat : '*' ;
//                    var asterisk0 = context.objStack.Pop() as string;
//                    var repeat = new Repeat(/*asterisk0*/);
//                    context.objStack.Push(repeat);
//                }
//                else if (node.regulation == CompilerPattern.regulations[16])
//                {
//                    // 16: Repeat : '{' 'min' UpperBound '}' ;
//                    var rightBrace0 = context.objStack.Pop() as string;
//                    var upperBound1 = context.objStack.Pop() as UpperBound;
//                    var min2 = context.objStack.Pop() as string;
//                    var leftBrace3 = context.objStack.Pop() as string;
//                    var repeat = new Repeat(/*leftBrace3, min2, upperBound1, rightBrace0*/);
//                    context.objStack.Push(repeat);
//                }
//                else if (node.regulation == CompilerPattern.regulations[17])
//                {
//                    // 17: Repeat : ;
//                    var repeat = new Repeat(/**/);
//                    context.objStack.Push(repeat);
//                }
//                else { throw new NotImplementedException(); }
//            });
//            extracterDict.Add(EType.UpperBound,
//            (node, context) => {
//                if (node.regulation == CompilerPattern.regulations[18])
//                {
//                    // 18: UpperBound : ',' 'max' ;
//                    var max0 = context.objStack.Pop() as string;
//                    var comma1 = context.objStack.Pop() as string;
//                    var upperBound = new UpperBound(/*comma1, max0*/);
//                    context.objStack.Push(upperBound);
//                }
//                else if (node.regulation == CompilerPattern.regulations[19])
//                {
//                    // 19: UpperBound : ',' ;
//                    var comma0 = context.objStack.Pop() as string;
//                    var upperBound = new UpperBound(/*comma0*/);
//                    context.objStack.Push(upperBound);
//                }
//                else if (node.regulation == CompilerPattern.regulations[20])
//                {
//                    // 20: UpperBound : ;
//                    var upperBound = new UpperBound(/**/);
//                    context.objStack.Push(upperBound);
//                }
//                else { throw new NotImplementedException(); }
//            });

//        }
//    }
//}