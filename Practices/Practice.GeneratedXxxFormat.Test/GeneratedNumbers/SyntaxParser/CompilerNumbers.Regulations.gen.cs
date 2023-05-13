using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.NumbersFormat {
    partial class CompilerNumbers {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: Numbers : Numbers Number ;
            new Regulation(EType.Numbers, EType.Numbers, EType.Number), 
            // 1: Numbers : Number ;
            new Regulation(EType.Numbers, EType.Number), 
            // 2: Number : 'integer' ;
            new Regulation(EType.Number, EType.@integer), 
            // 3: Number : 'float' ;
            new Regulation(EType.Number, EType.@float), 

        };
    }
}
