using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState6 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[6]",
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                return lexicalState19;
            }),
            new LexicalRule(
            currentChar => ' '/*'\u0020'(32)*/ <= currentChar && currentChar <= 'Z'/*'\u005A'(90)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState20;
            }),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState21;
            }),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState22;
            }),
            new LexicalRule(
            currentChar => '_'/*'\u005F'(95)*/ <= currentChar && currentChar <= '~'/*'\u007E'(126)*/,
            context => {
                AcceptPrevious(context, EType.@LeftBracket);
                BeginToken(context, EType.@firstItem1);
                ExtendToken(context);
                return lexicalState23;
            }),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => {
                ExtendToken(context);
                return lexicalState24;
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

