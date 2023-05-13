using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.PrefixFormat {
    public partial class CompilerPrefix {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{Prefix2}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<Prefix2>>> prefix2ExtracterDict = new Dictionary<string, Action<Node, TContext<Prefix2>>>();

        private static readonly Action<Node, TContext<Prefix2>> VtHandler =
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token);
            };

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializePrefix2ExtracterDict() {
            var extracterDict = prefix2ExtracterDict;
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
            extracterDict.Add(EType.@entityId, VtHandler);
            extracterDict.Add(EType.@Equal, VtHandler);
            extracterDict.Add(EType.@refEntity, VtHandler);
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: Prefix2> : Items ;
                var items = context.objStack.Pop() as Items;
                var prefix2 = new Prefix2(/*items*/);
                context.result = prefix2; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.Items,
            (node, context) => {
                if (node.regulation == CompilerPrefix.regulations[0]) {
                    // 0: Items : Items Item ;
                    var item0 = context.objStack.Pop() as Item;
                    var items1 = context.objStack.Pop() as Items;
                    var items = new Items(/*items1, item0*/);
                    context.objStack.Push(items);
                }
                else if (node.regulation == CompilerPrefix.regulations[1]) {
                    // 1: Items : Item ;
                    var item0 = context.objStack.Pop() as Item;
                    var items = new Items(/*item0*/);
                    context.objStack.Push(items);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Item,
            (node, context) => {
                if (node.regulation == CompilerPrefix.regulations[2]) {
                    // 2: Item : 'entityId' '=' 'refEntity' ;
                    var @refEntity0 = context.objStack.Pop() as Token;
                    var @Equal1 = context.objStack.Pop() as Token;
                    var @entityId2 = context.objStack.Pop() as Token;
                    var item = new Item(/*@entityId2, @Equal1, @refEntity0*/);
                    context.objStack.Push(item);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }
}