using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.SESFormat {
    public partial class CompilerSES {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{SES2}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<SES2>>> sES2ExtracterDict = new Dictionary<string, Action<Node, TContext<SES2>>>();

        private static readonly Action<Node, TContext<SES2>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeSES2ExtracterDict() {
            var extracterDict = sES2ExtracterDict;
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
            extracterDict.Add(EType.@s, VtHandler);
            extracterDict.Add(EType.@t, VtHandler);
            extracterDict.Add(EType.@g, VtHandler);
            extracterDict.Add(EType.@w, VtHandler);
            extracterDict.Add(EType.@e, VtHandler);
            extracterDict.Add(EType.@d, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: SES2> : S ;
                var s = context.objStack.Pop() as S;
                var sES2 = new SES2(/*s*/);
                context.result = sES2; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.S,
            (node, context) => {
                if (node.regulation == CompilerSES.regulations[0]) {
                    // 0: S : N V N ;
                    var n0 = context.objStack.Pop() as N;
                    var v1 = context.objStack.Pop() as V;
                    var n2 = context.objStack.Pop() as N;
                    var s = new S(/*n2, v1, n0*/);
                    context.objStack.Push(s);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.N,
            (node, context) => {
                if (node.regulation == CompilerSES.regulations[1]) {
                    // 1: N : 's' ;
                    var @s0 = context.objStack.Pop() as Token;
                    var n = new N(/*@s0*/);
                    context.objStack.Push(n);
                }
                else if (node.regulation == CompilerSES.regulations[2]) {
                    // 2: N : 't' ;
                    var @t0 = context.objStack.Pop() as Token;
                    var n = new N(/*@t0*/);
                    context.objStack.Push(n);
                }
                else if (node.regulation == CompilerSES.regulations[3]) {
                    // 3: N : 'g' ;
                    var @g0 = context.objStack.Pop() as Token;
                    var n = new N(/*@g0*/);
                    context.objStack.Push(n);
                }
                else if (node.regulation == CompilerSES.regulations[4]) {
                    // 4: N : 'w' ;
                    var @w0 = context.objStack.Pop() as Token;
                    var n = new N(/*@w0*/);
                    context.objStack.Push(n);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.V,
            (node, context) => {
                if (node.regulation == CompilerSES.regulations[5]) {
                    // 5: V : 'e' ;
                    var @e0 = context.objStack.Pop() as Token;
                    var v = new V(/*@e0*/);
                    context.objStack.Push(v);
                }
                else if (node.regulation == CompilerSES.regulations[6]) {
                    // 6: V : 'd' ;
                    var @d0 = context.objStack.Pop() as Token;
                    var v = new V(/*@d0*/);
                    context.objStack.Push(v);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}