using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.ReplaceComments
{
    public partial class Compiler_Char
    {
        private static readonly LexicalState state0 = new LexicalState("Initial State",
            new LexicalRule(
            currentChar => true,
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Char;
                token.value = context.Substring(context.Cursor, 1);
                context.result.Add(token);
                return state0;
            })
            );
    }

}

