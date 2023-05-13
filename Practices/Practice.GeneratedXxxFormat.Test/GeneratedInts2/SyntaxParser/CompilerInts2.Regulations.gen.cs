using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.Ints2Format {
    partial class CompilerInts2 {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: Ints : Ints ',' Int ;
            new Regulation(EType.Ints, EType.Ints, EType.@Comma, EType.Int), 
            // 1: Ints : Int ;
            new Regulation(EType.Ints, EType.Int), 
            // 2: Int : 'integer' ;
            new Regulation(EType.Int, EType.@integer), 

        };
    }
}
