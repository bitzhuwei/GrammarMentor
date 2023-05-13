using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.SESFormat {
    partial class CompilerSES {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: S : N V N ;
            new Regulation(EType.S, EType.N, EType.V, EType.N), 
            // 1: N : 's' ;
            new Regulation(EType.N, EType.@s), 
            // 2: N : 't' ;
            new Regulation(EType.N, EType.@t), 
            // 3: N : 'g' ;
            new Regulation(EType.N, EType.@g), 
            // 4: N : 'w' ;
            new Regulation(EType.N, EType.@w), 
            // 5: V : 'e' ;
            new Regulation(EType.V, EType.@e), 
            // 6: V : 'd' ;
            new Regulation(EType.V, EType.@d), 

        };
    }
}
