using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState32 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[32]",
            new LexicalRule(
            currentChar => (currentChar == '\\'/*'\u005C'(92)*/)
            || (currentChar == 't'/*'\u0074'(116)*/)
            || (currentChar == '\\'/*'\u005C'(92)*/)
            || (currentChar == 'r'/*'\u0072'(114)*/)
            || (' '/*'\u0020'(32)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/),
            context => {
                ExtendToken(context);
                return lexicalState38;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@inlineComment);
                return lexicalState0;
            })

        );
    }
}

