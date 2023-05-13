using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.NumbersFormat {
    public partial class CompilerNumbers {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{NumberArray}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<NumberArray>>> numberArrayExtracterDict = new Dictionary<string, Action<Node, TContext<NumberArray>>>();

        private static readonly Action<Node, TContext<NumberArray>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeNumberArrayExtracterDict() {
            var extracterDict = numberArrayExtracterDict;
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
            extracterDict.Add(EType.@float, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: NumberArray> : Numbers ;
                var numbers = context.objStack.Pop() as Numbers;
                var numberArray = new NumberArray(/*numbers*/);
                context.result = numberArray; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Numbers,
            (node, context) => {
                if (node.regulation == CompilerNumbers.regulations[0]) {
                    // 0: Numbers : Numbers Number ;
                    var number0 = context.objStack.Pop() as Number;
                    var numbers1 = context.objStack.Pop() as Numbers;
                    var numbers = new Numbers(/*numbers1, number0*/);
                    context.objStack.Push(numbers);
                }
                else if (node.regulation == CompilerNumbers.regulations[1]) {
                    // 1: Numbers : Number ;
                    var number0 = context.objStack.Pop() as Number;
                    var numbers = new Numbers(/*number0*/);
                    context.objStack.Push(numbers);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Number,
            (node, context) => {
                if (node.regulation == CompilerNumbers.regulations[2]) {
                    // 2: Number : 'integer' ;
                    var @integer0 = context.objStack.Pop() as Token;
                    var number = new Number(/*@integer0*/);
                    context.objStack.Push(number);
                }
                else if (node.regulation == CompilerNumbers.regulations[3]) {
                    // 3: Number : 'float' ;
                    var @float0 = context.objStack.Pop() as Token;
                    var number = new Number(/*@float0*/);
                    context.objStack.Push(number);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}