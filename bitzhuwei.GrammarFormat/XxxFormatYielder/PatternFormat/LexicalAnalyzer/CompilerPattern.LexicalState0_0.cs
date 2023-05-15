using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState0_0 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[0]",
            new LexicalRule(
            currentChar => currentChar == '/', // comment or LookAfter
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState1_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '|',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Pipe;
                token.value = "|";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == '(',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.LeftParenthesis;
                token.value = "(";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == ')',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.RightParenthesis;
                token.value = ")";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == '?',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Question;
                token.value = "?";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == '+',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Plus;
                token.value = "+";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == '*',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Asterisk;
                token.value = "*";
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == '{',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.LeftBrace;
                token.value = "{";
                context.result.Add(token);
                return lexicalState4_1;
            }),
            new LexicalRule(currentChar => currentChar == '<',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState5_1;
            }),
            new LexicalRule(currentChar => currentChar == '.',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Dot;
                token.value = context.CurrentChar.ToString();
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => "- !\"#%&',:;=>)]}@_`~".Contains(currentChar)
            || ('0' <= currentChar && currentChar <= '9')
            || ('A' <= currentChar && currentChar <= 'Z')
            || ('a' <= currentChar && currentChar <= 'z'), // literal char
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.char_;
                token.value = context.CurrentChar.ToString();
                context.result.Add(token);
                return lexicalState0_0;
            }),
            new LexicalRule(
            currentChar => currentChar == '\\', // escape char
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.char_;
                context.result.Add(token);
                return lexicalState2_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '[', // scoped chars
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.scope;
                context.result.Add(token);
                if (context.tagDict.TryGetValue(scopeKey, out var obj)) {
                    context.tagDict.Remove(scopeKey);
                }
                var b = new StringBuilder(); b.Append('[');
                context.tagDict.Add(scopeKey, b);
                return lexicalState3_1;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                // uncomment this to get tokens not lexically analyzed yet.
                if (!context.EOF) {
                    char c = context.CurrentChar;
                    if (!(char.IsControl(c))) {
                        var token = new Token(context.Cursor, context.Line, context.Column);
                        token.value = c.ToString();
                        token.type = EType.Error;
                        context.result.errorDict.Add(token, new TokenErrorInfo(token, $"unexpected token {c}"));
                        context.result.Add(token);
                    }
                }
                return lexicalState0_0;
            })
            );
    }

}

