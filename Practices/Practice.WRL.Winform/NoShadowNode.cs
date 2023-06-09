﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CSharpGL;

namespace Practice.WRL.Winform
{
    partial class NoShadowNode : ModernNode, IBlinnPhong
    {
        public static NoShadowNode Create(IBufferSource model, string position, string normal, vec3 size)
        {
            RenderMethodBuilder ambientBuilder, blinnPhongBuilder;
            {
                var ambientVert = File.ReadAllText(@"ambient.vert");
                var vs = new VertexShader(ambientVert);
                var ambientFrag = File.ReadAllText(@"ambient.frag");
                var fs = new FragmentShader(ambientFrag);
                var array = new ShaderArray(vs, fs);
                var map = new AttributeMap();
                map.Add("inPosition", position);
                ambientBuilder = new RenderMethodBuilder(array, map);
            }
            {
                var blinnPhongVert = File.ReadAllText(@"blinnPhong.vert");
                var vs = new VertexShader(blinnPhongVert);
                var blinnPhongFrag = File.ReadAllText(@"blinnPhong.frag");
                var fs = new FragmentShader(blinnPhongFrag);
                var array = new ShaderArray(vs, fs);
                var map = new AttributeMap();
                map.Add("inPosition", position);
                map.Add("inNormal", normal);
                blinnPhongBuilder = new RenderMethodBuilder(array, map);
            }

            var node = new NoShadowNode(model, ambientBuilder, blinnPhongBuilder);
            node.Initialize();
            node.ModelSize = size;

            return node;
        }

        private NoShadowNode(IBufferSource model, params RenderMethodBuilder[] builders)
            : base(model, builders)
        {
            //this.Color = new vec3(1, 1, 1);
            //this.Shiness = 32;
            this.BlinnPhong = true;
        }

        #region IBlinnPhong 成员

        private ThreeFlags enableRendering = ThreeFlags.BeforeChildren | ThreeFlags.Children;
        public ThreeFlags EnableRendering { get { return this.enableRendering; } set { this.enableRendering = value; } }

        public void RenderAmbientColor(BlinnPhongAmbientEventArgs arg)
        {
            ICamera camera = arg.Camera;
            mat4 projection = camera.GetProjectionMatrix();
            mat4 view = camera.GetViewMatrix();
            mat4 model = this.GetModelMatrix();

            RenderMethod method = this.RenderUnit.Methods[0];
            ShaderProgram program = method.Program;
            program.SetUniform("mvpMat", projection * view * model);
            program.SetUniform("ambientColor", this.ambientColor * 0.2f);// arg.Ambient);

            method.Render();
        }

        public void RenderBeforeChildren(RenderEventArgs arg, LightBase light)
        {
            ICamera camera = arg.Camera;
            mat4 projection = camera.GetProjectionMatrix();
            mat4 view = camera.GetViewMatrix();
            mat4 model = this.GetModelMatrix();

            RenderMethod method = this.RenderUnit.Methods[1];
            ShaderProgram program = method.Program;
            // matrix.
            program.SetUniform("mvpMat", projection * view * model);
            //program.SetUniform("projectionMat", projection);
            //program.SetUniform("viewMat", view);
            program.SetUniform("modelMat", model);
            program.SetUniform("normalMat", glm.transpose(glm.inverse(model)));
            // light info.
            light.SetBlinnPhongUniforms(program);
            // material.
            program.SetUniform("material.diffuse", this.diffuseColor);
            program.SetUniform("material.specular", this.specularColor);
            program.SetUniform("material.shiness", this.shininess);
            // eye pos.
            program.SetUniform("eyePos", camera.Position); // camera's position in world space.
            // use blinn phong or not?
            program.SetUniform("blinn", this.BlinnPhong);

            method.Render();
        }

        public void RenderAfterChildren(RenderEventArgs arg, LightBase light)
        {
        }

        #endregion

        //public vec3 Color { get; set; }

        //public float Shiness { get; set; }

        public bool BlinnPhong { get; set; }

        public vec3 ambientColor;
        public vec3 diffuseColor;
        //public vec3 emissiveColor;
        public vec3 specularColor;
        public float shininess;
        //public float transparency;
    }
}
