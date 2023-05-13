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
    /// Correspond to the Vn node Primary in the grammar(Calc).
    /// </summary>
    public class Primary
    {
        public readonly float value;

        public Primary(float value)
        {
            this.value = value;
        }
    }
}
