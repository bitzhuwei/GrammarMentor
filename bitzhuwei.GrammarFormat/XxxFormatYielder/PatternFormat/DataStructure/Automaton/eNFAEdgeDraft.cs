using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace bitzhuwei.PatternFormat {
    public partial class eNFAEdgeDraft {
        public readonly eNFAStateDraft from;
        public readonly eNFAStateDraft to;
        /// <summary>
        /// condition('x' or [xxx]) through which <paramref name="from"/> can go to <paramref name="to"/>
        /// <para><see cref="null"/> or <see cref="string.Empty"/> means empty edge(ε)</para>
        /// </summary>
        public readonly string condition;

        /// <summary>
        /// <paramref name="from"/> can go to <paramref name="to"/> via <paramref name="condition"/>
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="condition">condition(in regex) through which <paramref name="from"/> can go to <paramref name="to"/>
        /// <para><see cref="null"/> or <see cref="string.Empty"/> means empty edge(ε)</para></param>
        /// <returns></returns>
        public static eNFAEdgeDraft Connect(eNFAStateDraft from, eNFAStateDraft to, /*CharRange matching*/string condition = null) {
            var edge = new eNFAEdgeDraft(from, to, condition);

            from.toEdges.TryInsert(edge);
            to.fromEdges.TryInsert(edge);

            return edge;
        }

        private eNFAEdgeDraft(eNFAStateDraft from, eNFAStateDraft to, /*CharRange matching*/string condition = null) {
            if (from == null) { throw new ArgumentNullException($"{nameof(from)}"); }
            if (to == null) { throw new ArgumentNullException($"{nameof(to)}"); }

            this.from = from;
            this.to = to;
            // if condition is null or string.Empty, it means this edge is a ε.
            this.condition = condition == null ? string.Empty : condition;
        }

        /// <summary>
        /// is this edge empty(ε) ?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() {
            return string.IsNullOrEmpty(this.condition);
        }

        public bool TryAttach(TokenScript tokenScript, eNFAInfo eNFA) {
            return eNFA.edgeTokenScriptDict.TryInsert(this, tokenScript);
        }

        public bool TryAttach(IReadOnlyList<TokenScript> tokenScripts, eNFAInfo eNFA) {
            return eNFA.edgeTokenScriptDict.TryInsert(this, tokenScripts);
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