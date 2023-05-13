using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        private static readonly LexicalState lexicalState3_3 = new LexicalState($"{nameof(CompilerWRL)}.LexiStates[3_3]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => lexicalState3_4),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                token.type = EType.Error;
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing number(s)"));
                context.MoveBack(1);
                return lexicalState0;
            }));

    }
}
