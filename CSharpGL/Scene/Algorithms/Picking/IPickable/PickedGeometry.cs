using System.Text;

namespace CSharpGL {
    /// <summary>
    /// The color-coded picking result.
    /// <para>Representing a primitive.</para>
    /// </summary>
    public class PickedGeometry : IPickedGeometry {
        ///// <summary>
        ///// This geometry is picked from which view port?
        ///// </summary>
        //public ViewPort FromViewPort { get; set; }

        /// <summary>
        ///
        /// </summary>
        public string ErrorInfo { get; set; }

        /// <summary>
        /// Where mouse points.(Window space position)
        /// </summary>
        public vec3 PickedPosition { get; set; }

        /// <summary>
        /// Gets or sets primitive's geometry type.
        /// </summary>
        public GeometryType Type { get; set; }

        /// <summary>
        /// Gets or sets positions of this primitive's vertices.
        /// </summary>
        public vec3[] Positions { get; set; }

        /// <summary>
        /// Gets or sets indexes of this primitive's vertexes' index in the VBO.
        /// </summary>
        public uint[] VertexIds { get; set; }

        /// <summary>
        /// The last vertex's id that constructs the picked primitive.
        /// <para>This id is in scene's all <see cref="IPickable"/>s' order.</para>
        /// </summary>
        public uint StageVertexId { get; set; }

        /// <summary>
        /// The node that this picked primitive belongs to.
        /// </summary>
        public virtual IPickable FromObject { get; set; }

        //public PickedGeometry() { }
        /// <summary>
        /// The color-coded picking result.
        /// <para>Representing a primitive(point, line, triangle, quad, polygon).</para>
        /// </summary>
        /// <param name="geometryType"></param>
        /// <param name="positions"></param>
        /// <param name="vertexIds"></param>
        /// <param name="stageVertexId"></param>
        /// <param name="fromRenderer"></param>
        public PickedGeometry(GeometryType geometryType, vec3[] positions, uint[] vertexIds, uint stageVertexId, IPickable fromRenderer) {
            this.Type = geometryType;
            this.Positions = positions;
            this.VertexIds = vertexIds;
            this.StageVertexId = stageVertexId;
            this.FromObject = fromRenderer;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="projection"></param>
        /// <param name="view"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string ToString(mat4 projection, mat4 view, mat4 model) {
            StringBuilder b = BasicInfo();
            b.AppendLine();

            vec3[] positions = this.Positions;
            if (positions == null) { positions = new vec3[0]; }
            uint[] indexes = this.VertexIds;
            var worldSpacePos = new vec4[positions.Length];
            var viewPos = new vec4[positions.Length];
            var projectionPos = new vec4[positions.Length];
            var normalizedPos = new vec3[positions.Length];
            var screenPos = new vec3[positions.Length];

            b.Append("Positions in World Space:");
            b.AppendLine();

            for (int i = 0; i < positions.Length; i++) {
                var pos4 = new vec4(positions[i], 1);
                worldSpacePos[i] = model * pos4;
                b.Append("BigBuffer["); b.Append(indexes[i]); b.Append("]: ");
                b.Append(worldSpacePos[i]);
                b.AppendLine();
            }

            b.Append("Positions in Camera/View Space:");
            b.AppendLine();

            for (int i = 0; i < positions.Length; i++) {
                var pos4 = new vec4(positions[i], 1);
                viewPos[i] = view * worldSpacePos[i];
                b.Append('['); b.Append(indexes[i]); b.Append("]: ");
                b.Append(viewPos[i]);
                b.AppendLine();
            }
            b.Append("Positions in Projection Space:");
            b.AppendLine();
            for (int i = 0; i < positions.Length; i++) {
                projectionPos[i] = projection * viewPos[i];
                b.Append('['); b.Append(indexes[i]); b.Append("]: ");
                b.Append(projectionPos[i]);
                b.AppendLine();
            }
            b.Append("Positions in Normalized Space:");
            b.AppendLine();
            for (int i = 0; i < positions.Length; i++) {
                b.Append('['); b.Append(indexes[i]); b.Append("]: ");
                normalizedPos[i] = new vec3(projectionPos[i] / projectionPos[i].w);
                b.Append(normalizedPos[i]);
                b.AppendLine();
            }
            b.Append("Positions in Screen Space:");
            b.AppendLine();
            var viewport = new int[4];
            GL.Instance.GetIntegerv((uint)GetTarget.Viewport, viewport);
            int x = viewport[0], y = viewport[1], width = viewport[2], height = viewport[3];
            var depthRange = new float[4];
            GL.Instance.GetFloatv((uint)GetTarget.DepthRange, depthRange);
            float near = depthRange[0], far = depthRange[1];
            for (int i = 0; i < positions.Length; i++) {
                b.Append('['); b.Append(indexes[i]); b.Append("]: ");
                screenPos[i] = new vec3(
                    normalizedPos[i].x * width / 2 + (x + width / 2),
                    normalizedPos[i].y * height / 2 + (y + height / 2),
                    normalizedPos[i].z * (far - near) / 2 + ((far + near) / 2)
                    );
                b.Append(screenPos[i]);
                b.AppendLine();
            }

            return b.ToString();
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            StringBuilder b = BasicInfo();

            return b.ToString();
        }

        /// <summary>
        /// Getx pixel data from <paramref name="stageVertexId"/>.
        /// </summary>
        /// <param name="stageVertexId"></param>
        /// <returns></returns>
        private static Pixel FromStageVertexId(uint stageVertexId) {
            byte r = (byte)(stageVertexId & 0xFF);
            byte g = (byte)((stageVertexId >> 8) & 0xFF);
            byte b = (byte)((stageVertexId >> 16) & 0xFF);
            byte a = (byte)((stageVertexId >> 24) & 0xFF);

            return new Pixel(r, g, b, a);
        }

        private StringBuilder BasicInfo() {
            var b = new StringBuilder();

            b.AppendFormat("Stage Vertex ID: {0}", this.StageVertexId);
            b.AppendLine();
            b.AppendFormat("Color: vec4({0})", FromStageVertexId(this.StageVertexId));
            b.AppendLine();
            b.AppendFormat("From: {0}", this.FromObject);
            b.AppendLine();

            if (!string.IsNullOrEmpty(this.ErrorInfo)) {
                b.AppendLine("Error:");
                b.AppendLine(this.ErrorInfo);
            }

            b.AppendFormat("Geometry Type: {0}", this.Type);
            b.AppendLine();

            vec3[] positions = this.Positions;
            if (positions == null) { positions = new vec3[0]; }
            uint[] indexes = this.VertexIds;

            b.Append("Positions in Model Space:");
            b.AppendLine();
            for (int i = 0; i < positions.Length; i++) {
                b.Append("BigBuffer["); b.Append(indexes[i]); b.Append("]: ");
                b.Append(positions[i]);
                if (i + 1 < positions.Length) {
                    b.AppendLine();
                }
            }

            return b;
        }
    }
}