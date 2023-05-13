using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState1_1 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[1_1]",
            new LexicalRule(
            currentChar => currentChar == '*',
            context =>
            {
                var token = context.result.Last();
                token.type = EType.MultipleLineComment;
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState1_2;
            }),
            new LexicalRule(
            currentChar => currentChar == '/',
            context =>
            {
                var token = context.result.Last();
                token.type = EType.SingleLineComment;
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState1_4;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.type = EType.Slash;
                string str = context.Substring(token.index, context.Cursor - token.index);
                int length = str.Length;
                token.value = str.TrimEnd();
                //context.MoveCursor(-(syntaxStateCount - token.value.Length) - 1);
                context.MoveBack(length - token.value.Length + 1);
                //token.value = "/";
                //context.MoveCursor(-1);
                return lexicalState0;
            }));

    }
}
