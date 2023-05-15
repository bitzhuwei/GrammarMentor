using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.VFormat {
    partial class CompilerV {
        private static readonly LexicalState lexicalState17 = new LexicalState($"{nameof(CompilerV)}.LexicalStates[17]",
            new LexicalRule(
            currentChar => !(currentChar == '/'/*'\u002F'(47)*/),
            context => lexicalState21),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState22;
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

