using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState3_3 = new LexicalState($"{nameof(CompilerGrammar)}.LexiStates[3_3]",
            new LexicalRule(
            currentChar => currentChar == quot,
            context => {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index + 1);
                token.value = str;
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '\\',
            context => lexicalState3_2),
            new LexicalRule(
            currentChar => currentChar == char.MinValue, // '\0'
            context => {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing ending [']"));
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => char.IsControl(currentChar),
            context => {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                token.type = EType.Error;
                char c = context.CurrentChar;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Unexpected control char [{(int)c}]=[{c}]"));
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState3_3));

    }
}
