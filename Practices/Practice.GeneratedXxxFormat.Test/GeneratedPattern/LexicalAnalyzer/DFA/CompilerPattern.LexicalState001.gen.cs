using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState1 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[1]",
            new LexicalRule(
            currentChar => currentChar == '\''/*'\u0027'(39)*/,
            context => lexicalState18),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@char);
                return lexicalState0;
            })

        );
    }
}

