using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    partial class CompilerCalc {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerCalc)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                BeginToken(context, EType.@number);
                ExtendToken(context);
                return lexicalState1;
            }),
            new LexicalRule(
            currentChar => currentChar == '+'/*'\u002B'(43)*/,
            context => {
                BeginToken(context, EType.@Plus);
                ExtendToken(context);
                return lexicalState2;
            }),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => {
                BeginToken(context, EType.@Dash);
                ExtendToken(context);
                return lexicalState3;
            }),
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => {
                BeginToken(context, EType.@Asterisk);
                ExtendToken(context);
                return lexicalState4;
            }),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                BeginToken(context, EType.@Slash);
                ExtendToken(context);
                return lexicalState5;
            }),
            new LexicalRule(
            currentChar => currentChar == '('/*'\u0028'(40)*/,
            context => {
                BeginToken(context, EType.@LeftParenthesis);
                ExtendToken(context);
                return lexicalState6;
            }),
            new LexicalRule(
            currentChar => currentChar == ')'/*'\u0029'(41)*/,
            context => {
                BeginToken(context, EType.@RightParenthesis);
                ExtendToken(context);
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

