using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class CompilerGrammar {
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        public static IReadOnlyList<Regulation> Regulations => regulations;
        /// <summary>
        /// (regulations + VtRegexes) = grammar for this compiler.
        /// </summary>
        private static readonly Regulation[] regulations = new Regulation[] {
            // 0: StatementList : StatementList Statement ;
            new Regulation(EType.StatementList, EType.StatementList, EType.Statement), 
            // 1: StatementList : Statement ;
            new Regulation(EType.StatementList, EType.Statement), 
            // 2: Statement : SyntaxProduction ;
            new Regulation(EType.Statement, EType.SyntaxProduction), 
            // 3: Statement : LexiProduction ;
            new Regulation(EType.Statement, EType.LexiProduction), 
            // 4: SyntaxProduction : 'Vn' ':' CandidateList ';' ;
            new Regulation(EType.SyntaxProduction, EType.@Vn, EType.@Colon, EType.CandidateList, EType.@Semicolon), 
            // 5: CandidateList : CandidateList '|' Candidate ;
            new Regulation(EType.CandidateList, EType.CandidateList, EType.@Pipe, EType.Candidate), 
            // 6: CandidateList : Candidate ;
            new Regulation(EType.CandidateList, EType.Candidate), 
            // 7: Candidate : VList ;
            new Regulation(EType.Candidate, EType.VList), 
            // 8: Candidate : 'empty' ;
            new Regulation(EType.Candidate, EType.@empty), 
            // 9: VList : VList V ;
            new Regulation(EType.VList, EType.VList, EType.V), 
            // 10: VList : V ;
            new Regulation(EType.VList, EType.V), 
            // 11: V : 'Vn' ;
            new Regulation(EType.V, EType.@Vn), 
            // 12: V : 'Vt' ;
            new Regulation(EType.V, EType.@Vt), 
            // 13: LexiProduction : 'Vt' ':' 'pattern' ';' ;
            new Regulation(EType.LexiProduction, EType.@Vt, EType.@Colon, EType.@pattern, EType.@Semicolon), 

        };
    }
}
