using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState22 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[22]",
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= '&'/*'\u0026'(38)*/,
            context => lexicalState19),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState20),
            new LexicalRule(
            currentChar => '('/*'\u0028'(40)*/ <= currentChar && currentChar <= '['/*'\u005B'(91)*/,
            context => lexicalState21),
            new LexicalRule(
            currentChar => ']'/*'\u005D'(93)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => lexicalState22),
            new LexicalRule(
            currentChar => currentChar == '\''/*'\u0027'(39)*/,
            context => {
                ExtendToken(context);
                return lexicalState23;
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

