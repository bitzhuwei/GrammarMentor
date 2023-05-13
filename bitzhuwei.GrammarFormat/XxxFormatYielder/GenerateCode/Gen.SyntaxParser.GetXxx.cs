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
        class LL1TableSetActionLines {
            public readonly int VnCount;
            public readonly int actionCount;
            public readonly int conflictCount;
            public readonly string actionDict_Add_List;

            public LL1TableSetActionLines(int VnCount, int actionCount, int conflictCount, string actionDict_Add_List) {
                this.VnCount = VnCount;
                this.actionCount = actionCount;
                this.conflictCount = conflictCount;
                this.actionDict_Add_List = actionDict_Add_List;
            }
        }

        private static LL1TableSetActionLines GetTableSetActionLines(LL1ParsingTableDraft table) {
            var b = new StringBuilder();
            var list = new List<LL1TableItem>();
            foreach (var item in table) {
                var key = item.Key;
                if (!LL1ParsingTableDraft.TryParse(key, out var Vn, out var Vt)) {
                    throw new Exception($"wrong key {key}");
                }
                var actionDraftList = item.Value;
                foreach (var actionDraft in actionDraftList) {
                    var tableItem = new LL1TableItem(Vn, Vt, actionDraft);
                    list.Add(tableItem);
                }
            }

            var query = from item in list
                            //orderby item.Vn ascending
                        group item by item.Vn into g
                        select g;
            int index = 0, VnCount = 0;
            const int tab = 4 * 3;
            const int tab2 = 4 * 4;
            var conflictCount = 0;
            foreach (var group in query) {
                b.Tab(tab); b.Append("{"); b.AppendLine($" // table[{VnCount++}]");
                b.Tab(tab2); b.Append($"var line = new Dictionary<string, {nameof(Regulation)}>();"); b.AppendLine();
                var conflictDict = new Dictionary<string, int>();
                foreach (var tableItem in group) {
                    if (!conflictDict.TryGetValue(tableItem.Vt, out var count)) {
                        conflictDict.Add(tableItem.Vt, 1);
                    }
                    else {
                        conflictDict[tableItem.Vt] = count + 1;
                        conflictCount++;
                    }
                }
                foreach (var item in conflictDict) {
                    var repeated = item.Value;
                    if (repeated > 1) {
                        var Vt = item.Key.Vt2Name();
                        b.Tab(tab2); b.AppendLine($"//{Vt} repeated {repeated} times");
                    }
                }
                foreach (var tableItem in group) {
                    b.Tab(tab2); b.AppendLine($"{tableItem}/*Actions[{index++}]*/");
                }
                b.Tab(tab2); b.Append($"table.Add(EType.{group.Key}, line);"); b.AppendLine();
                b.Tab(tab); b.Append("}"); b.AppendLine();
            }

            var actionDict_Add_List = b.ToString();
            var result = new LL1TableSetActionLines(VnCount, index, conflictCount, actionDict_Add_List);
            return result;
        }

        class LL1TableItem {
            public readonly string Vn;
            public readonly string Vt;
            public readonly LL1ParsingActionDraft actionDraft;
            public LL1TableItem(string Vn, string Vt, LL1ParsingActionDraft actionDraft) {
                this.Vn = Vn;
                this.Vt = Vt;
                this.actionDraft = actionDraft;
            }

            public override string ToString() {
                string nodeName = Vt.Vt2Name();
                var p = actionDraft.ActionParam();
                var paramName = $"regulations[{p}]";

                //line.Add(EType.w, regulations[0]);
                return $"line.Add(EType.{nodeName}, {paramName});";
            }
        }
        //
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

        private static LRTableSetActionLines GetTableSetActionLines(LRParsingTableDraft table) {
            var b = new StringBuilder();
            var list = new List<LRTableItem>();
            foreach (var item in table) {
                var key = item.Key;
                if (!LRParsingTableDraft.TryParse(key, out var stateId, out var nextNode)) {
                    throw new Exception($"wrong key {key}");
                }
                var actionDraftList = item.Value;
                foreach (var actionDraft in actionDraftList) {
                    var tableItem = new LRTableItem(stateId, nextNode, actionDraft);
                    list.Add(tableItem);
                }
            }

            var query = from item in list
                        orderby item.stateId ascending
                        group item by item.stateId into g
                        select g;
            int index = 0, syntaxStateCount = 0;
            const int tab = 4 * 3;
            var conflictCount = 0;
            foreach (var group in query) {
                b.Tab(tab); b.AppendLine($"// list[{syntaxStateCount++}]");
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
                        b.Tab(tab); b.AppendLine($"//{nextNode} repeated {repeated} times");
                    }
                }
                foreach (var tableItem in group) {
                    b.Tab(tab); b.AppendLine($"{tableItem}/*Actions[{index++}]*/");
                }
            }

            var actionDict_Add_List = b.ToString();
            var result = new LRTableSetActionLines(syntaxStateCount, index, conflictCount, actionDict_Add_List);
            return result;
        }

        class LRTableItem {
            public readonly int stateId;
            public readonly string nextNode;
            public readonly LRParsingActionDraft actionDraft;
            public LRTableItem(int stateId, string nextNode, LRParsingActionDraft actionDraft) {
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
                else { throw new Exception("This should never happen!"); }

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