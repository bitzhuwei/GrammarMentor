using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// It's an internal bag. You can find anything you need for syntax parsing.
    /// </summary>
    public class LLSyntaxContext {
        /// <summary>
        /// tokenIndex of current Token in the <paramref name="tokenList"/>.
        /// </summary>
        private int m_Index = 0;
        /// <summary>
        /// Gets index of current Token in the <paramref name="tokenList"/>.
        /// </summary>
        public int Index { get { return this.m_Index; } }

        /// <summary>
        /// [Vn, Vt] -&gt; <see cref="Regulation"/>
        /// </summary>
        internal readonly Dictionary<string, Dictionary<string, Regulation>> LL1SyntaxParsingTable;

        /// <summary>
        /// When syntax parsing is finished, this is where syntax tree lies.
        /// </summary>
        internal readonly Stack<Node> nodeStack = new Stack<Node>();

        public readonly Node rootNode;

        /// <summary>
        /// token list from source code like C, C++, C#, Java, Xml, etc.
        /// </summary>
        private readonly TokenList tokenList;
        private readonly Token endOfTokenList;

        /// <summary>
        /// It's an internal context. You can find anything you need for syntax parsing.
        /// </summary>
        /// <param name="tokenList"></param>
        /// <param name="initialNodeType"></param>
        /// <param name="LL1SyntaxParsingTable"></param>
        /// <param name="endOfTokenList"></param>
        public LLSyntaxContext(TokenList tokenList, string initialNodeType, Dictionary<string, Dictionary<string, Regulation>> LL1SyntaxParsingTable, Token endOfTokenList) {
            this.tokenList = tokenList != null ? tokenList : new TokenList(string.Empty);
            var node = new Node(initialNodeType);
            this.nodeStack.Push(node);
            this.rootNode = node;
            this.LL1SyntaxParsingTable = LL1SyntaxParsingTable;
            this.endOfTokenList = endOfTokenList;
        }

        /// <summary>
        /// return true if the last token is syntax parsed.
        /// </summary>
        public bool EOT { get { return this.m_Index >= this.tokenList.Count; } }
        /// <summary>
        /// Gets current lexically analyzing character.
        /// </summary>
        public Token CurrentToken {
            get {
                var cursor = this.m_Index;
                TokenList tokenList = this.tokenList;
                if (cursor < tokenList.Count) {
                    return tokenList[cursor];
                }
                else {
                    return this.endOfTokenList;
                }
            }
        }

        ///// <summary>
        ///// Get handler of this state according to specified <paramref name="currentChar"/>
        ///// </summary>
        ///// <param name="currentChar"></param>
        ///// <returns></returns>
        //
        /// <summary>
        /// Get action of this state according to specified <paramref name="token"/>
        /// </summary>
        /// <param name="state"></param>
        /// <param name="Vt"></param>
        /// <returns></returns>
        public /*ParsingAction*/Regulation GetRegulation(/*SyntaxState*/string VnState, string Vt) {
            //var action = state.GetAction(nodeType);
            //return action;
            if (this.LL1SyntaxParsingTable.TryGetValue(VnState, out var dict)) {
                if (dict.TryGetValue(Vt, out var regulation)) {
                    return regulation;
                }
            }

            return null;
        }

        /// <summary>
        /// Set cursor to the index of next token to be parsed.
        /// <para>If <paramref name="nextTokenIndex"/>is over the last token, then set cursor to <see cref="EOT"/>.</para>
        /// </summary>
        internal void SetCursor(int nextTokenIndex) {
            if (this.tokenList.Count < nextTokenIndex) { throw new Exception($"maybe something wrong..."); }

            this.m_Index = nextTokenIndex;
        }
    }

}
