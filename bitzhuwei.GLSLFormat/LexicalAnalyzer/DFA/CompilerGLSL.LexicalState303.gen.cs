using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState303 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[303]",
            new LexicalRule(
            currentChar => currentChar == 'D'/*'\u0044'(68)*/,
            context => {
                ExtendToken(context);
                return lexicalState353;
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

