using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// LR1语法分析器需要的分析表
    /// </summary>
    public class LRParsingTableDraft : IEnumerable<KeyValuePair<string, List<LRParsingActionDraft>>> {
        /// <summary>
        /// ★
        /// </summary>
        public const char keySeparator = '★';

        public static string MakeKey(int stateId, string/*TreeNodeType*/ nextNode) {
            var key = $"{stateId}{keySeparator}{nextNode}";
            return key;
        }

        public static bool TryParse(string key, out int stateId, out string/*TreeNodeType*/ nextNode) {
            stateId = -1; nextNode = string.Empty;

            if (string.IsNullOrEmpty(key)) { return false; }

            var parts = key.Split(keySeparator);

            if (!int.TryParse(parts[0], out stateId)) { return false; }

            nextNode = parts[1];

            return true;
        }

        private Dictionary<string, List<LRParsingActionDraft>> parsingTable =
            new Dictionary<string, List<LRParsingActionDraft>>();
        /// <summary>
        /// 设置给定语法类型、单词类型所对应的分析函数
        /// </summary>
        /// <param name="stateId"></param>
        /// <param name="V">next node</param>
        /// <param name="parsingAction"></param>
        public void SetAction(int stateId, string/*V*/ V, LRParsingActionDraft parsingAction) {
            var key = $"{stateId}{keySeparator}{V}";

            if (parsingTable.TryGetValue(key, out var parsingActions)) {
                parsingActions.Add(parsingAction);
            }
            else {
                List<LRParsingActionDraft> list = new List<LRParsingActionDraft>();
                list.Add(parsingAction);
                parsingTable.Add(key, list);
            }
        }

        /// <summary>
        /// 获取处理函数
        /// </summary>
        /// <param name="stateId"></param>
        /// <param name="V">next node</param>
        /// <returns></returns>
        public IReadOnlyList<LRParsingActionDraft> GetActions(int stateId, string/*V*/ V) {
            var key = $"{stateId}{keySeparator}{V}";
            if (parsingTable.TryGetValue(key, out var parsingActions)) {
                return parsingActions;
            }
            else {
                return null;// new LRParsingAction(); // TODO:将来这里可以放对语法错误进行分析的函数
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

        public IEnumerator<KeyValuePair<string, List<LRParsingActionDraft>>> GetEnumerator() {
            foreach (var item in this.parsingTable) {
                yield return item;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        public void Print(System.IO.StreamWriter stream) {
            int conflictCount = 0;
            int count = 0;
            {
                stream.WriteLine("------------------------------------------------------------------------------------------");
                foreach (var item in this.parsingTable) {
                    int valueCount = item.Value.Count;
                    if (valueCount > 1) { conflictCount++; }
                    count += valueCount;
                }
                stream.WriteLine("[{0} items]", count);
                stream.WriteLine("[{0} conflicts]", conflictCount);
            }
            {
                stream.WriteLine("------------------------------------------------------------------------------------------");
                stream.WriteLine("[{0} items]:", count);
                foreach (var item in this.parsingTable) {
                    foreach (var parsingAction in item.Value) {
                        stream.WriteLine("[{0}]->[{1}]", item.Key, parsingAction);
                    }
                }
            }
            {
                stream.WriteLine("------------------------------------------------------------------------------------------");
                stream.WriteLine("[{0} conflicts]:", conflictCount);
                foreach (var item in this.parsingTable) {
                    int valueCount = item.Value.Count;
                    if (valueCount > 1) {
                        foreach (var parsingAction in item.Value) {
                            stream.WriteLine("[{0}]->[{1}]", item.Key, parsingAction);
                        }
                    }
                }
            }
        }
    }
}
