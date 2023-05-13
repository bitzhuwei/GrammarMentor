using bitzhuwei.GrammarFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;

namespace bitzhuwei.PatternFormat {
    class RangeItem {
        public readonly char min;
        public readonly char max;
        public RangeItem(char min, char max) {
            if (min <= max) {
                this.min = min;
                this.max = max;
            }
            else {
                this.min = max;
                this.max = min;
            }
        }

        public string ToCondition() {
            if (min == max && min != '-') { return $"{min}"; }
            if (min + 1 == max) { return $"{min}{max}"; }
            else { return $"{min}-{max}"; }
        }

        public override string ToString() {
            if (min == max && min != '-') { return $"{min.regexAppear()}"; }
            if (min + 1 == max) { return $"{min.regexAppear()}{max.regexAppear()}"; }
            else { return $"{min.regexAppear()}-{max.regexAppear()}"; }
        }
    }
}