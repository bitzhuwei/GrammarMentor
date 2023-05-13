using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitzhuwei.GrammarFormat.Winform {
    partial class Test {

        // Control: 0-31, 127
        // 魑魅魍魉
        // '\t'(09, '\u0009')魉(占'两'个字符的宽度)         is control.
        // '\n'(10, '\u000A')魍(往，行)                   is control.
        // '\r'(13, '\u000D')魅(Linux换行里'没'它)         is control.
        // ' ' (32, '\u0020')魑(吃饭去了，只见其座，不见其身) is not control.
        /// <summary>
        /// 
        /// </summary>
        public static void ControlASCII() {
            using (var w = new StreamWriter("ControlASCII.txt")) {
                for (int i = 0; i < 128; i++) {
                    char c = (char)i;
                    var result = Char.IsControl(c) ? "Control" : "Not Control";
                    w.WriteLine($"[{i}]:{result} | [{c}]");
                }
            }
        }
        public static void UnicodeToMermaid() {
            using (var w = new StreamWriter("Unicode2Mermaid.txt", false, System.Text.Encoding.Unicode)) {
                int counter = 0;
                for (int i = char.MinValue; i <= char.MaxValue; i++) {
                    try {
                        char c = (char)i;
                        if (!char.IsControl(c)) {
                            var line = $"[{c}]#{i};";
                            w.Write(line);
                            counter++;
                        }
                        if (counter >= 15) {
                            w.WriteLine();
                            counter = 0;
                        }
                    }
                    catch (Exception ex) {
                        w.WriteLine(ex.Message);
                    }
                }
            }
        }
        public static void ControlChars() {
            using (var w = new StreamWriter("ControlChars.txt", false, System.Text.Encoding.Unicode)) {
                int counter = 0;
                for (int i = char.MinValue; i <= char.MaxValue; i++) {
                    try {
                        char c = (char)i;
                        if (char.IsControl(c)) {
                            var line = $"[{c}]#{i};";
                            w.Write(line);
                            counter++;
                        }
                        if (counter >= 15) {
                            w.WriteLine();
                            counter = 0;
                        }
                    }
                    catch (Exception ex) {
                        w.WriteLine(ex.Message);
                    }
                }
            }
        }

        public static void Regex() {
            var regex = new Regex(
@"[]x]]" // same with [\]x]] ???
         //@"[x]]]" matches x]]
);
            regex = new Regex(
@"^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,10}$");
            string x = "1abdABCD";
            var y = regex.Match(x);
            var content = @"a[]x]";
            var match = regex.Match(content);
            Console.WriteLine(match);


        }
        public static void EscapeCharacter() {
            char x = '\0';
            char x1 = '\u0009';
            char x2 = '\u0000';
            Console.WriteLine(x);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            var matchingChar = '\r';
            //var hex = Convert.ToString(matchingChar, 16);
            //hex = hex.PadLeft(4, '0');
            var hex = string.Format(@"\u{0:X4}", (int)matchingChar);
            Console.WriteLine(hex);

        }
    }
}
