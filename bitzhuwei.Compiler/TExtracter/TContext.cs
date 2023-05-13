using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// It's an internal bag. You can find anything you need for extracting.
    /// </summary>
    /// <typeparam name="T">Extracted Type</typeparam>
    public class TContext<T> where T : class {
        /// <summary>
        /// final result of extracting.
        /// </summary>
        public T result;

        /// <summary>
        /// syntax tree from syntax parsing.
        /// </summary>
        public readonly Node rootNode;
        /// <summary>
        /// token list from lexical analyzing.
        /// </summary>
        public readonly TokenList tokens;
        /// <summary>
        /// Push children from right to left, then pop them at parent node, so I can construct object in upper node.
        /// <para>works in post-order traversing environment.</para>
        /// </summary>
        public readonly Stack objStack = new Stack();
        // TODO: I don't know if there's any difference between Stack and Stack<object>.
        //public readonly Stack<object> objStack = new Stack<object>();

        /// <summary>
        /// use this dict to pass user defined data.
        /// </summary>
        public readonly Dictionary<string, object> tagDict = new Dictionary<string, object>();

        /// <summary>
        /// It's an internal bag. You can find anything you need for extracting.
        /// </summary>
        /// <param name="rootNode">syntax tree from syntax parsing.</param>
        /// <param name="tokens">token list from lexical analyzing.</param>
        public TContext(Node rootNode, TokenList tokens) {
            this.rootNode = rootNode;
            this.tokens = tokens;
        }
    }


}