using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// FOLLOW( Vn ) = All possible Vt nodes(empty is not Vt) that follows Vn(next to Vn).
    /// </summary>
    public class FOLLOW {
        /// <summary>
        /// FOLLOW( Vn ) = All possible Vt nodes(empty is not Vt) that follows Vn(next to Vn).
        /// </summary>
        /// <param name="Vn"></param>
        /// <param name="values">All possible Vt nodes(empty is not Vt) that follows Vn(next to Vn)</param>
        public FOLLOW(string/*Node.type*/ Vn, params string/*Node.type*/[] values) {
            this.Vn = Vn;
            if (values != null) {
                foreach (var item in values) {
                    this.m_Values.TryInsert(item);
                }
            }
        }

        public readonly string/*Node.type*/ Vn;

        private CoupleList<string/*Node.type*/> m_Values = new CoupleList<string/*Node.type*/>();

        public IReadOnlyList<string/*Node.type*/> Values { get { return this.m_Values; } }

        public bool TryInsert(string/*Node.type*/ value) {
            var inserted = this.m_Values.TryInsert(value);

            return inserted;
        }

        public void Print(System.IO.TextWriter stream) {
            stream.Write("FOLLOW( "); stream.Write(this.Vn); stream.Write(" ) = { ");
            var count = this.m_Values.Count;
            for (int i = 0; i < count; i++) {
                var value = this.m_Values[i];
                stream.Write(value);
                stream.Write(" ");
            }
            stream.Write("}");
        }

        public override string ToString() {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                this.Print(w);
            }

            return b.ToString();
        }
    }
}
