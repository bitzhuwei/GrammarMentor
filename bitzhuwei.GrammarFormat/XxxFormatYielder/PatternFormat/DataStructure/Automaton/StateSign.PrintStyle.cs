using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {

    partial class StateSign {

        private void PrintStyle(TextWriter w, eNFAStateDraft state) {
            var list = GetStyleList();
            var count = list.Count;
            if (count > 0) {
                w.Write($"style "); state.PrintId(w); w.Write(" ");
                for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                { w.Write(list[count - 1]); }
                w.WriteLine();
            }
        }

        private void PrintStyle(TextWriter w, NFAStateDraft state) {
            var list = GetStyleList();
            var count = list.Count;
            if (count > 0) {
                w.Write($"style "); state.PrintId(w); w.Write(" ");
                for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                { w.Write(list[count - 1]); }
                w.WriteLine();
            }
        }

        private void PrintStyle(TextWriter w, NFAStateDraft state, string id) {
            var list = GetStyleList();
            var count = list.Count;
            if (count > 0) {
                w.Write($"style "); w.Write(id); w.Write(" ");
                for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                { w.Write(list[count - 1]); }
                w.WriteLine();
            }
        }

        private void PrintStyle(TextWriter w, DFAStateDraft state) {
            var list = GetStyleList();
            var count = list.Count;
            if (count > 0) {
                w.Write($"style "); state.PrintId(w); w.Write(" ");
                for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                { w.Write(list[count - 1]); }
                w.WriteLine();
            }
        }

        private void PrintStyle(TextWriter w, DFAStateDraft state, string id) {
            var list = GetStyleList();
            var count = list.Count;
            if (count > 0) {
                w.Write($"style "); w.Write(id); w.Write(" ");
                for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                { w.Write(list[count - 1]); }
                w.WriteLine();
            }
        }

        private void PrintStyle(TextWriter w, MiniDFAStateDraft state) {
            var list = GetStyleList();
            var count = list.Count;
            if (count > 0) {
                w.Write($"style "); state.PrintId(w); w.Write(" ");
                for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                { w.Write(list[count - 1]); }
                w.WriteLine();
            }
        }
    }
}