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
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: A : A '+' B ;
            new Regulation(EType.A, EType.A, EType.Plus, EType.B), 
            // 1: A : 'a' ;
            new Regulation(EType.A, EType.a), 
            // 2: B : 'b' ;
            new Regulation(EType.B, EType.b),

        };
    }
}
