using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState421 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[421]",
            new LexicalRule(
            currentChar => currentChar == '1'/*'\u0031'(49)*/,
            context => lexicalState461),
            new LexicalRule(
            currentChar => currentChar == '2'/*'\u0032'(50)*/,
            context => lexicalState462),
            new LexicalRule(
            currentChar => currentChar == '3'/*'\u0033'(51)*/,
            context => lexicalState463),
            new LexicalRule(
            currentChar => currentChar == 'C'/*'\u0043'(67)*/,
            context => lexicalState464),
            new LexicalRule(
            currentChar => currentChar == 'B'/*'\u0042'(66)*/,
            context => lexicalState465),
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

