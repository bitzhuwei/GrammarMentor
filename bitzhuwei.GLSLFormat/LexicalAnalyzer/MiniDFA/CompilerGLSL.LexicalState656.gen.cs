using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState656 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[656]",
            new LexicalRule(
            currentChar => currentChar == 'S'/*'\u0053'(83)*/,
            context => lexicalState372),
            new LexicalRule(
            currentChar => currentChar == 'A'/*'\u0041'(65)*/,
            context => lexicalState28),
            new LexicalRule(
            currentChar => currentChar == 'R'/*'\u0052'(82)*/,
            context => lexicalState135),
            new LexicalRule(
            currentChar => currentChar == 'M'/*'\u004D'(77)*/,
            context => lexicalState457),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@sampler2D);
                return lexicalState0;
            })

        );
    }
}

