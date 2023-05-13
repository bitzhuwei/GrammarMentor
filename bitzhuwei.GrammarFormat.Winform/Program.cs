using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitzhuwei.GrammarFormat.Winform {
    internal static class Program {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {

            //Test.PrintVtRegex(); return;
            //Test.Regex();
            //Test.ControlChars(); return;
            //Test.UnicodeToMermaid(); return;
            //Test.EscapeCharacter(); return;
            //Test.ControlASCII(); return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGrammarFormat());
        }
    }
}
