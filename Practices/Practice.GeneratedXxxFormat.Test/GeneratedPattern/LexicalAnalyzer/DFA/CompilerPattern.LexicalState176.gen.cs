using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState176 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[176]",
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState268),
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/,
            context => lexicalState269),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => lexicalState270),
            new LexicalRule(
            currentChar => '_'/*'\u005F'(95)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => lexicalState271),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => lexicalState121),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                ExtendToken(context);
                return lexicalState122;
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

