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
    public partial class LLSyntaxParser {
        /// <summary>
        /// type of the first <see cref="Regulation.left"/>
        /// </summary>
        public readonly string startNodeType;
        /// <summary>
        /// [Vn, Vt] - <see cref="Regulation"/>
        /// </summary>
        public readonly Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable;
        /// <summary>
        /// use this token when it's after the end of token list.
        /// </summary>
        public readonly Token endOfTokenList;

        /// <summary>
        /// </summary>
        /// <param name="startNodeType">type of the first <see cref="Regulation.left"/></param>
        /// <param name="LL1SyntaxParsingTable"></param>
        /// <param name="endOfTokenList">use this token when it's after the end of token list.</param>
        /// <exception cref="ArgumentNullException">The {LL1SyntaxParsingTable} cannot be null.</exception>
        /// <exception cref="ArgumentNullException">The {endOfTokenList} cannot be null.</exception>
        public LLSyntaxParser(string startNodeType, Dictionary<string/*Vn*/, Dictionary<string/*Vt*/, Regulation>> LL1SyntaxParsingTable, Token endOfTokenList) {
            if (LL1SyntaxParsingTable == null) {
                throw new ArgumentNullException($"{nameof(LL1SyntaxParsingTable)}");
            }
            if (endOfTokenList == null) {
                throw new ArgumentNullException($"{nameof(endOfTokenList)}");
            }

            this.startNodeType = startNodeType;
            this.LL1SyntaxParsingTable = LL1SyntaxParsingTable;
            this.endOfTokenList = endOfTokenList;
        }

        public Node Parse(TokenList tokenList) {
            var context = new LLSyntaxContext(tokenList, this.startNodeType, this.LL1SyntaxParsingTable, this.endOfTokenList);
            do {
                var node = context.nodeStack.Pop();
                Token currentToken = context.CurrentToken;
                var regulation = context.GetRegulation(node.type, currentToken.type);
                if (regulation == null) // node is a Vt
                {
                    node.tokenIndex = context.Index;
                    node.tokenCount = 1;
                    RefreshParentInfo(node);
                    context.SetCursor(node.tokenIndex + 1);
                }
                else // node is a Vn. no node needed for empty.
                {
                    node.regulation = regulation;
                    int count = regulation.right.Length;
                    for (int i = count - 1; i >= 0; i--) {
                        var type = regulation.right[i];
                        var child = new Node(type);
                        context.nodeStack.Push(child);
                        node.Children.Insert(0, child); child.parent = node;
                    }
                }
            } while (!context.EOT);

            return context.rootNode;
        }

        private void RefreshParentInfo(Node node) {
            var parent = node.parent;
            while (parent != null) {
                if (parent.tokenIndex < 0)// not assigned yet.
                {
                    parent.tokenIndex = node.tokenIndex;
                }

                parent.tokenCount = node.tokenIndex - parent.tokenIndex + 1;

                node = parent;
                parent = parent.parent;
            }
        }
    }
}
