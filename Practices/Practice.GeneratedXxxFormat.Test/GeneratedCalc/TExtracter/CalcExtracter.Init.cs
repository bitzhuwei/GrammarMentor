using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.CalcFormat {
    public partial class CompilerCalc {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{FinalValue}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<FinalValue>>> finalValueExtracterDict = new Dictionary<string, Action<Node, TContext<FinalValue>>>();

        private static readonly Action<Node, TContext<FinalValue>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeFinalValueExtracterDict() {
            var extracterDict = finalValueExtracterDict;
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
            extracterDict.Add(EType.@Dash, VtHandler);
            extracterDict.Add(EType.@Asterisk, VtHandler);
            extracterDict.Add(EType.@Slash, VtHandler);
            extracterDict.Add(EType.@LeftParenthesis, VtHandler);
            extracterDict.Add(EType.@RightParenthesis, VtHandler);
            extracterDict.Add(EType.@number, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: FinalValue> : Additive ;
                var additive = context.objStack.Pop() as Additive;
                var finalValue = new FinalValue(additive.value);
                context.result = finalValue; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Additive,
            (node, context) => {
                if (node.regulation == CompilerCalc.regulations[0]) {
                    // 0: Additive : Additive '+' Multiplicative ;
                    var multiplicative0 = context.objStack.Pop() as Multiplicative;
                    var plus1 = context.objStack.Pop() as Token;
                    var additive2 = context.objStack.Pop() as Additive;
                    var additive = new Additive(additive2.value + multiplicative0.value);
                    context.objStack.Push(additive);
                }
                else if (node.regulation == CompilerCalc.regulations[1]) {
                    // 1: Additive : Additive '-' Multiplicative ;
                    var multiplicative0 = context.objStack.Pop() as Multiplicative;
                    var dash1 = context.objStack.Pop() as Token;
                    var additive2 = context.objStack.Pop() as Additive;
                    var additive = new Additive(additive2.value - multiplicative0.value);
                    context.objStack.Push(additive);
                }
                else if (node.regulation == CompilerCalc.regulations[2]) {
                    // 2: Additive : Multiplicative ;
                    var multiplicative0 = context.objStack.Pop() as Multiplicative;
                    var additive = new Additive(multiplicative0.value);
                    context.objStack.Push(additive);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Multiplicative,
            (node, context) => {
                if (node.regulation == CompilerCalc.regulations[3]) {
                    // 3: Multiplicative : Multiplicative '*' Primary ;
                    var primary0 = context.objStack.Pop() as Primary;
                    var asterisk1 = context.objStack.Pop() as Token;
                    var multiplicative2 = context.objStack.Pop() as Multiplicative;
                    var multiplicative = new Multiplicative(multiplicative2.value * primary0.value);
                    context.objStack.Push(multiplicative);
                }
                else if (node.regulation == CompilerCalc.regulations[4]) {
                    // 4: Multiplicative : Multiplicative '/' Primary ;
                    var primary0 = context.objStack.Pop() as Primary;
                    var slash1 = context.objStack.Pop() as Token;
                    var multiplicative2 = context.objStack.Pop() as Multiplicative;
                    var multiplicative = new Multiplicative(multiplicative2.value / primary0.value);
                    context.objStack.Push(multiplicative);
                }
                else if (node.regulation == CompilerCalc.regulations[5]) {
                    // 5: Multiplicative : Primary ;
                    var primary0 = context.objStack.Pop() as Primary;
                    var multiplicative = new Multiplicative(primary0.value);
                    context.objStack.Push(multiplicative);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Primary,
            (node, context) => {
                if (node.regulation == CompilerCalc.regulations[6]) {
                    // 6: Primary : '(' Additive ')' ;
                    var rightParenthesis0 = context.objStack.Pop() as Token;
                    var additive1 = context.objStack.Pop() as Additive;
                    var leftParenthesis2 = context.objStack.Pop() as Token;
                    var primary = new Primary(additive1.value);
                    context.objStack.Push(primary);
                }
                else if (node.regulation == CompilerCalc.regulations[7]) {
                    // 7: Primary : 'number' ;
                    var number0 = context.objStack.Pop() as Token;
                    var primary = new Primary(float.Parse(number0.value));
                    context.objStack.Push(primary);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}