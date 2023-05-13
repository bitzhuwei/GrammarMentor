using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState2_1 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[2_1]",
            new LexicalRule(
            currentChar => currentChar == quot,
            context => lexicalState2_2),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => lexicalState2_1)
            );

    }
}
