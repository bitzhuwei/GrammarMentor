using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat
{
    partial class CompilerCalc
    {
        private static readonly LexicalState lexicalState1_4 = new LexicalState($"{nameof(CompilerCalc)}.LexicalStates[1_4]",
            new LexicalRule(
            currentChar => currentChar == '\r' || currentChar == '\n',
            context =>
            {
                // end of a single line comment.
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index);
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState1_4)
            );

    }
}
