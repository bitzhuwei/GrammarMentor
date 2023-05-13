using System.Collections.Generic;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public class LALR1SyntaxInfo {
        public readonly LALR1StateList stateList;
        public readonly LALR1EdgeList edgeList;
        public readonly LRParsingTableDraft table;

        public LALR1SyntaxInfo(LALR1StateList stateList, LALR1EdgeList edgeList, LRParsingTableDraft table) {
            this.stateList = stateList;
            this.edgeList = edgeList;
            this.table = table;
        }
    }
}