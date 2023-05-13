using bitzhuwei.Compiler;
using bitzhuwei.StepFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Practice.StepParser.Winform
{
    static partial class Test
    {
        public static Dictionary<string/*'TypeName'*/, List<bitzhuwei.StepFormat.StepTypeObj>> CollectStepTypeObj()
        {
            var dict = new Dictionary<string/*'TypeName'*/, List<bitzhuwei.StepFormat.StepTypeObj>>();

            var compiler = new bitzhuwei.StepFormat.CompilerStep();

            var filenames1 = System.IO.Directory.GetFiles(@"D:\stepFiles", "*.step");
            var filenames2 = System.IO.Directory.GetFiles(@"D:\stepFiles", "*.stp");
            var filenames = new List<string>(filenames1); filenames.AddRange(filenames2);
            foreach (var filename in filenames)
            {
                string content = File.ReadAllText(filename);
                var tokenList = compiler.Analyze(content);
                var node = compiler.Parse(tokenList);
                var stepFile = compiler.Extract(node, tokenList);
                foreach (var entity in stepFile.entityDict.Values)
                {
                    Collect(entity, dict);
                }
                foreach (var typeObj in stepFile.headlineList)
                {
                    PickOne(dict, typeObj);
                }
            }

            return dict;
        }

        private static void Collect(StepEntity entity, Dictionary<string, List<StepTypeObj>> dict)
        {
            foreach (var typeObj in entity.typeObjList)
            {
                PickOne(dict, typeObj);
            }

            foreach (var item in entity.entityList)
            {
                Collect(item, dict);
            }
        }

        private static void PickOne(Dictionary<string, List<StepTypeObj>> dict, StepTypeObj typeObj)
        {
            List<StepTypeObj> list = null;
            if (!dict.TryGetValue(typeObj.typeName, out list))
            {
                list = new List<StepTypeObj>();
                list.Add(typeObj);
                dict.Add(typeObj.typeName, list);
            }
            else
            {
                list.Add(typeObj);
            }
        }
    }
}
