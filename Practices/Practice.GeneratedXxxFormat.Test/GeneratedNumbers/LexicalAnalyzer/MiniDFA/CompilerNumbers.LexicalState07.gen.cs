using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.NumbersFormat {
    partial class CompilerNumbers {
        private static readonly LexicalState lexicalState7 = new LexicalState($"{nameof(CompilerNumbers)}.LexicalStates[7]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                ExtendToken(context);
                return lexicalState7;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@float);
                return lexicalState0;
            })

        );
    }
}

