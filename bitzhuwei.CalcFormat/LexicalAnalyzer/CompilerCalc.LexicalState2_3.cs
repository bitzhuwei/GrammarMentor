using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat
{
    partial class CompilerCalc
    {
        private static readonly LexicalState lexicalState2_3 = new LexicalState($"{nameof(CompilerCalc)}.LexicalStates[2_3]",
            new LexicalRule(
            currentChar => ('0' <= currentChar && currentChar <= '9'),
            context => lexicalState2_3),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.type = EType.number;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                context.MoveBack(1);
                return lexicalState0;
            }));

    }
}
