using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState229 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[229]",
            new LexicalRule(
            currentChar => currentChar == 'x'/*'\u0078'(120)*/,
            context => lexicalState290),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@mat3);
                return lexicalState0;
            })

        );
    }
}

