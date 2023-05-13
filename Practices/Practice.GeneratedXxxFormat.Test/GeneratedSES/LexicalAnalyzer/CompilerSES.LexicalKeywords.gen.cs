using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
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
        /// s
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @skeyword = "s";
        /// <summary>
        /// t
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @tkeyword = "t";
        /// <summary>
        /// g
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @gkeyword = "g";
        /// <summary>
        /// w
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @wkeyword = "w";
        /// <summary>
        /// e
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @ekeyword = "e";
        /// <summary>
        /// d
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// <para>Partly solved(2023年5月3日21:37:07).</para>
        /// </summary>
        public const string @dkeyword = "d";


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
            case @skeyword: token.type = EType.@s; isKeyword = true; break;
            case @tkeyword: token.type = EType.@t; isKeyword = true; break;
            case @gkeyword: token.type = EType.@g; isKeyword = true; break;
            case @wkeyword: token.type = EType.@w; isKeyword = true; break;
            case @ekeyword: token.type = EType.@e; isKeyword = true; break;
            case @dkeyword: token.type = EType.@d; isKeyword = true; break;

            default: isKeyword = false; break;
            }

            return isKeyword;
        }
    }
}
