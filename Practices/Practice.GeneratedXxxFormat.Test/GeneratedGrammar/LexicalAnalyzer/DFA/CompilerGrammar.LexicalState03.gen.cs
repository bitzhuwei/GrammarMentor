using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState3 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[3]",
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= '&'/*'\u0026'(38)*/,
            context => lexicalState11),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => lexicalState12),
            new LexicalRule(
            currentChar => '('/*'\u0028'(40)*/ <= currentChar && currentChar <= '['/*'\u005B'(91)*/,
            context => lexicalState13),
            new LexicalRule(
            currentChar => ']'/*'\u005D'(93)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => lexicalState14),
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

