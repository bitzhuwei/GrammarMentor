using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat {
    /// <summary>
    /// Correspond to the Vn node Multiplicative in the grammar(Calc).
    /// </summary>
    public partial class Multiplicative {
        public float value;

        public Multiplicative(float v) {
            this.value = v;
        }
    }
}
