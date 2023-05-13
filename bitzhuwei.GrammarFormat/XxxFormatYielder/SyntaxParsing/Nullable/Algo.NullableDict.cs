using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public static partial class Algorithm {
        // 计算所有可能推导出empty的结点。
        /// <summary>
        /// get the dictionary that tells if a node can refer to <see cref="CompilerGrammar.keywordEmpty"/>.
        /// </summary>
        /// <param name="vnRegulations"></param>
        /// <returns></returns>
        public static Dictionary<string, bool> GetNullableDict(this VnRegulationDraft[] vnRegulations) {
            var nullableDict = new Dictionary<string, bool>();/*Dictionary<Node.type, bool>*/

            // allocate space for all kinds of nodes(Vt and Vn, no CompilerGrammar.keywordEmpty).
            var allNodeTypes = vnRegulations.GetNodes();
            foreach (var item in allNodeTypes) {
                nullableDict.Add(item, false);
            }
            // TODO: everything depends on this. really?
            //nullableDict.Add(CompilerGrammar.keywordEmpty, true);
            nullableDict.Add(string.Empty, true);

            // iterate untill not changed.
            bool changed = false;
            do {
                changed = false;
                foreach (var regulation in vnRegulations) {
                    // 如果regulation.right可推导出empty，就说明regulation.left可推导出empty。
                    // if regulation.right can refer to CompilerGrammar.keywordEmpty,
                    // then regulation.left, too.
                    if (CanBeEmpty(regulation.Right, nullableDict)) {
                        var left = regulation.left;
                        if (!nullableDict[left]) {
                            nullableDict[left] = true;
                            changed = true;
                        }
                    }
                }
            } while (changed);

            return nullableDict;
        }
    }
}
