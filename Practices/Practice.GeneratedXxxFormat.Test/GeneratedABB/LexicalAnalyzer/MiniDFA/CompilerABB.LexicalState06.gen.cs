using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat {
    partial class CompilerABB {
        private static readonly LexicalState lexicalState6 = new LexicalState($"{nameof(CompilerABB)}.LexicalStates[6]",
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@b);
                return lexicalState0;
            })

        );
    }
}

