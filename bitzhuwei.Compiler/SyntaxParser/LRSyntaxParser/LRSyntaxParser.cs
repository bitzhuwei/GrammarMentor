using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// Input: a list of Token.
    /// Output: a syntax tree.
    /// </summary>
    public partial class LRSyntaxParser {
        /// <summary>
        /// the initial state for syntax parsing.
        /// </summary>
        public readonly SyntaxState initialState;
        /// <summary>
        /// use this token when it's after the end of token list.
        /// </summary>
        public readonly Token endOfTokenList;

        /// <summary>
        /// </summary>
        /// <param name="initialState">the initial state for syntax parsing.</param>
        /// <param name="endOfTokenList">use this token when it's after the end of token list.</param>
        /// <exception cref="ArgumentNullException">The {initialState} cannot be null.</exception>
        /// <exception cref="ArgumentNullException">The {endOfTokenList} cannot be null.</exception>
        public LRSyntaxParser(SyntaxState initialState, Token endOfTokenList) {
            if (initialState == null) {
                throw new ArgumentNullException($"The {initialState} cannot be null!");
            }
            if (endOfTokenList == null) {
                throw new ArgumentNullException($"The {endOfTokenList} cannot be null!");
            }

            this.initialState = initialState;
            this.endOfTokenList = endOfTokenList;
        }

        public Node Parse(TokenList tokenList) {
            var context = new LRSyntaxContext(tokenList, this.initialState, this.endOfTokenList);
            ParsingAction parsingAction;
            //while (!context.EOT)
            //while (context.stateStack.Count > 0)
            do {
                Token currentToken = context.CurrentToken;
                //ENodeType nodeType = (ENodeType)((int)currentToken.type); // syntax error.
                //ENodeType nodeType = currentToken.type.Convert(); // extension method.
                string nodeType = currentToken.type;// auto-convert from string to string.
                SyntaxState currentState = context.stateStack.Peek();
                parsingAction = context.GetAction(currentState, nodeType);
                int nextTokenIndex = parsingAction.Execute(context);
                // prepare for next loop.
                context.SetCursor(nextTokenIndex);
            } while (!(parsingAction is LRAcceptAction));
            //} while (!context.EOT);

            var node = context.nodeStack.Pop();
            return node;
        }
    }
}
