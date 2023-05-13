using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    // 规则
    /// <summary>
    /// Additive : Additive '+' Multiplicative ;
    /// </summary>
    public class Regulation {
        /// <summary>
        /// Additive
        /// </summary>
        public readonly string left;
        /// <summary>
        /// Additive '+' Multiplicative
        /// <para>There can be ZERO element.</para>
        /// </summary>
        public readonly string[] right;

        ///// <summary>
        ///// index of this <see cref="Regulation"/> object in the array.
        ///// </summary>
        //public readonly int index;

        /// <summary>
        /// Additive : Additive '+' Multiplicative ;
        /// </summary>
        /// <param name="left">Additive</param>
        /// <param name="right">Additive '+' Multiplicative</param>
        public Regulation(string left, params string[] right) {
            this.left = left;
            this.right = right;
        }

        public void Print(TextWriter w) {
            w.Write($"{left} : ");
            foreach (var item in right) {
                w.Write($"{item} ");
            }
            // should not write "empty" for the right part.
            w.Write(";");
        }

        public override string ToString() {
            var b = new StringBuilder();
            //b.Append($"regulations[{index}]=<");
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }
            //b.Append(">");

            return b.ToString();
        }
    }
}
