using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState560 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[560]",
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState283),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@do);
                return lexicalState0;
            })

        );
    }
}

