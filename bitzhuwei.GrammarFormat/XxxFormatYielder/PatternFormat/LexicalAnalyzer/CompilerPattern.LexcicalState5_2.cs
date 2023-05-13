using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        // got <' of <'Vt'>
        /// <summary>
        /// got &lt;' of &lt;'Vt'&gt;
        /// <para>begin scope</para>
        /// </summary>
        private static readonly LexicalState lexicalState5_2 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[5_2]",
            new LexicalRule(
            //currentChar => currentChar == '_'
            //|| ('A' <= currentChar && currentChar <= 'Z')
            //|| ('a' <= currentChar && currentChar <= 'z'),
            currentChar => !(currentChar == ' ' || char.IsControl(currentChar)),
            context => lexicalState5_3),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context => {
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index);
                token.type = EType.Error;
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"unexpected refVt starter {context.CurrentChar}"));
                context.MoveBack(1);
                return lexicalState0_0;
            }));

    }
}
