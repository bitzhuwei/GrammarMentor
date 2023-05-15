using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState531 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[531]",
            new LexicalRule(
            currentChar => currentChar == '|'/*'\u007C'(124)*/,
            context => {
                ExtendToken(context);
                return lexicalState556;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                ExtendToken(context);
                return lexicalState557;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Pipe);
                return lexicalState0;
            })

        );
    }
}

