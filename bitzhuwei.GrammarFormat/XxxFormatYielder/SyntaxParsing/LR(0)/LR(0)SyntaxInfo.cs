using System.Collections.Generic;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public class LR0SyntaxInfo {
        public readonly LR0StateList stateList;
        public readonly LR0EdgeList edgeList;
        public readonly LRParsingTableDraft table;

        public LR0SyntaxInfo(LR0StateList stateList, LR0EdgeList edgeList, LRParsingTableDraft table) {
            this.stateList = stateList;
            this.edgeList = edgeList;
            this.table = table;
        }
    }
}