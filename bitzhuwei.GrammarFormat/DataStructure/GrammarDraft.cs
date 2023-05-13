using bitzhuwei.Compiler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// input for generating source code of compiler.
    /// </summary>
    public partial class GrammarDraft {
        /// <summary>
        /// list of 
        /// <para>Additive : Additive '+' Multiplicative ;</para>
        /// </summary>
        public readonly VnRegulationDraft[] VnRegulations;
        /// <summary>
        /// list of 
        /// <para>'xxx': %...% ;</para>
        /// </summary>
        public readonly VtPatternDraft[] VtPatterns;

        /// <summary>
        /// input for generating source code of compiler.
        /// </summary>
        /// <param name="VnRegulations">list of <para>Additive : Additive '+' Multiplicative ;</para></param>
        /// <param name="VtPatterns">list of <para>'xxx', %...% ;</para></param>
        /// <exception cref="ArgumentNullException"></exception>
        public GrammarDraft(VnRegulationDraft[] VnRegulations, VtPatternDraft[] VtPatterns) {
            if (VnRegulations == null) { throw new ArgumentNullException($"{nameof(VnRegulations)}"); }
            if (VtPatterns == null) { throw new ArgumentNullException($"{nameof(VtPatterns)}"); }
            if (VnRegulations.Length == 0) { throw new ArgumentException("At least one element.", $"{nameof(VnRegulations)}"); }
            //if (rootNode == null) { throw new ArgumentNullException($"{nameof(rootNode)}"); }
            //if (tokens == null) { throw new ArgumentNullException($"{nameof(tokens)}"); }

            this.VnRegulations = VnRegulations;
            this.VtPatterns = VtPatterns;
        }

        public string Print() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        public void Print(TextWriter w) {
            {
                /* Vn : ...
                 *    | ...
                 *    | ... ;
                 */
                var VnRegulations = this.VnRegulations;
                var query = from item in VnRegulations group item by item.left into g select g;
                int globalIndex = 0;
                w.WriteLine($"// {VnRegulations.Length} VnRegulations:");
                foreach (var group in query) {
                    int groupIndex = 0;
                    var left = group.Key;
                    var length = left.Length + 1;
                    int candidateCount = group.Count();
                    foreach (var regulation in group) {
                        if (groupIndex == 0) {
                            w.Write(left); w.Write(" : ");
                        }
                        else {
                            //Utility.Tab(w, length); w.Write("| ");
                            w.Print(tab: length, "| ");
                        }

                        if (regulation.Right.Count > 0) {
                            foreach (var V in regulation.Right) {
                                w.Write(V); w.Write(" ");
                            }
                        }
                        else {
                            w.Write(CompilerGrammar.keywordEmpty); w.Write(" ");
                        }

                        if (groupIndex + 1 < candidateCount) {
                            w.Write($"// [{globalIndex}]"); w.WriteLine();
                        }
                        else {
                            w.Write($"; // [{globalIndex}]"); w.WriteLine();
                        }

                        globalIndex++; groupIndex++;
                    }
                }
            }
            {
                /* Vn : ... ;
                   Vn : ... ;
                   Vn : ... ;
                 */
                //var VnRegulations = this.VnRegulations;
                //w.WriteLine($"// {VnRegulations.Length} VnRegulations:");
                //for (int i = 0; i < VnRegulations.Length; i++)
                //{
                //    VnRegulations[i].Print(w); w.WriteLine($" // R[{i}]");
                //}
            }
            {
                /* Vt : %%...%% ;
                 */
                var VtPatterns = this.VtPatterns;
                w.WriteLine($"// {VtPatterns.Length} VtPatterns:");
                for (int i = 0; i < VtPatterns.Length; i++) {
                    VtPatterns[i].Print(w); w.WriteLine($" // [{i}]");
                }
            }
        }

        public override string ToString() {
            return $"{VnRegulations.Length} VnRegulations, {VtPatterns.Length} VtPatterns";
        }
    }
}