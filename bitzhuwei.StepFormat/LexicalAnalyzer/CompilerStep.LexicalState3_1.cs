using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState3_1 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[3_1]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => lexicalState3_2),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.type = EType.Error;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                context.result.errorDict.Add(token, new TokenErrorInfo(token, "There should be number(s) after '#'."));
                //context.MoveCursor(-1);
                context.MoveBack(1);
                return lexicalState0;
            })
            );

    }
}
