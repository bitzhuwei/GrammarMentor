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
    public class FinalValue {
        public readonly float value;

        public FinalValue(float value) {
            this.value = value;
        }
    }
}
