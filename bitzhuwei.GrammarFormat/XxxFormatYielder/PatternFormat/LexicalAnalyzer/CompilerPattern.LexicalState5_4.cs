using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        // got <'c' of <'Vt'>
        /// <summary>
        /// got &lt;' of &lt;'Vt'&gt;
        /// <para>begin scope</para>
        /// </summary>
        private static readonly LexicalState lexicalState5_4 = new LexicalState($"{nameof(CompilerPattern)}.LexicalStates[5_4]",
            new LexicalRule(
            currentChar => currentChar == '>',
            context => {
                var token = context.result.Last();
                token.value = context.Substring(token.index, context.Cursor - token.index + 1);
                token.type = EType.refVt;
                return lexicalState0_0;
            }),
            new LexicalRule(
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
                context.result.errorDict.Add(token, new TokenErrorInfo(token, $"Missing ending > for refVt {context.CurrentChar}"));
                context.MoveBack(1);
                return lexicalState0_0;
            }));

    }
}
