using System.Collections.Generic;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// (nullable dict + FIRST dict + FOLLOW dict) of a specified grammar(<see cref="GrammarDraft.VnRegulations"/>).
    /// </summary>
    public class NFF {
        /// <summary>
        /// key(<see cref="Node.type"/>) to value(bool(can refer to empty or not)).
        /// </summary>
        public readonly Dictionary<string, bool> nullableDict;

        /// <summary>
        /// key(<see cref="FIRST.key"/>) to value(<see cref="FIRST"/>).
        /// </summary>
        public readonly Dictionary<string, FIRST> firstDict;

        /// <summary>
        /// key(<see cref="FOLLOW.Target"/> to value(<see cref="FOLLOW"/>).
        /// </summary>
        public readonly Dictionary<string, FOLLOW> followDict;

        /// <summary>
        /// (nullable dict + FIRST dict + FOLLOW dict) of a specified grammar(<see cref="VnRegulationDraft[]"/>).
        /// </summary>
        /// <param name="nullableDict"></param>
        /// <param name="firstDict"></param>
        /// <param name="followDict"></param>
        public NFF(Dictionary<string, bool> nullableDict, Dictionary<string, FIRST> firstDict, Dictionary<string, FOLLOW> followDict) {
            this.nullableDict = nullableDict;
            this.firstDict = firstDict;
            this.followDict = followDict;
        }

        public override string ToString() {
            return $"N:{nullableDict.Count}, F:{firstDict.Count}, F:{followDict.Count}";
        }
    }
}