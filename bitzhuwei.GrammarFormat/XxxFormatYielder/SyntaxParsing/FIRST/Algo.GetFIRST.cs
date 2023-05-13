using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// 根据文法和已经计算的所有结点的FIRST集，计算任意一个结点串的FIRST。
        /// </summary>
        /// <param name="target"></param>
        /// <param name="firstDict"></param>
        /// <param name="emptyDict"></param>
        /// <returns></returns>
        private static FIRST GetFIRST(this IReadOnlyList<string/*Node.type*/> target,
            Dictionary<string/*FIRST.keyString*/, FIRST> firstDict, Dictionary<string/*Node.type*/, bool> emptyDict) {
            // 初始化FIRST集
            var first = new FIRST(target);

            bool changed = false;
            do {
                changed = false;
                var count = first.key.Length;
                for (int checkCount = 0; checkCount < count; checkCount++) {
                    // 如果前checkCount个结点都可为empty，就说明
                    // FIRST( target ) 包含 FIRST( target[checkCount] )（除了empty）。
                    // if target[(-1)->(checkCount-1)] are can refer to empty,
                    // then FIRST( target ) includes FIRST( target[checkCount] )
                    // except for empty.
                    if (CanBeEmpty(first.key, 0, checkCount, emptyDict)) {
                        // 找到下一个结点的FIRST
                        FIRST refFirst; string refKey = first.key[checkCount];
                        if (!firstDict.TryGetValue(refKey, out refFirst)) { throw new Exception(algorithmError); }
                        foreach (var value in refFirst.Values) {
                            //if (value != string/*Node.type*/.NullNode)//旧版
                            //if (value != CompilerGrammar.EType.null_) //错版
                            if (value != CompilerGrammar.keywordEmpty) {
                                changed = first.TryInsert(value) || changed;
                            }
                        }
                    }
                }
                {
                    // 如果target的每个V都可为empty，那么 FIRST( key ) 包含 empty。
                    // if target[0->(count-1)] can refer to empty,
                    // then FIRST( target ) includes empty.
                    if (CanBeEmpty(first.key, emptyDict)) {
                        //throw new Exception("如果是在LR1分析器生成工具的设计时走到此处，说明代码有问题。");// I don't remember what this was meant to.
                        //if (!first.Values.Contains(string/*Node.type*/.NullNode))
                        //if (!first.Values.Contains(CompilerGrammar.EType.null_))
                        //if (!first.Values.Contains(CompilerGrammar.keywordEmpty))
                        {
                            //changed = first.TryInsert(string/*Node.type*/.NullNode) || changed;
                            changed = first.TryInsert(CompilerGrammar.keywordEmpty) || changed;
                        }
                    }
                }
            } while (changed);

            return first;
        }
    }
}
