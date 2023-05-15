using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState26 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[26]",
            new LexicalRule(
            currentChar => !(currentChar == '%'/*'\u0025'(37)*/),
            context => lexicalState33),
            new LexicalRule(
            currentChar => currentChar == '%'/*'\u0025'(37)*/,
            context => lexicalState34),
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

