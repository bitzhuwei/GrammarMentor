using bitzhuwei.Compiler;
using bitzhuwei.PatternFormat;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Threading;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {
        /// <summary>
        /// yield the compiler source code.
        /// </summary>
        /// <param name="parameter"></param>
        public void YieldCompiler(YieldParameter parameter) {
            if (parameter == null) { throw new ArgumentNullException($"{nameof(parameter)}"); }

            YieldContext context;
            {
                var grammar = this;
                context = new YieldContext(grammar, parameter);
            }
            StreamWriter logWriter;
            {
                var p = context.parameter;
                if (!Directory.Exists(p.generationDirectory)) { Directory.CreateDirectory(p.generationDirectory); }
                string fullname = Path.Combine(p.generationDirectory, $"Compiler{p.GrammarName}.gen.log_");
                logWriter = new StreamWriter(fullname); logWriter.AutoFlush = true;
                logWriter.WriteLine($"{DateTime.Now} Generating for Compiler{p.GrammarName} started.");
            }
            // generate misc
            {
                var log = $"{DateTime.Now} Generating pre-main..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                this.GenerateGrammarInfo(context);
                this.GenerateCompilerXxx(context);
                this.GenerateREADME(context);
                this.GenerateEType(context);
                this.GenerateDataStructure(context);
                this.GenerateSyntaxParserPre(context);
                this.GenerateTExtracter(context);
            }
            // generate lexical analyzer.
            {
                var log = $"{DateTime.Now} Generating lexical analyzer..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                var grammar = context.grammar;
                context.patternDict = grammar.GetPatternDict();
                context.tokenDraftDict = GetTokenDraftDict(context.patternDict);
                this.GenerateLexicalAnalyzerTokensMD(context);
                context.automatonInfo = GetWholeAutomaton(context.tokenDraftDict);
                this.GenerateLexicalAnalyzerKeywords(context);
                this.GenerateLexicalAnalyzerDelegates(context);
                this.GenerateLexicalAnalyzerMermaid(context);
                this.GenerateLexicalAnalyzerREADME(context);
                this.GenerateLexicalAnalyzerDFAStates(context);
                this.GenerateLexicalAnalyzerMiniDFAStates(context);
            }
            // generate syntax parser.
            {
                var log = $"{DateTime.Now} Generating syntax parser..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                var grammar = context.grammar;
                var nullableDict = grammar.VnRegulations.GetNullableDict();
                var firstDict = grammar.VnRegulations.GetFIRSTDict(nullableDict);
                var followDict = grammar.VnRegulations.GetFOLLOWDict(nullableDict, firstDict);
                var nff = new NFF(nullableDict, firstDict, followDict);
                context.nff = nff;
            }
            {
                var log = $"{DateTime.Now} Generating nullable + FIRST + FOLLOW..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                var eEnd = CompilerGrammar.EType.EndOfTokenList;
                var grammar = context.GetExtendedGrammar();
                var nullableDict = grammar.VnRegulations.GetNullableDict(); nullableDict.Add(eEnd, false);
                var firstDict = grammar.VnRegulations.GetFIRSTDict(nullableDict); firstDict.Add(eEnd, new FIRST(eEnd, eEnd));
                var followDict = grammar.VnRegulations.GetFOLLOWDict(nullableDict, firstDict); followDict[grammar.VnRegulations[1].left].TryInsert(eEnd);
                var nff = new NFF(nullableDict, firstDict, followDict);
                context.extendedNFF = nff;
                this.GenerateFIRSTFOLLOW(context);
            }
            {
                var grammar = context.grammar;
                var eGammar = context.GetExtendedGrammar();
                var eNFF = context.extendedNFF;
                {
                    var log = $"{DateTime.Now} Generating LL(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                context.ll1SyntaxInfo = grammar.VnRegulations.GetLL1SyntaxInfo(eGammar.VnRegulations, eNFF.followDict, eNFF.firstDict);
                this.GenerateMainLL1(context);
                this.GenerateSyntaxParserLL1(context);
                {
                    var log = $"{DateTime.Now} Generating LR(0) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                context.lr0SyntaxInfo = grammar.VnRegulations.GetLR0SyntaxInfo(eGammar.VnRegulations);
                this.GenerateMainLR0(context);
                this.GenerateSyntaxParserLR0(context);
                {
                    var log = $"{DateTime.Now} Generating SLR(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                context.slr1SyntaxInfo = grammar.VnRegulations.GetSLR1SyntaxInfo(eGammar.VnRegulations, eNFF.followDict);
                this.GenerateMainSLR1(context);
                this.GenerateSyntaxParserSLR1(context);
                {
                    var log = $"{DateTime.Now} Generating LALR(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                context.lalr1SyntaxInfo = grammar.VnRegulations.GetLALR1SyntaxInfo(eGammar.VnRegulations, eNFF.nullableDict, eNFF.firstDict);
                this.GenerateMainLALR1(context);
                this.GenerateSyntaxParserLALR1(context);
                {
                    var log = $"{DateTime.Now} Generating LR(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                context.lr1SyntaxInfo = grammar.VnRegulations.GetLR1SyntaxInfo(eGammar.VnRegulations, eNFF.nullableDict, eNFF.firstDict);
                this.GenerateMainLR1(context);
                this.GenerateSyntaxParserLR1(context);
            }
            {
                var log = $"{DateTime.Now} Generating post-main..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                this.GenerateMainPost(context);
            }
            {
                logWriter.WriteLine($"{DateTime.Now} Generating for {context.parameter.GrammarName} ended.");
                logWriter.Close();
            }
        }


    }
}