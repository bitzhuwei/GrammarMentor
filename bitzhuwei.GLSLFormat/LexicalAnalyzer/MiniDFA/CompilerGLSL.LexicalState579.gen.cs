using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState579 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[579]",
            new LexicalRule(
            currentChar => currentChar == 'x'/*'\u0078'(120)*/,
            context => lexicalState412),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@mat4);
                return lexicalState0;
            })

        );
    }
}

