using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState18 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[18]",
            new LexicalRule(
            currentChar => ('0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/)
            || ('A'/*'\u0041'(65)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/)
            || (currentChar == '_'/*'\u005F'(95)*/)
            || ('a'/*'\u0061'(97)*/ <= currentChar && currentChar <= 's'/*'\u0073'(115)*/)
            || ('u'/*'\u0075'(117)*/ <= currentChar && currentChar <= 'z'/*'\u007A'(122)*/),
            context => {
                ExtendToken(context);
                return lexicalState9;
            }),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => {
                ExtendToken(context);
                return lexicalState30;
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

