using bitzhuwei.Compiler;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using static System.Collections.Specialized.BitVector32;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        /*
| 状态 | 'a' | 'b' | '+' |   '¥'  |
|:----:|:---:|:---:|:---:|:------:|
| Vn1  | R[2] |    |       |      |
| Vn2  |      |    | R[3]  | R[4] |  
| Vn3  |      |    | R[1]  | R[1] |  
         */
        /// <summary>
        /// get syntax parsing table in markdown format
        /// </summary>
        /// <param name="table"></param>
        /// <param name="regulations"></param>
        /// <returns></returns>
        private static string GetSyntaxParsingTableMD(LL1ParsingTableDraft table,
            VnRegulationDraft[] regulations) {
            //var nodeList = new List<string>();
            var Vts = regulations.GetVtNodes();
            //nodeList.AddRange(Vts); nodeList.Add(CompilerGrammar.EType.EndOfTokenList);
            var Vns = regulations.GetVnNodes();
            //nodeList.AddRange(Vns);
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                // head
                w.Write($"| 状态 |"); foreach (var Vt in Vts) { w.Write($" {Vt.ToMarkdown()} |"); }
                w.WriteLine();
                // separator line
                int VtCount = Vts.Length;
                w.Write("|"); for (var i = 0; i < VtCount + 1; i++) { w.Write($":---:|"); }
                w.WriteLine();
                // body
                var stateCount = Vns.Length;
                for (int stateId = 0; stateId < stateCount; stateId++) {
                    var Vn = Vns[stateId];
                    w.Write($"| {Vn} |");
                    for (int j = 0; j < VtCount; j++) {
                        var Vt = Vts[j];
                        var actions = table.GetActions(Vn, Vt);
                        if (actions == null) {
                            w.Write($"   |");
                        }
                        else {
                            foreach (var action in actions) {
                                w.Write($" R[{action.regulationId}]");
                            }
                            {
                                w.Write($" |");
                            }
                        }
                    }
                    w.WriteLine();
                }
            }

            return b.ToString();
        }

        /*
| 状态 | 'a' | 'b' | '+' |   '¥'   | A | B |
|:----:|:---:|:---:|:---:|:------:|:-:|:-:|
| 0    | S2  |     |     |        | 1 |   |
| 1    |     |     | S3  | accept |   |   |
| 2    |     |     | R[1] | R[1]  |   |   |
| 3    |     | S5  |      |       |   | 4 |
| 4    |     |     | R[0] | R[0]  |   |   |
| 5    |     |     | R[2] | R[2]  |   |   |
         */
        /// <summary>
        /// get syntax parsing table in markdown format
        /// </summary>
        /// <param name="table"></param>
        /// <param name="regulations"></param>
        /// <param name="stateCount"></param>
        /// <returns></returns>
        private static string GetSyntaxParsingTableMD(LRParsingTableDraft table,
            VnRegulationDraft[] regulations, int stateCount) {
            var nodeList = new List<string>();
            var Vts = regulations.GetVtNodes();
            nodeList.AddRange(Vts); nodeList.Add(CompilerGrammar.EType.EndOfTokenList);
            var Vns = regulations.GetVnNodes();
            nodeList.AddRange(Vns);
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                // head
                w.Write($"| 状态 |"); foreach (var node in nodeList) { w.Write($" {node.ToMarkdown()} |"); }
                w.WriteLine();
                // separator line
                int nodeCount = nodeList.Count;
                w.Write("|"); for (var i = 0; i < nodeCount + 1; i++) { w.Write($":---:|"); }
                w.WriteLine();
                // body
                for (int stateId = 0; stateId < stateCount; stateId++) {
                    w.Write($"| {stateId} |");
                    for (int j = 0; j < nodeCount; j++) {
                        var node = nodeList[j];
                        var actions = table.GetActions(stateId, node);
                        if (actions == null) {
                            w.Write($"   |");
                        }
                        else {
                            foreach (var action in actions) {
                                w.Write(' '); action.ToMermaid(w, regulations);
                            }
                            {
                                w.Write($" |");
                            }
                        }
                    }
                    w.WriteLine();
                }
            }

            return b.ToString();
        }

        class StateNodeReduction {
            public readonly int fromStateId;
            public readonly string nextNode;
            public readonly int regulationId;

            //public string GetGroupKey()
            //{
            //    return $"{fromStateId}#{regulationId}";
            //}

            //public static bool TryParse(string key, out int stateId, out int regulationId)
            //{
            //    stateId = -1; regulationId = -1;

            //    if (string.IsNullOrEmpty(key)) { return false; }

            //    var parts = key.Split('#');
            //    if (!int.TryParse(parts[0], out stateId)) { return false; }
            //    if (!int.TryParse(parts[1], out regulationId)) { return false; }

            //    return true;
            //}

            public StateNodeReduction(int stateId, string nextNode, int regulationId) {
                this.fromStateId = stateId;
                this.nextNode = nextNode;
                this.regulationId = regulationId;
            }

            public override string ToString() {
                return $"syntaxState[{fromStateId}]★{nextNode} -> R[{regulationId}]";
            }
        }

        private static void DrawConnections(LRParsingTableDraft table,
            VnRegulationDraft[] regulations, TextWriter w) {
            var list = new List<StateNodeReduction>();
            foreach (var pair in table) {
                var key = pair.Key;
                if (!LRParsingTableDraft.TryParse(key, out var fromId, out string nextNode)) {
                    throw new Exception($"wrong key {key}");
                }
                nextNode = nextNode.ToMermaid();
                foreach (var action in pair.Value) {
                    if (action is LRShiftInActionDraft) {
                        var shiftAction = action as LRShiftInActionDraft;
                        var toId = shiftAction.nextStateIndex;
                        w.Write("syntaxState"); w.Write(fromId);
                        w.Write(" --> |\""); w.Write(nextNode); w.Write("\"| ");
                        w.Write("syntaxState"); w.Write(toId);
                        w.WriteLine();
                    }
                    else if (action is LRGotoActionDraft) {
                        var gotoAction = action as LRGotoActionDraft;
                        var toId = gotoAction.GoToStateIndex;
                        w.Write("syntaxState"); w.Write(fromId);
                        w.Write(" -.-> |\""); w.Write(nextNode); w.Write("\"| ");
                        w.Write("syntaxState"); w.Write(toId);
                        w.WriteLine();
                    }
                    else if (action is LRReducitonActionDraft) {
                        ////TODO: reduction action is reduction and goto.
                        var reductionAction = action as LRReducitonActionDraft;
                        //var reductionId = reductionAction.RegulationId;
                        //w.Write("syntaxState"); w.Write(fromId);
                        //w.Write(" ==x |\""); w.Write(nextNode); w.WriteLine();
                        //w.Write($"[{reductionId}]= {regulations[reductionId]}"); w.Write("\"| ");
                        //w.Write("syntaxState"); w.Write(fromId);
                        list.Add(new StateNodeReduction(fromId, nextNode, reductionAction.regulationIndex));
                    }
                    else if (action is LRAcceptActionDraft) {
                        var acceptAction = action as LRAcceptActionDraft;
                        w.Write("syntaxState"); w.Write(fromId);
                        w.Write(" o--o |\""); w.Write(nextNode); w.Write("\"| ");
                        w.Write("syntaxState"); w.Write(fromId);
                        w.WriteLine();
                    }
                    else { throw new NotImplementedException(); }
                }
            }
            //var query = from item in list
            //            group item by item.GetGroupKey()
            //            into g
            //            select g;
            var query = from item in list
                        group item by new { item.fromStateId, item.regulationId }
                        into g
                        select g;
            foreach (var group in query) {
                //var key = group.Key; StateNodeReduction.TryParse(key, out var fromId, out var regulationId);
                var fromId = group.Key.fromStateId; var regulationId = group.Key.regulationId;
                w.Write("syntaxState"); w.Write(fromId); w.Write(" x==x |\"");
                foreach (var item in group) {
                    w.Write(item.nextNode); w.Write(' ');
                }
                w.WriteLine();
                w.Write($"R[{regulationId}]= {regulations[regulationId]}"); w.Write("\"| ");
                w.Write("syntaxState"); w.Write(fromId);
                w.WriteLine();
            }
        }

        private static string GetLR1SyntaxDiagram(LR1SyntaxInfo info, VnRegulationDraft[] regulations) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                info.stateList.ToMermaid(w, regulations);
                w.WriteLine();
                //info.lr1EdgeList.ToMermaid(w);
                DrawConnections(info.table, regulations, w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLALR1SyntaxDiagram(LALR1SyntaxInfo info, VnRegulationDraft[] regulations) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                info.stateList.ToMermaid(w, regulations);
                w.WriteLine();
                //info.lalr1EdgeList.ToMermaid(w);
                DrawConnections(info.table, regulations, w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetSLR1SyntaxDiagram(SLR1SyntaxInfo info, VnRegulationDraft[] regulations) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                info.stateList.ToMermaid(w, regulations);
                w.WriteLine();
                //info.slr1EdgeList.ToMermaid(w);
                DrawConnections(info.table, regulations, w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLR0SyntaxDiagram(LR0SyntaxInfo info, VnRegulationDraft[] regulations) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                info.stateList.ToMermaid(w, regulations);
                w.WriteLine();
                //info.lr0EdgeList.ToMermaid(w);
                DrawConnections(info.table, regulations, w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLR1EdgeList(LR1EdgeList edges) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                edges.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private string GetLALR1EdgeList(LALR1EdgeList edges) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                edges.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetSLR1EdgeList(SLR1EdgeList edges) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                edges.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLR0EdgeList(LR0EdgeList edges) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                edges.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLR1StateList(LR1StateList states) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                states.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLALR1StateList(LALR1StateList states) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                states.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetSLR1StateList(SLR1StateList states) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                states.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetLR0StateList(LR0StateList states) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                states.Print(w);
                w.WriteLine();
            }

            return b.ToString();
        }

        private static string GetFOLLOWList(Dictionary<string, FOLLOW> followDict) {
            var b = new StringBuilder();
            int index = 0;
            foreach (var item in followDict) {
                var follow = item.Value;
                b.AppendLine($"[{index++}]: {follow}");
            }

            return b.ToString();
        }

        private static string GetFIRSTList(Dictionary<string, FIRST> firstDict) {
            var b = new StringBuilder();
            int index = 0;
            foreach (var item in firstDict) {
                var first = item.Value;
                b.AppendLine($"[{index++}]: {first}");
            }

            return b.ToString();
        }
    }
}