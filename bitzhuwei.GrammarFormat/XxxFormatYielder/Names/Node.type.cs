using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        /// <summary>
        /// is this a Vt node?
        /// <para>'xxx'</para>
        /// </summary>
        /// <param name="V"></param>
        /// <returns></returns>
        public static bool IsVt(this string V) {
            // empty node name
            if (string.IsNullOrEmpty(V)) { return false; }
            // first should be '
            if (V[0] != '\'') { return false; }
            // last should be '
            if (V.Last() != '\'') { return false; }
            // '' is invalid
            if (V.Length == 2) { return false; }

            return true;
        }

        public static bool IsVn(this string V) {
            // empty node name
            if (string.IsNullOrEmpty(V)) { return false; }
            // should start with letter or _
            var first = V[0];
            if (!
                 (
                  ('a' <= first && first <= 'z')
                  || ('A' <= first && first <= 'Z')
                  || (first == '_')
                 )
                ) {
                return false;
            }
            // should only contains letters, numbers or _
            for (int j = 1; j < V.Length; j++) {
                var c = V[j];
                if (!
                    (
                     ('a' <= first && first <= 'z')
                     || ('A' <= first && first <= 'Z')
                     || ('0' <= first && first <= '9')
                     || (first == '_')
                    )
                   ) {
                    return false;
                }
            }
            // it cannot be empty
            if (V == CompilerGrammar.keywordEmpty) { return false; }

            return true;
        }

        // 'xxx' -> xxx
        /// <summary>
        /// 'xxx' -&gt; xxx
        /// </summary>
        /// <param name="Vt"></param>
        /// <returns></returns>
        public static string VtInner(this string Vt) {
            int length = Vt.Length;
            var inner = Vt.Substring(1, length - 2);

            return inner;
        }

        // 'xxx' -> xxx -> abcde_
        /// <summary>
        /// 'xxx' -&gt; xxx -&gt; abcde_
        /// </summary>
        /// <param name="Vn"></param>
        /// <returns></returns>
        public static string Vn2Name(this string Vn) {
            // use @ as prefix to avoid same name with Vn or C# keyword.
            var name = Vn.ToVarName();

            // TODO: use @... ?
            if (!provider.IsValidIdentifier(name)) {
                name = name + "_";
            }

            return name;
        }

        // 'xxx' -> xxx -> @abcde
        /// <summary>
        /// 'xxx' -&gt; xxx -&gt; @abcde
        /// </summary>
        /// <param name="Vt"></param>
        /// <returns></returns>
        public static string Vt2Name(this string Vt) {
            int length = Vt.Length;
            if (length <= 2) {
                Console.WriteLine();
            }
            var inner = Vt.Substring(1, length - 2);
            // use @ as prefix to avoid same name with Vn or C# keyword.
            var name = "@" + inner.ToVarName();

            return name;
        }

    }
}
