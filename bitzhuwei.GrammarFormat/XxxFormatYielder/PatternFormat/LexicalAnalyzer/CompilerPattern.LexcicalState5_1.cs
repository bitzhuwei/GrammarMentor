using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        // got < of <'Vt'>
        /// <summary>
        /// got &lt; of &lt;'Vt'&gt;
        /// <para>begin scope</para>
        /// </summary>
        private static readonly LexicalState lexicalState5_1 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[5_1]",
            new LexicalRule(
            currentChar => currentChar == '\'',
            context => lexicalState5_2),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = context.result.Last();
                token.type = EType.char_;
                token.value = context.Substring(token.index, context.Cursor - token.index);
                context.MoveBack(1);
                return lexicalState0_0;
            }));

    }
}
