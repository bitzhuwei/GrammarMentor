using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.CalcFormat
{
    /// <summary>
    /// Correspond to the Vn node Additive in the grammar(Calc).
    /// </summary>
    public class Additive
    {
        public readonly float value;

        public Additive(float value)
        {
            this.value = value;
        }
    }
}
