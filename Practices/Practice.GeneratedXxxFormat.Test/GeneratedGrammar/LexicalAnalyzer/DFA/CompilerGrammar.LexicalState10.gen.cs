using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState10 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[10]",
            new LexicalRule(
            currentChar => ('0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/)
            || ('A'/*'\u0041'(65)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/)
            || (currentChar == '_'/*'\u005F'(95)*/)
            || ('a'/*'\u0061'(97)*/ <= currentChar && currentChar <= 'o'/*'\u006F'(111)*/)
            || ('q'/*'\u0071'(113)*/ <= currentChar && currentChar <= 'z'/*'\u007A'(122)*/),
            context => {
                ExtendToken(context);
                return lexicalState9;
            }),
            new LexicalRule(
            currentChar => currentChar == 'p'/*'\u0070'(112)*/,
            context => {
                ExtendToken(context);
                return lexicalState18;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Vn);
                return lexicalState0;
            })

        );
    }
}

