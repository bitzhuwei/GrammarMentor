using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState139 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[139]",
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState214),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => lexicalState215),
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => lexicalState216),
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => lexicalState217),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => lexicalState218),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => lexicalState219),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState220),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => lexicalState221),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => lexicalState222),
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

