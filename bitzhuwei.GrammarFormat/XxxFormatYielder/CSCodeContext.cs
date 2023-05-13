using System.IO;

namespace bitzhuwei.GrammarFormat {
    ///// <summary>
    ///// returns C# code.
    ///// </summary>
    //public interface ICSCode {
    //    /// <summary>
    //    /// returns C# code.
    //    /// </summary>
    //    /// <returns></returns>
    //    void ToCSCode(TextWriter w, object context);
    //}

    public class CSCodeContext {
        private readonly int tabUnit;
        private int tabCount;

        public void IncreaseTab() {
            this.tabCount++;
        }
        public void DecreaseTab() {
            this.tabCount--;
        }

        public int Tab { get { return this.tabUnit * this.tabCount; } }

        public CSCodeContext(int tabUnit, int tabCount) {
            this.tabUnit = tabUnit;
            this.tabCount = tabCount;
        }

        public override string ToString() {
            return $"tab: {tabUnit * tabCount}";
        }
    }
}