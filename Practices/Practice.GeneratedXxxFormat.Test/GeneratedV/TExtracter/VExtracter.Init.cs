using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.VFormat {
    public partial class CompilerV {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{V2}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<V2>>> v2ExtracterDict = new Dictionary<string, Action<Node, TContext<V2>>>();

        private static readonly Action<Node, TContext<V2>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeV2ExtracterDict() {
            var extracterDict = v2ExtracterDict;
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
            extracterDict.Add(EType.@Vt, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: V2> : V ;
                var v = context.objStack.Pop() as V;
                var v2 = new V2(/*v*/);
                context.result = v2; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.V,
            (node, context) => {
                if (node.regulation == CompilerV.regulations[0]) {
                    // 0: V : 'Vt' ;
                    var @Vt0 = context.objStack.Pop() as Token;
                    var v = new V(/*@Vt0*/);
                    context.objStack.Push(v);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}