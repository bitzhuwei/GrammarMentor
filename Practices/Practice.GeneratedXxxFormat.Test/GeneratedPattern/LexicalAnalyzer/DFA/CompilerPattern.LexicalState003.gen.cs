using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState3 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[3]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                AcceptPrevious(context, EType.@Comma);
                BeginToken(context, EType.@max);
                ExtendToken(context);
                return lexicalState19;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@char, EType.@Comma);
                return lexicalState0;
            })

        );
    }
}

