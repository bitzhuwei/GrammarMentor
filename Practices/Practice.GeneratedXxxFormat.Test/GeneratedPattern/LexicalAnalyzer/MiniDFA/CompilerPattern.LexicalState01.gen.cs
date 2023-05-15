using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        private static readonly LexicalState lexicalState1 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[1]",
            new LexicalRule(
            currentChar => (currentChar == '$'/*'\u0024'(36)*/)
            || (currentChar == '('/*'\u0028'(40)*/)
            || (currentChar == ')'/*'\u0029'(41)*/)
            || (currentChar == '*'/*'\u002A'(42)*/)
            || (currentChar == '+'/*'\u002B'(43)*/),
            context => {
                ExtendToken(context);
                return lexicalState65;
            }),
            new LexicalRule(
            currentChar => currentChar == '-'/*'\u002D'(45)*/,
            context => {
                ExtendToken(context);
                return lexicalState66;
            }),
            new LexicalRule(
            currentChar => (currentChar == '.'/*'\u002E'(46)*/)
            || (currentChar == '/'/*'\u002F'(47)*/)
            || (currentChar == '<'/*'\u003C'(60)*/)
            || (currentChar == '>'/*'\u003E'(62)*/)
            || (currentChar == '?'/*'\u003F'(63)*/),
            context => {
                ExtendToken(context);
                return lexicalState67;
            }),
            new LexicalRule(
            currentChar => currentChar == '['/*'\u005B'(91)*/,
            context => {
                ExtendToken(context);
                return lexicalState68;
            }),
            new LexicalRule(
            currentChar => currentChar == '\\'/*'\u005C'(92)*/,
            context => {
                ExtendToken(context);
                return lexicalState69;
            }),
            new LexicalRule(
            currentChar => currentChar == ']'/*'\u005D'(93)*/,
            context => {
                ExtendToken(context);
                return lexicalState70;
            }),
            new LexicalRule(
            currentChar => currentChar == '^'/*'\u005E'(94)*/,
            context => {
                ExtendToken(context);
                return lexicalState71;
            }),
            new LexicalRule(
            currentChar => currentChar == '{'/*'\u007B'(123)*/,
            context => {
                ExtendToken(context);
                return lexicalState72;
            }),
            new LexicalRule(
            currentChar => currentChar == '|'/*'\u007C'(124)*/,
            context => {
                ExtendToken(context);
                return lexicalState73;
            }),
            new LexicalRule(
            currentChar => currentChar == '}'/*'\u007D'(125)*/,
            context => {
                ExtendToken(context);
                return lexicalState74;
            }),
            new LexicalRule(
            currentChar => currentChar == 'u'/*'\u0075'(117)*/,
            context => lexicalState6),
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

