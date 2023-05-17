using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// state for syntax parsing.
    /// </summary>
    public class SyntaxState {
        private static int idCounter = 0;
        /// <summary>
        /// Gets the id to identify different <see cref="SyntaxState"/> objects.
        /// </summary>
        public readonly int id;

        /// <summary>
        /// readable name for debugging.
        /// </summary>
        public readonly string name;

        //public SyntaxState(LR1ParsingAction errorHandler = null, params SyntaxRule[] rules) : this(string.Empty, errorHandler, rules) { }

        //public SyntaxState(string name, LR1ParsingAction errorHandler = null, params SyntaxRule[] rules)
        public SyntaxState(string name) {
            lock (this) {
                this.id = idCounter++;
            }
            this.name = string.IsNullOrEmpty(name) ? string.Empty : name;
            //foreach (var rule in rules)
            //{
            //    this.actionDict.Add(rule.key, rule.handler);
            //}
            //this.errorHandler = errorHandler;
        }

        /// <summary>
        /// from `V` to <see cref="ParsingAction"/>.
        /// </summary>
        public readonly Dictionary<string/*V*/, ParsingAction> actionDict = new Dictionary<string, ParsingAction>();
        public ParsingAction errorHandler;

        /// <summary>
        /// Get handler of this state according to specified <paramref name="V"/>
        /// </summary>
        /// <param name="V"></param>
        /// <returns></returns>
        public ParsingAction GetAction(string V) {
            if (!this.actionDict.TryGetValue(V, out var action)) {
                action = this.errorHandler;
            }

            return action;
        }

        public override string ToString() {
            //return string.Format("id:{0}, name:{1}", this.id, this.name);
            //return $"name:{name}, id:{id}";
            return this.name;
        }
    }
}
