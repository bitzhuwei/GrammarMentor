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
                logWriter.WriteLine($"{DateTime.Now} GenerateGrammarInfo..");
                this.GenerateGrammarInfo(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateCompilerXxx..");
                this.GenerateCompilerXxx(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateREADME..");
                this.GenerateREADME(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateEType..");
                this.GenerateEType(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateDataStructure..");
                this.GenerateDataStructure(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateSyntaxParserPre..");
                this.GenerateSyntaxParserPre(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateTExtracter..");
                this.GenerateTExtracter(context);
            }
            // generate lexical analyzer.
            {
                var log = $"{DateTime.Now} Generating lexical analyzer..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                var grammar = context.grammar;
                logWriter.WriteLine($"{DateTime.Now} GetPatternDict..");
                context.patternDict = grammar.GetPatternDict();
                logWriter.WriteLine($"{DateTime.Now} GetTokenDraftDict..");
                context.tokenDraftDict = GetTokenDraftDict(context.patternDict);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerTokensMD..");
                this.GenerateLexicalAnalyzerTokensMD(context);
                logWriter.WriteLine($"{DateTime.Now} GetWholeAutomaton..");
                context.automatonInfo = GetWholeAutomaton(context.tokenDraftDict);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerKeywords..");
                this.GenerateLexicalAnalyzerKeywords(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerDelegates..");
                this.GenerateLexicalAnalyzerDelegates(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerMermaid..");
                this.GenerateLexicalAnalyzerMermaid(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerREADME..");
                this.GenerateLexicalAnalyzerREADME(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerDFAStates..");
                this.GenerateLexicalAnalyzerDFAStates(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateLexicalAnalyzerMiniDFAStates..");
                this.GenerateLexicalAnalyzerMiniDFAStates(context);
            }
            // generate syntax parser.
            {
                var log = $"{DateTime.Now} Generating syntax parser..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                var grammar = context.grammar;
                logWriter.WriteLine($"{DateTime.Now} GetNullableDict..");
                var nullableDict = grammar.VnRegulations.GetNullableDict();
                logWriter.WriteLine($"{DateTime.Now} GetFIRSTDict..");
                var firstDict = grammar.VnRegulations.GetFIRSTDict(nullableDict);
                logWriter.WriteLine($"{DateTime.Now} GetFOLLOWDict..");
                var followDict = grammar.VnRegulations.GetFOLLOWDict(nullableDict, firstDict);
                var nff = new NFF(nullableDict, firstDict, followDict);
                context.nff = nff;
            }
            {
                var log = $"{DateTime.Now} Generating nullable + FIRST + FOLLOW..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                var eEnd = CompilerGrammar.EType.EndOfTokenList;
                logWriter.WriteLine($"{DateTime.Now} GetExtendedGrammar..");
                var grammar = context.GetExtendedGrammar();
                logWriter.WriteLine($"{DateTime.Now} GetNullableDict..");
                var nullableDict = grammar.VnRegulations.GetNullableDict(); nullableDict.Add(eEnd, false);
                logWriter.WriteLine($"{DateTime.Now} GetFIRSTDict..");
                var firstDict = grammar.VnRegulations.GetFIRSTDict(nullableDict); firstDict.Add(eEnd, new FIRST(eEnd, eEnd));
                logWriter.WriteLine($"{DateTime.Now} GetFOLLOWDict..");
                var followDict = grammar.VnRegulations.GetFOLLOWDict(nullableDict, firstDict); followDict[grammar.VnRegulations[1].left].TryInsert(eEnd);
                var nff = new NFF(nullableDict, firstDict, followDict);
                context.extendedNFF = nff;
                logWriter.WriteLine($"{DateTime.Now} GenerateFIRSTFOLLOW..");
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
                logWriter.WriteLine($"{DateTime.Now} GetLL1SyntaxInfo..");
                context.ll1SyntaxInfo = grammar.VnRegulations.GetLL1SyntaxInfo(eGammar.VnRegulations, eNFF.followDict, eNFF.firstDict);
                logWriter.WriteLine($"{DateTime.Now} GenerateMainLL1..");
                this.GenerateMainLL1(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateSyntaxParserLL1..");
                this.GenerateSyntaxParserLL1(context);
                {
                    var log = $"{DateTime.Now} Generating LR(0) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                context.lr0SyntaxInfo = grammar.VnRegulations.GetLR0SyntaxInfo(eGammar.VnRegulations);
                logWriter.WriteLine($"{DateTime.Now} GenerateMainLR0..");
                this.GenerateMainLR0(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateSyntaxParserLR0..");
                this.GenerateSyntaxParserLR0(context);
                {
                    var log = $"{DateTime.Now} Generating SLR(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                logWriter.WriteLine($"{DateTime.Now} GetSLR1SyntaxInfo..");
                context.slr1SyntaxInfo = grammar.VnRegulations.GetSLR1SyntaxInfo(eGammar.VnRegulations, eNFF.followDict);
                logWriter.WriteLine($"{DateTime.Now} GenerateMainSLR1..");
                this.GenerateMainSLR1(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateSyntaxParserSLR1..");
                this.GenerateSyntaxParserSLR1(context);
                {
                    var log = $"{DateTime.Now} Generating LALR(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                logWriter.WriteLine($"{DateTime.Now} lalr1SyntaxInfo..");
                context.lalr1SyntaxInfo = grammar.VnRegulations.GetLALR1SyntaxInfo(eGammar.VnRegulations, eNFF.nullableDict, eNFF.firstDict);
                logWriter.WriteLine($"{DateTime.Now} GenerateMainLALR1..");
                this.GenerateMainLALR1(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateSyntaxParserLALR1..");
                this.GenerateSyntaxParserLALR1(context);
                {
                    var log = $"{DateTime.Now} Generating LR(1) syntax info..";
                    Console.WriteLine(log); logWriter.WriteLine(log);
                }
                logWriter.WriteLine($"{DateTime.Now} GetLR1SyntaxInfo..");
                context.lr1SyntaxInfo = grammar.VnRegulations.GetLR1SyntaxInfo(eGammar.VnRegulations, eNFF.nullableDict, eNFF.firstDict);
                logWriter.WriteLine($"{DateTime.Now} GenerateMainLR1..");
                this.GenerateMainLR1(context);
                logWriter.WriteLine($"{DateTime.Now} GenerateSyntaxParserLR1..");
                this.GenerateSyntaxParserLR1(context);
            }
            {
                var log = $"{DateTime.Now} Generating post-main..";
                Console.WriteLine(log); logWriter.WriteLine(log);
                logWriter.WriteLine($"{DateTime.Now} GenerateMainPost..");
                this.GenerateMainPost(context);
            }
            {
                logWriter.WriteLine($"{DateTime.Now} Generating for {context.parameter.GrammarName} ended.");
                logWriter.Close();
            }
        }
    }
}