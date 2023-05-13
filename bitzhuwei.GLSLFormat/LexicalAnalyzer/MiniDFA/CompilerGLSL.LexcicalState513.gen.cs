using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GLSLFormat {
    partial class CompilerGLSL {
        private static readonly LexicalState lexicalState513 = new LexicalState($"{nameof(CompilerGLSL)}.LexicalStates[513]",
            new LexicalRule(
            currentChar => '0'/*'\u0030'(48)*/ <= currentChar && currentChar <= '9'/*'\u0039'(57)*/,
            context => {
                BeginToken(context, EType.@number);
                ExtendToken(context);
                return lexicalState537;
            }),
            new LexicalRule(
            currentChar => currentChar == '+'/*'\u002B'(43)*/,
            context => {
                ExtendToken(context);
                return lexicalState539;
            }),
            new LexicalRule(
            currentChar => currentChar == '='/*'\u003D'(61)*/,
            context => {
                ExtendToken(context);
                return lexicalState540;
            }),
            /* accept everything else. */
            /* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */
            new LexicalRule(
            acceptAll,
            context => {
                AcceptToken(context, EType.@Plus);
                return lexicalState0;
            })

        );
    }
}

