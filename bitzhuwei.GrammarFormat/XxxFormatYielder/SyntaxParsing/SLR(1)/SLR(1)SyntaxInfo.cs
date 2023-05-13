using System.Collections.Generic;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public class SLR1SyntaxInfo {
        public readonly SLR1StateList stateList;
        public readonly SLR1EdgeList edgeList;
        public readonly LRParsingTableDraft table;

        public SLR1SyntaxInfo(SLR1StateList stateList, SLR1EdgeList edgeList, LRParsingTableDraft table) {
            this.stateList = stateList;
            this.edgeList = edgeList;
            this.table = table;
        }
    }
}