using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState37 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[37]",
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState97),
            new LexicalRule(
            currentChar => currentChar == 'o'/*'\u006F'(111)*/,
            context => lexicalState98),
            new LexicalRule(
            currentChar => currentChar == 'v'/*'\u0076'(118)*/,
            context => lexicalState99),
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => lexicalState100),
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

