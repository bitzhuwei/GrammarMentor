using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState68 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[68]",
            new LexicalRule(
            currentChar => currentChar == 'o'/*'\u006F'(111)*/,
            context => lexicalState209),
            new LexicalRule(
            currentChar => currentChar == 'e'/*'\u0065'(101)*/,
            context => lexicalState210),
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

