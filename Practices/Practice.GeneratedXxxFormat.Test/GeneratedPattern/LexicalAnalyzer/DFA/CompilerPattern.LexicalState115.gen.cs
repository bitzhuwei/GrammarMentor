using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState115 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[115]",
            new LexicalRule(
            currentChar => ('0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/)
            || ('a'/*'\u0061'(97)*/ <= currentChar && currentChar <= 'f'/*'\u0066'(102)*/)
            || ('A'/*'\u0041'(65)*/ <= currentChar && currentChar <= 'F'/*'\u0046'(70)*/),
            context => {
                ExtendToken(context);
                return lexicalState185;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                context.MoveBack(1);
                return lexicalState0;
            })

        );
    }
}

