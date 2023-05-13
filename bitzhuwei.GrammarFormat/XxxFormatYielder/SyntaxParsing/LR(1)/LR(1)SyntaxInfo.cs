using System.Collections.Generic;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public class LR1SyntaxInfo {
        public readonly LR1StateList stateList;
        public readonly LR1EdgeList edgeList;
        public readonly LRParsingTableDraft table;

        public LR1SyntaxInfo(LR1StateList stateList, LR1EdgeList edgeList, LRParsingTableDraft table) {
            this.stateList = stateList;
            this.edgeList = edgeList;
            this.table = table;
        }
    }
}