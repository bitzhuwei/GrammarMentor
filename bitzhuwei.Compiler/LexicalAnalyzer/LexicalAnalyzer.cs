using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bitzhuwei.Compiler {
    /// <summary>
    /// I lexically analyze source code and return the list of <see cref="Token"/>.
    /// </summary>
    public partial class LexicalAnalyzer {
        /// <summary>
        /// the initial state of lexical analyzer.
        /// </summary>
        private readonly LexicalState initialState;

        /// <summary>
        /// specify the initial state.
        /// </summary>
        /// <param name="initializer">The initial state.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="initialState"/> cannot be null.<exception>
        public LexicalAnalyzer(LexicalState initialState) {
            if (initialState == null) { throw new ArgumentNullException($"{nameof(initialState)}"); }

            this.initialState = initialState;
        }

        /// <summary>
        /// analyze the specified <paramref name="sourceCode"/> and return the list of <see cref="Token"/>.
        /// </summary>
        /// <param name="sourceCode">source code in string.</param>
        /// <returns></returns>
        public TokenList Analyze(string sourceCode) {
            var context = new LexicalContext(sourceCode, this.initialState);
            while (!context.EOF) {
                char currentChar = context.CurrentChar;
                Func<LexicalContext, LexicalState> function = context.GetFunction(currentChar);
                LexicalState nextState = function(context);
                context.currentState = nextState;// prepare the current state to meet with next char.
                context.MoveForward();
            }
            // finish lexical analyzing with external char('\0').
            {
                char currentChar = context.CurrentChar;
                Func<LexicalContext, LexicalState> function = context.GetFunction(currentChar);
                LexicalState nextState = function(context);
                // practically not needed.
                context.currentState = nextState;// prepare the current state to meet with next char.
                context.MoveForward();
            }

            return context.result;
        }
    }
}
