using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState16 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[16]",
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Vt);
                return lexicalState0;
            })

        );
    }
}

