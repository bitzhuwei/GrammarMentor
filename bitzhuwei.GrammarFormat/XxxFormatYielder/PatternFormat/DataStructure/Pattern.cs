using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    /// <summary>
    /// Correspond to the Vn node Pattern in the grammar(Pattern).
    /// </summary>
    public class Pattern {
        // the pre flag state. similar to <Xxx> in lex.
        /// <summary>
        /// the pre flag state. similar to &lt;Xxx&gt; in lex.
        /// </summary>
        public readonly string preVt;
        /// <summary>
        /// matching target.
        /// </summary>
        public eNFAFragment regex;
        /// <summary>
        /// look after <see cref="Pattern.regex"/>.
        /// </summary>
        public eNFAFragment postRegex;

        public Pattern(string preVt, eNFAFragment regex, eNFAFragment postRegex) {
            this.preVt = preVt;
            this.regex = regex;
            this.postRegex = postRegex;
        }

        public override string ToString() {
            return $"{this.preVt}, {this.regex}, {this.postRegex}";
        }
    }
}
