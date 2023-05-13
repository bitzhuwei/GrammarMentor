using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState4_1 = new LexicalState($"{nameof(CompilerGrammar)}.LexiStates[4_1]",
            new LexicalRule(
            currentChar => currentChar == '%',
            context => lexicalState4_2),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                token.value = str;
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"start with %%"));
                return lexicalState0;
            }));

    }
}
