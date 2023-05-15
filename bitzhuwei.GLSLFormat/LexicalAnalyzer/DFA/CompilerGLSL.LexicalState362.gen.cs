using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState362 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[362]",
            new LexicalRule(
            currentChar => currentChar == '1'/*'\u0031'(49)*/,
            context => lexicalState409),
            new LexicalRule(
            currentChar => currentChar == '2'/*'\u0032'(50)*/,
            context => lexicalState410),
            new LexicalRule(
            currentChar => currentChar == '3'/*'\u0033'(51)*/,
            context => lexicalState411),
            new LexicalRule(
            currentChar => currentChar == 'C'/*'\u0043'(67)*/,
            context => lexicalState412),
            new LexicalRule(
            currentChar => currentChar == 'B'/*'\u0042'(66)*/,
            context => lexicalState413),
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

