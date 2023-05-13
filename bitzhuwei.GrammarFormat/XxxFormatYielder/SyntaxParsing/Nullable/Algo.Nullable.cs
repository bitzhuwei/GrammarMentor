using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    public static partial class Algorithm {
        // list是否都能产生empty？
        /// <summary>
        /// can the <paramref name="nodeList"/> be empty ?
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="nullableDict"></param>
        /// <returns></returns>
        static bool CanBeEmpty(IReadOnlyList<string> nodeList, Dictionary<string, bool> nullableDict) {
            return CanBeEmpty(nodeList, 0, nodeList.Count, nullableDict);
        }

        // list中指定的某一段结点是否都能产生empty？
        /// <summary>
        /// can the specified part of <paramref name="nodeList"/>(from <paramref name="checkIndex"/> to (<paramref name="checkIndex"/> + <paramref name="checkCount"/> - 1)) be empty ?
        /// </summary>
        /// <param name="nodeList"></param>
        /// <param name="checkIndex"></param>
        /// <param name="checkCount"></param>
        /// <param name="nullableDict"></param>
        /// <returns></returns>
        static bool CanBeEmpty(IReadOnlyList<string> nodeList, int checkIndex, int checkCount, Dictionary<string, bool> nullableDict) {
            bool result = true;
            for (int i = 0; i < checkCount; i++) {
                var node = nodeList[i + checkIndex];
                if (!nullableDict[node]) {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
