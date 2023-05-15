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
            currentChar => currentChar == 'a', // comment or slash [/]
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.a;
                token.value = "a";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '+', // comment or slash [/]
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.Plus;
                token.value = "+";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == 'b', // comment or slash [/]
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                token.type = EType.b;
                token.value = "b";
                context.result.Add(token);
                return lexicalState0;
            }),
            new LexicalRule(
            currentChar => currentChar == '/', // comment or slash [/]
            context => {
                var token = new Token(context.Cursor, context.Line, context.Column);
                context.result.Add(token);
                return lexicalState1_1;
            }),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                // uncomment this to get tokens not lexically analyzed yet.
                if (!context.EOF) {
                    char c = context.CurrentChar;
                    if (!(c == space || char.IsControl(c))) {
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

