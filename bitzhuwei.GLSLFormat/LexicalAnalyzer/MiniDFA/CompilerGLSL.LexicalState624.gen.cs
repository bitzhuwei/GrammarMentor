using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState624 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[624]",
            new LexicalRule(
            currentChar => currentChar == 'A'/*'\u0041'(65)*/,
            context => lexicalState19),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@image1D);
                return lexicalState0;
            })

        );
    }
}

