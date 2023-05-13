using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// extracted info from syntax tree(<see cref="bitzhuwei.Compiler.Node"/>).
    /// </summary>
    public partial class TokenDraft {
        // the pre flag state. similar to <Xxx> in lex.
        /// <summary>
        /// &lt;'Vt'&gt; but without &lt;&gt;
        /// <para>the pre flag state. similar to &lt;Xxx&gt; in lex.</para>
        /// </summary>
        public readonly string preVt;
        /// <summary>
        /// extracted ¦Å-NFA from <see cref="CompilerPattern"/>
        /// </summary>
        public readonly eNFAInfo regexInfo;
        /// <summary>
        /// extracted post ¦Å-NFA from <see cref="CompilerPattern"/>
        /// </summary>
        public readonly eNFAInfo postInfo;

        public TokenDraft(string preVt, eNFAInfo regexInfo, eNFAInfo postInfo) {
            this.preVt = preVt;
            this.regexInfo = regexInfo;
            this.postInfo = postInfo;
        }

        public override string ToString() {
            return $"{this.preVt}, {this.regexInfo}, {this.postInfo}";
        }
    }
}
