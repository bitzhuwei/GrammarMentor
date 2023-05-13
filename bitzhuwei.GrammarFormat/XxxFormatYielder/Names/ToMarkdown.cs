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
//            { '!', @"\!" }, // ¸ÐÌ¾ºÅ exclamation mark
//            { '"', "\\\"" }, // 
//            { '#', @"\#" }, // ¾®ºÅ pound sign
//            { '\'', @"\'" }, //
//            { '(', @"\(" }, { ')', @"\)" }, // À¨»¡ parentheses
//            { '*', @"\*" }, // ÐÇºÅ asterisk
//            { '+', @"\+" }, // ¼ÓºÅ plus sign
//            { '-', @"\-" }, // ¼õºÅ minus sign (hyphen)
//            { '.', @"\." }, // µã dot
//            { '<', @"\<" }, { '>', @"\>" }, // ¼âÀ¨ºÅ 
//            { '[', @"\[" }, { ']', @"\]" }, // À¨ºÅ brackets
//            { '\\', @"\\" }, // ·´Ð±¸Ü backslash
//            //{ '_', @"\_" }, // ÏÂ»®Ïß underscore
//            { '`', @"\`" }, // ·´ÒýºÅ backtick
//            { '{', @"\{" }, { '}', @"\}" }, // ´óÀ¨ºÅ curly braces
//            { '|', @"\|" }, // ¹ÜµÀ pipe
//            { '~', @"\~" }, // ²¨ÀËÏß;
//        };
//    }
//}
