using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace bitzhuwei.PatternFormat {
    public partial class NFAEdgeDraft {
        public readonly NFAStateDraft from;
        public readonly NFAStateDraft to;
        /// <summary>
        /// condition('x' or [xxx]) through which <paramref name="from"/> can go to <paramref name="to"/>
        /// <para><see cref="null"/> or <see cref="string.Empty"/> is not allowed</para>
        /// </summary>
        public readonly string condition;

        /// <summary>
        /// <paramref name="from"/> can go to <paramref name="to"/> via <paramref name="condition"/>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        public static NFAEdgeDraft Connect(NFAStateDraft from, NFAStateDraft to, string condition) {
            var edge = new NFAEdgeDraft(from, to, condition);

            from.toEdges.TryInsert(edge);
            to.fromEdges.TryInsert(edge);

            return edge;
        }

        private NFAEdgeDraft(NFAStateDraft from, NFAStateDraft to, string condition) {
            if (from == null) { throw new ArgumentNullException($"{nameof(from)}"); }
            if (to == null) { throw new ArgumentNullException($"{nameof(to)}"); }
            if (string.IsNullOrEmpty(condition)) { throw new ArgumentNullException($"{nameof(condition)}"); }

            this.from = from;
            this.to = to;
            this.condition = condition;
        }


        private string plainConditions = null;
        private string GetPlainConditions() {
            if (string.IsNullOrEmpty(this.plainConditions)) {
                var b = new StringBuilder();
                //if (this.condition == ConditionHelper.otherSign) {
                //    var others = new CoupleList<char>();
                //    var from = this.from;
                //    foreach (var edge in from.toEdges) {
                //        if (edge != this) {
                //            foreach (var c in edge.GetChars()) {
                //                others.TryInsert(c);
                //            }
                //        }
                //    }
                //    for (int i = 0; i < ConditionHelper.ASCIIinText.Length; i++) {
                //        var c = ConditionHelper.ASCIIinText[i];
                //        if (!others.Contains(c)) {
                //            b.Append(c);
                //        }
                //    }
                //}
                //else {
                var chars = ConditionHelper.GetChars(this.condition);
                foreach (var c in chars) {
                    b.Append(c);
                }
                //}
                this.plainConditions = b.ToString();
            }

            return this.plainConditions;
        }

        /// <summary>
        /// return true if <paramref name="c"/> belongs to the <see cref="NFAEdgeDraft.condition"/>.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool Contains(char c) {
            var plainConditions = this.GetPlainConditions();
            return plainConditions.Contains(c);
        }

        /// <summary>
        /// enumerate conditions through which <paramref name="from"/> can go to <paramref name="to"/>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<char> GetChars() {
            var plainConditions = this.GetPlainConditions();
            foreach (var c in plainConditions) {
                yield return c;
            }
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.ToMermaid(w, null);
            }

            return b.ToString();
        }
    }
}