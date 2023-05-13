using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ReplaceComments
{
    partial class Compiler_Comment
    {
        private static readonly LexicalState state4 = new LexicalState(
            new LexicalRule(
            // accept '\n'(newline)
            currentChar => currentChar == '\r' || currentChar == '\n' || char.IsControl(currentChar),
            context =>
            {
                // end of a single line comment.
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index + 1);
                return state0;
            }),
            new LexicalRule(
            // accept everything else.
            currentChar => true,
            context => state4)
            );

    }

}
