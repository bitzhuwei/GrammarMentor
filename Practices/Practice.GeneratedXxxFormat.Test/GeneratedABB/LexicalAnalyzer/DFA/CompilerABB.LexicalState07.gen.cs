using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat {
    partial class CompilerABB {
        private static readonly LexicalState lexicalState7 = new LexicalState($"{nameof(CompilerABB)}.LexicalStates[7]",
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

