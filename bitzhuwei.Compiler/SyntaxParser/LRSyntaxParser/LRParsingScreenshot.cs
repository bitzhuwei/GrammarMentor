using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// </summary>
    public class LRParsingScreenshot {
        //public readonly TokenList tokens;
        //public int currentTokenIndex;
        public readonly Font font = new Font("Lucida Console", 12);
        public readonly Brush brush = Brushes.Red;

        public void Screenshot(LRSyntaxContext context, IReadOnlyList<Regulation> regulations, string filename) {
            const int width = 800, height = 500;
            using (var image = new Bitmap(width, height)) {
                DrawImage(image, context, regulations);

                image.Save(filename);
            }

        }

        private void DrawImage(Bitmap image, LRSyntaxContext context, IReadOnlyList<Regulation> regulations) {
            using (var g = Graphics.FromImage(image)) {
                var fontHeight = this.font.GetHeight(g);
                {
                    var sourceCode = context.tokenList.sourceCode;
                    g.DrawString(sourceCode, this.font, this.brush, 0, fontHeight * 0);
                }
                {
                    var strCurrentToken = context.CurrentToken.ToString();
                    g.DrawString(strCurrentToken, this.font, this.brush, 0, fontHeight * 1.2f);
                }
                {
                    var strNode = PrintNodes(context.nodeStack, context.tokenList, regulations);
                    g.DrawString(strNode, this.font, this.brush, 0, fontHeight * 2.4f);
                }
            }
        }

        private string PrintNodes(Stack<Node> nodeStack, TokenList tokens, IReadOnlyList<Regulation> regulations) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                foreach (var node in nodeStack.Reverse()) {
                    node.Print(w, tokens, regulations);
                }
            }

            return b.ToString();
        }
    }
}
