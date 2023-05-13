using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.SABFormat {
    public partial class CompilerSAB {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{SAB2}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<SAB2>>> sAB2ExtracterDict = new Dictionary<string, Action<Node, TContext<SAB2>>>();

        private static readonly Action<Node, TContext<SAB2>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeSAB2ExtracterDict() {
            var extracterDict = sAB2ExtracterDict;
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
            extracterDict.Add(EType.@a, VtHandler);
            extracterDict.Add(EType.@s, VtHandler);
            extracterDict.Add(EType.@b, VtHandler);
            extracterDict.Add(EType.@d, VtHandler);
            extracterDict.Add(EType.@c, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: SAB2> : S ;
                var s = context.objStack.Pop() as S;
                var sAB2 = new SAB2(/*s*/);
                context.result = sAB2; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.S,
            (node, context) => {
                if (node.regulation == CompilerSAB.regulations[0]) {
                    // 0: S : A 'a' 's' ;
                    var @s0 = context.objStack.Pop() as Token;
                    var @a1 = context.objStack.Pop() as Token;
                    var a2 = context.objStack.Pop() as A;
                    var s = new S(/*a2, @a1, @s0*/);
                    context.objStack.Push(s);
                }
                else if (node.regulation == CompilerSAB.regulations[1]) {
                    // 1: S : B 'b' 's' ;
                    var @s0 = context.objStack.Pop() as Token;
                    var @b1 = context.objStack.Pop() as Token;
                    var b2 = context.objStack.Pop() as B;
                    var s = new S(/*b2, @b1, @s0*/);
                    context.objStack.Push(s);
                }
                else if (node.regulation == CompilerSAB.regulations[2]) {
                    // 2: S : 'd' ;
                    var @d0 = context.objStack.Pop() as Token;
                    var s = new S(/*@d0*/);
                    context.objStack.Push(s);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.A,
            (node, context) => {
                if (node.regulation == CompilerSAB.regulations[3]) {
                    // 3: A : 'a' ;
                    var @a0 = context.objStack.Pop() as Token;
                    var a = new A(/*@a0*/);
                    context.objStack.Push(a);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.B,
            (node, context) => {
                if (node.regulation == CompilerSAB.regulations[4]) {
                    // 4: B : 'c' ;
                    var @c0 = context.objStack.Pop() as Token;
                    var b = new B(/*@c0*/);
                    context.objStack.Push(b);
                }
                else if (node.regulation == CompilerSAB.regulations[5]) {
                    // 5: B : ;
                    var b = new B(/**/);
                    context.objStack.Push(b);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}