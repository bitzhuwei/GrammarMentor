using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PatternFormat {
    partial class CompilerPattern {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: Pattern : PreRegex Regex PostRegex ;
            new Regulation(EType.Pattern, EType.PreRegex, EType.Regex, EType.PostRegex), 
            // 1: PreRegex : 'refVt' ;
            new Regulation(EType.PreRegex, EType.refVt), 
            // 2: PreRegex : ;
            new Regulation(EType.PreRegex), 
            // 3: PostRegex : '/' Regex ;
            new Regulation(EType.PostRegex, EType.Slash, EType.Regex), 
            // 4: PostRegex : ;
            new Regulation(EType.PostRegex), 
            // 5: Regex : Regex '|' Bunch ;
            new Regulation(EType.Regex, EType.Regex, EType.Pipe, EType.Bunch), 
            // 6: Regex : Bunch ;
            new Regulation(EType.Regex, EType.Bunch), 
            // 7: Bunch : Bunch Unit ;
            new Regulation(EType.Bunch, EType.Bunch, EType.Unit), 
            // 8: Bunch : Unit ;
            new Regulation(EType.Bunch, EType.Unit), 
            // 9: Unit : 'char' Repeat ;
            new Regulation(EType.Unit, EType.char_, EType.Repeat), 
            // 10: Unit : '.' Repeat ;
            new Regulation(EType.Unit, EType.Dot, EType.Repeat), 
            // 11: Unit : 'scope' Repeat ;
            new Regulation(EType.Unit, EType.scope, EType.Repeat), 
            // 12: Unit : '(' Regex ')' Repeat ;
            new Regulation(EType.Unit, EType.LeftParenthesis, EType.Regex, EType.RightParenthesis, EType.Repeat), 
            // 13: Repeat : '?' ;
            new Regulation(EType.Repeat, EType.Question), 
            // 14: Repeat : '+' ;
            new Regulation(EType.Repeat, EType.Plus), 
            // 15: Repeat : '*' ;
            new Regulation(EType.Repeat, EType.Asterisk), 
            // 16: Repeat : '{' 'min' UpperBound '}' ;
            new Regulation(EType.Repeat, EType.LeftBrace, EType.min, EType.UpperBound, EType.RightBrace), 
            // 17: Repeat : ;
            new Regulation(EType.Repeat), 
            // 18: UpperBound : ',' 'max' ;
            new Regulation(EType.UpperBound, EType.Comma, EType.max), 
            // 19: UpperBound : ',' ;
            new Regulation(EType.UpperBound, EType.Comma), 
            // 20: UpperBound : ;
            new Regulation(EType.UpperBound), 

        };
    }
}
