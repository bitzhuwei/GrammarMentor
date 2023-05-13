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
        /// <summary>
        /// returns the dictionary of <see cref="FIRST.keyString"/> -&gt; <see cref="FIRST"/>
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="nullableDict"></param>
        /// <returns></returns>
        public static Dictionary<string, FIRST> GetFIRSTDict(this VnRegulationDraft[] regulations,
            Dictionary<string, bool> nullableDict) {
            var result = new Dictionary<string, FIRST>();

            regulations.GetFIRSTDict4Node(result, nullableDict);

            regulations.GetFIRSTDict4Right(result, nullableDict);

            return result;
        }

        /// <summary>
        /// 计算文法的各个RightPart的FIRST集
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="result"></param>
        /// <param name="emptyDict"></param>
        /// <returns></returns>
        private static void GetFIRSTDict4Right(this VnRegulationDraft[] regulations,
            Dictionary<string, FIRST> result, Dictionary<string, bool> emptyDict) {
            // allocate space for all regulation.right
            foreach (var regulation in regulations) {
                var first = new FIRST(regulation.Right); // not filled up yet.
                if (!result.TryGetValue(first.keyString, out FIRST tmp)) {
                    result.Add(first.keyString, first);
                }
            }

            bool changed = false;
            do {
                changed = false;
                foreach (var first in result.Values) {
                    var key = first.key;
                    int count = key.Length;
                    for (int checkLength = 0; checkLength < count; checkLength++) {
                        // 如果前checkLength个结点都可为empty，
                        // 就说明 FIRST( left ) 包含 FIRST( key[checkpoint] )，empty除外。
                        // if key[(-1)->(checkpoint-1)] can be empty,
                        // then FIRST( left ) includes FIRST( key[checkpoint] )
                        // except for empty.
                        const int checkIndex = 0;
                        if (CanBeEmpty(key, checkIndex, checkLength, emptyDict)) {
                            string refKey = key[checkLength];// FIRST.MakeKey(first.Key[i]);
                            if (!result.TryGetValue(refKey, out FIRST refFirst)) { throw new Exception(algorithmError); }
                            foreach (var value in refFirst.Values) {
                                //if (value != string/*Node.type*/.NullNode)
                                if (value != CompilerGrammar.keywordEmpty) {
                                    changed = first.TryInsert(value) || changed;
                                }
                            }
                        }
                    }
                    {
                        // 如果key的全部结点都可为empty，就说明FIRST( key ) 包含 empty。
                        // if key[0->(count-1)] can be empty,
                        // then FIRST( key ) includes empty.
                        if (CanBeEmpty(key, emptyDict)) {
                            //changed = first.TryInsert(string/*Node.type*/.NullNode) || changed;
                            changed = first.TryInsert(CompilerGrammar.keywordEmpty) || changed;
                        }
                    }
                }
            } while (changed);
        }

        /// <summary>
        /// 计算文法的所有单个的结点的FIRST
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="emptyDict"></param>
        /// <returns></returns>
        private static void GetFIRSTDict4Node(this VnRegulationDraft[] regulations,
            Dictionary<string, FIRST> result, Dictionary<string, bool> emptyDict) {
            // allocate space for all single nodes.
            // 初始化FIRST(Vn)
            var VnNodes = regulations.GetVnNodes();
            foreach (var Vn in VnNodes) {
                if (emptyDict[Vn]) {
                    //var first = new FIRST(Vn, CompilerGrammar.EType.null_);
                    var first = new FIRST(Vn, CompilerGrammar.keywordEmpty);
                    result.Add(first.keyString, first);
                }
                else {
                    var first = new FIRST(Vn);
                    result.Add(first.keyString, first);
                }
            }

            // 初始化FIRST(Vt)（FIRST(Vt)实际上已经完工）
            var VtNodes = regulations.GetVtNodes();
            foreach (var Vt in VtNodes) {
                var first = new FIRST(Vt, Vt);
                result.Add(first.keyString, first);
            }

            // FIRST( empty ) = { empty }
            {
                //var first = new FIRST(CompilerGrammar.keywordEmpty);
                var first = new FIRST(string.Empty);
                result.Add(first.keyString, first);
            }

            bool changed = false;
            do {
                changed = false;
                foreach (var regulation in regulations) {
                    var left = regulation.left; //string key = FIRST.MakeKey(left);
                    var right = regulation.Right;
                    // try to collect FIRST( left )
                    int rightLength = right.Count;
                    for (int checkLength = 0; checkLength < rightLength; checkLength++) {
                        // 如果前checkpoint个结点都可为null，
                        // 就说明 FIRST(left) 包含 FIRST(right[checkCount])，empty除外。
                        // if regulation.right[(-1)->(checkpoint-1)] can be empty,
                        // then FIRST( left ) includes FIRST( right[checkpoint] )
                        // except for empty.
                        if (CanBeEmpty(right, 0, checkLength, emptyDict)) {
                            //string refKey = FIRST.MakeKey(regulation.right[checkCount]);
                            var refKey = right[checkLength];
                            if (left != refKey) {
                                if (!result.TryGetValue(left, out FIRST first)) { throw new Exception(algorithmError); }
                                if (!result.TryGetValue(refKey, out FIRST refFirst)) { throw new Exception(algorithmError); }
                                foreach (var value in refFirst.Values) {
                                    //if (value != string/*Node.type*/.NullNode)
                                    if (value != CompilerGrammar.keywordEmpty) {
                                        changed = first.TryInsert(value) || changed;
                                    }
                                }
                            }
                        }
                    }
                    {
                        // if regulation.right can be empty,
                        // then regulation.left can be empty.
                        if (CanBeEmpty(right, emptyDict)) {
                            if (!result.TryGetValue(left, out FIRST first)) { throw new Exception(algorithmError); }
                            changed = first.TryInsert(CompilerGrammar.keywordEmpty) || changed;
                        }
                    }
                }
            } while (changed);
        }

        //private static FIRST FindFirst(FIRSTList firstCollection, string/*Node.type*/ target)
        //{
        //    foreach (var item in firstCollection)
        //    {
        //        if (item.Target.Count() == 1
        //            && item.Target.First() == target)
        //        {
        //            return item;
        //        }
        //    }

        //    return null;
        //}
    }

}
