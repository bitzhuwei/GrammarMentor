//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Security.AccessControl;
//using System.Text;
//using System.Threading.Tasks;
//using bitzhuwei.Compiler;

//namespace bitzhuwei.GrammarFormat {
//    partial class Algorithm {
//        // '|' -> '\|'
//        /// <summary>
//        /// '|' -&gt; '\|'
//        /// <para>translate escape chars.</para>
//        /// </summary>
//        /// <param name="Vt"></param>
//        /// <returns></returns>
//        public static string mdAppear(this string Vt) {
//            var b = new StringBuilder();
//            foreach (var c in Vt) {
//                if (mdEscapeCharDict.TryGetValue(c, out var value)) {
//                    b.Append(value);
//                }
//                else { b.Append(c); }
//            }

//            return b.ToString();
//        }

//        private static readonly Dictionary<char, string> mdEscapeCharDict = new Dictionary<char, string>()
//        {
//            { '!', @"\!" }, // ��̾�� exclamation mark
//            { '"', "\\\"" }, // 
//            { '#', @"\#" }, // ���� pound sign
//            { '\'', @"\'" }, //
//            { '(', @"\(" }, { ')', @"\)" }, // ���� parentheses
//            { '*', @"\*" }, // �Ǻ� asterisk
//            { '+', @"\+" }, // �Ӻ� plus sign
//            { '-', @"\-" }, // ���� minus sign (hyphen)
//            { '.', @"\." }, // �� dot
//            { '<', @"\<" }, { '>', @"\>" }, // ������ 
//            { '[', @"\[" }, { ']', @"\]" }, // ���� brackets
//            { '\\', @"\\" }, // ��б�� backslash
//            //{ '_', @"\_" }, // �»��� underscore
//            { '`', @"\`" }, // ������ backtick
//            { '{', @"\{" }, { '}', @"\}" }, // ������ curly braces
//            { '|', @"\|" }, // �ܵ� pipe
//            { '~', @"\~" }, // ������;
//        };
//    }
//}
