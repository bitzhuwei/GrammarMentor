using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        class LRTableSetActionLines {
            public readonly int syntaxStateCount;
            public readonly int actionCount;
            public readonly int conflictCount;
            public readonly string actionDict_Add_List;

            public LRTableSetActionLines(int syntaxStateCount, int actionCount, int conflictCount, string actionDict_Add_List) {
                this.syntaxStateCount = syntaxStateCount;
                this.actionCount = actionCount;
                this.conflictCount = conflictCount;
                this.actionDict_Add_List = actionDict_Add_List;
            }
        }

        private static LRTableSetActionLines GetTableSetActionLines(LR0SyntaxInfo syntaxInfo, VnRegulationDraft[] regulations) {
            var list = new List<LRTableItemDraft>();
            var table = syntaxInfo.table;
            foreach (var item in table) {
                var key = item.Key;
                if (!LRParsingTableDraft.TryParse(key, out var stateId, out var nextNode)) {
                    throw new Exception($"wrong key {key}");
                }
                var actionDraftList = item.Value;
                foreach (var actionDraft in actionDraftList) {
                    var tableItem = new LRTableItemDraft(stateId, nextNode, actionDraft);
                    list.Add(tableItem);
                }
            }

            var query = from item in list
                        orderby item.stateId ascending
                        group item by item.stateId into g
                        select g;
            int actionIndex = 0, syntaxStateIndex = 0;
            const int tab = 4 * 3;
            var conflictCount = 0;
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                foreach (var group in query) {
                    syntaxStateIndex = group.Key;
                    var state = syntaxInfo.stateList.States[syntaxStateIndex];
                    w.PrintLine(tab, $"// syntaxStates[{syntaxStateIndex}]:");
                    foreach (var item in state.Items) {
                        w.Print(tab, "// "); item.Print(w, regulations); w.WriteLine();
                    }
                    var conflictDict = new Dictionary<string, int>();
                    foreach (var tableItem in group) {
                        if (!conflictDict.TryGetValue(tableItem.nextNode, out var count)) {
                            conflictDict.Add(tableItem.nextNode, 1);
                        }
                        else {
                            conflictDict[tableItem.nextNode] = count + 1;
                            conflictCount++;
                        }
                    }
                    foreach (var item in conflictDict) {
                        var repeated = item.Value;
                        if (repeated > 1) {
                            var nextNode = item.Key; if (nextNode.IsVt()) { nextNode = nextNode.Vt2Name(); }
                            w.PrintLine(tab, $"//{nextNode} repeated {repeated} times");
                        }
                    }
                    foreach (var tableItem in group) {
                        w.PrintLine(tab, $"{tableItem}/*Actions[{actionIndex++}]*/");
                    }
                }
            }
            var actionDict_Add_List = b.ToString();
            var syntaxStateCount = syntaxStateIndex + 1;
            var result = new LRTableSetActionLines(syntaxStateCount, actionIndex, conflictCount, actionDict_Add_List);
            return result;
        }

        private static LRTableSetActionLines GetTableSetActionLines(SLR1SyntaxInfo syntaxInfo, VnRegulationDraft[] regulations) {
            var list = new List<LRTableItemDraft>();
            var table = syntaxInfo.table;
            foreach (var item in table) {
                var key = item.Key;
                if (!LRParsingTableDraft.TryParse(key, out var stateId, out var nextNode)) {
                    throw new Exception($"wrong key {key}");
                }
                var actionDraftList = item.Value;
                foreach (var actionDraft in actionDraftList) {
                    var tableItem = new LRTableItemDraft(stateId, nextNode, actionDraft);
                    list.Add(tableItem);
                }
            }

            var query = from item in list
                        orderby item.stateId ascending
                        group item by item.stateId into g
                        select g;
            int actionIndex = 0, syntaxStateIndex = 0;
            const int tab = 4 * 3;
            var conflictCount = 0;
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                foreach (var group in query) {
                    syntaxStateIndex = group.Key;
                    var state = syntaxInfo.stateList.States[syntaxStateIndex];
                    w.PrintLine(tab, $"// syntaxStates[{syntaxStateIndex}]:");
                    foreach (var item in state.Items) {
                        w.Print(tab, "// "); item.Print(w, regulations); w.WriteLine();
                    }
                    var conflictDict = new Dictionary<string, int>();
                    foreach (var tableItem in group) {
                        if (!conflictDict.TryGetValue(tableItem.nextNode, out var count)) {
                            conflictDict.Add(tableItem.nextNode, 1);
                        }
                        else {
                            conflictDict[tableItem.nextNode] = count + 1;
                            conflictCount++;
                        }
                    }
                    foreach (var item in conflictDict) {
                        var repeated = item.Value;
                        if (repeated > 1) {
                            var nextNode = item.Key; if (nextNode.IsVt()) { nextNode = nextNode.Vt2Name(); }
                            w.PrintLine(tab, $"//{nextNode} repeated {repeated} times");
                        }
                    }
                    foreach (var tableItem in group) {
                        w.PrintLine(tab, $"{tableItem}/*Actions[{actionIndex++}]*/");
                    }
                }
            }
            var actionDict_Add_List = b.ToString();
            var syntaxStateCount = syntaxStateIndex + 1;
            var result = new LRTableSetActionLines(syntaxStateCount, actionIndex, conflictCount, actionDict_Add_List);
            return result;
        }

        private static LRTableSetActionLines GetTableSetActionLines(LALR1SyntaxInfo syntaxInfo, VnRegulationDraft[] regulations) {
            var list = new List<LRTableItemDraft>();
            var table = syntaxInfo.table;
            foreach (var item in table) {
                var key = item.Key;
                if (!LRParsingTableDraft.TryParse(key, out var stateId, out var nextNode)) {
                    throw new Exception($"wrong key {key}");
                }
                var actionDraftList = item.Value;
                foreach (var actionDraft in actionDraftList) {
                    var tableItem = new LRTableItemDraft(stateId, nextNode, actionDraft);
                    list.Add(tableItem);
                }
            }

            var query = from item in list
                        orderby item.stateId ascending
                        group item by item.stateId into g
                        select g;
            int actionIndex = 0, syntaxStateIndex = 0;
            const int tab = 4 * 3;
            var conflictCount = 0;
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                foreach (var group in query) {
                    syntaxStateIndex = group.Key;
                    {
                        var state = syntaxInfo.stateList.States[syntaxStateIndex];
                        w.PrintLine(tab, $"// syntaxStates[{syntaxStateIndex}]:");
                        var query2 = from item in state.Items
                                     group item by new { item.VnRegulation, item.dotPosition } into g
                                     select g;
                        var groupCount = query.Count(); var index = 0;
                        foreach (var group2 in query2) {
                            // A : X . 'y' Z ; 
                            var regulation = group2.Key.VnRegulation;
                            var dotPosition = group2.Key.dotPosition;
                            w.Print(tab, $"// ");
                            if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, regulation)}] "); }
                            w.Write(regulation.left); w.Write(" : ");
                            for (int i = 0; i < regulation.Right.Count; i++) {
                                if (i == dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                                string/*Node.type*/ V = regulation.Right[i];
                                w.Write(V); w.Write(' ');
                            }
                            if (dotPosition == regulation.Right.Count) { w.Write(Utility.dot); w.Write(' '); }
                            w.Write("; ");
                            // 'a' 'b' ...
                            foreach (var item in group2) {
                                w.Write(item.lookAhead); w.Write(' ');
                            }

                            if (index++ + 1 < groupCount) {
                                w.WriteLine();
                            }
                        }
                    }
                    var conflictDict = new Dictionary<string, int>();
                    foreach (var tableItem in group) {
                        if (!conflictDict.TryGetValue(tableItem.nextNode, out var count)) {
                            conflictDict.Add(tableItem.nextNode, 1);
                        }
                        else {
                            conflictDict[tableItem.nextNode] = count + 1;
                            conflictCount++;
                        }
                    }
                    foreach (var item in conflictDict) {
                        var repeated = item.Value;
                        if (repeated > 1) {
                            var nextNode = item.Key; if (nextNode.IsVt()) { nextNode = nextNode.Vt2Name(); }
                            w.PrintLine(tab, $"//{nextNode} repeated {repeated} times");
                        }
                    }
                    foreach (var tableItem in group) {
                        w.PrintLine(tab, $"{tableItem}/*Actions[{actionIndex++}]*/");
                    }
                }
            }
            var actionDict_Add_List = b.ToString();
            var syntaxStateCount = syntaxStateIndex + 1;
            var result = new LRTableSetActionLines(syntaxStateCount, actionIndex, conflictCount, actionDict_Add_List);
            return result;
        }

        private static LRTableSetActionLines GetTableSetActionLines(LR1SyntaxInfo syntaxInfo, VnRegulationDraft[] regulations) {
            var list = new List<LRTableItemDraft>();
            var table = syntaxInfo.table;
            foreach (var item in table) {
                var key = item.Key;
                if (!LRParsingTableDraft.TryParse(key, out var stateId, out var nextNode)) {
                    throw new Exception($"wrong key {key}");
                }
                var actionDraftList = item.Value;
                foreach (var actionDraft in actionDraftList) {
                    var tableItem = new LRTableItemDraft(stateId, nextNode, actionDraft);
                    list.Add(tableItem);
                }
            }

            var query = from item in list
                        orderby item.stateId ascending
                        group item by item.stateId into g
                        select g;
            int actionIndex = 0, syntaxStateIndex = 0;
            const int tab = 4 * 3;
            var conflictCount = 0;
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                foreach (var group in query) {
                    syntaxStateIndex = group.Key;
                    {
                        var state = syntaxInfo.stateList.States[syntaxStateIndex];
                        w.PrintLine(tab, $"// syntaxStates[{syntaxStateIndex}]:");
                        var query2 = from item in state.Items
                                     group item by new { item.VnRegulation, item.dotPosition } into g
                                     select g;
                        var groupCount = query.Count(); var index = 0;
                        foreach (var group2 in query2) {
                            // A : X . 'y' Z ; 
                            var regulation = group2.Key.VnRegulation;
                            var dotPosition = group2.Key.dotPosition;
                            w.Print(tab, $"// ");
                            if (regulations != null) { w.Write($"[{Array.IndexOf(regulations, regulation)}] "); }
                            w.Write(regulation.left); w.Write(" : ");
                            for (int i = 0; i < regulation.Right.Count; i++) {
                                if (i == dotPosition) { w.Write(Utility.dot); w.Write(' '); }

                                string/*Node.type*/ V = regulation.Right[i];
                                w.Write(V); w.Write(' ');
                            }
                            if (dotPosition == regulation.Right.Count) { w.Write(Utility.dot); w.Write(' '); }
                            w.Write("; ");
                            // 'a' 'b' ...
                            foreach (var item in group2) {
                                w.Write(item.lookAhead); w.Write(' ');
                            }

                            if (index++ + 1 < groupCount) {
                                w.WriteLine();
                            }
                        }
                    }
                    var conflictDict = new Dictionary<string, int>();
                    foreach (var tableItem in group) {
                        if (!conflictDict.TryGetValue(tableItem.nextNode, out var count)) {
                            conflictDict.Add(tableItem.nextNode, 1);
                        }
                        else {
                            conflictDict[tableItem.nextNode] = count + 1;
                            conflictCount++;
                        }
                    }
                    foreach (var item in conflictDict) {
                        var repeated = item.Value;
                        if (repeated > 1) {
                            var nextNode = item.Key; if (nextNode.IsVt()) { nextNode = nextNode.Vt2Name(); }
                            w.PrintLine(tab, $"//{nextNode} repeated {repeated} times");
                        }
                    }
                    foreach (var tableItem in group) {
                        w.PrintLine(tab, $"{tableItem}/*Actions[{actionIndex++}]*/");
                    }
                }
            }
            var actionDict_Add_List = b.ToString();
            var syntaxStateCount = syntaxStateIndex + 1;
            var result = new LRTableSetActionLines(syntaxStateCount, actionIndex, conflictCount, actionDict_Add_List);
            return result;
        }

        //private static LRTableSetActionLines GetTableSetActionLines(LRParsingTableDraft table) {
        //    var b = new StringBuilder();
        //    var list = new List<LRTableItemDraft>();
        //    foreach (var item in table) {
        //        var key = item.Key;
        //        if (!LRParsingTableDraft.TryParse(key, out var stateId, out var nextNode)) {
        //            throw new Exception($"wrong key {key}");
        //        }
        //        var actionDraftList = item.Value;
        //        foreach (var actionDraft in actionDraftList) {
        //            var tableItem = new LRTableItemDraft(stateId, nextNode, actionDraft);
        //            list.Add(tableItem);
        //        }
        //    }

        //    var query = from item in list
        //                orderby item.stateId ascending
        //                group item by item.stateId into g
        //                select g;
        //    int index = 0, syntaxStateCount = 0;
        //    const int tab = 4 * 3;
        //    var conflictCount = 0;
        //    foreach (var group in query) {
        //        b.Tab(tab); b.AppendLine($"// list[{syntaxStateCount++}]");

        //        var conflictDict = new Dictionary<string, int>();
        //        foreach (var tableItem in group) {
        //            if (!conflictDict.TryGetValue(tableItem.nextNode, out var count)) {
        //                conflictDict.Add(tableItem.nextNode, 1);
        //            }
        //            else {
        //                conflictDict[tableItem.nextNode] = count + 1;
        //                conflictCount++;
        //            }
        //        }
        //        foreach (var item in conflictDict) {
        //            var repeated = item.Value;
        //            if (repeated > 1) {
        //                var nextNode = item.Key; if (nextNode.IsVt()) { nextNode = nextNode.Vt2Name(); }
        //                b.Tab(tab); b.AppendLine($"//{nextNode} repeated {repeated} times");
        //            }
        //        }
        //        foreach (var tableItem in group) {
        //            b.Tab(tab); b.AppendLine($"{tableItem}/*Actions[{index++}]*/");
        //        }
        //    }

        //    var actionDict_Add_List = b.ToString();
        //    var result = new LRTableSetActionLines(syntaxStateCount, index, conflictCount, actionDict_Add_List);
        //    return result;
        //}

        class LRTableItemDraft {
            public readonly int stateId;
            public readonly string nextNode;
            public readonly LRParsingActionDraft actionDraft;
            public LRTableItemDraft(int stateId, string nextNode, LRParsingActionDraft actionDraft) {
                this.stateId = stateId;
                this.nextNode = nextNode;
                this.actionDraft = actionDraft;
            }

            public override string ToString() {
                string nodeName;
                if (nextNode.IsVt()) { nodeName = nextNode.Vt2Name(); }
                else { nodeName = nextNode; }
                string actionType, paramName;
                if (actionDraft is LRShiftInActionDraft) {
                    actionType = nameof(LRShiftInAction);
                    var p = actionDraft.ActionParam();
                    paramName = $"syntaxStates[{p}]";
                }
                else if (actionDraft is LRReducitonActionDraft) {
                    actionType = nameof(LRReducitonAction);
                    var p = actionDraft.ActionParam();
                    paramName = $"regulations[{p}]";
                }
                else if (actionDraft is LRGotoActionDraft) {
                    actionType = nameof(LRGotoAction);
                    var p = actionDraft.ActionParam();
                    paramName = $"syntaxStates[{p}]";
                }
                else if (actionDraft is LRAcceptActionDraft) {
                    actionType = nameof(LRAcceptAction);
                    //var p = actionDraft.ActionParam();
                    paramName = $"/*no param*/";
                }
                else { throw new NotImplementedException(); }

                return $"list[{stateId}].actionDict.Add(EType.{nodeName}, new {actionType}({paramName}));";
            }
        }

        private static string GetnewRegulations(VnRegulationDraft[] regulations) {
            const int tab = 4 * 3;
            var b = new StringBuilder();
            for (int i = 0; i < regulations.Length; i++) {
                var regulation = regulations[i];
                b.Tab(tab); b.AppendLine($"// {i}: {regulation}");
                b.Tab(tab);
                b.Append($"new Regulation(EType.{regulation.left}");
                int count = regulation.Right.Count;
                for (int j = 0; j < count; j++) {
                    var V = regulation.Right[j];
                    if (V == CompilerGrammar.keywordEmpty) {
                        b.Append($"\"{V}\", ");
                        throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(VnRegulationDraft.Right)}");
                    }
                    else if (V.IsVt()) {
                        var name = V.Vt2Name();
                        b.Append($", EType.{name}");
                    }
                    else // Vn
                    {
                        b.Append($", EType.{V}");
                    }
                }
                b.AppendLine("), ");
            }

            return b.ToString();
        }
    }
}