using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState527 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[527]",
            new LexicalRule(
            currentChar => currentChar == '>'/*'\u003E'(62)*/,
            context => {
                ExtendToken(context);
                return lexicalState549;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                ExtendToken(context);
                return lexicalState550;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@RightAngle);
                return lexicalState0;
            })

        );
    }
}

