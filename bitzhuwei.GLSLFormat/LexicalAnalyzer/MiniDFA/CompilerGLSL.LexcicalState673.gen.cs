using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState673 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[673]",
            new LexicalRule(
            currentChar => currentChar == 'S'/*'\u0053'(83)*/,
            context => lexicalState373),
            new LexicalRule(
            currentChar => currentChar == 'A'/*'\u0041'(65)*/,
            context => lexicalState38),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@samplerCube);
                return lexicalState0;
            })

        );
    }
}

