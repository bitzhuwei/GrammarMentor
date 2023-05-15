using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState422 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[422]",
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => {
                ExtendToken(context);
                return lexicalState637;
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

