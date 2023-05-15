using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat
{
    partial class CompilerPattern
    {
        /// <summary>
        /// got \uNN of the escape char \uNNNN
        /// </summary>
        private static readonly LexicalState lexicalState2_4 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[2_4]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => lexicalState2_5),
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index);
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing 2 hex-numbers(0-9A-Fa-f)"));
                return lexicalState0_0;
            }));

    }
}
