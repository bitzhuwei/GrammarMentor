using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState4_4 = new LexicalState($"{nameof(CompilerGrammar)}.LexiStates[4_4]",
            new LexicalRule(
            currentChar => currentChar == '%', // end of regulat expression for Vt
            context => {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index + 1);
                token.value = str;
                if (str == "%%%%") {
                    token.type = EType.Error;
                    context.result.errorDict.Add(token, new TokenErrorInfo(token, $"empty regex for Vt!"));
                }
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == char.MinValue, // '\0'
            context => {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"end with %%"));
                return lexicalState0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState4_2));

    }
}
