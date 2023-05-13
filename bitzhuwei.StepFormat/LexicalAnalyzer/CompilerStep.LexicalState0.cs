using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState0 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[0]",
            new LexicalRule(
            currentChar => currentChar == '(',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.LeftParenthesis;
                token.value = "(";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == ')',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.RightParenthesis;
                token.value = ")";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '=',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Equal;
                token.value = "=";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == ';',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Semicolon;
                token.value = ";";
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
            currentChar => currentChar == '$',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Dollar;
                token.value = "$";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '*',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Asterisk;
                token.value = "*";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '/', // 多行注释 or 单行注释 or Slash[/]
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState1_1;
            }),
            new LexicalRule(
            currentChar => currentChar == quot, // 字符串
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.String;
                context.result.Add(token);
                return lexicalState2_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '#', // EntityId or Identity
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState3_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '-' || currentChar == '+',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState4_1;
            }),
            new LexicalRule(
            currentChar => '0' <= currentChar && currentChar <= '9',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState4_2;
            }),
            new LexicalRule(
            currentChar => currentChar == '.',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState4_4;
            }),
            new LexicalRule(
            currentChar => (('a' <= currentChar && currentChar <= 'z')
                || ('A' <= currentChar && currentChar <= 'Z')
                || (currentChar == '_')),
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState5_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '\"',
            context =>
            {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState6_1;

            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                // uncomment this to get tokens not lexically analyzed yet.
                if (!context.EOF)
                {
                    char c = context.CurrentChar;
                    if (!(c == space || char.IsControl(c)))
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

