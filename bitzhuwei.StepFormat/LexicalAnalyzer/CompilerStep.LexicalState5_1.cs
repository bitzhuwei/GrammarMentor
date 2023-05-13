using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using bitzhuwei.Compiler;

namespace bitzhuwei.StepFormat
{
    partial class CompilerStep
    {
        private static readonly LexicalState lexicalState5_1 = new LexicalState($"{nameof(CompilerStep)}.LexiStates[5_1]",
            new LexicalRule(
            currentChar => (('a' <= currentChar && currentChar <= 'z')
                || ('A' <= currentChar && currentChar <= 'Z')
                || ('0' <= currentChar && currentChar <= '9')
                || (currentChar == '_')
                || (currentChar == '-')), // for STEP and ENDSTEP only.
            context => lexicalState5_1),
            // accept everything else.
            new LexicalRule(
            // NOTE: this rule should only be put in the last position, as this is a lazy coding style!
            currentChar => true,
            context =>
            {
                var token = context.result.Last();
                string str = context.Substring(token.index, context.Cursor - token.index);
                char c = context.CurrentChar;
                if (str == keywordHEADER)
                {
                    if (c == ';') { token.type = EType.HEADER; }
                    else
                    {
                        token.type = EType.Error;
                        context.result.errorDict.Add(token, new TokenErrorInfo(token, "Missing [;]"));
                    }
                }
                else if (str == keywordENDSEC)
                {
                    if (c == ';') { token.type = EType.ENDSEC; }
                    else
                    {
                        token.type = EType.Error;
                        context.result.errorDict.Add(token, new TokenErrorInfo(token, "Missing [;]"));
                    }
                }
                else if (str == keywordDATA)
                {
                    if (c == ';') { token.type = EType.DATA; }
                    else
                    {
                        token.type = EType.Error;
                        context.result.errorDict.Add(token, new TokenErrorInfo(token, "Missing [;]"));
                    }
                }
                else if (str == keywordSCOPE)
                {
                    token.type = EType.SCOPE;
                }
                else if (str == keywordENDSCOPE)
                {
                    token.type = EType.ENDSCOPE;
                }
                else if (IsSTEP(str))
                {
                    if (c == ';') { token.type = EType.STEP; }
                    else
                    {
                        token.type = EType.Error;
                        context.result.errorDict.Add(token, new TokenErrorInfo(token, "Missing [;]"));
                    }
                }
                else if (IsENDSTEP(str))
                {
                    if (c == ';') { token.type = EType.ENDSTEP; }
                    else
                    {
                        token.type = EType.Error;
                        context.result.errorDict.Add(token, new TokenErrorInfo(token, "Missing [;]"));
                    }
                }
                else // some TYPE
                {
                    token.type = EType.TypeName;
                }

                token.value = str;
                //context.MoveCursor(-1);
                context.MoveBack(1);

                return lexicalState0;
            })
            );

        /// <summary>
        /// is END-ISO-nnn-nnn?
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static bool IsENDSTEP(string str)
        {
            if (string.IsNullOrEmpty(str)) { return false; }
            if (!str.StartsWith("END-ISO-")) { return false; }

            string[] parts = str.Split('-');
            if (parts.Length != 4) { return false; }
            //if (parts[0] != "END") { return false; }
            //if (parts[1] != "ISO") { return false; }
            int number;
            if (!int.TryParse(parts[2], out number)) { return false; }
            if (!int.TryParse(parts[3], out number)) { return false; }

            return true;
        }

        /// <summary>
        /// is ISO-nnn-nnn?
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private static bool IsSTEP(string str)
        {
            if (string.IsNullOrEmpty(str)) { return false; }
            if (!str.StartsWith("ISO-")) { return false; }

            string[] parts = str.Split('-');
            if (parts.Length != 3) { return false; }
            //if (parts[0] != "ISO") { return false; }
            int number;
            if (!int.TryParse(parts[1], out number)) { return false; }
            if (!int.TryParse(parts[2], out number)) { return false; }

            return true;
        }
    }
}
