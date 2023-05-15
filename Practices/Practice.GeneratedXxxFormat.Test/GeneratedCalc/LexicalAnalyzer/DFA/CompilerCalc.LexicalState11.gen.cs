using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    partial class CompilerCalc {
        private static readonly LexicalState lexicalState11 = new LexicalState($"{nameof(CompilerCalc)}.LexicalStates[11]",
            new LexicalRule(
            currentChar => !(currentChar == '/'/*'\u002F'(47)*/),
            context => lexicalState13),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                ExtendToken(context);
                return lexicalState14;
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

