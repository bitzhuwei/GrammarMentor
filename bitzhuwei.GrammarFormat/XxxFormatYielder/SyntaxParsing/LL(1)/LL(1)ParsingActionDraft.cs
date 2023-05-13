using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    /// <summary>
    /// LL(1)分析动作的基类
    /// </summary>
    public class LL1ParsingActionDraft {
        public readonly int regulationId;

        public LL1ParsingActionDraft(int regulationId) {
            this.regulationId = regulationId;
        }

        ///// <summary>
        ///// 执行分析动作。
        ///// </summary>
        ///// <param name="context"></param>
        ///// <returns></returns>
        //public int Execute(ParsingContext context) { }

        /// <summary>
        /// 为自动生成分析表而添加的方法。代表(R[1], R[2] ..)中的数字。
        /// </summary>
        /// <returns></returns>
        public string ActionParam() {
            return this.regulationId.ToString();
        }

        public override string ToString() {
            return $"R[{this.regulationId}]";
        }
    }
}
