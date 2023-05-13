using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {

    partial class StateSign : IComparable<StateSign> {
        // 指明此cache需要更新才能用。
        // faster comparing.
        private bool dirty = true;

        public static bool operator ==(StateSign left, StateSign right) {
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

        public static bool operator !=(StateSign left, StateSign right) {
            return !(left == right);
        }

        public override bool Equals(object obj) {
            var p = obj as StateSign;
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
            //var b = new StringBuilder();
            //b.Append(this.isBegin); b.Append(Utility.hashCodeSeparator);
            //b.Append(this.isEnd); b.Append(Utility.hashCodeSeparator);
            //b.Append(this.isCheck); b.Append(Utility.hashCodeSeparator);
            //b.Append(this.isAccept); b.Append(Utility.hashCodeSeparator);

            //string str = b.ToString();
            //int hashCode = str.GetHashCode();
            //return hashCode;
            if (this.isBegin) { // 1xxx
                if (this.isEnd) { // 11xx
                    if (this.isCheck) { // 111x
                        if (this.isAccept) { return 0x1111; }
                        else { return 0x1110; }
                    }
                    else { // 110x
                        if (this.isAccept) { return 0x1101; }
                        else { return 0x1100; }
                    }
                }
                else { // 10xx
                    if (this.isCheck) { // 101x
                        if (this.isAccept) { return 0x1011; }
                        else { return 0x1010; }
                    }
                    else { // 100x
                        if (this.isAccept) { return 0x1001; }
                        else { return 0x1000; }
                    }
                }
            }
            else { // 0xxx
                if (this.isEnd) { // 01xx
                    if (this.isCheck) { // 011x
                        if (this.isAccept) { return 0x0111; }
                        else { return 0x0110; }
                    }
                    else { // 010x
                        if (this.isAccept) { return 0x0101; }
                        else { return 0x0100; }
                    }
                }
                else { // 00xx
                    if (this.isCheck) { // 001x
                        if (this.isAccept) { return 0x0011; }
                        else { return 0x0010; }
                    }
                    else { // 000x
                        if (this.isAccept) { return 0x0001; }
                        else { return 0x0000; }
                    }
                }
            }
        }

        public int CompareTo(StateSign other) {
            if (other == null) { return 1; }

            // 如果用this.HashCode - other.HashCode < 0，就会发生溢出，这个bug让我折腾了近8个小时。
            //var a = this.GetHashCode();
            //var b = other.GetHashCode();
            //if (a < b) { return -1; }
            //else if (a > b) { return 1; }
            //else { return 0; }
            if (this.isBegin != other.isBegin) {
                if (!this.isBegin) { return -1; }
                else { return 1; }
            }
            else if (this.isEnd != other.isEnd) {
                if (!this.isEnd) { return -1; }
                else { return 1; }
            }
            else if (this.isCheck != other.isCheck) {
                if (!this.isCheck) { return -1; }
                else { return 1; }
            }
            else if (this.isAccept != other.isAccept) {
                if (!this.isAccept) { return -1; }
                else { return 1; }
            }
            else { return 0; }
        }
    }
}