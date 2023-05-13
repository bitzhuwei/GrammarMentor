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
        private static readonly LexicalState state1 = new LexicalState(
            new LexicalRule(
            // accept '*'
            currentChar => currentChar == '*',
            context =>
            {
                var token = context.result.Last();
                token.type = EType.MultipleLineComment;
                return state2;
            }),
            new LexicalRule(
            // accept '/'
            currentChar => currentChar == '/',
            context =>
            {
                var token = context.result.Last();
                token.type = EType.SingleLineComment;
                return state4;
            }),
            new LexicalRule(
            // accept everything else.
            currentChar => true, // currentChar != '*' && currentChar != '/',
            context =>
            {
                var token = context.result.Last();
                //token.type = EType.Other;
                //token.value = "/";
                context.result.Remove(token);
                return state0;
            }));

    }

}
