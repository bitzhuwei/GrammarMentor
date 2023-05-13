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
        private static readonly LexicalState state2 = new LexicalState(
            new LexicalRule(
            // accept '*'
            currentChar => currentChar == '*',
            context => state3),
            new LexicalRule(
            // accept everything else.
            currentChar => currentChar != '*',
            context => state2)
            );

    }

}
