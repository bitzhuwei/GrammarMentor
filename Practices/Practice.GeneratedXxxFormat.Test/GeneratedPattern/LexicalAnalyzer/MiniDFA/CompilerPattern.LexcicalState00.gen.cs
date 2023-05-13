using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => currentChar == '<'/*'\u003C'(60)*/,
            context => {
                BeginToken(context, EType.@refVt, EType.@char);
                ExtendToken(context);
                return lexicalState48;
            }),
            new LexicalRule(
            currentChar => (' '/*'\u0020'(32)*/ <= currentChar && currentChar <= '#'/*'\u0023'(35)*/)
            || ('%'/*'\u0025'(37)*/ <= currentChar && currentChar <= '\''/*'\u0027'(39)*/),
            context => {
                BeginToken(context, EType.@char);
                ExtendToken(context);
                return lexicalState49;
            }),
            new LexicalRule(
            currentChar => currentChar == ','/*'\u002C'(44)*/,
            context => {
                BeginToken(context, EType.@char, EType.@Comma);
                ExtendToken(context);
                return lexicalState50;
            }),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => {
                BeginToken(context, EType.@char);
                ExtendToken(context);
                return lexicalState51;
            }),
            new LexicalRule(
            currentChar => ('0'/*'\u0030'(48)*/ <= currentChar && currentChar <= ';'/*'\u003B'(59)*/)
            || (currentChar == '='/*'\u003D'(61)*/)
            || (currentChar == '>'/*'\u003E'(62)*/)
            || ('@'/*'\u0040'(64)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/)
            || ('_'/*'\u005F'(95)*/ <= currentChar && currentChar <= 'z'/*'\u007A'(122)*/)
            || (currentChar == '~'/*'\u007E'(126)*/),
            context => {
                BeginToken(context, EType.@char);
                ExtendToken(context);
                return lexicalState52;
            }),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                BeginToken(context, EType.@char);
                return lexicalState1;
            }),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => {
                BeginToken(context, EType.@scope);
                return lexicalState2;
            }),
            new LexicalRule(
            currentChar => currentChar == '/'/*'\u002F'(47)*/,
            context => {
                BeginToken(context, EType.@Slash);
                ExtendToken(context);
                return lexicalState53;
            }),
            new LexicalRule(
            currentChar => currentChar == '|'/*'\u007C'(124)*/,
            context => {
                BeginToken(context, EType.@Pipe);
                ExtendToken(context);
                return lexicalState54;
            }),
            new LexicalRule(
            currentChar => currentChar == '.'/*'\u002E'(46)*/,
            context => {
                BeginToken(context, EType.@Dot);
                ExtendToken(context);
                return lexicalState55;
            }),
            new LexicalRule(
            currentChar => currentChar == '('/*'\u0028'(40)*/,
            context => {
                BeginToken(context, EType.@LeftParenthesis);
                ExtendToken(context);
                return lexicalState56;
            }),
            new LexicalRule(
            currentChar => currentChar == ')'/*'\u0029'(41)*/,
            context => {
                BeginToken(context, EType.@RightParenthesis);
                ExtendToken(context);
                return lexicalState57;
            }),
            new LexicalRule(
            currentChar => currentChar == '?'/*'\u003F'(63)*/,
            context => {
                BeginToken(context, EType.@Question);
                ExtendToken(context);
                return lexicalState58;
            }),
            new LexicalRule(
            currentChar => currentChar == '+'/*'\u002B'(43)*/,
            context => {
                BeginToken(context, EType.@Plus);
                ExtendToken(context);
                return lexicalState59;
            }),
            new LexicalRule(
            currentChar => currentChar == '*'/*'\u002A'(42)*/,
            context => {
                BeginToken(context, EType.@Asterisk);
                ExtendToken(context);
                return lexicalState60;
            }),
            new LexicalRule(
            currentChar => currentChar == '{'/*'\u007B'(123)*/,
            context => {
                BeginToken(context, EType.@LeftBrace);
                ExtendToken(context);
                return lexicalState61;
            }),
            new LexicalRule(
            currentChar => currentChar == '}'/*'\u007D'(125)*/,
            context => {
                BeginToken(context, EType.@RightBrace);
                ExtendToken(context);
                return lexicalState62;
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

