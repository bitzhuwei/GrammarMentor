using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        private static readonly LexicalState lexicalState1_2 = new LexicalState($"{nameof(CompilerGrammar)}.LexiStates[1_2]",
            new LexicalRule(
            currentChar => currentChar == '*',
            context => lexicalState1_3),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState1_2)
            );

    }
}
