using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        // xxx -> abcde
        /// <summary>
        /// xxx -&gt; abcde
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string ToVarName(this string content) {
            if (string.IsNullOrEmpty(content)) { throw new ArgumentNullException(); }

            var b = new StringBuilder();
            for (int i = 0; i < content.Length; i++) {
                char c = content[i];
                if (punctuationDict.TryGetValue(c, out string part)) {
                    b.Append(part);
                }
                else {
                    b.Append(c);
                }
            }
            string result = b.ToString();

            {
                char firstChar = result[0];
                bool needPrefix;

                if (('a' <= firstChar && firstChar <= 'z')
                    || ('A' <= firstChar && firstChar <= 'Z')
                    || (firstChar == '_')) {
                    needPrefix = false;
                }
                else {
                    needPrefix = true;
                }

                if (needPrefix) {
                    result = "_" + result;
                }
            }

            return result;
        }

    }
}
