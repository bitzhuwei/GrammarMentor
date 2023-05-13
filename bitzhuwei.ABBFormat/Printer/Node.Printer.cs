using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat
{
    partial class CompilerABB
    {

        public string PrintFormat(Node rootNode, TokenList tokens)
        {
            var b = new StringBuilder();
            using (var w = new StringWriter(b))
            {
                Print(w, rootNode, tokens);
            }

            return b.ToString();
        }

        private void Print(StringWriter w, Node node, TokenList tokens)
        {
            if (node.type == EType.Plus)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.a)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.b)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.EndOfTokenList)
            {
                // -1: BCounter☞ : A '¥' ;
                // this branch will never happen.
            }
            else if (node.type == EType.A)
            {
                if (node.regulation == regulations[0])
                {
                    // 0: A: A '+' B;
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        Print(w, node.Children[i], tokens);
                        w.Write(' ');
                    }
                    if (count > 0)
                    {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else if (node.regulation == regulations[1])
                {
                    // 1: A: 'a';
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        Print(w, node.Children[i], tokens);
                        w.Write(' ');
                    }
                    if (count > 0)
                    {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else { throw new NotImplementedException(); }
            }
            else if (node.type == EType.B)
            {
                if (node.regulation == regulations[2])
                {
                    // 2: B: 'b';
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        Print(w, node.Children[i], tokens);
                        w.Write(' ');
                    }
                    if (count > 0)
                    {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else { throw new NotImplementedException(); }
            }
        }
    }

}
