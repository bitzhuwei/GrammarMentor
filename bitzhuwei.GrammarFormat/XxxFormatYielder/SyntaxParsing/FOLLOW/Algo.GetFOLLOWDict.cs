using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        // 计算文法的FOLLOW集
        /// <summary>
        /// returns the dictionary of <see cref="FOLLOW.Vn"/> -&gt; <see cref="FOLLOW"/>
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="emptyDict"></param>
        /// <param name="firstDict"></param>
        public static Dictionary<string/*FOLLOW.target*/, FOLLOW> GetFOLLOWDict(this VnRegulationDraft[] regulations,
            Dictionary<string, bool> emptyDict, Dictionary<string, FIRST> firstDict) {
            var result = new Dictionary<string/*FOLLOW.Vn*/, FOLLOW>();

            // 初始化Follow Dict
            // allocate space for the FOLLOW( Vn ) items.
            var VnNodes = regulations.GetVnNodes();
            foreach (var item in VnNodes) {
                var follow = new FOLLOW(item);
                result.Add(follow.Vn, follow);
            }

            // 迭代到不动点
            // iterate untill not changed.
            bool changed = false;
            do {
                changed = false;
                foreach (var regulation in regulations) {
                    var right = regulation.Right;
                    int count = right.Count;
                    for (int checkpoint = 0; checkpoint < count; checkpoint++) {
                        string/*Node.type*/ target = right[checkpoint];
                        if (target.IsVt()) { continue; } // 叶结点没有follow
                        if (target == CompilerGrammar.keywordEmpty) {
                            throw new Exception($"No '{CompilerGrammar.keywordEmpty}' should appear in {nameof(VnRegulationDraft.Right)}");
                        }
                        else {
                            // 准备为target添加follow元素
                            // try to collect FOLLOW( target )
                            var checkIndex = checkpoint + 1;
                            for (int checkCount = 0; checkCount < count - checkIndex; checkCount++) {
                                // if right[checkIndex->(checkIndex+checkCount-1)] can be empty,
                                // then FOLLOW( target ) includes FIRST( right[checkInde+checkCount] )
                                // except empty.
                                if (CanBeEmpty(right, checkIndex, checkCount, emptyDict)) {
                                    // FOLLOW( target ) 包含 FIRST( right[checkInde+checkCount] )（除了empty）
                                    var Vn = target;
                                    if (!result.TryGetValue(Vn, out FOLLOW follow)) { throw new Exception(algorithmError); }
                                    string key = right[checkIndex + checkCount];
                                    if (!firstDict.TryGetValue(key, out FIRST first)) { throw new Exception(algorithmError); }
                                    foreach (var value in first.Values) {
                                        //if (value != string/*Node.type*/.NullNode)
                                        //if (value != CompilerGrammar.keywordEmpty) {
                                        changed = follow.TryInsert(value) || changed;
                                        //}
                                    }
                                }
                            }
                            {
                                var checkCount = count - checkIndex;
                                // 如果target之后的全部结点都可为empty，那么 FOLLOW( target ) 包含 FOLLOW( regulation.left )
                                // if right[checkIndex->(count - checkIndex-1)] can be empty,
                                // then FOLLOW( target ) includes FOLLOW( regulation.left ).
                                if (CanBeEmpty(right, checkIndex, checkCount, emptyDict)) {
                                    if (!result.TryGetValue(target, out FOLLOW follow)) { throw new Exception(algorithmError); }
                                    if (!result.TryGetValue(regulation.left, out FOLLOW refFollow)) { throw new Exception(algorithmError); }
                                    if (follow != refFollow) {
                                        foreach (var item in refFollow.Values) {
                                            changed = follow.TryInsert(item) || changed;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (changed);

            return result;
        }

    }

}
