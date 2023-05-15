using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.Ints2Format {
    partial class CompilerInts2 {
        private static readonly LexicalState lexicalState2 = new LexicalState($"{nameof(CompilerInts2)}.LexicalStates[2]",
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Comma);
                return lexicalState0;
            })

        );
    }
}

