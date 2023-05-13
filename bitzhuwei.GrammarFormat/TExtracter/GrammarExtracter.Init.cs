using bitzhuwei.Compiler;
using System.Collections.Generic;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Collections;
using System.Data;
using System.Net.Http.Headers;

namespace bitzhuwei.GrammarFormat
{
    public partial class CompilerGrammar {
        /// <summary>
        /// <see cref="Node.type"/> -&gt; <see cref="Action{Node, TContext{GrammarDraft}}"/>
        /// </summary>
        private static readonly Dictionary<string/*Node.type*/, Action<Node, TContext<GrammarDraft>>> grammarDraftExtracterDict = new Dictionary<string, Action<Node, TContext<GrammarDraft>>>();

        /// <summary>
        /// initialize dict for extracter.
        /// </summary>
        private static void InitializeGrammarDraftExtracterDict() {
            var extracterDict = grammarDraftExtracterDict;
            //extracterDict.Add(EType.NotYet,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.Error,
            //(node, context) => {
            // nothing to do.
            //});
            //extracterDict.Add(EType.MultipleLineComment,
            //(node, context) => {
            // not needed.
            //});
            //extracterDict.Add(EType.SingleLineComment,
            //(node, context) => {
            // not needed.
            //});
            extracterDict.Add(EType.Vn,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Colon,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Semicolon,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Pipe,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.Vt,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.empty,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.pattern,
            (node, context) => {
                var token = context.tokens[node.tokenIndex];
                context.objStack.Push(token.value);
            });
            extracterDict.Add(EType.EndOfTokenList,
            (node, context) => {
                // -1: GrammarDraft> : StatementList ;
                var statementList = context.objStack.Pop() as StatementList;
                var grammarDraft = new GrammarDraft(/*statementList*/);
                context.result = grammarDraft; // final step, no need to push into stack.
            });
            extracterDict.Add(EType.StatementList,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[0])
                {
                    // 0: StatementList : StatementList Statement ;
                    var statement0 = context.objStack.Pop() as Statement;
                    var statementList1 = context.objStack.Pop() as StatementList;
                    var statementList = new StatementList(/*statementList1, statement0*/);
                    context.objStack.Push(statementList);
                }
                else if (node.regulation == CompilerGrammar.regulations[1])
                {
                    // 1: StatementList : Statement ;
                    var statement0 = context.objStack.Pop() as Statement;
                    var statementList = new StatementList(/*statement0*/);
                    context.objStack.Push(statementList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Statement,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[2])
                {
                    // 2: Statement : SyntaxProduction ;
                    var syntaxProduction0 = context.objStack.Pop() as SyntaxProduction;
                    var statement = new Statement(/*syntaxProduction0*/);
                    context.objStack.Push(statement);
                }
                else if (node.regulation == CompilerGrammar.regulations[3])
                {
                    // 3: Statement : LexiProduction ;
                    var lexiProduction0 = context.objStack.Pop() as LexiProduction;
                    var statement = new Statement(/*lexiProduction0*/);
                    context.objStack.Push(statement);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.SyntaxProduction,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[4])
                {
                    // 4: SyntaxProduction : 'Vn' ':' CandidateList ';' ;
                    var semicolon0 = context.objStack.Pop() as string;
                    var candidateList1 = context.objStack.Pop() as CandidateList;
                    var colon2 = context.objStack.Pop() as string;
                    var vn3 = context.objStack.Pop() as string;
                    var syntaxProduction = new SyntaxProduction(/*vn3, colon2, candidateList1, semicolon0*/);
                    context.objStack.Push(syntaxProduction);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.CandidateList,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[5])
                {
                    // 5: CandidateList : CandidateList '|' Candidate ;
                    var candidate0 = context.objStack.Pop() as Candidate;
                    var pipe1 = context.objStack.Pop() as string;
                    var candidateList2 = context.objStack.Pop() as CandidateList;
                    var candidateList = new CandidateList(/*candidateList2, pipe1, candidate0*/);
                    context.objStack.Push(candidateList);
                }
                else if (node.regulation == CompilerGrammar.regulations[6])
                {
                    // 6: CandidateList : Candidate ;
                    var candidate0 = context.objStack.Pop() as Candidate;
                    var candidateList = new CandidateList(/*candidate0*/);
                    context.objStack.Push(candidateList);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.Candidate,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[7])
                {
                    // 7: Candidate : Candidate V ;
                    var v0 = context.objStack.Pop() as V;
                    var candidate1 = context.objStack.Pop() as Candidate;
                    var candidate = new Candidate(/*candidate1, v0*/);
                    context.objStack.Push(candidate);
                }
                else if (node.regulation == CompilerGrammar.regulations[8])
                {
                    // 8: Candidate : V ;
                    var v0 = context.objStack.Pop() as V;
                    var candidate = new Candidate(/*v0*/);
                    context.objStack.Push(candidate);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.V,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[9])
                {
                    // 9: V : 'Vn' ;
                    var vn0 = context.objStack.Pop() as string;
                    var v = new V(/*vn0*/);
                    context.objStack.Push(v);
                }
                else if (node.regulation == CompilerGrammar.regulations[10])
                {
                    // 10: V : 'Vt' ;
                    var vt0 = context.objStack.Pop() as string;
                    var v = new V(/*vt0*/);
                    context.objStack.Push(v);
                }
                else if (node.regulation == CompilerGrammar.regulations[11])
                {
                    // 11: V : 'empty' ;
                    var empty0 = context.objStack.Pop() as string;
                    var v = new V(/*empty0*/);
                    context.objStack.Push(v);
                }
                else { throw new NotImplementedException(); }
            });
            extracterDict.Add(EType.LexiProduction,
            (node, context) => {
                if (node.regulation == CompilerGrammar.regulations[12])
                {
                    // 12: LexiProduction : 'Vt' ':' 'pattern' ';' ;
                    var semicolon0 = context.objStack.Pop() as string;
                    var pattern1 = context.objStack.Pop() as string;
                    var colon2 = context.objStack.Pop() as string;
                    var vt3 = context.objStack.Pop() as string;
                    var lexiProduction = new LexiProduction(/*vt3, colon2, pattern1, semicolon0*/);
                    context.objStack.Push(lexiProduction);
                }
                else { throw new NotImplementedException(); }
            });

        }
    }

}