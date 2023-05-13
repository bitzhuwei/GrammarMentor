using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState16 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[16]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBrace);
                BeginToken(context, EType.@min);
                ExtendToken(context);
                return lexicalState37;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@LeftBrace);
                return lexicalState0;
            })

        );
    }
}

