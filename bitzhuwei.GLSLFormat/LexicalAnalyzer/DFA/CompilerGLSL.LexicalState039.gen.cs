using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState39 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[39]",
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => lexicalState102),
            new LexicalRule(
            currentChar => currentChar == 'h'/*'\u0068'(104)*/,
            context => lexicalState103),
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

