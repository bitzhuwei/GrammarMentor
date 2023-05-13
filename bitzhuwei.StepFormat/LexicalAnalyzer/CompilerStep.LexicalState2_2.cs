using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState2_2 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[2_2]",
            new LexicalRule(
            currentChar => currentChar == space || currentChar == '\r' || currentChar == '\n',
            context => lexicalState2_2),
            new LexicalRule(
            currentChar => currentChar == ',' || currentChar == ')',
            context =>
            {
                var token = context.result.Last();
                var str = context.Substring(token.index, context.Cursor - token.index);
                int length = str.Length;
                token.value = str.TrimEnd();
                //context.MoveCursor(-(syntaxStateCount - token.value.Length) - 1);
                // read those ' ' '\n' '\r' ',' or ')' again.
                context.MoveBack(length - token.value.Length + 1);
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState2_1)
            );

    }
}
