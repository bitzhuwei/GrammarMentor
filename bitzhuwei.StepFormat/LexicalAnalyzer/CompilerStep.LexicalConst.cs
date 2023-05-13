using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        /// <summary>
        /// ' '
        /// </summary>
        const char space = (char)32; // ' ';
        /// <summary>
        /// '\''
        /// </summary>
        const char quot = '\'';
        /// <summary>
        /// '\t'
        /// </summary>
        const char tab = '\t';
        /// <summary>
        /// '\"'
        /// </summary>
        const char doubleQuot = '\"';

        // ISO-nnn-nnn is STEP
        //const string keywordSTEP = @"STEP";
        const string keywordHEADER = @"HEADER";
        const string keywordENDSEC = @"ENDSEC";
        const string keywordDATA = @"DATA";
        const string keywordSCOPE = @"SCOPE";
        const string keywordENDSCOPE = @"ENDSCOPE";
        // END-ISO-nnn-nnn is ENDSTEP
        //const string keywordENDSTEP = @"ENDSTEP";
    }
}
