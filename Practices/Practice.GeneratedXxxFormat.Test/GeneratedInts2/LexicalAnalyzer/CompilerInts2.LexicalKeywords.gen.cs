using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.Ints2Format {
    partial class CompilerInts2 {
        /// <summary>
        /// ' '
        /// </summary>
        const char space = (char)32; // ' ';
        /// <summary>
        /// '\t' = '\u0009'
        /// </summary>
        const char HorizontalTab = '\t';
        /// <summary>
        /// '\n' = '\u000A'
        /// </summary>
        const char NewLine = '\n';
        /// <summary>
        /// '\r' = '\u000D'
        /// </summary>
        const char CarriageReturn = '\r';
        /// <summary>
        /// '\''
        /// </summary>
        const char quot = '\'';
        /// <summary>
        /// '\"'
        /// </summary>
        const char doubleQuot = '\"';



        /// <summary>
        /// if <paramref name="token"/> is a keyword, assign correspond type and return true.
        /// <para>otherwise, return false.</para>
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private static bool CheckKeyword(Token token) {
            bool isKeyword;
            switch (token.value) {
            //case @emptykeyword: token.type = EType.@empty; isKeyword = true; break;

            default: isKeyword = false; break;
            }

            return isKeyword;
        }
    }
}
