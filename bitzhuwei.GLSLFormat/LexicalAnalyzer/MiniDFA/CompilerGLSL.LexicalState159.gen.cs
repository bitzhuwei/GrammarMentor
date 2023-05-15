using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState159 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[159]",
            new LexicalRule(
            currentChar => currentChar == 'o'/*'\u006F'(111)*/,
            context => {
                ExtendToken(context);
                return lexicalState560;
            }),
            new LexicalRule(
            currentChar => currentChar == 'v'/*'\u0076'(118)*/,
            context => lexicalState130),
            new LexicalRule(
            currentChar => currentChar == 'm'/*'\u006D'(109)*/,
            context => lexicalState239),
            new LexicalRule(
            currentChar => currentChar == 'e'/*'\u0065'(101)*/,
            context => lexicalState330),
            new LexicalRule(
            currentChar => currentChar == 'i'/*'\u0069'(105)*/,
            context => lexicalState313),
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

