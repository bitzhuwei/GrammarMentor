using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        private static readonly LexicalState lexicalState1_1 = new LexicalState($"{nameof(CompilerWRL)}.LexiStates[1_1]",
            new LexicalRule(
            currentChar => currentChar == '\r' || currentChar == '\n',
            context =>
            {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState0; // end with '\r' ?
            }),
            new LexicalRule(
            currentChar => char.IsControl(currentChar),
            context =>
            {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                char c = context.CurrentChar;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Unexpected char [{(int)c}]=[{c}]"));
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState1_1));

    }
}
