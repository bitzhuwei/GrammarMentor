using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState295 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[295]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                ExtendToken(context);
                return lexicalState295;
            }),
            new LexicalRule(
            currentChar => (currentChar == 'E'/*'\u0045'(69)*/)
            || (currentChar == 'e'/*'\u0065'(101)*/),
            context => lexicalState115),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@number);
                return lexicalState0;
            })

        );
    }
}

