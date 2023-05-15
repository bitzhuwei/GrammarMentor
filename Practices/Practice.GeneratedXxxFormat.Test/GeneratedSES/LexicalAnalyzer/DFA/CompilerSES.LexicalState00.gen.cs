using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerSES)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => currentChar == 's'/*'\u0073'(115)*/,
            context => {
                BeginToken(context, EType.@s);
                ExtendToken(context);
                return lexicalState1;
            }),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => {
                BeginToken(context, EType.@t);
                ExtendToken(context);
                return lexicalState2;
            }),
            new LexicalRule(
            currentChar => currentChar == 'g'/*'\u0067'(103)*/,
            context => {
                BeginToken(context, EType.@g);
                ExtendToken(context);
                return lexicalState3;
            }),
            new LexicalRule(
            currentChar => currentChar == 'w'/*'\u0077'(119)*/,
            context => {
                BeginToken(context, EType.@w);
                ExtendToken(context);
                return lexicalState4;
            }),
            new LexicalRule(
            currentChar => currentChar == 'e'/*'\u0065'(101)*/,
            context => {
                BeginToken(context, EType.@e);
                ExtendToken(context);
                return lexicalState5;
            }),
            new LexicalRule(
            currentChar => currentChar == 'd'/*'\u0064'(100)*/,
            context => {
                BeginToken(context, EType.@d);
                ExtendToken(context);
                return lexicalState6;
            }),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                BeginToken(context, EType.@blockComment, EType.@inlineComment);
                return lexicalState7;
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

