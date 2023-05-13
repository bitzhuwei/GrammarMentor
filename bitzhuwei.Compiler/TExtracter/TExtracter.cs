using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// Extract some data structure from syntax tree.
    /// </summary>
    /// <typeparam name="T">Extracted Type</typeparam>
    public class TExtracter<T> where T : class {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{T}}"/>
        /// </summary>
        private readonly Dictionary<string/*Node.type*/, Action<Node, TContext<T>>> extracterDict;
        /// <summary>
        /// use this node when it's after the end of token list.
        /// </summary>
        public readonly Node endOfTokenList;

        /// <summary>
        /// Extract some data structure from syntax tree.
        /// </summary>
        /// <param name="extracterDict"><see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{T}}"/></param>
        /// <param name="endOfTokenList">use this token when it's after the end of token list.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public TExtracter(Dictionary<string/*Node.type*/, Action<Node, TContext<T>>> extracterDict, Node endOfTokenList) {
            if (extracterDict == null) {
                throw new ArgumentNullException($"{nameof(extracterDict)}");
            }

            this.extracterDict = extracterDict;
            this.endOfTokenList = endOfTokenList;
        }

        /// <summary>
        /// Extract some data structure from syntax tree.
        /// <para>Post-order traversing.</para>
        /// </summary>
        /// <param name="rootNode">root node of the syntax tree.</param>
        /// <param name="tokens">the token list correspond to <paramref name="rootNode"/>.</param>
        /// <returns></returns>
        public T Extract(Node rootNode, TokenList tokens) {
            var context = new TContext<T>(rootNode, tokens);

            // post-order traverse rootNode with stack(without recursion).
            var nodeStack = new Stack<Node>();
            var indexStack = new Stack<int>();
            // init stack.
            {
                // push nextLeft and its next pending children.
                var nextLeft = rootNode;
                nodeStack.Push(nextLeft); indexStack.Push(0);
                while (nextLeft.Children.Count > 0) {
                    nextLeft = nextLeft.Children[0];
                    nodeStack.Push(nextLeft);
                    indexStack.Push(0);
                }
            }

            while (nodeStack.Count > 0) {
                var current = nodeStack.Pop();
                var index = indexStack.Pop() + 1;
                if (index < current.Children.Count) {
                    // push this node back again.
                    nodeStack.Push(current); indexStack.Push(index);

                    // push nextLeft and its next pending children.
                    var nextLeft = current.Children[index];
                    nodeStack.Push(nextLeft); indexStack.Push(0);
                    while (nextLeft.Children.Count > 0) {
                        nextLeft = nextLeft.Children[0];
                        nodeStack.Push(nextLeft);
                        indexStack.Push(0);
                    }
                }
                else {
                    // Visit(current);
                    if (extracterDict.TryGetValue(current.type, out Action<Node, TContext<T>> action)) {
                        action(current, context);
                    }
                }
            }

            {
                var current = this.endOfTokenList;
                if (extracterDict.TryGetValue(current.type, out Action<Node, TContext<T>> action)) {
                    action(current, context);
                }
            }

            return context.result;
        }

        //void PostOrderRecursion(Node node)
        //{
        //    for (int i = 0; i < node.Children.Count; i++)
        //    {
        //        PostOrderRecursion(node.Children[i]);
        //    }

        //    Visit(node);
        //}

        //private void Visit(Node node)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
