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
        /// found a char(again)
        /// </summary>
        private static readonly LexicalState lexicalState3_4 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[3_4]",
            new LexicalRule(
            currentChar => currentChar == '\\',
            context => lexicalState3_6),
            new LexicalRule(
            currentChar => currentChar == '\0',
            context =>
            {
                var token = context.result.Last();
                var b = context.tagDict[scopeKey] as StringBuilder;
                token.value = b.ToString();
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing ]"));
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == ']', // end of scope
            context =>
            {
                var token = context.result.Last();
                var b = context.tagDict[scopeKey] as StringBuilder;
                b.Append(']');
                token.value = b.ToString();
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
