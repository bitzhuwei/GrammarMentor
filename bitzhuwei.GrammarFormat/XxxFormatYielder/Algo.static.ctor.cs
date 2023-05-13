using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    static partial class Algorithm {
        const string algorithmError = "algorithm error!";

        private static readonly CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");

        private static readonly Dictionary<char, string> punctuationDict = new Dictionary<char, string>();

        static Algorithm() {
            punctuationDict.Add('!', "Bang");
            punctuationDict.Add('"', "DoubleQuote");
            punctuationDict.Add('#', "Pound");
            punctuationDict.Add('$', "Dollar");
            punctuationDict.Add('%', "Percent");
            punctuationDict.Add('&', "And");
            punctuationDict.Add('\'', "Quote");
            punctuationDict.Add('(', "LeftParenthesis");
            punctuationDict.Add(')', "RightParenthesis");
            punctuationDict.Add('*', "Asterisk");
            punctuationDict.Add('+', "Plus");
            punctuationDict.Add(',', "Comma");
            punctuationDict.Add('-', "Dash");
            punctuationDict.Add('.', "Dot");
            punctuationDict.Add('/', "Slash");
            punctuationDict.Add(':', "Colon");
            punctuationDict.Add(';', "Semicolon");
            punctuationDict.Add('<', "LeftAngle");
            punctuationDict.Add('=', "Equal");
            punctuationDict.Add('>', "RightAngle");
            punctuationDict.Add('?', "Question");
            punctuationDict.Add('@', "At");
            punctuationDict.Add('[', "LeftBracket");
            punctuationDict.Add('\\', "BackSlash");
            punctuationDict.Add(']', "RightBracket");
            punctuationDict.Add('^', "Caret");
            punctuationDict.Add('`', "Separation"); // 间隔号
            punctuationDict.Add('{', "LeftBrace");
            punctuationDict.Add('|', "Pipe");
            punctuationDict.Add('}', "RightBrace");
            punctuationDict.Add('~', "Tilde"); // 波浪字符

            // TODO: not needed ?
            punctuationDict.Add('￥', "EndOfTokenList");
        }

    }
}
