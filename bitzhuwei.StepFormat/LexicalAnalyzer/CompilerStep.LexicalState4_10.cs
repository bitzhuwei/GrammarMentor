using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState4_10 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[4_10]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => lexicalState4_10),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.type = EType.Float;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                //context.MoveCursor(-1);
                context.MoveBack(1);
                return lexicalState0;
            })
            );

    }
}
