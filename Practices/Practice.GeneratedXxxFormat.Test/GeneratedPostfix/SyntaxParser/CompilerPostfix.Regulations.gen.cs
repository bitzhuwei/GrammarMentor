using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.PostfixFormat {
    partial class CompilerPostfix {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: Items : Items Item ;
            new Regulation(EType.Items, EType.Items, EType.Item), 
            // 1: Items : Item ;
            new Regulation(EType.Items, EType.Item), 
            // 2: Item : 'entityId' '=' 'refEntity' ;
            new Regulation(EType.Item, EType.@entityId, EType.@Equal, EType.@refEntity), 

        };
    }
}
