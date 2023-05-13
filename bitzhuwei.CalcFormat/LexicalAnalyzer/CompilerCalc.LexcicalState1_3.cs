using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat
{
    partial class CompilerCalc
    {
        private static readonly LexicalState lexicalState1_3 = new LexicalState($"{nameof(CompilerCalc)}.LexicalStates[1_3]",
            new LexicalRule(
            currentChar => currentChar == '/',
            context =>
            {
                // end of a multiple line comment.
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index + 1);
                context.result.Remove(token);
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState1_2)
            );

    }
}
