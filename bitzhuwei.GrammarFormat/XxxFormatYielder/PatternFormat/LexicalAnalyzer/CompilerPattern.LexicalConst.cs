using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat
{
    partial class CompilerPattern
    {
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
        /// /
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordSlash = "/";
        /// <summary>
        /// |
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordPipe = "|";
        /// <summary>
        /// char
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordchar_ = "char";
        /// <summary>
        /// (
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordLeftParenthesis = "(";
        /// <summary>
        /// )
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordRightParenthesis = ")";
        /// <summary>
        /// ?
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordQuestion = "?";
        /// <summary>
        /// +
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordPlus = "+";
        /// <summary>
        /// *
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordAsterisk = "*";
        /// <summary>
        /// [
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordLeftBracket = "[";
        /// <summary>
        /// ]
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordRightBracket = "]";
        /// <summary>
        /// ^
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordCaret = "^";
        /// <summary>
        /// char_char
        /// <para>This may not be a keyword in this grammar. It's impossible to tell for now,</para>
        /// <para>because it requires regular exprssion parsing.</para>
        /// <para>I will get this done later(2023年4月3日16:03:41).</para>
        /// </summary>
        public const string keywordchar_char = "char_char";

    }
}
