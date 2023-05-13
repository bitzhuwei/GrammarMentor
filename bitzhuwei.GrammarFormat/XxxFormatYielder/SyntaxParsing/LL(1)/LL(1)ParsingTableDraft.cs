using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// LL(1)语法分析的分析表
    /// </summary>
    public class LL1ParsingTableDraft : IEnumerable<KeyValuePair<string, List<LL1ParsingActionDraft>>> {
        /// <summary>
        /// ★
        /// </summary>
        private const char keySeparator = '★';

        //public static string MakeKey(int Vn, string/*TreeNodeType*/ Vt) {
        //    string key = Vn.ToString() + keySeparator + Vt;
        //    return key;
        //}

        public static bool TryParse(string key, out string Vn, out string/*TreeNodeType*/ Vt) {
            var parts = key.Split(keySeparator);

            Vn = parts[0];
            Vt = parts[1];

            return true;
        }

        private Dictionary<string, List<LL1ParsingActionDraft>> parsingTable =
            new Dictionary<string, List<LL1ParsingActionDraft>>();

        /// <summary>
        /// 设置给定语法类型、单词类型所对应的分析函数
        /// </summary>
        /// <param name="Vn"></param>
        /// <param name="Vt"></param>
        /// <param name="LL1ParsingAction"></param>
        public void SetAction(string Vn, string/*TreeNodeType*/ Vt, LL1ParsingActionDraft LL1ParsingAction) {
            var key = $"{Vn}{keySeparator}{Vt}";
            if (parsingTable.TryGetValue(key, out var LL1ParsingAcitons)) {
                foreach (var item in LL1ParsingAcitons) {
                    if (item.regulationId == LL1ParsingAction.regulationId) {
                        // something is wrong.
                        throw new NotImplementedException();
                    }
                }
                LL1ParsingAcitons.Add(LL1ParsingAction);
            }
            else {
                var list = new List<LL1ParsingActionDraft>();
                list.Add(LL1ParsingAction);
                parsingTable.Add(key, list);
            }
        }

        /// <summary>
        /// 获取处理函数
        /// </summary>
        /// <param name="Vn">当前结非终点类型</param>
        /// <param name="Vt">要处理的结点类型</param>
        /// <returns></returns>
        public IReadOnlyList<LL1ParsingActionDraft> GetActions(string Vn, string/*TreeNodeType*/ Vt) {
            var key = $"{Vn}{keySeparator}{Vt}";
            if (parsingTable.TryGetValue(key, out List<LL1ParsingActionDraft> value)) {
                return value;
            }
            else {
                return null;// new LL1ParsingActionDraft(); // TODO:将来这里可以放对语法错误进行分析的函数
            }
        }


        public override string ToString() {
            var totalBuilder = new StringBuilder();
            var b = new StringBuilder();
            var conflictsBuilder = new StringBuilder();
            int conflictCount = 0;
            int count = 0;
            foreach (var item in this.parsingTable) {
                int valueCount = item.Value.Count;
                if (valueCount > 1) { conflictCount++; }
                count += valueCount;

                foreach (var function in item.Value) {
                    string str = string.Format("[{0}]->[{1}]", item.Key, function);
                    b.AppendLine(str);
                    if (valueCount > 1) { conflictsBuilder.AppendLine(str); }
                }
            }

            b.AppendLine("------------------------------------------------------------------------------------------");
            totalBuilder.AppendFormat("[{0} items]:", count);
            totalBuilder.AppendLine();
            totalBuilder.Append(b.ToString());
            b.AppendLine("------------------------------------------------------------------------------------------");
            totalBuilder.AppendFormat("[{0} conflicts]:", conflictCount);
            totalBuilder.AppendLine();
            totalBuilder.Append(conflictsBuilder.ToString());

            return totalBuilder.ToString();
        }

        public IEnumerator<KeyValuePair<string, List<LL1ParsingActionDraft>>> GetEnumerator() {
            foreach (var item in this.parsingTable) {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        public void Print(System.IO.TextWriter w) {
            int conflictCount = 0;
            int count = 0;
            {
                w.WriteLine("------------------------------------------------------------------------------------------");
                foreach (var item in this.parsingTable) {
                    int valueCount = item.Value.Count;
                    if (valueCount > 1) { conflictCount++; }
                    count += valueCount;
                }
                w.WriteLine("[{0} items]", count);
                w.WriteLine("[{0} conflicts]", conflictCount);
            }
            {
                w.WriteLine("------------------------------------------------------------------------------------------");
                w.WriteLine("[{0} items]:", count);
                foreach (var item in this.parsingTable) {
                    foreach (var parsingAction in item.Value) {
                        w.WriteLine("[{0}]->[{1}]", item.Key, parsingAction);
                    }
                }
            }
            {
                w.WriteLine("------------------------------------------------------------------------------------------");
                w.WriteLine("[{0} conflicts]:", conflictCount);
                foreach (var item in this.parsingTable) {
                    int valueCount = item.Value.Count;
                    if (valueCount > 1) {
                        foreach (var parsingAction in item.Value) {
                            w.WriteLine("[{0}]->[{1}]", item.Key, parsingAction);
                        }
                    }
                }
            }
        }
    }
}
