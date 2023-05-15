using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.Ints2Format {
    partial class CompilerInts2 {
        private static readonly LexicalState lexicalState6 = new LexicalState($"{nameof(CompilerInts2)}.LexicalStates[6]",
            new LexicalRule(
            currentChar => !(currentChar == '*'/*'\u002A'(42)*/),
            context => lexicalState6),
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => lexicalState7),
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

