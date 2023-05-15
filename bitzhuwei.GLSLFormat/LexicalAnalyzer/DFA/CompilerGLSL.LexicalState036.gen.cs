using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState36 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[36]",
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => lexicalState93),
            new LexicalRule(
            currentChar => currentChar == 's'/*'\u0073'(115)*/,
            context => lexicalState94),
            new LexicalRule(
            currentChar => currentChar == 'i'/*'\u0069'(105)*/,
            context => lexicalState95),
            new LexicalRule(
            currentChar => currentChar == 'v'/*'\u0076'(118)*/,
            context => lexicalState96),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                context.MoveBack(1);
                return lexicalState0;
            })

        );
    }
}

