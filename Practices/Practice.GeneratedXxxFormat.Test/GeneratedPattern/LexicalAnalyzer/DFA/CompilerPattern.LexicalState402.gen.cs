using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState402 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[402]",
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState404),
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/,
            context => lexicalState405),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => lexicalState406),
            new LexicalRule(
            currentChar => '_'/*'\u005F'(95)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => lexicalState407),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => lexicalState95),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                ExtendToken(context);
                return lexicalState96;
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

