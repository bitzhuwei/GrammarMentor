using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// state for lexical analyzing.
    /// </summary>
    public class LexicalState {
        private static readonly object locker = new object();
        private static int idCounter = 0;
        /// <summary>
        /// the id to identify different <see cref="LexicalState"/> objects.
        /// </summary>
        public readonly int Id;

        /// <summary>
        /// readable name for debugging.
        /// </summary>
        public string Name { get; private set; }

        //private Func<char, bool>[] matchingRules;
        //private Func<LexiContext_Step, LexiState>[] functions;
        /// <summary>
        /// rule0: matchingRule0, function0
        /// <para>rule1: matchingRule1, function1</para>
        /// <para>rule2: matchingRule2, function2</para>
        /// <para>...</para>
        /// </summary>
        private LexicalRule[] candidates;

        /// <summary>
        /// state for lexical analyzing.
        /// </summary>
        public LexicalState(params LexicalRule[] candidates) : this(string.Empty, candidates) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public LexicalState(string name, params LexicalRule[] candidates) {
            lock (locker) { this.Id = idCounter++; }
            this.Name = string.IsNullOrEmpty(name) ? string.Empty : name;
            this.candidates = candidates;
        }

        /// <summary>
        /// Get handler of this state according to specified <paramref name="currentChar"/>
        /// </summary>
        /// <param name="currentChar"></param>
        /// <returns></returns>
        public Func<LexicalContext, LexicalState> GetFunction(char currentChar) {
            for (int i = 0; i < this.candidates.Length; i++) {
                var candidate = this.candidates[i];
                if (candidate.matchingRule(currentChar)) {
                    return candidate.function;
                }
            }

            // naive..
            // DON'T skip this exception. 
            // Any exception in a lexical analyzer or syntax parser 
            // should be discovered and fixed before we use it in practice.
            // If we are not confident enough to use it like this, we should only keep working on it.
            // This is not an extreme view, 
            // because we have full scientific theory of compiling,
            // and the routine is an appearance of that theory.
            throw new Exception($"function not found for condition[{currentChar}] in {this}");
        }

        public override string ToString() {
            return $"[{this.Id}]: {this.Name}";
        }
    }
}
