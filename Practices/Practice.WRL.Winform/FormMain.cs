using bitzhuwei.WRLFormat;
using CSharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.WRL.Winform
{
    public partial class FormMain : Form
    {
        private Scene scene;
        private ActionList actionList;
        private List<LightBase> lights;

        private static List<LightBase> GetDirctionalLights()
        {
            var list = new List<LightBase>();
            {
                var light = new CSharpGL.DirectionalLight(new vec3(3, 3, 3));
                light.Diffuse = new vec3(1, 1, 1);
                light.Specular = new vec3(1, 1, 1);
                list.Add(light);
            }
            //{
            //    var light = new CSharpGL.DirectionalLight(new vec3(3, 3, 3));
            //    light.Diffuse = new vec3(0, 1, 0);
            //    light.Specular = new vec3(0, 1, 0);
            //    list.Add(light);
            //}
            //{
            //    var light = new CSharpGL.DirectionalLight(new vec3(3, 3, 3));
            //    light.Diffuse = new vec3(0, 0, 1);
            //    light.Specular = new vec3(0, 0, 1);
            //    list.Add(light);
            //}

            return list;
        }

        public FormMain()
        {
            InitializeComponent();

            this.lights = GetDirctionalLights();

            this.Load += FormMain_Load;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var position = new vec3(1, 0.6f, 1) * 16;
            var center = new vec3(0, 0, 0);
            var up = new vec3(0, 0, 1);
            var camera = new Camera(position, center, up, CameraType.Perspective, this.winGLCanvas1.Width, this.winGLCanvas1.Height);
            this.scene = new Scene(camera);
            this.scene.RootNode = GetRootNode();
            // add lights.
            {
                var lightList = this.lights;
                float angle = 0;
                foreach (var light in lightList)
                {
                    this.scene.Lights.Add(light);
                    var node = LightPositionNode.Create(light, angle);
                    angle += 360.0f / lightList.Count;
                    this.scene.RootNode.Children.Add(node);
                }
            }
            var list = new ActionList();
            var transformAction = new TransformAction(scene);
            list.Add(transformAction);
            var blinnPhongAction = new BlinnPhongAction(scene);
            list.Add(blinnPhongAction);
            var renderAction = new RenderAction(scene);
            list.Add(renderAction);
            this.actionList = list;

            var manipulater = new FirstPerspectiveManipulater();
            manipulater.Bind(camera, this.winGLCanvas1);

            this.winGLCanvas1.OpenGLDraw += winGLCanvas1_OpenGLDraw;
            this.winGLCanvas1.Resize += winGLCanvas1_Resize;
        }


        private void Match(TreeNode node, SceneNodeBase nodeBase)
        {
            foreach (var item in nodeBase.Children)
            {
                var child = new TreeNode(item.ToString()) { Tag = item };
                node.Nodes.Add(child);
                Match(child, item);
            }
        }

        private SceneNodeBase GetRootNode()
        {
            var compiler = new CompilerWRL();
            var group = new GroupNode();
            var filenames = Directory.GetFiles(@"D:\stepFiles\WRL\SC80-EC", "*.wrl");
            for (int i = 0; i < filenames.Length; i++)
            {
                string filename = filenames[i];
                var content = File.ReadAllText(filename);
                var tokens = compiler.Analyze(content);
                var syntaxTree = compiler.Parse(tokens);
                var wrlFile = compiler.Extract(syntaxTree, tokens);
                var model = new WRLModel(wrlFile);
                var node = NoShadowNode.Create(model, "position", "normal", model.modelSize);
                node.WorldPosition = model.initialPosition;
                node.ambientColor = model.ambientColor;
                node.diffuseColor = model.diffuseColor;
                ////node.emissiveColor = model.emissiveColor;
                //node.specularColor = model.specularColor;
                node.shininess = model.shininess;
                ////node.transparency = model.transparency;
                node.Name = filename;
                //node.Children.Add(new LegacyBoundingBoxNode(model.modelSize));
                group.Children.Add(node);
            }

            return group;
        }

        private void winGLCanvas1_OpenGLDraw(object sender, PaintEventArgs e)
        {
            ActionList list = this.actionList;
            if (list != null)
            {
                vec4 clearColor = this.scene.ClearColor;
                GL.Instance.ClearColor(clearColor.x, clearColor.y, clearColor.z, clearColor.w);
                GL.Instance.Clear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT | GL.GL_STENCIL_BUFFER_BIT);

                list.Act(new ActionParams(Viewport.GetCurrent()));
            }
        }

        void winGLCanvas1_Resize(object sender, EventArgs e)
        {
            this.scene.Camera.AspectRatio = ((float)this.winGLCanvas1.Width) / ((float)this.winGLCanvas1.Height);
        }


    }

}
