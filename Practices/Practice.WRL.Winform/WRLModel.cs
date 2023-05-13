using bitzhuwei.WRLFormat;
using CSharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.WRL.Winform {
    unsafe class WRLModel : IBufferSource {

        public readonly vec3 modelSize;
        public readonly vec3 initialPosition;
        public readonly vec3 ambientColor;
        public readonly vec3 diffuseColor;
        public readonly vec3 emissiveColor;
        public readonly vec3 specularColor;
        public readonly float shininess;
        public readonly float transparency;

        private readonly float[] positions;
        private readonly float[] normals;
        private readonly uint[] faces;

        public WRLModel(WRLFile wrlFile) {
            this.ambientColor = new vec3(wrlFile.ambientColor[0], wrlFile.ambientColor[1], wrlFile.ambientColor[2]);
            this.diffuseColor = new vec3(wrlFile.diffuseColor[0], wrlFile.diffuseColor[1], wrlFile.diffuseColor[2]);
            this.emissiveColor = new vec3(wrlFile.emissiveColor[0], wrlFile.emissiveColor[1], wrlFile.emissiveColor[2]);
            this.specularColor = new vec3(wrlFile.specularColor[0], wrlFile.specularColor[1], wrlFile.specularColor[2]);
            this.shininess = wrlFile.shininess;
            this.transparency = wrlFile.transparency;
            var pinned0 = GCHandle.Alloc(wrlFile.points, GCHandleType.Pinned);
            IntPtr handle0 = pinned0.AddrOfPinnedObject();
            var pPositions = (vec3*)handle0;
            int count = wrlFile.points.Length / 3;
            float minX, minY, minZ, maxX, maxY, maxZ;
            minX = pPositions[0].x;
            minY = pPositions[0].y;
            minZ = pPositions[0].z;
            maxX = pPositions[0].x;
            maxY = pPositions[0].y;
            maxZ = pPositions[0].z;
            for (int i = 0; i < count; i++) {
                var p = pPositions[i];
                if (p.x < minX) { minX = p.x; }
                if (p.y < minY) { minY = p.y; }
                if (p.z < minZ) { minZ = p.z; }
                if (maxX < p.x) { maxX = p.x; }
                if (maxY < p.y) { maxY = p.y; }
                if (maxZ < p.z) { maxZ = p.z; }
            }
            pinned0.Free();

            this.initialPosition = new vec3((maxX + minX) / 2, (maxY + minY) / 2, (maxZ + minZ) / 2);
            this.modelSize = new vec3(maxX - minX, maxY - minY, maxZ - minZ);

            this.positions = new float[wrlFile.points.Length];
            for (int i = 0; i < wrlFile.points.Length / 3; i++) {
                this.positions[i * 3 + 0] = wrlFile.points[i * 3 + 0] - this.initialPosition.x;
                this.positions[i * 3 + 1] = wrlFile.points[i * 3 + 1] - this.initialPosition.y;
                this.positions[i * 3 + 2] = wrlFile.points[i * 3 + 2] - this.initialPosition.z;
            }

            this.faces = new uint[wrlFile.coordIndexes.Length * 3 / 4];
            for (int i = 0; i < this.faces.Length / 3; i++) {
                this.faces[i * 3 + 0] = (uint)wrlFile.coordIndexes[i * 4 + 0];
                this.faces[i * 3 + 1] = (uint)wrlFile.coordIndexes[i * 4 + 1];
                this.faces[i * 3 + 2] = (uint)wrlFile.coordIndexes[i * 4 + 2];
            }
            for (int i = 0; i < this.faces.Length; i++) {
                if (this.faces[i] >= this.positions.Length / 3) {
                    Console.WriteLine();
                }
            }
            this.normals = NormalHelper.CalcNormal(wrlFile.points, this.faces);

        }


        public const string strPosition = "position";
        private VertexBuffer positionBuffer;
        public const string strNormal = "normal";
        private VertexBuffer normalBuffer;
        public const string strTangent = "tangent";
        private VertexBuffer tangentBuffer;

        private IDrawCommand drawCmd;

        public IEnumerable<VertexBuffer> GetVertexAttribute(string bufferName) {
            if (bufferName == strPosition) {
                if (this.positionBuffer == null) {
                    this.positionBuffer = positions.GenVertexBuffer(VBOConfig.Vec3, BufferUsage.StaticDraw);
                }

                yield return this.positionBuffer;
            }
            else if (bufferName == strNormal) {
                if (this.normalBuffer == null) {
                    this.normalBuffer = normals.GenVertexBuffer(VBOConfig.Vec3, BufferUsage.StaticDraw);
                }

                yield return this.normalBuffer;
            }
            else {
                throw new ArgumentException("bufferName");
            }
        }

        public IEnumerable<IDrawCommand> GetDrawCommand() {
            if (this.drawCmd == null) {
                IndexBuffer buffer = this.faces.GenIndexBuffer(BufferUsage.StaticDraw);

                this.drawCmd = new DrawElementsCmd(buffer, CSharpGL.DrawMode.Triangles);
            }
            yield return this.drawCmd;
        }

    }
}
