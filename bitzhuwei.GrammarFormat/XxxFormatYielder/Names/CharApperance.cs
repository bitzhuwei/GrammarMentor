using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class Algorithm {
        // ��������
        // '\t'(09, '\u0009')��(ռ'��'���ַ��Ŀ��)           is control.
        // '\n'(10, '\u000A')��('��'����)                   is control.
        // '\r'(13, '\u000D')��(Linux������'û'��)           is control.
        // ' ' (32, '\u0020')��('��'��ȥ�ˣ�ֻ����������������) is not control.
        /// <summary>
        /// return readable appearance if possible.
        /// <para>��'\t' returns '\t'/*'\u0009'(9)*/</para>
        /// <para>��'\n' returns '\n'/*'\u000A'(10)*/</para>
        /// <para>��'\r' returns '\r'/*'\u000D'(13)*/</para>
        /// <para>��' ' returns ' '/*'\u0020'(32)*/</para>
        /// <para>'\'' returns '\''/*'\u0027'(39)*/</para>
        /// <para>'\\' returns '\\'/*'\u005C'(92)*/</para>
        /// <para>other control char returns '\uNNNN'/*{decimalNumber}*/</para>
        /// <para>other char returns '<paramref name="c"/>'/*'\uNNNN'({decimalNumber})*/</para>
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string csAppear(this char c) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                csAppear(c, w);
            }

            return b.ToString();
        }

        // ��������
        // '\t'(09, '\u0009')��(ռ'��'���ַ��Ŀ��)           is control.
        // '\n'(10, '\u000A')��('��'����)                   is control.
        // '\r'(13, '\u000D')��(Linux������'û'��)           is control.
        // ' ' (32, '\u0020')��('��'��ȥ�ˣ�ֻ����������������) is not control.
        /// <summary>
        /// return readable appearance if possible.
        /// <para>��'\t' returns '\t'/*'\u0009'(9)*/</para>
        /// <para>��'\n' returns '\n'/*'\u000A'(10)*/</para>
        /// <para>��'\r' returns '\r'/*'\u000D'(13)*/</para>
        /// <para>��' ' returns ' '/*'\u0020'(32)*/</para>
        /// <para>'\'' returns '\''/*'\u0027'(39)*/</para>
        /// <para>'\\' returns '\\'/*'\u005C'(92)*/</para>
        /// <para>other control char returns '\uNNNN'/*{decimalNumber}*/</para>
        /// <para>other char returns '<paramref name="c"/>'/*'\uNNNN'({decimalNumber})*/</para>
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static void csAppear(this char c, TextWriter w) {
            switch (c) {
            case '\u0009': w.Write(@"'\t'/*'\u0009'(9)*/"); break;
            case '\u000A': w.Write(@"'\n'/*'\u000A'(10)*/"); break;
            case '\u000D': w.Write(@"'\r'/*'\u000D'(13)*/"); break;
            case '\u0020': w.Write(@"' '/*'\u0020'(32)*/"); break;
            case '\'': w.Write(@"'\''/*'\u0027'(39)*/"); break;
            case '\\': w.Write(@"'\\'/*'\u005C'(92)*/"); break;
            default:
            var decimalNumber = Convert.ToString(c, 10);
            //var hex = Convert.ToString(c, 16);
            //hex = hex.PadLeft(4, '0');
            var hex = string.Format(@"\u{0:X4}", (int)c);
            if (char.IsControl(c)) { w.Write($"'{hex}'/*{decimalNumber}*/"); }
            else { w.Write($"'{c}'/*'{hex}'({decimalNumber})*/"); }
            break;
            }
        }

        // '"' -> #34;
        /// <summary>
        /// '"' -&gt; #34;
        /// </summary>
        /// <param name="str"></param>
        /// <param name="w"></param>
        public static string ToMermaid(this string str) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                ToMermaid(str, w);
            }

            return b.ToString();
        }

        // '"' -> #34;
        /// <summary>
        /// '"' -&gt; #34;
        /// </summary>
        /// <param name="str"></param>
        /// <param name="w"></param>
        public static void ToMermaid(this string str, TextWriter w) {
            foreach (var c in str) {
                c.ToMermaid(w);
            }
        }

        /// <summary>
        /// return readable appearance if possible.
        /// <para>��'\t' returns #92;t</para>
        /// <para>��'\n' returns #92;n</para>
        /// <para>��'\r' returns #92;r</para>
        /// <para>��' ' returns #32;</para>
        /// <para>other control char returns #n;</para>
        /// <para>other char returns c</para>
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static void ToMermaid(this char c, TextWriter w) {
            switch (c) {
            case '\u0009': w.Write("#92;t"); break;
            case '\u000A': w.Write("#92;n"); break;
            case '\u000D': w.Write("#92;r"); break;
            case '\u0020': w.Write("#32;"); break;
            case '"': w.Write("#34;"); break;
            case '#': w.Write("#35;"); break;
            case '\\': w.Write("#92;"); break;
            case '`': w.Write("#96;"); break;
            default:
            if (char.IsControl(c)) {
                var decimalNumber = Convert.ToString(c, 10);
                w.Write($"#{decimalNumber};");
            }
            else {
                w.Write(c);
            }
            break;
            }
        }

        ///// <summary>
        ///// return readable appearance if possible.
        ///// <para>��'\t' returns \t</para>
        ///// <para>��'\n' returns \n</para>
        ///// <para>��'\r' returns \r</para>
        ///// <para>��' ' returns ��</para>
        ///// <para>'\'' returns '</para>
        ///// <para>'\\' returns \\</para>
        ///// <para>other char returns <paramref name="c"/></para>
        ///// </summary>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //public static string ToRegexAppearance(this char c) {
        //    if (c == '\u0009') { return @"\t"; }
        //    else if (c == '\u000A') { return @"\n"; }
        //    else if (c == '\u000D') { return @"\r"; }
        //    else if (c == '\u0020') { return @" "; }
        //    else if (c == '\'') { return @"'"; }
        //    else if (c == '\\') { return @"\\"; }
        //    else { return c.ToString(); }
        //}

        /// <summary>
        /// add \ for escape chars(xxx in [xxx])
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string regexAppear(this char c) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                regexAppear(c, w);
            }

            return b.ToString();
        }

        /// <summary>
        /// add \ for escape chars(xxx in [xxx])
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static void regexAppear(this char c, TextWriter w) {
            switch (c) {
            case '\u0009': w.Write(@"\t"); break;
            case '\u000A': w.Write(@"\n"); break;
            case '\u000D': w.Write(@"\r"); break;
            case '\u0020': w.Write(@" "); break;
            case '\'': w.Write(@"'"); break;
            default:
            if (@"$()*+-./<>?[\]^{|}".Contains(c)) {
                w.Write($"\\{c}");
            }
            else if (char.IsControl(c)) {
                var hex = string.Format(@"\u{0:X4}", (int)c);
                w.Write(hex);
            }
            else {
                w.Write(c);
            }
            break;
            }
        }

        ///// <summary>
        ///// try to add \ for escape chars(xxx in [xxx])
        ///// </summary>
        ///// <param name="c"></param>
        ///// <returns></returns>
        //public static string ToMermaidEscapeApperance(this char c) {
        //    if (c == '\u0009') { return @"\t"; }
        //    else if (c == '\u000A') { return @"\n"; }
        //    else if (c == '\u000D') { return @"\r"; }
        //    //else if (c == '\u0020') { return @" "; }
        //    else if (@"\]^".Contains(c)) {
        //        return $"\\{c}";
        //    }
        //    else if (char.IsControl(c)) {
        //        var decimalNumber = Convert.ToString(c, 10);
        //        return $"#{decimalNumber};";
        //    }
        //    else {
        //        return c.ToString();
        //    }
        //}

        // '|' -> '\|'
        /// <summary>
        /// '|' -&gt; '\|'
        /// <para>translate escape chars.</para>
        /// </summary>
        /// <param name="Vt"></param>
        /// <returns></returns>
        public static string ToMarkdown(this string Vt) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                ToMarkdown(Vt, w);
            }

            return b.ToString();
        }

        // '|' -> '\|'
        /// <summary>
        /// '|' -&gt; '\|'
        /// <para>translate escape chars.</para>
        /// </summary>
        /// <param name="Vt"></param>
        /// <returns></returns>
        public static void ToMarkdown(this string Vt, TextWriter w) {
            foreach (var c in Vt) {
                c.mdAppear(w);
            }
        }

        public static void mdAppear(this char c, TextWriter w) {
            switch (c) {
            case '!': w.Write(@"\!"); break; // ��̾�� exclamation mark
            case '"': w.Write("\\\""); break;
            case '#': w.Write(@"\#"); break; // ���� pound sign
            case '\'': w.Write(@"\'"); break;
            case '(': w.Write(@"\("); break; // ���� parentheses
            case ')': w.Write(@"\)"); break; // ���� parentheses
            case '*': w.Write(@"\*"); break; // �Ǻ� asterisk
            case '+': w.Write(@"\+"); break; // �Ӻ� plus sign
            case '-': w.Write(@"\-"); break; // ���� minus sign (hyphen)
            case '.': w.Write(@"\."); break; // �� dot
            case '<': w.Write(@"\<"); break; // ������
            case '>': w.Write(@"\>"); break; // ������
            case '[': w.Write(@"\["); break; // ���� brackets
            case ']': w.Write(@"\]"); break; // ���� brackets
            case '\\': w.Write(@"\\"); break;// ��б�� backslash
            case '`': w.Write(@"\`"); break; // ������ backtick
            case '{': w.Write(@"\{"); break; // ������ curly braces
            case '}': w.Write(@"\}"); break; // ������ curly braces
            case '|': w.Write(@"\|"); break; // �ܵ� pipe
            case '~': w.Write(@"\~"); break; // ������
            default:
            if (char.IsControl(c)) {
                //var decimalNumber = Convert.ToString(c, 10);
                //w.Write( $"$\\u{decimalNumber}$";
                var hex = string.Format(@"$\u{0:X4}$", (int)c);
                w.Write(hex);
            }
            else {
                w.Write(c);
            }
            break;
            }
        }

        //private static readonly Dictionary<char, string> mdEscapeCharDict = new Dictionary<char, string>()
        //{
        //    { '!', @"\!" }, // ��̾�� exclamation mark
        //    { '"', "\\\"" }, // 
        //    { '#', @"\#" }, // ���� pound sign
        //    { '\'', @"\'" }, //
        //    { '(', @"\(" }, { ')', @"\)" }, // ���� parentheses
        //    { '*', @"\*" }, // �Ǻ� asterisk
        //    { '+', @"\+" }, // �Ӻ� plus sign
        //    { '-', @"\-" }, // ���� minus sign (hyphen)
        //    { '.', @"\." }, // �� dot
        //    { '<', @"\<" }, { '>', @"\>" }, // ������ 
        //    { '[', @"\[" }, { ']', @"\]" }, // ���� brackets
        //    { '\\', @"\\" }, // ��б�� backslash
        //    //{ '_', @"\_" }, // �»��� underscore
        //    { '`', @"\`" }, // ������ backtick
        //    { '{', @"\{" }, { '}', @"\}" }, // ������ curly braces
        //    { '|', @"\|" }, // �ܵ� pipe
        //    { '~', @"\~" }, // ������;
        //};
    }
}
