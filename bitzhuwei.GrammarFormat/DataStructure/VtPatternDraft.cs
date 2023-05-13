using System.IO;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// 'xxx' : %%...%% ;
    /// </summary>
    public partial class VtPatternDraft {
        /// <summary>
        /// 'xxx'
        /// </summary>
        public readonly string Vt;

        /// <summary>
        /// %%...%%
        /// </summary>
        public readonly string pattern;

        /// <summary>
        /// 'xxx' : %%...%% ;
        /// </summary>
        /// <param name="Vt">'xxx'</param>
        /// <param name="pattern">%%...%%</param>
        public VtPatternDraft(string Vt, string pattern) {
            this.Vt = Vt;
            this.pattern = pattern;
        }

        public void Print(TextWriter w) {
            w.Write($"{Vt} : {pattern} ;");
        }

        public override string ToString() {
            return $"{Vt} : {pattern} ;";
        }
    }
}