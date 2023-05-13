using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState64 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[64]",
            new LexicalRule(
            currentChar => currentChar == '>'/*'\u003E'(62)*/,
            context => {
                ExtendToken(context);
                return lexicalState103;
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

