using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState95 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[95]",
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => lexicalState152),
            new LexicalRule(
            currentChar => currentChar == 'm'/*'\u006D'(109)*/,
            context => lexicalState153),
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

