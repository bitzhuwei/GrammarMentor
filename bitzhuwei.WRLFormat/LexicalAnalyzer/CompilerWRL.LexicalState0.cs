using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.WRLFormat
{
    partial class CompilerWRL
    {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerWRL)}.LexiStates[0]",
            new LexicalRule(
            currentChar => currentChar == '{',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.LeftBrace;
                token.value = "{";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '}',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.RightBrace;
                token.value = "}";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '[',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.LeftBracket;
                token.value = "[";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == ']',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.RightBracket;
                token.value = "]";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == ',',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Comma;
                token.value = ",";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '#',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.SingleLineComment;
                context.result.Add(token);
                return lexicalState1_1;
            }),
            new LexicalRule(
            currentChar => (('a' <= currentChar && currentChar <= 'z')
                || ('A' <= currentChar && currentChar <= 'Z')
                || (currentChar == '_')),
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState2_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '+' || currentChar == '-',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState3_1;
            }),
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState3_2;
            }),
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                // uncomment this to get tokens not lexically analyzed yet.
                if (!context.EOF)
                {
                    char c = context.CurrentChar;
                    if (!(c == ' ' || char.IsControl(c)))
                    {
                        var token = new Token(context.Cursor, context.Line, context.Column);
                        token.type = EType.Coding;
                        token.value = c.ToString();
                        context.result.Add(token);
                    }
                }
                return lexicalState0;
            })
            );
    }

}

