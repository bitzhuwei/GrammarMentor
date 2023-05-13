using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.ABBFormat
{
    public partial class CompilerABB
    {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, BCounterContext}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/ , Action<Node, TContext<BCounter>>> bCounterExtracterDict = new Dictionary<string, Action<Node, TContext<BCounter>>>();

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeBCounterExtracterDict()
        {
            var extracterDict = bCounterExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, stepContext) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, stepContext) =>
            //{
            // nothing to do.
            //});
            //extracterDict.Add(EType.MultipleLineComment,
            //(node, stepContext) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, stepContext) =>
            //{
            // not needed.
            //});
            //extracterDict.Add(EType.Plus,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.a,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            //extracterDict.Add(EType.b,
            //(node, context) =>
            //{
            //    var token = context.tokens[node.tokenIndex];
            //    context.objStack.Push(token.value);
            //});
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) =>
            {
                // -1: <BCounter> : A ;
                //var obj = context.objStack.Pop(); var a = obj as A;
                //var bCounter = new BCounter(/*a*/);
                //context.result = bCounter; // final step, no need to push into stack.
                var obj = context.objStack.Pop(); var counter = obj as BCounter;
                context.result = counter;
            });
            extracterDict.Add(EType.A,
            (node, context) =>
            {
                if (node.regulation == regulations[0])
                {
                    // 0: A : A '+' B ;
                    //object obj;
                    //obj = context.objStack.Pop(); var b0 = obj as B;
                    //obj = context.objStack.Pop(); var plus1 = obj as string;
                    //obj = context.objStack.Pop(); var a2 = obj as A;
                    //var a = new A(/*a2, plus1, b0*/);
                    //context.objStack.Push(a);
                    object obj;
                    obj = context.objStack.Pop(); var counter = obj as BCounter;
                    counter.value++;
                    context.objStack.Push(counter);
                }
                else if (node.regulation == regulations[1])
                {
                    // 1: A : 'a' ;
                    //object obj;
                    //obj = context.objStack.Pop(); var a0 = obj as string;
                    //var a = new A(/*a0*/);
                    //context.objStack.Push(a);
                    var counter = new BCounter();
                    counter.value = 0;
                    context.objStack.Push(counter);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.B,
            (node, context) =>
            {
                //if (node.regulation == regulations[2])
                //{
                //    // 2: B : 'b' ;
                //    object obj;
                //    obj = context.objStack.Pop(); var b0 = obj as string;
                //    var b = new B(/*b0*/);
                //    context.objStack.Push(b);
                //}
                //else { throw new NotImplementedException(); }
            });

        }
    }

}