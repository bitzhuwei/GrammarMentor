using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState18 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[18]",
            new LexicalRule(
            currentChar => currentChar == '<'/*'\u003C'(60)*/,
            context => {
                ExtendToken(context);
                return lexicalState61;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                ExtendToken(context);
                return lexicalState62;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@LeftAngle);
                return lexicalState0;
            })

        );
    }
}

