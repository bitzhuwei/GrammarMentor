using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState493 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[493]",
            new LexicalRule(
            currentChar => currentChar == 'w'/*'\u0077'(119)*/,
            context => {
                ExtendToken(context);
                return lexicalState706;
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

