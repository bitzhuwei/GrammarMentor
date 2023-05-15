using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState30 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[30]",
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => {
                ExtendToken(context);
                return lexicalState74;
            }),
            new LexicalRule(
            currentChar => currentChar == 'v'/*'\u0076'(118)*/,
            context => lexicalState75),
            new LexicalRule(
            currentChar => currentChar == 's'/*'\u0073'(115)*/,
            context => lexicalState76),
            new LexicalRule(
            currentChar => currentChar == 'm'/*'\u006D'(109)*/,
            context => lexicalState77),
            new LexicalRule(
            currentChar => currentChar == 'i'/*'\u0069'(105)*/,
            context => lexicalState78),
            new LexicalRule(
            currentChar => currentChar == 'f'/*'\u0066'(102)*/,
            context => {
                ExtendToken(context);
                return lexicalState79;
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

