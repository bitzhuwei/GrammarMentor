using CSharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.WRL.Winform
{
    public static partial class NormalHelper
    {
        /// <summary>
        /// Calculate normals for triangles.
        /// </summary>
        /// <param name="positions">{ x0, y0, z0, x1, y1, z1, ... }</param>
        /// <param name="faceIndexes">{ f0.x, f0.y, f0.z, f1.x, f1.y, f1.z ... }</param>
        /// <returns></returns>
        public unsafe static float[] CalcNormal(this float[] positions, uint[] faceIndexes)
        {
            int faceCount = faceIndexes.Length / 3;

            int positionCount = positions.Length / 3;

            var faceNormals = new vec3[faceCount];
            for (int i = 0; i < faceCount; i++)
            {
                uint i0 = faceIndexes[i * 3 + 0];
                uint i1 = faceIndexes[i * 3 + 1];
                uint i2 = faceIndexes[i * 3 + 2];
                vec3 v0 = new vec3(positions[i0 * 3 + 0], positions[i0 * 3 + 1], positions[i0 * 3 + 2]);
                vec3 v1 = new vec3(positions[i1 * 3 + 0], positions[i1 * 3 + 1], positions[i1 * 3 + 2]);
                vec3 v2 = new vec3(positions[i2 * 3 + 0], positions[i2 * 3 + 1], positions[i2 * 3 + 2]);

                vec3 normal = (v0 - v1).cross(v0 - v2).normalize();
                faceNormals[i] = normal;
            }

            var normals = new vec3[positionCount];
            var counters = new int[positionCount];
            for (int i = 0; i < faceCount; i++)
            {
                uint i0 = faceIndexes[i * 3 + 0];
                uint i1 = faceIndexes[i * 3 + 1];
                uint i2 = faceIndexes[i * 3 + 2];

                normals[i0] += faceNormals[i];
                counters[i0]++;
                normals[i1] += faceNormals[i];
                counters[i1]++;
                normals[i2] += faceNormals[i];
                counters[i2]++;
            }
            for (int i = 0; i < positionCount; i++)
            {
                if (counters[i] > 0)
                {
                    //normals[i] = reverseNormal ? -normals[i].normalize() : normals[i].normalize();
                    normals[i] = normals[i].normalize();
                }
            }

            var result = new float[positionCount * 3];
            for (int i = 0; i < positionCount; i++)
            {
                result[i * 3 + 0] = normals[i].x;
                result[i * 3 + 1] = normals[i].y;
                result[i * 3 + 2] = normals[i].z;
            }

            return result;
        }
    }
}
