using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// Node of the syntax tree from syntax parsing.
    /// </summary>
    public partial class Node {
        /// <summary>
        /// node type in syntax parsing.
        /// </summary>
        public readonly string type;
        /// <summary>
        /// Reduction according to which regulation?
        /// </summary>
        public Regulation regulation;

        private readonly List<Node> m_Children = new List<Node>();
        public List<Node> Children { get { return this.m_Children; } }

        public Node parent;

        /// <summary>
        /// tokenIndex of the first character in the source code.
        /// </summary>
        public int tokenIndex;

        /// <summary>
        /// tokenCount of this rootNode(all children included) in the source code.
        /// </summary>
        public int tokenCount;

        /// <summary>
        /// Node from syntax parsing.
        /// </summary>
        /// <param name="type">type of this node(a Vn or a Vt)</param>
        /// <param name="tokenIndex">index of the first token in the token list.</param>
        public Node(string type, int tokenIndex = -1) {
            this.type = type;
            this.tokenIndex = tokenIndex;
        }

        public override string ToString() {
            var regulation = this.regulation;
            var tokenIndex = this.tokenIndex;
            var tokenCount = this.tokenCount;
            if (regulation != null) {
                if (tokenCount > 1) {
                    return ($"{regulation}: T[{tokenIndex}->{tokenIndex + tokenCount - 1}]");
                }
                else {
                    return ($"{regulation}: T[{tokenIndex}]");
                }
            }
            else {
                var type = this.type;
                return $"{type}: tokens[{tokenIndex}]";
            }
        }
    }
}
