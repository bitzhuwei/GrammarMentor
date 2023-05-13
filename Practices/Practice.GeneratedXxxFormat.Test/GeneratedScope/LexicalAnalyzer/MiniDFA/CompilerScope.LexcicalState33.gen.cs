using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState33 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[33]",
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracketCaret);
                BeginToken(context, EType.@firstItem2);
                return lexicalState12;
            }),
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracketCaret);
                BeginToken(context, EType.@firstItem2);
                ExtendToken(context);
                return lexicalState40;
            }),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracketCaret);
                BeginToken(context, EType.@firstItem2);
                ExtendToken(context);
                return lexicalState41;
            }),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracketCaret);
                BeginToken(context, EType.@firstItem2);
                ExtendToken(context);
                return lexicalState42;
            }),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracketCaret);
                BeginToken(context, EType.@firstItem2);
                ExtendToken(context);
                return lexicalState43;
            }),
            new LexicalRule(
            currentChar => '_'/*'\u005F'(95)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracketCaret);
                BeginToken(context, EType.@firstItem2);
                ExtendToken(context);
                return lexicalState44;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@LeftBracketCaret);
                return lexicalState0;
            })

        );
    }
}

