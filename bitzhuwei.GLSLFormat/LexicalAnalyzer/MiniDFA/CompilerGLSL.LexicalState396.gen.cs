using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState396 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[396]",
            new LexicalRule(
            currentChar => currentChar == '1'/*'\u0031'(49)*/,
            context => lexicalState425),
            new LexicalRule(
            currentChar => currentChar == '2'/*'\u0032'(50)*/,
            context => lexicalState426),
            new LexicalRule(
            currentChar => currentChar == '3'/*'\u0033'(51)*/,
            context => lexicalState427),
            new LexicalRule(
            currentChar => currentChar == 'C'/*'\u0043'(67)*/,
            context => lexicalState107),
            new LexicalRule(
            currentChar => currentChar == 'B'/*'\u0042'(66)*/,
            context => lexicalState113),
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

