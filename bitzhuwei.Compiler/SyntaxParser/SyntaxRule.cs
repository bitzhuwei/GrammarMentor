//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bitzhuwei.Compiler {
//    /// <summary>
//    /// when the condition
//    /// </summary>
//    public class SyntaxRule {
//        // 返回true时表示应当使用本对象中的function
//        /// <summary>
//        /// key in the dictionary, which is a nodeType.
//        /// </summary>
//        public readonly string keyNodeType;

//        // 本规则应当进行的具体操作。
//        /// 返回值是下一个<see cref="Token"/>在<see cref="TokenList"/>中的索引。
//        /// <summary>
//        /// function of this rule.
//        /// <para>returns next index in <see cref="Token"/> in <see cref="TokenList"/>.</para>
//        /// </summary>
//        public readonly ParsingAction handler;

//        public SyntaxRule(string keyNodeType, ParsingAction handler) {
//            this.keyNodeType = keyNodeType;
//            this.handler = handler;
//        }

//    }
//}
