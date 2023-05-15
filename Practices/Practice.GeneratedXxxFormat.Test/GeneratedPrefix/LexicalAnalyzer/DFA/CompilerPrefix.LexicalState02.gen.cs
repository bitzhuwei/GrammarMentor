using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PrefixFormat {
    partial class CompilerPrefix {
        private static readonly LexicalState lexicalState2 = new LexicalState($"{nameof(CompilerPrefix)}.LexicalStates[2]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                AcceptPrevious(context, EType.@Equal);
                BeginToken(context, EType.@refEntity);
                ExtendToken(context);
                return lexicalState4;
            }),
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

