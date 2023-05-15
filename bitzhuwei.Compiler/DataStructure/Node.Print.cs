using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// Node of the syntax tree from syntax parsing.
    /// </summary>
    public partial class Node {
        /// <summary>
        /// Print all syntax tree.
        /// <para>pre-order traversing.</para>
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="tokens"></param>
        /// <param name="regulations"></param>
        public void Print(System.IO.TextWriter w, TokenList tokens, IReadOnlyList<Regulation> regulations) {
            if (tokens == null) { throw new ArgumentNullException($"{nameof(tokens)}"); }
            if (regulations == null) { throw new ArgumentNullException($"{nameof(regulations)}"); }

            var stack = new Stack<Node>(); stack.Push(this);
            while (stack.Count > 0) {
                var node = stack.Pop();
                node.PrintPremark(w);
                var regulation = node.regulation;
                var tokenIndex = node.tokenIndex;
                var tokenCount = node.tokenCount;
                var type = node.type;

                if (regulation != null) // a Vn
                {
                    w.Write($"R[{IndexOf(regulations, regulation)}]="); regulation.Print(w); w.Write(" ");
                    if (tokenCount > 1) { w.Write($"T[{tokenIndex}->{tokenIndex + tokenCount - 1}]"); }
                    else { w.Write($"T[{tokenIndex}]"); }
                }
                else if (tokenIndex >= 0 && tokenCount == 1) // a Vt
                {
                    var token = tokens[tokenIndex];
                    w.Write($"T[{tokenIndex}]={token.type} {token.value}");
                }
                else if (tokenCount == 0) // an empty
                {
                    w.Write($"{type} : T[{tokenIndex}]");
                }
                else // something wrong.
                {
                    w.Write(type); w.Write(" : ");
                    if (tokenCount > 1) { w.Write($"T[{tokenIndex}->{tokenIndex + tokenCount - 1}]"); }
                    else { w.Write($"T[{tokenIndex}]"); }
                }
                w.WriteLine();

                for (int i = node.Children.Count - 1; i >= 0; i--) {
                    stack.Push(node.Children[i]);
                }
            }
        }

        private static int IndexOf(IReadOnlyList<Regulation> regulations, Regulation regulation) {
            int result = -1;
            for (int i = 0; i < regulations.Count; i++) {
                if (regulation == regulations[i]) {
                    result = i;
                    break;
                }
            }

            return result;
        }

        //TODO: optimize this ?
        private void PrintPremark(TextWriter w) {
            var parent = this.parent;
            if (parent == null) { return; }

            var lstline = new List<bool>();
            while (parent != null) {
                var pp = parent.parent;
                if (pp != null) {
                    lstline.Add(pp.Children.IndexOf(parent) < pp.Children.Count - 1);
                }
                parent = pp;
            }
            for (int i = lstline.Count - 1; i >= 0; i--) {
                if (lstline[i]) { w.Write(" │ "); }
                else { w.Write("   "); }
            }
            parent = this.parent;
            if (parent.Children.IndexOf(this) < parent.Children.Count - 1) { w.Write(" ├─"); }
            else { w.Write(" └─"); }
        }

    }
}
