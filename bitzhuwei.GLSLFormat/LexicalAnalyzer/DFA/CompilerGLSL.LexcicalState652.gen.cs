using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState652 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[652]",
            new LexicalRule(
            currentChar => currentChar == 'S'/*'\u0053'(83)*/,
            context => lexicalState677),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@sampler1DArray);
                return lexicalState0;
            })

        );
    }
}

