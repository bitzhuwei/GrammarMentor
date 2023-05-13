using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState577 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[577]",
            new LexicalRule(
            currentChar => currentChar == 'x'/*'\u0078'(120)*/,
            context => lexicalState410),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@mat2);
                return lexicalState0;
            })

        );
    }
}

