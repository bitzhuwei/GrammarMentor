using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState213 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[213]",
            new LexicalRule(
            currentChar => currentChar == '2'/*'\u0032'(50)*/,
            context => {
                ExtendToken(context);
                return lexicalState267;
            }),
            new LexicalRule(
            currentChar => currentChar == '3'/*'\u0033'(51)*/,
            context => {
                ExtendToken(context);
                return lexicalState268;
            }),
            new LexicalRule(
            currentChar => currentChar == '4'/*'\u0034'(52)*/,
            context => {
                ExtendToken(context);
                return lexicalState269;
            }),
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

