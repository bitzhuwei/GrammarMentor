using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        /// <summary>
        /// got {N, of {min, max}
        /// <para>begin scope</para>
        /// </summary>
        private static readonly LexicalState lexicalState4_3 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[4_3]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.max;
                context.result.Add(token);
                return lexicalState4_4;
            }),
            new LexicalRule(
            currentChar => currentChar == '}',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.RightBrace;
                token.value = "}";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Error;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                context.result.Add(token);
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing [0-9]+}}"));
                return lexicalState0_0;
            }));

    }
}
