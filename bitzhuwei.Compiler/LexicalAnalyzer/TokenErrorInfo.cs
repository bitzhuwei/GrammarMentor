using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bitzhuwei.Compiler {
    public class TokenErrorInfo {
        public readonly Token token;
        public readonly string message;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <param name="message"></param>
        public TokenErrorInfo(Token token, string message) {
            if (token == null) { throw new ArgumentNullException($"{nameof(token)}"); }
            if (message == null) { throw new ArgumentNullException($"{nameof(message)}"); }

            this.token = token;
            this.message = message;
        }

        public override string ToString() {
            //return string.Format("{0}|{1}", token, message);
            return $"{token}|{message}";
        }
    }
}
