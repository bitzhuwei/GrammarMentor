using bitzhuwei.Compiler;
using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {

        private void GenerateGrammarInfo(YieldContext context) {
            var p = context.parameter;
            //var now = DateTime.Now.ToString();
            if (!Directory.Exists(p.generationDirectory)) { Directory.CreateDirectory(p.generationDirectory); }
            {
                string fullname = Path.Combine(p.generationDirectory, $"{p.GrammarName}.gen.tokens");
                using (var w = new System.IO.StreamWriter(fullname)) {
                    var tokens = context.parameter.tokens;
                    tokens.Print(w);
                }
            }
            {
                string fullname = Path.Combine(p.generationDirectory, $"{p.GrammarName}.gen.node");
                using (var w = new System.IO.StreamWriter(fullname)) {
                    var tokens = context.parameter.tokens;
                    var node = context.parameter.rootNode;
                    node.Print(w, tokens, CompilerGrammar.Regulations);
                }
            }
            {
                string fullname = Path.Combine(p.generationDirectory, $"{p.GrammarName}.gen.st");
                using (var w = new System.IO.StreamWriter(fullname)) {
                    var grammar = context.grammar;
                    grammar.Print(w);
                }
            }
        }
    }
}