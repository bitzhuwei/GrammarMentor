using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    partial class CompilerCalc {
        private static readonly LexicalState lexicalState5 = new LexicalState($"{nameof(CompilerCalc)}.LexicalStates[5]",
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => lexicalState8),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState9;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Slash);
                return lexicalState0;
            })

        );
    }
}

