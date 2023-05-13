using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace bitzhuwei.StepFormat
{
    static partial class Utility
    {
        private static readonly Dictionary<int, string> tabDict = new Dictionary<int, string>();
        public static void PrintTab(this TextWriter w, int tab)
        {
            if (!tabDict.TryGetValue(tab, out string result))
            {
                var b = new StringBuilder();
                for (int i = 0; i < tab; i++) { b.Append(' '); }
                result = b.ToString();
                tabDict.Add(tab, result);
            }

            w.Write(result);
        }
    }
}