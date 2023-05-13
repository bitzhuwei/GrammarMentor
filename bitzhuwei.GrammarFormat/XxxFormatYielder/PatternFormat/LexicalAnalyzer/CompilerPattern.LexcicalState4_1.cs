using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        /// <summary>
        /// got { of {min, max}
        /// <para>begin scope</para>
        /// </summary>
        private static readonly LexicalState lexicalState4_1 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[4_1]",
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.min;
                context.result.Add(token);
                return lexicalState4_2;
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
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing number"));
                return lexicalState0_0;
            }));

    }
}
