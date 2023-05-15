using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PrefixFormat {
    partial class CompilerPrefix {
        private static readonly LexicalState lexicalState8 = new LexicalState($"{nameof(CompilerPrefix)}.LexicalStates[8]",
            new LexicalRule(
            currentChar => !(currentChar == '/'/*'\u002F'(47)*/),
            context => lexicalState10),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState11;
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

