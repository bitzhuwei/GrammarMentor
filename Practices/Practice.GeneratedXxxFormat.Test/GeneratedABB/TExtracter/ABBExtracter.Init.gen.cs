using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.ABBFormat {
    public partial class CompilerABB {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{BCounter}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<BCounter>>> bCounterExtracterDict = new Dictionary<string, Action<Node, TContext<BCounter>>>();

        private static readonly Action<Node, TContext<BCounter>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeBCounterExtracterDict() {
            var extracterDict = bCounterExtracterDict;
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
            extracterDict.Add(EType.@Plus, VtHandler);
            extracterDict.Add(EType.@a, VtHandler);
            extracterDict.Add(EType.@b, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: BCounter> : A ;
                var a = context.objStack.Pop() as A;
                var bCounter = new BCounter(/*a*/);
                context.result = bCounter; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.A,
            (node, context) => {
                if (node.regulation == CompilerABB.regulations[0]) {
                    // 0: A : A '+' B ;
                    var b0 = context.objStack.Pop() as B;
                    var @Plus1 = context.objStack.Pop() as Token;
                    var a2 = context.objStack.Pop() as A;
                    var a = new A(/*a2, @Plus1, b0*/);
                    context.objStack.Push(a);
                }
                else if (node.regulation == CompilerABB.regulations[1]) {
                    // 1: A : 'a' ;
                    var @a0 = context.objStack.Pop() as Token;
                    var a = new A(/*@a0*/);
                    context.objStack.Push(a);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.B,
            (node, context) => {
                if (node.regulation == CompilerABB.regulations[2]) {
                    // 2: B : 'b' ;
                    var @b0 = context.objStack.Pop() as Token;
                    var b = new B(/*@b0*/);
                    context.objStack.Push(b);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}