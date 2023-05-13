using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.Ints2Format {
    public partial class CompilerInts2 {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{Ints2Array}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<Ints2Array>>> ints2ArrayExtracterDict = new Dictionary<string, Action<Node, TContext<Ints2Array>>>();

        private static readonly Action<Node, TContext<Ints2Array>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeInts2ArrayExtracterDict() {
            var extracterDict = ints2ArrayExtracterDict;
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
            extracterDict.Add(EType.@Comma, VtHandler);
            extracterDict.Add(EType.@integer, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: Ints2Array> : Ints ;
                var ints = context.objStack.Pop() as Ints;
                var ints2Array = new Ints2Array(/*ints*/);
                context.result = ints2Array; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Ints,
            (node, context) => {
                if (node.regulation == CompilerInts2.regulations[0]) {
                    // 0: Ints : Ints ',' Int ;
                    var int0 = context.objStack.Pop() as Int;
                    var @Comma1 = context.objStack.Pop() as Token;
                    var ints2 = context.objStack.Pop() as Ints;
                    var ints = new Ints(/*ints2, @Comma1, int0*/);
                    context.objStack.Push(ints);
                }
                else if (node.regulation == CompilerInts2.regulations[1]) {
                    // 1: Ints : Int ;
                    var int0 = context.objStack.Pop() as Int;
                    var ints = new Ints(/*int0*/);
                    context.objStack.Push(ints);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Int,
            (node, context) => {
                if (node.regulation == CompilerInts2.regulations[2]) {
                    // 2: Int : 'integer' ;
                    var @integer0 = context.objStack.Pop() as Token;
                    var @int = new Int(/*@integer0*/);
                    context.objStack.Push(@int);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}