using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SABFormat {
    partial class CompilerSAB {
        private static readonly LexicalState lexicalState11 = new LexicalState($"{nameof(CompilerSAB)}.LexicalStates[11]",
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@blockComment);
                return lexicalState0;
            })

        );
    }
}

