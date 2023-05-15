using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState26 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[26]",
            new LexicalRule(
            currentChar => !(currentChar == '*'/*'\u002A'(42)*/),
            context => lexicalState26),
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => lexicalState27),
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

