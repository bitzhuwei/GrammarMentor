using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState19 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[19]",
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => lexicalState11),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState32;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@char);
                return lexicalState0;
            })

        );
    }
}

