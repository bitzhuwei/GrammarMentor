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
//            //{ '!', "#33;" }, // ��̾�� exclamation mark
//            { '"', "#34;" }, // 
//            { '#', "#35;" }, // ���� pound sign
//            //{ '\'', "#39;" }, //
//            //{ '(', "#40;" }, { ')', "#41;" }, // ���� parentheses
//            //{ '*', "#42;" }, // �Ǻ� asterisk
//            //{ '+', "#43;" }, // �Ӻ� plus sign
//            //{ '-', "#45;" }, // ���� minus sign (hyphen)
//            //{ '.', "#46;" }, // �� dot
//            //{ '<', "#60;" }, { '>', "#62;" }, // ������ 
//            //{ '[', "#91;" }, { ']', "#93;" }, // ���� brackets
//            { '\\', "#92;" }, // ��б�� backslash
//            //{ '_', "#95;" }, // �»��� underscore
//            { '`', "#96;" }, // ������ backtick
//            //{ '{', "#123;" }, { '}', "#125;" }, // ������ curly braces
//            //{ '|', "#124;" }, // �ܵ� pipe
//            //{ '~', "#126;" }, // ������;
//        };
//    }
//}
