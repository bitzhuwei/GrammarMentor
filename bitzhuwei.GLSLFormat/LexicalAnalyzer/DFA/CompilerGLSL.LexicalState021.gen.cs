using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState21 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[21]",
            new LexicalRule(
            currentChar => currentChar == '&'/*'\u0026'(38)*/,
            context => {
                ExtendToken(context);
                return lexicalState66;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                ExtendToken(context);
                return lexicalState67;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@And);
                return lexicalState0;
            })

        );
    }
}

