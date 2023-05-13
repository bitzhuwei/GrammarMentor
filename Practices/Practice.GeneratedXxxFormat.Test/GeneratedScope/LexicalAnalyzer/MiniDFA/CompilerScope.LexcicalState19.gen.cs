using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState19 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[19]",
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                return lexicalState11;
            }),
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState29;
            }),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState30;
            }),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState31;
            }),
            new LexicalRule(
            currentChar => '_'/*'\u005F'(95)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState32;
            }),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => {
                ExtendToken(context);
                return lexicalState33;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@LeftBracket);
                return lexicalState0;
            })

        );
    }
}

