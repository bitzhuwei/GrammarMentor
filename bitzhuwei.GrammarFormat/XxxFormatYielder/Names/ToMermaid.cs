//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Security.AccessControl;
//using System.Text;
//using System.Threading.Tasks;
//using bitzhuwei.Compiler;

//namespace bitzhuwei.GrammarFormat {
//    partial class Algorithm {
//        // '"' -> #34;
//        /// <summary>
//        /// '"' -&gt; #34;
//        /// <para>translate escape chars.</para>
//        /// </summary>
//        /// <param name="str"></param>
//        /// <returns></returns>
//        public static string ToMermaid(this string str) {
//            var b = new StringBuilder();
//            foreach (var c in str) {
//                if (mmdEscapeCharDict.TryGetValue(c, out var value)) {
//                    b.Append(value);
//                }
//                else { b.Append(c); }
//            }

//            return b.ToString();
//        }

//        // '"' -> #34;
//        /// <summary>
//        /// '"' -&gt; #34;
//        /// </summary>
//        /// <param name="str"></param>
//        /// <param name="w"></param>
//        public static void ToMermaid(this string str, TextWriter w) {
//            foreach (var c in str) {
//                if (mmdEscapeCharDict.TryGetValue(c, out var value)) {
//                    w.Write(value);
//                }
//                else {
//                    w.Write(c);
//                }
//            }
//        }

//        private static readonly Dictionary<char, string> mmdEscapeCharDict = new Dictionary<char, string>()
//        {
//            //{ '!', "#33;" }, // ¸ÐÌ¾ºÅ exclamation mark
//            { '"', "#34;" }, // 
//            { '#', "#35;" }, // ¾®ºÅ pound sign
//            //{ '\'', "#39;" }, //
//            //{ '(', "#40;" }, { ')', "#41;" }, // À¨»¡ parentheses
//            //{ '*', "#42;" }, // ÐÇºÅ asterisk
//            //{ '+', "#43;" }, // ¼ÓºÅ plus sign
//            //{ '-', "#45;" }, // ¼õºÅ minus sign (hyphen)
//            //{ '.', "#46;" }, // µã dot
//            //{ '<', "#60;" }, { '>', "#62;" }, // ¼âÀ¨ºÅ 
//            //{ '[', "#91;" }, { ']', "#93;" }, // À¨ºÅ brackets
//            { '\\', "#92;" }, // ·´Ð±¸Ü backslash
//            //{ '_', "#95;" }, // ÏÂ»®Ïß underscore
//            { '`', "#96;" }, // ·´ÒýºÅ backtick
//            //{ '{', "#123;" }, { '}', "#125;" }, // ´óÀ¨ºÅ curly braces
//            //{ '|', "#124;" }, // ¹ÜµÀ pipe
//            //{ '~', "#126;" }, // ²¨ÀËÏß;
//        };
//    }
//}
