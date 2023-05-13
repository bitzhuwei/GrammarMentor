using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    partial class CompilerScope {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: Scope : '[' 'firstItem1' RangeItems ']' ;
            new Regulation(EType.Scope, EType.@LeftBracket, EType.@firstItem1, EType.RangeItems, EType.@RightBracket), 
            // 1: Scope : '[^' 'firstItem2' RangeItems ']' ;
            new Regulation(EType.Scope, EType.@LeftBracketCaret, EType.@firstItem2, EType.RangeItems, EType.@RightBracket), 
            // 2: Scope : '[' 'firstItem1' ']' ;
            new Regulation(EType.Scope, EType.@LeftBracket, EType.@firstItem1, EType.@RightBracket), 
            // 3: Scope : '[^' 'firstItem2' ']' ;
            new Regulation(EType.Scope, EType.@LeftBracketCaret, EType.@firstItem2, EType.@RightBracket), 
            // 4: RangeItems : RangeItems RangeItem ;
            new Regulation(EType.RangeItems, EType.RangeItems, EType.RangeItem), 
            // 5: RangeItems : RangeItem ;
            new Regulation(EType.RangeItems, EType.RangeItem), 
            // 6: RangeItem : 'char' ;
            new Regulation(EType.RangeItem, EType.@char), 

        };
    }
}
