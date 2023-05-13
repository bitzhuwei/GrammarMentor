using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState1_1 = new LexicalState($"{nameof(CompilerGrammar)}.LexiStates[1_1]",
            new LexicalRule(
            currentChar => currentChar == '*',
            context => {
                var token = context.result.Last();
                token.type = EType.MultipleLineComment;
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState1_2;
            }),
            new LexicalRule(
            currentChar => currentChar == '/',
            context => {
                var token = context.result.Last();
                token.type = EType.SingleLineComment;
                // no need to pick up comment now.
                context.result.Remove(token);
                return lexicalState1_4;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = context.result.Last();
                token.type = EType.Error;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                context.MoveBack(1);
                return lexicalState0;
            }));
    }
}
