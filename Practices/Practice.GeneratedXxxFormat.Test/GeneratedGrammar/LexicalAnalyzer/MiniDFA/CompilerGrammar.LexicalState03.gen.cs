using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState3 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[3]",
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => lexicalState7),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState18;
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

