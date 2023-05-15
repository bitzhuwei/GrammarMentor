using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState71 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[71]",
            new LexicalRule(
            currentChar => currentChar == 'm'/*'\u006D'(109)*/,
            context => lexicalState73),
            new LexicalRule(
            currentChar => currentChar == 'a'/*'\u0061'(97)*/,
            context => lexicalState277),
            new LexicalRule(
            currentChar => currentChar == 'h'/*'\u0068'(104)*/,
            context => lexicalState236),
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState282),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => lexicalState2),
            new LexicalRule(
            currentChar => currentChar == 'w'/*'\u0077'(119)*/,
            context => lexicalState175),
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

