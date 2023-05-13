using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.ErrorFormat {
    public partial class CompilerError {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{Error2}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<Error2>>> error2ExtracterDict = new Dictionary<string, Action<Node, TContext<Error2>>>();

        private static readonly Action<Node, TContext<Error2>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeError2ExtracterDict() {
            var extracterDict = error2ExtracterDict;
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
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: Error2> : PreRegex ;
                var preRegex = context.objStack.Pop() as PreRegex;
                var error2 = new Error2(/*preRegex*/);
                context.result = error2; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.PreRegex,
            (node, context) => {
                if (node.regulation == CompilerError.regulations[0]) {
                    // 0: PreRegex : 'refVt' ;
                    var @refVt0 = context.objStack.Pop() as Token;
                    var preRegex = new PreRegex(/*@refVt0*/);
                    context.objStack.Push(preRegex);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}