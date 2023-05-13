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
        private static readonly LexicalState state3 = new LexicalState(
            new LexicalRule(
            currentChar => currentChar == '/',
            context =>
            {
                // end of a multiple line comment.
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index + 1);
                return state0;
            }),
            new LexicalRule(
            currentChar => true,// currentChar != '/',
            context => state2)
            );

    }

}
