using System.Collections.Generic;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public class LL1SyntaxInfo {
        //public readonly LL1StateList stateList;
        //public readonly LRParsingTableDraft table;

        //public LL1SyntaxInfo(LL1StateList stateList, LRParsingTableDraft table)
        //{
        //    this.stateList = stateList;
        //    this.table = table;
        //}
        public readonly LL1ParsingTableDraft table;

        public LL1SyntaxInfo(LL1ParsingTableDraft table) {
            this.table = table;
        }
    }
}