using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {

    partial class StateSign {

        /// <summary>
        /// classDef name attribute:value, .. ;
        /// </summary>
        /// <param name="w"></param>
        public static void PrintClassDefs(TextWriter w) {
            foreach (var item in sign2NameDict) {
                var sign = item.Key; var className = item.Value;
                var list = sign.GetStyleList();
                var count = list.Count;
                if (count > 0) {
                    w.Write($"classDef {className} ");
                    for (int i = 0; i < count - 1; i++) { w.Write(list[i]); w.Write(","); }
                    { w.Write(list[count - 1]); w.Write(";"); }
                    w.WriteLine();
                }
            }
        }

        private static string ClassName(StateSign stateSign) {
            if (sign2NameDict.TryGetValue(stateSign, out var className)) {
                return className;
            }
            else {
                return string.Empty;
            }
        }

        private void PrintClass(TextWriter w, eNFAStateDraft state) {
            var className = ClassName(this);
            if (!string.IsNullOrEmpty(className)) {
                w.Write($"class "); state.PrintId(w); w.Write($" {className};"); w.WriteLine();
            }
        }

        private void PrintClass(TextWriter w, NFAStateDraft state) {
            var className = ClassName(this);
            if (!string.IsNullOrEmpty(className)) {
                w.Write($"class "); state.PrintId(w); w.Write($" {className};"); w.WriteLine();
            }
        }

        private void PrintClass(TextWriter w, NFAStateDraft state, string id) {
            var className = ClassName(this);
            if (!string.IsNullOrEmpty(className)) {
                w.Write($"class "); w.Write(id); w.Write($" {className};"); w.WriteLine();
            }
        }

        private void PrintClass(TextWriter w, DFAStateDraft state) {
            var className = ClassName(this);
            if (!string.IsNullOrEmpty(className)) {
                w.Write($"class "); state.PrintId(w); w.Write($" {className};"); w.WriteLine();
            }
        }

        private void PrintClass(TextWriter w, DFAStateDraft state, string id) {
            var className = ClassName(this);
            if (!string.IsNullOrEmpty(className)) {
                w.Write($"class "); w.Write(id); w.Write($" {className};"); w.WriteLine();
            }
        }

        private void PrintClass(TextWriter w, MiniDFAStateDraft state) {
            var className = ClassName(this);
            if (!string.IsNullOrEmpty(className)) {
                w.Write($"class "); state.PrintId(w); w.Write($" {className};"); w.WriteLine();
            }
        }
    }
}