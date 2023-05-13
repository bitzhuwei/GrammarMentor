using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState1_4 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[1_4]",
            new LexicalRule(
            currentChar => currentChar == '\r' || currentChar == '\n',
            context =>
            {
                // end of a single line comment.
                //var token = context.result.Last();
                //token.value = context.Substring(token.index, context.Cursor - token.index);
                //if (token.value.EndsWith("\r"))
                //{
                //    token.value = token.value.TrimEnd('\r');
                //}
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState1_4)
            );

    }
}
