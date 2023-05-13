using bitzhuwei.Compiler;
using bitzhuwei.StepFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Practice.StepParser.Winform {
    static partial class Test {
        public static void CollectRefs() {
            var compiler = new CompilerStep();
            var filenames1 = System.IO.Directory.GetFiles(@"D:\stepFiles", "*.step");
            var filenames2 = System.IO.Directory.GetFiles(@"D:\stepFiles", "*.stp");
            var filenames = new List<string>(filenames1); filenames.AddRange(filenames2);
            var referedDict = new Dictionary<string, List<string>>();//key is refered by value(list of typeName)
            var referingDict = new Dictionary<string, List<string>>();//key refers to value(list of typeName)
            foreach (var filename in filenames) {
                var subReferingDict = new Dictionary<string/*typeName*/, List<string>/*typeNames*/>();
                string content = File.ReadAllText(filename);
                var tokenList = compiler.Analyze(content);
                var node = compiler.Parse(tokenList);
                var stepFile = compiler.Extract(node, tokenList);
                foreach (var entity in stepFile.entityDict.Values) {
                    CollectReferings(entity, subReferingDict, stepFile);
                }
                Dictionary<string, List<string>> subReferedDict = ConvertReferedDict(subReferingDict);
                Merge(subReferingDict, referingDict);
                Merge(subReferedDict, referedDict);
                //using (var w = new StreamWriter(filename + ".refered"))
                //{ PrintReferedDict(subReferedDict, w); }
            }

            using (var w = new StreamWriter("Types.refered.txt")) { PrintReferedDict(referedDict, w); }

            var orderDict = ParseOrderDict(referingDict);
            using (var w = new StreamWriter("Types.refering.txt")) { PrintReferingDict(referingDict, orderDict, w); }
        }

        private static Dictionary<string, int> ParseOrderDict(Dictionary<string, List<string>> referingDict) {
            var result = new Dictionary<string, int>();
            bool updated = true; int order = 0;
            while (updated) {
                updated = false;
                foreach (var item in referingDict) {
                    if (!result.ContainsKey(item.Key)) {
                        bool ready = ReferingOrdered(item.Value, result);
                        if (ready) {
                            result.Add(item.Key, order++);
                            updated = true;
                        }
                    }
                }
            }

            foreach (var item in referingDict) {
                if (!result.ContainsKey(item.Key)) {
                    result.Add(item.Key, -1);
                }
            }

            return result;
        }

        private static bool ReferingOrdered(List<string> typeNames, Dictionary<string, int> orderDict) {
            var result = true;
            foreach (var item in typeNames) {
                if (!orderDict.ContainsKey(item)) {
                    result = false;
                    break;
                }
            }

            return result;
        }

        private static void PrintReferingDict(Dictionary<string, List<string>> referingDict, Dictionary<string, int> orderDict, StreamWriter w) {
            var query = from item in referingDict
                        orderby orderDict[item.Key] ascending
                        select item;
            foreach (var item in query) {
                {
                    var order = (orderDict.ContainsKey(item.Key)) ? orderDict[item.Key] : -1;
                    w.WriteLine($"{item.Key} refers to: [{order}]");
                }
                var query2 = from refered in item.Value orderby refered ascending select refered;
                foreach (var refered in query2) {
                    var order = (orderDict.ContainsKey(refered)) ? orderDict[refered] : -1;
                    w.WriteLine($"    {refered} [{order}]");
                }
                w.WriteLine("-----------------------------------");
            }
        }

        private static void Merge(Dictionary<string, List<string>> subReferedDict, Dictionary<string, List<string>> referedDict) {
            foreach (var sub in subReferedDict) {
                List<string> list;
                if (referedDict.TryGetValue(sub.Key, out list)) {
                    foreach (var typeName in sub.Value) {
                        if (!list.Contains(typeName)) { list.Add(typeName); }
                    }
                }
                else {
                    list = new List<string>(); list.AddRange(sub.Value);
                    referedDict.Add(sub.Key, list);
                }
            }
        }

        private static void PrintReferedDict(Dictionary<string, List<string>> referedDict, StreamWriter w) {
            var query = from item in referedDict
                        orderby item.Key ascending
                        select item;
            foreach (var item in query) {
                w.WriteLine($"{item.Key} is refered by:");
                var query2 = from refering in item.Value orderby refering ascending select refering;
                foreach (var refering in query2) {
                    w.WriteLine($"    {refering}");
                }
                w.WriteLine("===================================");
            }
        }

        private static Dictionary<string, List<string>> ConvertReferedDict(Dictionary<string, List<string>> referingDict) {
            // refered -> list of refering.
            var result = new Dictionary<string, List<string>>();
            foreach (var item in referingDict) {
                var refering = item.Key;
                var referedList = item.Value;
                foreach (var refered in referedList) {
                    List<string> list;
                    if (result.TryGetValue(refered, out list)) {
                        if (!list.Contains(refering)) { list.Add(refering); }
                    }
                    else {
                        list = new List<string>(); list.Add(refering);
                        result.Add(refered, list);
                    }
                }
            }

            return result;
        }

        private static void CollectReferings(StepEntity entity, Dictionary<string, List<string>> referingDict, StepModel stepFile) {
            foreach (var typeObj in entity.typeObjList) {
                foreach (var arg in typeObj.argList) {
                    var referingList = ExtractTypeNames(arg, stepFile);
                    CollectReferings(typeObj.typeName, referingList, referingDict);
                }
            }
            foreach (var item in entity.entityList) {
                CollectReferings(item, referingDict, stepFile);
            }
        }

        private static void CollectReferings(string typeName, List<string> referingList, Dictionary<string, List<string>> referingDict) {
            List<string> list;
            if (referingDict.TryGetValue(typeName, out list)) {
                foreach (var refering in referingList) {
                    if (!list.Contains(refering)) { list.Add(refering); }
                }
            }
            else {
                referingDict.Add(typeName, referingList);
            }
        }

        private static List<string> ExtractTypeNames(StepArg arg, StepModel stepFile) {
            List<string> result = new List<string>();
            if (arg is StepArg23) { /*w.Write($"{CompilerStep.EType.Identity}");*/
                var referingEntity = stepFile.entityDict[(arg as StepArg23).identity];
                var names = from item in referingEntity.typeObjList select item.typeName;
                result.AddRange(names);
            }
            else if (arg is StepArg24) { /*w.Write($"{CompilerStep.EType.Dollar}");*/ }
            else if (arg is StepArg25) { /*w.Write($"{CompilerStep.EType.Asterisk}");*/ }
            else if (arg is StepArg26) { /*w.Write($"{CompilerStep.EType.String}");*/ }
            else if (arg is StepArg27) { /*w.Write($"{CompilerStep.EType.Integer}");*/ }
            else if (arg is StepArg28) { /*w.Write($"{CompilerStep.EType.Float}");*/ }
            else if (arg is StepArg29) { /*w.Write($"{CompilerStep.EType.Hexadecimal}");*/ }
            else if (arg is StepArg30) { /*w.Write($"{CompilerStep.EType.Enum}");*/ }
            else if (arg is StepArg31) {
                var arg31 = arg as StepArg31;
                for (int i = 0; i < arg31.argList.Count; i++) {
                    var item = arg31.argList[i];
                    ////item.Print(w);
                    //PrintAbstract(item, w); w.Write(", ");
                    var subList = ExtractTypeNames(item, stepFile);
                    result.AddRange(subList);
                }
            }
            else if (arg is StepArg32) { /*PrintAbstract((arg as StepArg32).typeObj, w);*/ }
            else { throw new NotImplementedException(); }

            return result;
        }

    }
}
