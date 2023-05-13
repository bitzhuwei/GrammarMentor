using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState40 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[40]",
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= '&'/*'\u0026'(38)*/,
            context => lexicalState4),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState5),
            new LexicalRule(
            currentChar => ('('/*'\u0028'(40)*/ <= currentChar && currentChar <= '='/*'\u003D'(61)*/)
            || ('?'/*'\u003F'(63)*/ <= currentChar && currentChar <= '['/*'\u005B'(91)*/)
            || (']'/*'\u005D'(93)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/),
            context => lexicalState4),
            new LexicalRule(
            currentChar => currentChar == '>'/*'\u003E'(62)*/,
            context => {
                ExtendToken(context);
                return lexicalState80;
            }),
            new LexicalRule(
            currentChar => currentChar == '\''/*'\u0027'(39)*/,
            context => lexicalState39),
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

