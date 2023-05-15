using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerGrammar)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => ('A'/*'\u0041'(65)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/)
            || (currentChar == '_'/*'\u005F'(95)*/)
            || ('a'/*'\u0061'(97)*/ <= currentChar && currentChar <= 'd'/*'\u0064'(100)*/)
            || ('f'/*'\u0066'(102)*/ <= currentChar && currentChar <= 'z'/*'\u007A'(122)*/),
            context => {
                BeginToken(context, EType.@Vn);
                ExtendToken(context);
                return lexicalState11;
            }),
            new LexicalRule(
            currentChar => currentChar == 'e'/*'\u0065'(101)*/,
            context => {
                BeginToken(context, EType.@Vn, EType.@empty);
                ExtendToken(context);
                return lexicalState12;
            }),
            new LexicalRule(
            currentChar => currentChar == '\''/*'\u0027'(39)*/,
            context => {
                BeginToken(context, EType.@Vt);
                return lexicalState1;
            }),
            new LexicalRule(
            currentChar => currentChar == '%'/*'\u0025'(37)*/,
            context => {
                BeginToken(context, EType.@pattern);
                return lexicalState2;
            }),
            new LexicalRule(
            currentChar => currentChar == ':'/*'\u003A'(58)*/,
            context => {
                BeginToken(context, EType.@Colon);
                ExtendToken(context);
                return lexicalState13;
            }),
            new LexicalRule(
            currentChar => currentChar == ';'/*'\u003B'(59)*/,
            context => {
                BeginToken(context, EType.@Semicolon);
                ExtendToken(context);
                return lexicalState14;
            }),
            new LexicalRule(
            currentChar => currentChar == '|'/*'\u007C'(124)*/,
            context => {
                BeginToken(context, EType.@Pipe);
                ExtendToken(context);
                return lexicalState15;
            }),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                BeginToken(context, EType.@blockComment, EType.@inlineComment);
                return lexicalState3;
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

