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
        /// got [^\ of the scope chars [xxx]
        /// </summary>
        private static readonly LexicalState lexicalState3_3 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[3_3]",
            new LexicalRule(
            currentChar => currentChar == '\0',
            context =>
            {
                var token = context.result.Last();
                var b = context.tagDict[scopeKey] as StringBuilder;
                token.value = b.ToString();
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing reversed escape content]"));
                return lexicalState0_0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var b = context.tagDict[scopeKey] as StringBuilder;
                b.Append(context.CurrentChar);
                return lexicalState3_4;
            }));

    }
}
