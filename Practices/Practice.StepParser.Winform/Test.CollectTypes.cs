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

namespace Practice.StepParser.Winform {
    static partial class Test {
        public static void CollectTypes() {
            Dictionary<string/*'TypeName'*/, List<bitzhuwei.StepFormat.StepTypeObj>> dict = CollectStepTypeObj();

            var query = from item in dict
                        orderby item.Key ascending
                        select item;
            //int index = 0;
            foreach (var pair in query) {
                using (var w = new System.IO.StreamWriter($"Types.Count.{pair.Key}.txt")) {
                    var typeObjs = pair.Value;
                    w.WriteLine($"// {pair.Key}");
                    var lineDict = new Dictionary<string, int>();
                    foreach (var typeObj in typeObjs) {
                        //typeObj.Print(w);
                        var b = new StringBuilder();
                        using (var strWriter = new StringWriter(b)) {
                            PrintAbstract(typeObj, strWriter);
                        }
                        var line = b.ToString();
                        int count;
                        if (lineDict.TryGetValue(line, out count)) { lineDict[line] = count + 1; }
                        else { lineDict.Add(line, 1); }
                    }
                    foreach (var item in lineDict) {
                        w.WriteLine($"{item.Key}/* count:{item.Value} */ ");
                        //w.WriteLine($"/* [{index++}] */");
                    }
                }
            }
        }

        static void PrintAbstract(StepTypeObj typeObj, TextWriter w) {
            w.Write($"{typeObj.typeName}");
            //w.Write($"{CompilerStep.EType.LeftParenthesis} ");
            w.Write("(");
            for (int i = 0; i < typeObj.argList.Count - 1; i++) {
                var arg = typeObj.argList[i];
                //arg.Print(w);
                PrintAbstract(arg, w); w.Write(", ");
            }
            if (typeObj.argList.Count > 0) {
                var arg = typeObj.argList[typeObj.argList.Count - 1];
                //arg.Print(w);
                PrintAbstract(arg, w);
            }
            //w.Write($"{CompilerStep.EType.RightParenthesis}");
            w.Write(")");
        }

        static void PrintAbstract(StepArg arg, TextWriter w) {
            if (arg is StepArg23) { w.Write($"{CompilerStep.EType.Identity}"); }
            else if (arg is StepArg24) { w.Write($"{CompilerStep.EType.Dollar}"); }
            else if (arg is StepArg25) { w.Write($"{CompilerStep.EType.Asterisk}"); }
            else if (arg is StepArg26) { w.Write($"{CompilerStep.EType.String}"); }
            else if (arg is StepArg27) { w.Write($"{CompilerStep.EType.Integer}"); }
            else if (arg is StepArg28) { w.Write($"{CompilerStep.EType.Float}"); }
            else if (arg is StepArg29) { w.Write($"{CompilerStep.EType.Hexadecimal}"); }
            else if (arg is StepArg30) { w.Write($"{CompilerStep.EType.Enum}"); }
            else if (arg is StepArg31) {
                var arg31 = arg as StepArg31;
                //w.Write($"{CompilerStep.EType.LeftParenthesis} ");
                w.Write("(");
                for (int i = 0; i < arg31.argList.Count - 1; i++) {
                    var item = arg31.argList[i];
                    //item.Print(w);
                    PrintAbstract(item, w); w.Write(", ");
                }
                if (arg31.argList.Count > 0) {
                    var item = arg31.argList[arg31.argList.Count - 1];
                    //item.Print(w);
                    PrintAbstract(item, w);
                }
                //w.Write($"{CompilerStep.EType.RightParenthesis}");
                w.Write(")");
            }
            else if (arg is StepArg32) { PrintAbstract((arg as StepArg32).typeObj, w); }
            else { throw new NotImplementedException(); }
        }


    }
}
