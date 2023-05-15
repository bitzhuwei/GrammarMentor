using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
        private static readonly LexicalState lexicalState3 = new LexicalState($"{nameof(CompilerPostfix)}.LexicalStates[3]",
            new LexicalRule(
            currentChar => !(currentChar == '/'/*'\u002F'(47)*/),
            context => lexicalState2),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState9;
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

