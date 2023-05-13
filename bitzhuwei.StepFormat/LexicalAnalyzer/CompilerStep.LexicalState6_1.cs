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
        private static readonly LexicalState lexicalState6_1 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[6_1]",
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
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, "Missing number(s) for hexadecimal."));
                token.value = str;
                context.MoveBack(1);

                return lexicalState0;
            })
            );

    }
}
