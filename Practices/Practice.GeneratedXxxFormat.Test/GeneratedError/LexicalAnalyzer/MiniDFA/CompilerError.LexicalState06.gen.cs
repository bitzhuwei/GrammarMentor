using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ErrorFormat {
    partial class CompilerError {
        private static readonly LexicalState lexicalState6 = new LexicalState($"{nameof(CompilerError)}.LexicalStates[6]",
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                ExtendToken(context);
                return lexicalState6;
            }),
            new LexicalRule(
            currentChar => 'Y'/*'\u0059'(89)*/ <= currentChar && currentChar <= '['/*'\u005B'(91)*/,
            context => {
                ExtendToken(context);
                return lexicalState7;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@refVt);
                return lexicalState0;
            })

        );
    }
}

