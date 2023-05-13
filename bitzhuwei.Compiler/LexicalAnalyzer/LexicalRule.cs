using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// when the condition
    /// </summary>
    public class LexicalRule {
        // 返回true时表示应当使用本对象中的function
        /// <summary>
        /// Return true if current char matches this rule.
        /// <para>and that's when the <see cref="LexicalRule.function"/> should be applied.</para>
        /// </summary>
        public readonly Func<char, bool> matchingRule;
        // 本规则应当进行的具体操作。
        /// 返回值是下一个LexiState对象，即状态机的下一个状态。
        /// <summary>
        /// function of this rule.
        /// <para>returns next <see cref="LexicalState"/> object.</para>
        /// </summary>
        public readonly Func<LexicalContext, LexicalState> function;

        public LexicalRule(Func<char, bool> matchingRule, Func<LexicalContext, LexicalState> function) {
            if (matchingRule == null) { throw new ArgumentNullException($"{nameof(matchingRule)}"); }
            if (function == null) { throw new ArgumentNullException($"{nameof(function)}"); }

            this.matchingRule = matchingRule;
            this.function = function;
        }

    }
}
