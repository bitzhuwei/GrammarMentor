using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState2_1 = new LexicalState($"{nameof(CompilerGrammar)}.LexiStates[2_1]",
            new LexicalRule(
            currentChar => (('a' <= currentChar && currentChar <= 'z')
                || ('A' <= currentChar && currentChar <= 'Z')
                || ('0' <= currentChar && currentChar <= '9')
                || (currentChar == '_')),
            context => lexicalState2_1),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index);
                if (token.value == CompilerGrammar.keywordEmpty) { token.type = EType.empty; }
                else { token.type = EType.Vn; }

                context.MoveBack(1);
                return lexicalState0;
            })
            );
    }
}
