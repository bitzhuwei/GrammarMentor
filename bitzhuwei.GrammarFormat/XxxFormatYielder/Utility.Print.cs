using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    static partial class Utility {
        private static readonly Dictionary<int, string> tabDict = new Dictionary<int, string>();
        public static void Tab(this TextWriter w, int tab) {
            if (!tabDict.TryGetValue(tab, out var result)) {
                var b = new StringBuilder();
                for (int i = 0; i < tab; i++) { b.Append(' '); }
                result = b.ToString();
                tabDict.Add(tab, result);
            }

            w.Write(result);
        }

        public static void Tab(this StringBuilder stringBuilder, int tab) {
            if (!tabDict.TryGetValue(tab, out var result)) {
                var b = new StringBuilder();
                for (int i = 0; i < tab; i++) { b.Append(' '); }
                result = b.ToString();
                tabDict.Add(tab, result);
            }

            stringBuilder.Append(result);
        }

        public static void PrintLine(this TextWriter w, int tab, string value) {
            if (tab > 0) { Tab(w, tab); }
            w.Write(value); w.WriteLine();
        }

        public static void Print(this TextWriter w, int tab, string value) {
            if (tab > 0) { Tab(w, tab); }
            w.Write(value);
        }

        public static void PrintLine(this StringBuilder w, int tab, string value) {
            if (tab > 0) { Tab(w, tab); }
            w.Append(value); w.AppendLine();
        }

        public static void Print(this StringBuilder w, int tab, string value) {
            if (tab > 0) { Tab(w, tab); }
            w.Append(value);
        }
    }
}