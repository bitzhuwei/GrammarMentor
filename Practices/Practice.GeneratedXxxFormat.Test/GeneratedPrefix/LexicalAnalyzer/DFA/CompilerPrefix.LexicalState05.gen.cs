using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PrefixFormat {
    partial class CompilerPrefix {
        private static readonly LexicalState lexicalState5 = new LexicalState($"{nameof(CompilerPrefix)}.LexicalStates[5]",
            new LexicalRule(
            currentChar => !(currentChar == '*'/*'\u002A'(42)*/),
            context => lexicalState7),
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => lexicalState8),
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

