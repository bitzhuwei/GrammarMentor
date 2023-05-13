using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    partial class LALR1State : IComparable<LALR1State> {
        // 指明此cache需要更新才能用。
        // faster comparing.
        private bool dirty = true;

        public static bool operator ==(LALR1State left, LALR1State right) {
            object leftObj = left, rightObj = right;
            if (leftObj == null) {
                if (rightObj == null) { return true; }
                else { return false; }
            }
            else {
                if (rightObj == null) { return false; }
            }

            return left.Equals(right);
        }

        public static bool operator !=(LALR1State left, LALR1State right) {
            return !(left == right);
        }

        public override bool Equals(object obj) {
            var p = obj as LALR1State;
            if ((System.Object)p == null) {
                return false;
            }

            return this.GetHashCode() == p.GetHashCode();
        }

        private int m_HashCode;
        public override int GetHashCode() {
            if (this.dirty) {
                this.m_HashCode = UpdateHashCode();

                this.dirty = false;
            }

            return this.m_HashCode;
        }

        const string separator = "#";
        private int UpdateHashCode() {
            var b = new StringBuilder();
            //foreach (var item in this.m_Items) {
            //    b.Append(item.VnRegulation.GetHashCode()); b.Append(Utility.hashCodeSeparator);
            //    b.Append(item.dotPosition); b.Append(Utility.hashCodeSeparator);
            //    // it's the core idea of LALR(1) to ignore item.lookAhead
            //}
            var groups = from item in this.m_Items
                         group item by new { item.VnRegulation, item.dotPosition } into g
                         orderby g.Key.VnRegulation, g.Key.dotPosition
                         select g;
            //var groups = from item in this.m_Items
            //             group item by new LALR1Key(item.VnRegulation, item.dotPosition) into g
            //             orderby g.Key
            //             select g;
            foreach (var item in groups) {
                var key = item.Key;
                b.Append(key.VnRegulation.GetHashCode()); b.Append(Utility.hashCodeSeparator);
                //b.Append(key.dotPosition.GetHashCode()); b.Append(Utility.hashCodeSeparator);
                b.Append(key.dotPosition); b.Append(Utility.hashCodeSeparator);
            }

            string str = b.ToString();
            int hashCode = str.GetHashCode();
            return hashCode;
        }

        public int CompareTo(LALR1State other) {
            if (other == null) { return 1; }

            // 如果用this.HashCode - other.HashCode < 0，就会发生溢出，这个bug让我折腾了近8个小时。
            var a = this.GetHashCode();
            var b = other.GetHashCode();
            if (a < b) { return -1; }
            else if (a > b) { return 1; }
            else { return 0; }
        }
    }

    class LALR1Key : IComparable<LALR1Key> {
        public readonly VnRegulationDraft VnRegulation;
        public readonly int dotPosition;
        public LALR1Key(VnRegulationDraft VnRegulation, int dotPosition) {
            this.VnRegulation = VnRegulation;
            this.dotPosition = dotPosition;
        }

        public override string ToString() {
            return $"{VnRegulation}, {dotPosition}";
        }

        // 指明此cache需要更新才能用。
        // faster comparing.
        private bool dirty = true;

        public static bool operator ==(LALR1Key left, LALR1Key right) {
            object leftObj = left, rightObj = right;
            if (leftObj == null) {
                if (rightObj == null) { return true; }
                else { return false; }
            }
            else {
                if (rightObj == null) { return false; }
            }

            return left.Equals(right);
        }

        public static bool operator !=(LALR1Key left, LALR1Key right) {
            return !(left == right);
        }

        public override bool Equals(object obj) {
            var p = obj as LALR1Key;
            if ((System.Object)p == null) {
                return false;
            }

            return this.GetHashCode() == p.GetHashCode();
        }

        private int m_HashCode;
        public override int GetHashCode() {
            if (this.dirty) {
                this.m_HashCode = UpdateHashCode();

                this.dirty = false;
            }

            return this.m_HashCode;
        }

        private int UpdateHashCode() {
            var b = new StringBuilder();
            b.Append(this.VnRegulation.GetHashCode()); b.Append(Utility.hashCodeSeparator);
            //b.Append(key.dotPosition.GetHashCode()); b.Append(Utility.hashCodeSeparator);
            b.Append(this.dotPosition); b.Append(Utility.hashCodeSeparator);

            string str = b.ToString();
            int hashCode = str.GetHashCode();
            return hashCode;
        }

        public int CompareTo(LALR1Key other) {
            if (other == null) { return 1; }

            // 如果用this.HashCode - other.HashCode < 0，就会发生溢出，这个bug让我折腾了近8个小时。
            var a = this.GetHashCode();
            var b = other.GetHashCode();
            if (a < b) { return -1; }
            else if (a > b) { return 1; }
            else { return 0; }
        }
    }
}
