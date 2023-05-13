using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.ScopeFormat {
    /// <summary>
    /// Correspond to the Vn node Scope in the grammar(Scope).
    /// </summary>
    public partial class Scope {
        public readonly bool reverse;
        public readonly char[] items;

        public Scope(bool reverse, char[] items) {
            this.reverse = reverse;
            this.items = items;
        }

        /// <summary>
        /// [xxx]
        /// <para>or</para>
        /// <para>[^xxx]</para>
        /// </summary>
        /// <returns></returns>
        public string ItemsAppearance() {
            var b = new StringBuilder();
            foreach (var c in this.items) {
                var appearance = CompilerScope.ToAppearance(c);
                b.Append(appearance);
            }

            return b.ToString();
        }

        /// <summary>
        /// [xxx]
        /// <para>or</para>
        /// <para>[^xxx]</para>
        /// </summary>
        /// <returns></returns>
        public string ToAppearance() {
            var b = new StringBuilder();
            if (this.reverse) { b.Append("[^"); }
            else { b.Append("["); }
            foreach (var c in this.items) {
                var appearance = CompilerScope.ToAppearance(c);
                b.Append(appearance);
            }
            b.Append("]");

            return b.ToString();
        }
        public override string ToString() {
            return this.ToAppearance();
        }

    }
}
