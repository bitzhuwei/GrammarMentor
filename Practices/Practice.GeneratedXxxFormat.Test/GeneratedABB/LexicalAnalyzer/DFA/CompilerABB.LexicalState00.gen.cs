using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat {
    partial class CompilerABB {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerABB)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => currentChar == '+'/*'\u002B'(43)*/,
            context => {
                BeginToken(context, EType.@Plus);
                ExtendToken(context);
                return lexicalState1;
            }),
            new LexicalRule(
            currentChar => currentChar == 'a'/*'\u0061'(97)*/,
            context => {
                BeginToken(context, EType.@a);
                ExtendToken(context);
                return lexicalState2;
            }),
            new LexicalRule(
            currentChar => currentChar == 'b'/*'\u0062'(98)*/,
            context => {
                BeginToken(context, EType.@b);
                ExtendToken(context);
                return lexicalState3;
            }),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                BeginToken(context, EType.@blockComment, EType.@inlineComment);
                return lexicalState4;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                char c = context.CurrentChar;
                if (c == ' ' || c == '\r' || c == '\n' || c == '\t' || c == '\0') { return lexicalState0; }
                // default handler: unexpected char.
                context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(context.analyzingToken);
                context.checkpoint = context.Cursor + 1;
                context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index);
                context.analyzingToken.type = EType.Error;
                context.result.errorDict.Add(context.analyzingToken, new TokenErrorInfo(context.analyzingToken, $"Unexpected char {c}"));
                return lexicalState0;
            })

        );
    }
}

