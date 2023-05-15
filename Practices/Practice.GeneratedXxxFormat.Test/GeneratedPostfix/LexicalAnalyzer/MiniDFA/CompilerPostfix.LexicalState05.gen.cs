using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
        private static readonly LexicalState lexicalState5 = new LexicalState($"{nameof(CompilerPostfix)}.LexicalStates[5]",
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Equal);
                return lexicalState0;
            })

        );
    }
}

