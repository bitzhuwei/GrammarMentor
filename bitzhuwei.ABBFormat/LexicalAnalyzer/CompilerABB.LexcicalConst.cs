using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ABBFormat
{
    partial class CompilerABB
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

    }
}
