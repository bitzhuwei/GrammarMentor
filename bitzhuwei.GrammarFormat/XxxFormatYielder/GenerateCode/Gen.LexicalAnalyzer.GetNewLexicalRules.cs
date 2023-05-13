using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        /* 
         * same code for DFA and MiniDFA.
         * please update them simultaneously.
         * 
         * */

        /* 
         * Now it's for DFA
         * 
         * */

        private int GetStateIdLength(DFAInfo DFA) {
            int count = 0;
            var queue = new Queue<DFAStateDraft>(); queue.Enqueue(DFA.start);
            var visited = new List<DFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    count++;

                    foreach (var edge in state.toEdges) {
                        var to = edge.to;
                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }

            if (count <= 9) { return 1; }
            else if (count <= 99) { return 2; }
            else if (count <= 999) { return 3; }
            else if (count <= 9999) { return 4; }
            else if (count <= 99999) { return 5; }
            else if (count <= 999999) { return 6; }
            else if (count <= 9999999) { return 7; }
            else if (count <= 99999999) { return 8; }
            else if (count <= 999999999) { return 9; }
            //else if (count <= 9999999999) { return 10; }
            else { return 11; }
        }

        /* a list of :
         * new LexicalRule(
           currentChar => currentChar == '/', 
           context => {
                context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.Cursor - context.analyzingToken.index);
                context.analyzingToken.type = EType.{Vt.Vt2Name()};
                context.result.Add(context.analyzingToken);
                context.analyzingToken = null;
                context.MoveBack(1);
                return lexicalStateN;
           }),
         */
        private string GetNewLexicalRules(DFAStateDraft state, DFAInfo DFA) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                var c = new CSCodeContext(tabUnit: 4, tabCount: 3);
                // general edges.
                foreach (var edge in state.toEdges) {
                    // new LexicalRule(..)
                    WritenewLexicalRule(edge, DFA, w, c); w.Write(","); w.WriteLine();
                }
                // the final edge: 'other'.
                {
                    w.PrintLine(c.Tab, "/* accept everything else. */");
                    w.PrintLine(c.Tab, "/* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */");
                    WritenewLexicalRule(state, DFA, w, c);
                    w.WriteLine();
                }
            }

            return b.ToString();
        }

        /// <summary>
        /// currentChar =&gt; currentChar == '+',
        /// <para>
        /// currentChar =&gt; '0' &lt;= currentChar &amp;&amp; currentChar &lt;= '9',
        /// </para>
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="DFA"></param>
        /// <param name="w"></param>
        /// <param name="c"></param>
        private static void WritenewLexicalRule(DFAEdgeDraft edge, DFAInfo DFA, TextWriter w, CSCodeContext c) {
            // new LexicalRule(
            w.PrintLine(c.Tab, "new LexicalRule(");
            // currentChar => currentChar == '+',
            // currentChar => '0' <= currentChar && currentChar <= '9',
            // ...
            w.Print(c.Tab, $"{ConditionHelper.var_currentChar} => "); edge.ToCSCode(w, c); w.Write(","); w.WriteLine();
            if (DFA.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                // context => { ... }
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                WriteDFATokenScripts(tokenScripts, w, c);
                w.PrintLine(c.Tab, $"return lexicalState{edge.to.Id};");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            else { // simply go to next state.
                // context => lexicalStateN
                w.Print(c.Tab, $"context => lexicalState{edge.to.Id}");
            }
            w.Write(")"); // ) end of new LexicalRule
        }


        /// <summary>
        /// currentChar =&gt; true,
        /// <para>context =&gt; { ... }</para>
        /// </summary>
        /// <param name="state"></param>
        /// <param name="DFA"></param>
        /// <param name="w"></param>
        /// <param name="c"></param>
        private static void WritenewLexicalRule(DFAStateDraft state, DFAInfo DFA, TextWriter w, CSCodeContext c) {
            // new LexicalRule '('
            w.PrintLine(c.Tab, "new LexicalRule(");
            // currentChar => true,
            w.PrintLine(c.Tab, "acceptAll,");
            if (DFA.stateTokenScriptDict.TryGetValue(state, out var tokenScripts)) {
                // context => { ... }
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                WriteDFATokenScripts(tokenScripts, w, c);
                w.PrintLine(c.Tab, "return lexicalState0;");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            else if (state.Id == 0) { // the initial state of lexical analyzing.
                // context => lexicalStateN
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                w.PrintLine(c.Tab, "char c = context.CurrentChar;");
                w.PrintLine(c.Tab, @"if (c == ' ' || c == '\r' || c == '\n' || c == '\t' || c == '\0') { return lexicalState0; }");
                w.PrintLine(c.Tab, "// default handler: unexpected char.");
                w.PrintLine(c.Tab, "context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);");
                w.PrintLine(c.Tab, "context.result.Add(context.analyzingToken);");
                w.PrintLine(c.Tab, "context.checkpoint = context.Cursor + 1;");
                w.PrintLine(c.Tab, "context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index);");
                w.PrintLine(c.Tab, "context.analyzingToken.type = EType.Error;");
                w.PrintLine(c.Tab, "context.result.errorDict.Add(context.analyzingToken, new TokenErrorInfo(context.analyzingToken, $\"Unexpected char {c}\"));");
                //w.PrintLine(context.Tab, "context.analyzingToken = null;");
                w.PrintLine(c.Tab, "return lexicalState0;");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            else { // neutralize the last LexicalContext.MoveForward()
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                w.PrintLine(c.Tab, "context.MoveBack(1);");
                w.PrintLine(c.Tab, "return lexicalState0;");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            w.Write(")"); // ')' end new LexicalRule
        }

        /* 
         * Now it's for MiniDFA
         * 
         * */

        private int GetStateIdLength(MiniDFAInfo DFA) {
            int count = 0;
            var queue = new Queue<MiniDFAStateDraft>(); queue.Enqueue(DFA.start);
            var visited = new List<MiniDFAStateDraft>();
            while (queue.Count > 0) {
                var state = queue.Dequeue();
                if (!visited.Contains(state)) {
                    visited.Add(state);

                    count++;

                    foreach (var edge in state.toEdges) {
                        var to = edge.to;
                        if (!visited.Contains(to)) { queue.Enqueue(to); }
                    }
                }
            }

            if (count <= 9) { return 1; }
            else if (count <= 99) { return 2; }
            else if (count <= 999) { return 3; }
            else if (count <= 9999) { return 4; }
            else if (count <= 99999) { return 5; }
            else if (count <= 999999) { return 6; }
            else if (count <= 9999999) { return 7; }
            else if (count <= 99999999) { return 8; }
            else if (count <= 999999999) { return 9; }
            //else if (count <= 9999999999) { return 10; }
            else { return 11; }
        }

        /* a list of :
         * new LexicalRule(
           currentChar => currentChar == '/', 
           context => {
                context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);
                context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.Cursor - context.analyzingToken.index);
                context.analyzingToken.type = EType.{Vt.Vt2Name()};
                context.result.Add(context.analyzingToken);
                context.analyzingToken = null;
                context.MoveBack(1);
                return lexicalStateN;
           }),
         */
        private string GetNewLexicalRules(MiniDFAStateDraft state, MiniDFAInfo DFA) {
            var b = new StringBuilder();
            using (var w = new StringWriter(b)) {
                var c = new CSCodeContext(tabUnit: 4, tabCount: 3);
                // general edges.
                foreach (var edge in state.toEdges) {
                    // new LexicalRule(..)
                    WritenewLexicalRule(edge, DFA, w, c); w.Write(","); w.WriteLine();
                }
                // the final edge: 'other'.
                {
                    w.PrintLine(c.Tab, "/* accept everything else. */");
                    w.PrintLine(c.Tab, "/* NOTE: this rule should only be put in the last position, as this is a lazy coding style! */");
                    WritenewLexicalRule(state, DFA, w, c);
                    w.WriteLine();
                }
            }

            return b.ToString();
        }

        /// <summary>
        /// currentChar =&gt; currentChar == '+',
        /// <para>
        /// currentChar =&gt; '0' &lt;= currentChar &amp;&amp; currentChar &lt;= '9',
        /// </para>
        /// </summary>
        /// <param name="edge"></param>
        /// <param name="DFA"></param>
        /// <param name="w"></param>
        /// <param name="c"></param>
        private static void WritenewLexicalRule(MiniDFAEdgeDraft edge, MiniDFAInfo DFA, TextWriter w, CSCodeContext c) {
            // new LexicalRule(
            w.PrintLine(c.Tab, "new LexicalRule(");
            // currentChar => currentChar == '+',
            // currentChar => '0' <= currentChar && currentChar <= '9',
            // ...
            w.Print(c.Tab, $"{ConditionHelper.var_currentChar} => "); edge.ToCSCode(w, c); w.Write(","); w.WriteLine();
            if (DFA.edgeTokenScriptDict.TryGetValue(edge, out var tokenScripts)) {
                // context => { ... }
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                WriteMiniDFATokenScripts(tokenScripts, w, c);
                w.PrintLine(c.Tab, $"return lexicalState{edge.to.Id};");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            else { // simply go to next state.
                // context => lexicalStateN
                w.Print(c.Tab, $"context => lexicalState{edge.to.Id}");
            }
            w.Write(")"); // ) end of new LexicalRule
        }


        /// <summary>
        /// currentChar =&gt; true,
        /// <para>context =&gt; { ... }</para>
        /// </summary>
        /// <param name="state"></param>
        /// <param name="DFA"></param>
        /// <param name="w"></param>
        /// <param name="c"></param>
        private static void WritenewLexicalRule(MiniDFAStateDraft state, MiniDFAInfo DFA, TextWriter w, CSCodeContext c) {
            // new LexicalRule '('
            w.PrintLine(c.Tab, "new LexicalRule(");
            // currentChar => true,
            w.PrintLine(c.Tab, "acceptAll,");
            if (DFA.stateTokenScriptDict.TryGetValue(state, out var tokenScripts)) {
                // context => { ... }
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                WriteMiniDFATokenScripts(tokenScripts, w, c);
                w.PrintLine(c.Tab, "return lexicalState0;");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            else if (state.Id == 0) { // the initial state of lexical analyzing.
                // context => lexicalStateN
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                w.PrintLine(c.Tab, "char c = context.CurrentChar;");
                w.PrintLine(c.Tab, @"if (c == ' ' || c == '\r' || c == '\n' || c == '\t' || c == '\0') { return lexicalState0; }");
                w.PrintLine(c.Tab, "// default handler: unexpected char.");
                w.PrintLine(c.Tab, "context.analyzingToken = new Token(context.Cursor, context.Line, context.Column);");
                w.PrintLine(c.Tab, "context.result.Add(context.analyzingToken);");
                w.PrintLine(c.Tab, "context.checkpoint = context.Cursor + 1;");
                w.PrintLine(c.Tab, "context.analyzingToken.value = context.Substring(context.analyzingToken.index, context.checkpoint - context.analyzingToken.index);");
                w.PrintLine(c.Tab, "context.analyzingToken.type = EType.Error;");
                w.PrintLine(c.Tab, "context.result.errorDict.Add(context.analyzingToken, new TokenErrorInfo(context.analyzingToken, $\"Unexpected char {c}\"));");
                //w.PrintLine(context.Tab, "context.analyzingToken = null;");
                w.PrintLine(c.Tab, "return lexicalState0;");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            else { // neutralize the last LexicalContext.MoveForward()
                w.PrintLine(c.Tab, "context => {");
                c.IncreaseTab();
                w.PrintLine(c.Tab, "context.MoveBack(1);");
                w.PrintLine(c.Tab, "return lexicalState0;");
                c.DecreaseTab();
                w.Print(c.Tab, "}");
            }
            w.Write(")"); // ')' end new LexicalRule
        }
    }
}