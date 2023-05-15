using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState206 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[206]",
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState312),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => lexicalState313),
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => lexicalState314),
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => lexicalState315),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => lexicalState316),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => lexicalState229),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState317),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => lexicalState231),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => lexicalState318),
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

