using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat
{
    partial class CompilerCalc
    {
        /// print formatted calculation expression.
        /// <para>Post-order traversing.</para>
        /// </summary>
        /// <param name="rootNode">root node of the syntax tree.</param>
        /// <param name="tokens">the token list correspond to <paramref name="rootNode"/>.</param>
        /// <returns></returns>
        public string PrintFormat(Node rootNode, TokenList tokens)
        {
            var b = new StringBuilder();
            using (var w = new StringWriter(b))
            {
                Print(w, rootNode, tokens);
            }

            return b.ToString();
        }

        private void Print(TextWriter w, Node node, TokenList tokens)
        {
            if (node.type == EType.Plus)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.Dash)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.Asterisk)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.Slash)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.LeftParenthesis)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.RightParenthesis)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.number)
            {
                var token = tokens[node.tokenIndex];
                w.Write(token.value);
            }
            else if (node.type == EType.EndOfTokenList)
            {
                // -1: FinalValue☞ : Additive '¥' ;
            }
            else if (node.type == EType.Additive)
            {
                if (node.regulation == regulations[0])
                {
                    // 0: Additive : Additive '+' Multiplicative ;
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
                    // 1: Additive : Additive '-' Multiplicative ;
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
                else if (node.regulation == regulations[2])
                {
                    // 2: Additive : Multiplicative ;
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        Print(w, node.Children[i], tokens);
                        //w.Write(' ');
                    }
                    if (count > 0)
                    {
                        Print(w, node.Children[count - 1], tokens);
                    }
                }
                else { throw new NotImplementedException(); }
            }
            else if (node.type == EType.Multiplicative)
            {
                if (node.regulation == regulations[3])
                {
                    // 3: Multiplicative : Multiplicative '*' Primary ;
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
                else if (node.regulation == regulations[4])
                {
                    // 4: Multiplicative : Multiplicative '/' Primary ;
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
                else if (node.regulation == regulations[5])
                {
                    // 5: Multiplicative : Primary ;
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
            else if (node.type == EType.Primary)
            {
                if (node.regulation == regulations[6])
                {
                    // 6: Primary : '(' Additive ')' ;
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
                else if (node.regulation == regulations[7])
                {
                    // 7: Primary : 'number' ;
                    int count = node.Children.Count;
                    for (int i = 0; i < count - 1; i++)
                    {
                        Print(w, node.Children[i], tokens);
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
