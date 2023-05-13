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
    /// extracted info from syntax tree(<see cref="Node"/>).
    /// </summary>
    public partial class FinalValue {
        public float value;

        public FinalValue(float v) {
            this.value = v;
        }
    }
}
