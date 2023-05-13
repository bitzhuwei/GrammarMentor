using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.IntsFormat {
    public partial class CompilerInts {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{IntArray}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<IntArray>>> intArrayExtracterDict = new Dictionary<string, Action<Node, TContext<IntArray>>>();

        private static readonly Action<Node, TContext<IntArray>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeIntArrayExtracterDict() {
            var extracterDict = intArrayExtracterDict;
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
            extracterDict.Add(EType.@integer, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: IntArray> : Ints ;
                var ints = context.objStack.Pop() as Ints;
                var intArray = new IntArray(/*ints*/);
                context.result = intArray; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Ints,
            (node, context) => {
                if (node.regulation == CompilerInts.regulations[0]) {
                    // 0: Ints : Ints Int ;
                    var int0 = context.objStack.Pop() as Int;
                    var ints1 = context.objStack.Pop() as Ints;
                    var ints = new Ints(/*ints1, int0*/);
                    context.objStack.Push(ints);
                }
                else if (node.regulation == CompilerInts.regulations[1]) {
                    // 1: Ints : Int ;
                    var int0 = context.objStack.Pop() as Int;
                    var ints = new Ints(/*int0*/);
                    context.objStack.Push(ints);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Int,
            (node, context) => {
                if (node.regulation == CompilerInts.regulations[2]) {
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