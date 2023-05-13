using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SABFormat {
    partial class CompilerSAB {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: S : A 'a' 's' ;
            new Regulation(EType.S, EType.A, EType.@a, EType.@s), 
            // 1: S : B 'b' 's' ;
            new Regulation(EType.S, EType.B, EType.@b, EType.@s), 
            // 2: S : 'd' ;
            new Regulation(EType.S, EType.@d), 
            // 3: A : 'a' ;
            new Regulation(EType.A, EType.@a), 
            // 4: B : 'c' ;
            new Regulation(EType.B, EType.@c), 
            // 5: B : ;
            new Regulation(EType.B), 

        };
    }
}
