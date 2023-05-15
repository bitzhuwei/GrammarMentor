using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState359 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[359]",
            new LexicalRule(
            currentChar => currentChar == 'd'/*'\u0064'(100)*/,
            context => {
                ExtendToken(context);
                return lexicalState570;
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

