using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.WRLFormat
{
    public class WRLFile
    {
        public readonly float[] ambientColor = new float[3];
        public readonly float[] diffuseColor = new float[3];
        public readonly float[] emissiveColor = new float[3];
        public readonly float[] specularColor = new float[3];
        public readonly float shininess;
        public readonly float transparency;
        public readonly float[] points;
        public readonly int[] coordIndexes;

        public WRLFile(float[] ambientColor, float[] diffuseColor, float[] emissiveColor, float[] specularColor, float shininess, float transparency, float[] points, int[] coordIndexes)
        {
            this.ambientColor = ambientColor;
            this.diffuseColor = diffuseColor;
            this.emissiveColor = emissiveColor;
            this.specularColor = specularColor;
            this.shininess = shininess;
            this.transparency = transparency;
            this.points = points;
            this.coordIndexes = coordIndexes;
        }
    }
}
