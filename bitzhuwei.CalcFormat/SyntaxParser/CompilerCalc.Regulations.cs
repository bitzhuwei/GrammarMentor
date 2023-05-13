using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat
{
    partial class CompilerCalc
    {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: Additive : Additive '+' Multiplicative ;
            new Regulation(EType.Additive, EType.Additive, EType.Plus, EType.Multiplicative), 
            // 1: Additive : Additive '-' Multiplicative ;
            new Regulation(EType.Additive, EType.Additive, EType.Dash, EType.Multiplicative), 
            // 2: Additive : Multiplicative ;
            new Regulation(EType.Additive, EType.Multiplicative), 
            // 3: Multiplicative : Multiplicative '*' Primary ;
            new Regulation(EType.Multiplicative, EType.Multiplicative, EType.Asterisk, EType.Primary), 
            // 4: Multiplicative : Multiplicative '/' Primary ;
            new Regulation(EType.Multiplicative, EType.Multiplicative, EType.Slash, EType.Primary), 
            // 5: Multiplicative : Primary ;
            new Regulation(EType.Multiplicative, EType.Primary), 
            // 6: Primary : '(' Additive ')' ;
            new Regulation(EType.Primary, EType.LeftParenthesis, EType.Additive, EType.RightParenthesis), 
            // 7: Primary : 'number' ;
            new Regulation(EType.Primary, EType.number),

        };
    }
}
