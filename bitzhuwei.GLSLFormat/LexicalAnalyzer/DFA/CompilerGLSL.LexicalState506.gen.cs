using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState506 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[506]",
            new LexicalRule(
            currentChar => currentChar == 'A'/*'\u0041'(65)*/,
            context => lexicalState549),
            new LexicalRule(
            currentChar => currentChar == 'R'/*'\u0052'(82)*/,
            context => lexicalState550),
            new LexicalRule(
            currentChar => currentChar == 'M'/*'\u004D'(77)*/,
            context => lexicalState551),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@usampler2D);
                return lexicalState0;
            })

        );
    }
}

