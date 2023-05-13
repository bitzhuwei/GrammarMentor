using bitzhuwei.Compiler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// Additive : Additive '+' Multiplicative ;
    /// </summary>
    public partial class VnRegulationDraft {
        /// <summary>
        /// Additive
        /// </summary>
        public readonly string left;
        /// <summary>
        /// Additive '+' Multiplicative
        /// </summary>
        //private List<string> m_right = new List<string>();
        private readonly string[] m_Right;
        /// <summary>
        /// an array of Vt and Vn.
        /// <para>There can be ZERO element.</para>
        /// <para>No <see cref="CompilerGrammar.keywordEmpty"/></para>
        /// </summary>
        public IReadOnlyList<string> Right { get { return this.m_Right; } }
        //public string RightNode(int index)
        //{
        //    return m_right[index];
        //}

        /// <summary>
        /// Additive : Additive '+' Multiplicative ;
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public VnRegulationDraft(string left, params string[] right) {
            if (right == null) { throw new ArgumentNullException($"{nameof(right)}"); }
            // if A : empty ; then right.Length is 0.
            //if (right.Length == 0) { throw new ArgumentException($"{nameof(right)}"); }
            // important check. don't remove this.
            foreach (var item in right) {
                if (item == CompilerGrammar.keywordEmpty) {
                    throw new Exception($"No {item} should appear in {nameof(Right)}");
                }
            }

            this.left = left;
            this.m_Right = right;
        }


        public void Print(TextWriter w) {
            w.Write(this.left); w.Write(" : ");
            var right = this.m_Right; var length = right.Length;
            //if (length > 0)
            //{
            //    for (int i = 0; i < length; i++)
            //    {
            //        w.Write(right[i]); w.Write(" ");
            //    }
            //}
            //else
            //{
            //    w.Write(CompilerGrammar.keywordEmpty); w.Write(" ");
            //}
            for (int i = 0; i < length; i++) {
                w.Write(right[i]); w.Write(" ");
            }
            w.Write(";");
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }

        //public int CompareTo(VnRegulationDraft other)
        //{
        //    if (other == null) { return 1; }

        //    {
        //        var value = left.CompareTo(m_Right);
        //        if (value != 0)
        //        {
        //            return value;
        //        }
        //    }

        //    int aCount = this.m_Right.Length;
        //    int bCount = other.m_Right.Length;
        //    if (aCount < bCount) { return -1; }
        //    else if (aCount > bCount) { return 1; }
        //    else
        //    {
        //        int result = 0;
        //        for (int i = 0; i < aCount; i++)
        //        {
        //            var a = this.m_Right[i];
        //            var b = other.m_Right[i];
        //            Debug.Assert(a != null && b != null);
        //            var value = a.CompareTo(b);
        //            if (value != 0)
        //            {
        //                result = value;
        //                break;
        //            }
        //        }

        //        return result;
        //    }
        //}
    }
}