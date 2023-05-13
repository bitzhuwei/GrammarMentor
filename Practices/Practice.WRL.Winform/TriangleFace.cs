using CSharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice.WRL.Winform
{
    [StructLayout(LayoutKind.Explicit)]
    public struct TriangleFace
    {
        /// <summary>
        /// x = r = s
        /// </summary>
        [FieldOffset(sizeof(uint) * 0)]
        public uint index0;

        /// <summary>
        /// y = g = t
        /// </summary>
        [FieldOffset(sizeof(uint) * 1)]
        public uint index1;

        /// <summary>
        /// z = b = p
        /// </summary>
        [FieldOffset(sizeof(uint) * 2)]
        public uint index2;

        public TriangleFace(uint index0, uint index1, uint index2)
        {
            this.index0 = index0;
            this.index1 = index1;
            this.index2 = index2;
        }

        public override string ToString()
        {
            return $"{index0}, {index1}, {index2}";
        }
    }

}
