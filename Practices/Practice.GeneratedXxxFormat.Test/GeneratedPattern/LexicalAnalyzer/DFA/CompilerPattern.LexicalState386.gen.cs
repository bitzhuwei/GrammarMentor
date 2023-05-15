using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState386 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[386]",
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState463),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => lexicalState464),
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => lexicalState465),
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => lexicalState466),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => lexicalState467),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => lexicalState396),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState468),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => lexicalState398),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => lexicalState469),
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

