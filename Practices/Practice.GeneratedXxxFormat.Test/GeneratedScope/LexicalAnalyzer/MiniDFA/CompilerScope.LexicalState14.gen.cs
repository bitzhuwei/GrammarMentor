using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        private static readonly LexicalState lexicalState14 = new LexicalState($"{nameof(CompilerScope)}.LexicalStates[14]",
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState4),
            new LexicalRule(
            currentChar => currentChar == 't'/*'\u0074'(116)*/,
            context => {
                ExtendToken(context);
                return lexicalState51;
            }),
            new LexicalRule(
            currentChar => currentChar == 'n'/*'\u006E'(110)*/,
            context => {
                ExtendToken(context);
                return lexicalState52;
            }),
            new LexicalRule(
            currentChar => currentChar == 'r'/*'\u0072'(114)*/,
            context => {
                ExtendToken(context);
                return lexicalState53;
            }),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => {
                ExtendToken(context);
                return lexicalState54;
            }),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                ExtendToken(context);
                return lexicalState55;
            }),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => {
                ExtendToken(context);
                return lexicalState56;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                context.MoveBack(1);
                return lexicalState0;
            })

        );
    }
}

