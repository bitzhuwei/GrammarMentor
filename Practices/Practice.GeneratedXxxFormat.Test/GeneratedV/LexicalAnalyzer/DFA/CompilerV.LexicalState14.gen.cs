using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.VFormat {
    partial class CompilerV {
        private static readonly LexicalState lexicalState14 = new LexicalState($"{nameof(CompilerV)}.LexicalStates[14]",
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= '&'/*'\u0026'(38)*/,
            context => lexicalState9),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState10),
            new LexicalRule(
            currentChar => '('/*'\u0028'(40)*/ <= currentChar && currentChar <= '['/*'\u005B'(91)*/,
            context => lexicalState11),
            new LexicalRule(
            currentChar => ']'/*'\u005D'(93)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => lexicalState12),
            new LexicalRule(
            currentChar => currentChar == '\''/*'\u0027'(39)*/,
            context => {
                ExtendToken(context);
                return lexicalState13;
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

