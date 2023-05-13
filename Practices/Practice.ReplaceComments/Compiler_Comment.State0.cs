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
        private static readonly LexicalState state0 = new LexicalState("Initial State",
            new LexicalRule(
            // accept '/'
            currentChar => currentChar == '/',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return state1;
            }),
            new LexicalRule(
            // accept everything else.
            currentChar => true, // currentChar != '/',
            context => state0)
            );
    }

}

