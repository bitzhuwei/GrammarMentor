using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
        private static readonly LexicalState lexicalState4 = new LexicalState($"{nameof(CompilerPostfix)}.LexicalStates[4]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                ExtendToken(context);
                return lexicalState4;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                CheckToken(context, EType.@entityId);
                return lexicalState6;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@refEntity);
                return lexicalState0;
            })

        );
    }
}

