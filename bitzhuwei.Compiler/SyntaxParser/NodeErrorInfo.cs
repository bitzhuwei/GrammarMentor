using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// </summary>
    public class NodeErrorInfo {
        public readonly Node node;
        public readonly string message;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="message"></param>
        public NodeErrorInfo(Node node, string message) {
            this.node = node;
            this.message = message;
        }

        public override string ToString() {
            return string.Format("{0}|{1}", node, message);
        }
    }
}
