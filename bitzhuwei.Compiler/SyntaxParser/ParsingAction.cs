using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// LR1分析动作的基类
    /// <summary>
    /// </summary>
    public abstract class ParsingAction {
        /// 执行分析动作。
        /// <summary>
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public abstract int Execute(LRSyntaxContext context);
    }

}
