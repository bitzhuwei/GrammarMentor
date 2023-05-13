using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        /// <summary>
        /// got \ of the escape char \xxxxx
        /// </summary>
        private static readonly LexicalState lexicalState2_1 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[2_1]",
            new LexicalRule(
            currentChar => "$()*+-/%.?[\\]^<>{|}".Contains(currentChar),
            context => {
                var token = context.result.Last();
                token.value = context.CurrentChar.ToString();
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == 'u', // \uNNNN
            context => {
                var token = context.result.Last();
                token.value = context.CurrentChar.ToString();
                return lexicalState2_2;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index + 1);
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"unexpected escape char {context.CurrentChar}"));
                context.MoveBack(1);
                return lexicalState0_0;
            }));

    }
}
