using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.ScopeFormat {
    public partial class CompilerScope {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{ResolvedScope}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<ResolvedScope>>> resolvedScopeExtracterDict = new Dictionary<string, Action<Node, TContext<ResolvedScope>>>();

        private static readonly Action<Node, TContext<ResolvedScope>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeResolvedScopeExtracterDict() {
            var extracterDict = resolvedScopeExtracterDict;
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
            extracterDict.Add(EType.@LeftBracket, VtHandler);
            extracterDict.Add(EType.@firstItem1, VtHandler);
            extracterDict.Add(EType.@RightBracket, VtHandler);
            extracterDict.Add(EType.@LeftBracketCaret, VtHandler);
            extracterDict.Add(EType.@firstItem2, VtHandler);
            extracterDict.Add(EType.@char, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: ResolvedScope> : Scope ;
                var scope = context.objStack.Pop() as Scope;
                var resolvedScope = new ResolvedScope(/*scope*/);
                context.result = resolvedScope; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Scope,
            (node, context) => {
                if (node.regulation == CompilerScope.regulations[0]) {
                    // 0: Scope : '[' 'firstItem1' RangeItems ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var rangeItems1 = context.objStack.Pop() as RangeItems;
                    var @firstItem12 = context.objStack.Pop() as Token;
                    var @LeftBracket3 = context.objStack.Pop() as Token;
                    var scope = new Scope(/*@LeftBracket3, @firstItem12, rangeItems1, @RightBracket0*/);
                    context.objStack.Push(scope);
                }
                else if (node.regulation == CompilerScope.regulations[1]) {
                    // 1: Scope : '[^' 'firstItem2' RangeItems ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var rangeItems1 = context.objStack.Pop() as RangeItems;
                    var @firstItem22 = context.objStack.Pop() as Token;
                    var @LeftBracketCaret3 = context.objStack.Pop() as Token;
                    var scope = new Scope(/*@LeftBracketCaret3, @firstItem22, rangeItems1, @RightBracket0*/);
                    context.objStack.Push(scope);
                }
                else if (node.regulation == CompilerScope.regulations[2]) {
                    // 2: Scope : '[' 'firstItem1' ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var @firstItem11 = context.objStack.Pop() as Token;
                    var @LeftBracket2 = context.objStack.Pop() as Token;
                    var scope = new Scope(/*@LeftBracket2, @firstItem11, @RightBracket0*/);
                    context.objStack.Push(scope);
                }
                else if (node.regulation == CompilerScope.regulations[3]) {
                    // 3: Scope : '[^' 'firstItem2' ']' ;
                    var @RightBracket0 = context.objStack.Pop() as Token;
                    var @firstItem21 = context.objStack.Pop() as Token;
                    var @LeftBracketCaret2 = context.objStack.Pop() as Token;
                    var scope = new Scope(/*@LeftBracketCaret2, @firstItem21, @RightBracket0*/);
                    context.objStack.Push(scope);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.RangeItems,
            (node, context) => {
                if (node.regulation == CompilerScope.regulations[4]) {
                    // 4: RangeItems : RangeItems RangeItem ;
                    var rangeItem0 = context.objStack.Pop() as RangeItem;
                    var rangeItems1 = context.objStack.Pop() as RangeItems;
                    var rangeItems = new RangeItems(/*rangeItems1, rangeItem0*/);
                    context.objStack.Push(rangeItems);
                }
                else if (node.regulation == CompilerScope.regulations[5]) {
                    // 5: RangeItems : RangeItem ;
                    var rangeItem0 = context.objStack.Pop() as RangeItem;
                    var rangeItems = new RangeItems(/*rangeItem0*/);
                    context.objStack.Push(rangeItems);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.RangeItem,
            (node, context) => {
                if (node.regulation == CompilerScope.regulations[6]) {
                    // 6: RangeItem : 'char' ;
                    var @char0 = context.objStack.Pop() as Token;
                    var rangeItem = new RangeItem(/*@char0*/);
                    context.objStack.Push(rangeItem);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}