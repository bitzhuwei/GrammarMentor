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
            //extracterDict.Add(EType.@LeftBracket, VtHandler);
            extracterDict.Add(EType.@firstItem1, VtHandler);
            //extracterDict.Add(EType.@RightBracket, VtHandler);
            //extracterDict.Add(EType.@LeftBracketCaret, VtHandler);
            extracterDict.Add(EType.@firstItem2, VtHandler);
            extracterDict.Add(EType.@char, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: ResolvedScope> : Scope ;
                var scope = context.objStack.Pop() as Scope;
                var resolvedScope = new ResolvedScope(scope);
                context.result = resolvedScope; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Scope,
            (node, context) => {
                if (node.regulation == CompilerScope.regulations[0]) {
                    // 0: Scope : '[' 'firstItem1' RangeItems ']' ;
                    var rangeItems1 = context.objStack.Pop() as List<char>;
                    var @firstItem12 = context.objStack.Pop() as Token;
                    var c = CompilerScope.ToContent(@firstItem12.value);
                    rangeItems1.Insert(0, c);
                    var scope = new Scope(reverse: false, items: rangeItems1.ToArray());
                    context.objStack.Push(scope);
                }
                else if (node.regulation == CompilerScope.regulations[1]) {
                    // 1: Scope : '[^' 'firstItem2' RangeItems ']' ;
                    var rangeItems1 = context.objStack.Pop() as List<char>;
                    var @firstItem22 = context.objStack.Pop() as Token;
                    var c = CompilerScope.ToContent(@firstItem22.value);
                    rangeItems1.Insert(0, c);
                    var scope = new Scope(reverse: true, items: rangeItems1.ToArray());
                    context.objStack.Push(scope);
                }
                else if (node.regulation == CompilerScope.regulations[2]) {
                    // 2: Scope : '[' 'firstItem1' ']' ;
                    var @firstItem11 = context.objStack.Pop() as Token;
                    var c = CompilerScope.ToContent(@firstItem11.value);
                    var array = new char[] { c };
                    var scope = new Scope(reverse: false, items: array);
                    context.objStack.Push(scope);
                }
                else if (node.regulation == CompilerScope.regulations[3]) {
                    // 3: Scope : '[^' 'firstItem2' ']' ;
                    var @firstItem21 = context.objStack.Pop() as Token;
                    var c = CompilerScope.ToContent(@firstItem21.value);
                    var array = new char[] { c };
                    var scope = new Scope(reverse: true, items: array);
                    context.objStack.Push(scope);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.RangeItems,
            (node, context) => {
                if (node.regulation == CompilerScope.regulations[4]) {
                    // 4: RangeItems : RangeItems RangeItem ;
                    var rangeItem0 = context.objStack.Pop() as Token;
                    var rangeItems1 = context.objStack.Pop() as List<char>;
                    var c = CompilerScope.ToContent(rangeItem0.value);
                    rangeItems1.Add(c);
                    context.objStack.Push(rangeItems1);
                }
                else if (node.regulation == CompilerScope.regulations[5]) {
                    // 5: RangeItems : RangeItem ;
                    var rangeItem0 = context.objStack.Pop() as Token;
                    var c = CompilerScope.ToContent(rangeItem0.value);
                    var list = new List<char>(); list.Add(c);
                    context.objStack.Push(list);
                }
                else { throw new NotImplementedException(); }
            });
            //extracterDict.Add(EType.RangeItem,
            //(node, context) => {
            //    if (node.regulation == CompilerScope.regulations[6]) {
            //        // 6: RangeItem : 'char' ;
            //        var @char0 = context.objStack.Pop() as Token;
            //        var rangeItem = new RangeItem(/*@char0*/);
            //        context.objStack.Push(rangeItem);
            //    }
            //    else { throw new NotImplementedException(); }
            //});

        }
    }
}