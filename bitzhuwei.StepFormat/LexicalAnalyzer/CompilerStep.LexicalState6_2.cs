using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState6_2 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[6_2]",
            new LexicalRule(
            currentChar => (('0' <= currentChar && currentChar <= '9')
                || ('A' <= currentChar && currentChar <= 'Z')),
            context => lexicalState6_2),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                char c = context.CurrentChar;
                if (c == '\"')
                {
                    token.type = EType.Hexadecimal;
                    string str = context.Substring(token.index, context.Cursor - token.index + 1);
                    token.value = str;
                }
                else
                {
                    token.type = EType.Error;
                    string str = context.Substring(token.index, context.Cursor - token.index);
                    token.value = str;
                    context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing [{doubleQuot}] for hexadecimal."));
                    context.MoveBack(1);
                }
                return lexicalState0;
            })
            );

    }
}
