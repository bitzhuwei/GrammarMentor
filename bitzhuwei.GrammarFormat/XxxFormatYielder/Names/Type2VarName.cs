using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        // Xxx -> xxx
        /// <summary>
        /// Xxx -&gt; xxx
        /// </summary>
        /// <param name="Type">Xxx</param>
        /// <param name="addPrefix">add prefix @ if it's a C# keyword</param>
        /// <returns></returns>
        public static string Type2VarName(this string Type, bool addPrefix = false) {
            var b = new StringBuilder();
            char first = char.ToLower(Type[0]);
            b.Append(first);
            b.Append(Type.Substring(1));

            var varName = b.ToString();

            if (addPrefix) {
                if (!provider.IsValidIdentifier(varName)) {
                    varName = "@" + varName;
                }
            }

            return varName;
        }
    }
}
