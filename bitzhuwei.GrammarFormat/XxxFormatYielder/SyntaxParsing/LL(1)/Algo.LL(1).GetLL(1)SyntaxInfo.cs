using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        // 用LL(1)分析法得到分析表
        /// <summary>
        /// get <see cref="LL1ParsingTableDraft"/> via LL(1) parsing.
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="eFOLLOWDict"></param>
        /// <param name="eFIRSTDict"></param>
        /// <returns></returns>
        public static LL1SyntaxInfo GetLL1SyntaxInfo(this VnRegulationDraft[] regulations,
            VnRegulationDraft[] eRegulations,
            Dictionary<string, FOLLOW> eFOLLOWDict, Dictionary<string, FIRST> eFIRSTDict) {
            var regCount = regulations.Length;
            var table = new LL1ParsingTableDraft();
            for (int regulationId = 0; regulationId < regCount; regulationId++) {
                var regulation = regulations[regulationId];
                var Vn = regulation.left;
                var key = FIRST.MakeKey(regulation.Right);
                var first = eFIRSTDict[key]; // FIRST( regulation.Right )
                var firstCount = first.Values.Count;
                for (int index = 0; index < firstCount; index++) {
                    Utility.Rewrite($"LL(1)Regulations[{regulationId}/{regCount}] <-- working on {index + 1}/{firstCount}");

                    var Vt = first.Values[index];
                    table.SetAction(Vn, Vt, new LL1ParsingActionDraft(regulationId));
                }
                if (first.containsEmpty) {
                    var follow = eFOLLOWDict[Vn];
                    foreach (var Vt in follow.Values) {
                        table.SetAction(Vn, Vt, new LL1ParsingActionDraft(regulationId));
                    }
                }
            }
            Console.WriteLine();

            var result = new LL1SyntaxInfo(table);

            return result;
        }
    }
}
