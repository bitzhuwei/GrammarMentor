using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.CalcFormat
{
    public partial class CompilerCalc
    {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, FinalValueContext}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/ , Action<Node, TContext<FinalValue>>> finalValueExtracterDict = new Dictionary<string, Action<Node, TContext<FinalValue>>>();

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeFinalValueExtracterDict()
        {
            var extracterDict = finalValueExtracterDict;
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
            extracterDict.Add(EType.Plus,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Dash,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Asterisk,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Slash,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.LeftParenthesis,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.RightParenthesis,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.number,
            (node, context) =>
            {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) =>
            {
                // -1: FinalValue☞ : Additive '¥' ;
                var obj = context.objStack.Pop(); var additive = obj as Additive;
                //var finalValue = new FinalValue(/*additive*/);
                var value = additive.value;
                var finalValue = new FinalValue(value);
                context.result = finalValue; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Additive,
            (node, context) =>
            {
                if (node.regulation == regulations[0])
                {
                    // 0: Additive : Additive '+' Multiplicative ;
                    object obj;
                    obj = context.objStack.Pop(); var multiplicative0 = obj as Multiplicative;
                    obj = context.objStack.Pop(); var plus1 = obj as string;
                    obj = context.objStack.Pop(); var additive2 = obj as Additive;
                    //var additive = new Additive(/*additive2, plus1, multiplicative0*/);
                    var value = additive2.value + multiplicative0.value;
                    var additive = new Additive(value);
                    context.objStack.Push(additive);
                }
                else if (node.regulation == regulations[1])
                {
                    // 1: Additive : Additive '-' Multiplicative ;
                    object obj;
                    obj = context.objStack.Pop(); var multiplicative0 = obj as Multiplicative;
                    obj = context.objStack.Pop(); var dash1 = obj as string;
                    obj = context.objStack.Pop(); var additive2 = obj as Additive;
                    //var additive = new Additive(/*additive2, dash1, multiplicative0*/);
                    var value = additive2.value - multiplicative0.value;
                    var additive = new Additive(value);
                    context.objStack.Push(additive);
                }
                else if (node.regulation == regulations[2])
                {
                    // 2: Additive : Multiplicative ;
                    object obj;
                    obj = context.objStack.Pop(); var multiplicative0 = obj as Multiplicative;
                    //var additive = new Additive(/*multiplicative0*/);
                    var value = multiplicative0.value;
                    var additive = new Additive(value);
                    context.objStack.Push(additive);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Multiplicative,
            (node, context) =>
            {
                if (node.regulation == regulations[3])
                {
                    // 3: Multiplicative : Multiplicative '*' Primary ;
                    object obj;
                    obj = context.objStack.Pop(); var primary0 = obj as Primary;
                    obj = context.objStack.Pop(); var asterisk1 = obj as string;
                    obj = context.objStack.Pop(); var multiplicative2 = obj as Multiplicative;
                    //var multiplicative = new Multiplicative(/*multiplicative2, asterisk1, primary0*/);
                    var value = multiplicative2.value * primary0.value;
                    var multiplicative = new Multiplicative(value);
                    context.objStack.Push(multiplicative);
                }
                else if (node.regulation == regulations[4])
                {
                    // 4: Multiplicative : Multiplicative '/' Primary ;
                    object obj;
                    obj = context.objStack.Pop(); var primary0 = obj as Primary;
                    obj = context.objStack.Pop(); var slash1 = obj as string;
                    obj = context.objStack.Pop(); var multiplicative2 = obj as Multiplicative;
                    //var multiplicative = new Multiplicative(/*multiplicative2, slash1, primary0*/);
                    var value = multiplicative2.value / primary0.value;
                    var multiplicative = new Multiplicative(value);
                    context.objStack.Push(multiplicative);
                }
                else if (node.regulation == regulations[5])
                {
                    // 5: Multiplicative : Primary ;
                    object obj;
                    obj = context.objStack.Pop(); var primary0 = obj as Primary;
                    //var multiplicative = new Multiplicative(/*primary0*/);
                    var value = primary0.value;
                    var multiplicative = new Multiplicative(value);
                    context.objStack.Push(multiplicative);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Primary,
            (node, context) =>
            {
                if (node.regulation == regulations[6])
                {
                    // 6: Primary : '(' Additive ')' ;
                    object obj;
                    obj = context.objStack.Pop(); var rightParenthesis0 = obj as string;
                    obj = context.objStack.Pop(); var additive1 = obj as Additive;
                    obj = context.objStack.Pop(); var leftParenthesis2 = obj as string;
                    //var primary = new Primary(/*leftParenthesis2, additive1, rightParenthesis0*/);
                    float value = additive1.value;
                    var primary = new Primary(value);
                    context.objStack.Push(primary);
                }
                else if (node.regulation == regulations[7])
                {
                    // 7: Primary : 'number' ;
                    object obj;
                    obj = context.objStack.Pop(); var number0 = obj as string;
                    //var primary = new Primary(/*number0*/);
                    float value = float.Parse(number0);
                    var primary = new Primary(value);
                    context.objStack.Push(primary);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }

}