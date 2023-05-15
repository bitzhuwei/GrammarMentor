using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.VFormat {
    partial class CompilerV {
        private static readonly LexicalState lexicalState10 = new LexicalState($"{nameof(CompilerV)}.LexicalStates[10]",
            new LexicalRule(
            currentChar => currentChar == '\''/*'\u0027'(39)*/,
            context => lexicalState19),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState20),
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

