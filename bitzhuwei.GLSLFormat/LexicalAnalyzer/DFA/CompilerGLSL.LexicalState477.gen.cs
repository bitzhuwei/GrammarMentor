using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState477 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[477]",
            new LexicalRule(
            currentChar => currentChar == 'A'/*'\u0041'(65)*/,
            context => lexicalState520),
            new LexicalRule(
            currentChar => currentChar == 'R'/*'\u0052'(82)*/,
            context => lexicalState521),
            new LexicalRule(
            currentChar => currentChar == 'M'/*'\u004D'(77)*/,
            context => lexicalState522),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@isampler2D);
                return lexicalState0;
            })

        );
    }
}

