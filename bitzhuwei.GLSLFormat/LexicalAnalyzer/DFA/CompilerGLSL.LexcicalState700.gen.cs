using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState700 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[700]",
            new LexicalRule(
            currentChar => currentChar == 'y'/*'\u0079'(121)*/,
            context => {
                ExtendToken(context);
                return lexicalState710;
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

