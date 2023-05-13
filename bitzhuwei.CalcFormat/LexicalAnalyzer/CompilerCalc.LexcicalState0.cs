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
            currentChar => currentChar == '+',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Plus;
                token.value = "+";//context.Substring(token.index, context.Cursor - token.index);
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '-',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Dash;
                token.value = "-";//context.Substring(token.index, context.Cursor - token.index);
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '*',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Asterisk;
                token.value = "*";//context.Substring(token.index, context.Cursor - token.index);
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '/', // comment or slash [/]
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                // token.type = ?
                // token.value = ?
                context.result.Add(token);
                return lexicalState1_1;
            }),
            new LexicalRule(
            currentChar => currentChar == '(',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.LeftParenthesis;
                token.value = "(";//context.Substring(token.index, context.Cursor - token.index);
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == ')',
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.RightParenthesis;
                token.value = ")";//context.Substring(token.index, context.Cursor - token.index);
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => ('0' <= currentChar && currentChar <= '9'),
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                //token.type = ?
                // token.value = ?
                context.result.Add(token);
                return lexicalState2_1;
            }),
            new LexicalRule(
            currentChar => currentChar == space || currentChar == '\0' || char.IsControl(currentChar),
            context => lexicalState0),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                // uncomment this to get tokens not lexically analyzed yet.
                context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.Cursor - context.analyzingToken.index);
                context.analyzingToken.type = EType.Coding;
                context.result.Add(context.analyzingToken);
                return lexicalState0;
            })
            );
    }

}

