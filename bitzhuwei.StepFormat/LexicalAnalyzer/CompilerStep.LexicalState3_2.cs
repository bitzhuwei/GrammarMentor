using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState3_2 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[3_2]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => lexicalState3_2),
            new LexicalRule(
            currentChar => currentChar == space || currentChar == tab,
            context => lexicalState3_3),
            new LexicalRule(
            currentChar => currentChar == '=',
            context =>
            {
                var token = context.result.Last();
                token.type = EType.EntityId;
                string str = context.Substring(token.index, context.Cursor - token.index);
                int length = str.Length;
                token.value = str.TrimEnd();
                //context.MoveCursor(-(syntaxStateCount - token.value.Length) - 1);
                context.MoveBack(length - token.value.Length + 1);
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.type = EType.Identity;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                //context.MoveCursor(-1);
                context.MoveBack(1);
                return lexicalState0;
            })
            );

    }
}
