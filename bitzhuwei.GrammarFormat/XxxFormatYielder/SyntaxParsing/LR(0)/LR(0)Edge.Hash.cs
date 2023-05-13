﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    partial class LR0Edge : IComparable<LR0Edge> {
        // 指明此cache需要更新才能用。
        // faster comparing.
        private bool dirty = true;

        public static bool operator ==(LR0Edge left, LR0Edge right) {
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

        public static bool operator !=(LR0Edge left, LR0Edge right) {
            return !(left == right);
        }

        public override bool Equals(object obj) {
            var p = obj as LR0Edge;
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
            b.Append(this.from.GetHashCode()); b.Append(Utility.hashCodeSeparator);
            b.Append(this.V); b.Append(Utility.hashCodeSeparator);
            b.Append(this.to.GetHashCode()); b.Append(Utility.hashCodeSeparator);

            string str = b.ToString();
            int hashCode = str.GetHashCode();
            return hashCode;
        }

        public int CompareTo(LR0Edge other) {
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
