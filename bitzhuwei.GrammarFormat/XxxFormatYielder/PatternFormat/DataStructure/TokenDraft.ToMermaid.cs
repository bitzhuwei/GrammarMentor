using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// extracted info from syntax tree(<see cref="Node"/>).
    /// </summary>
    public partial class TokenDraft {
        public void ToMermaid(TextWriter w) {
            w.Write("1/3: pre-regex "); w.Write("`"); w.Write(this.preVt); w.WriteLine("`");
            w.WriteLine();
            w.WriteLine("2/3: regex");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.regexInfo.ToMermaid(w);
            w.WriteLine("```");
            w.WriteLine();
            w.WriteLine("3/3: post-regex");
            w.WriteLine("```Mermaid");
            w.WriteLine("flowchart");
            this.postInfo.ToMermaid(w);
            w.WriteLine("```");
            w.WriteLine();
        }
    }
}
