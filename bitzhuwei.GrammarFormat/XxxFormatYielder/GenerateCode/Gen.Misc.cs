using bitzhuwei.Compiler;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace bitzhuwei.GrammarFormat {
    partial class GrammarDraft {
        const string templateMain =
            @"yieldTemplate\CompilerXxx.cs_";
        const string templateReadmeFull =
            @"yieldTemplate\doc\readme-full.md";
        const string templateREADME =
            @"yieldTemplate\README.md";
        const string templateNFF =
            @"yieldTemplate\doc\Nullable-FIRST-FOLLOW.md";
        const string templateSyntaxMachineLL1 =
            @"yieldTemplate\doc\SyntaxMachine.LL(1).md";
        const string templateSytnaxMachineLR0 =
            @"yieldTemplate\doc\SytnaxMachine.LR(0).md";
        const string templateSyntaxMachineSLR1 =
            @"yieldTemplate\doc\SyntaxMachine.SLR(1).md";
        const string templateSyntaxMachineLALR1 =
            @"yieldTemplate\doc\SyntaxMachine.LALR(1).md";
        const string templateSyntaxMachineLR1 =
            @"yieldTemplate\doc\SyntaxMachine.LR(1).md";
        const string templateEType =
            @"yieldTemplate\CompilerXxx.EType.cs_";
        const string templateTableLL1 =
            @"yieldTemplate\SyntaxParser\CompilerXxx.Table.LL(1).cs_";
        const string templateTableLR =
            @"yieldTemplate\SyntaxParser\CompilerXxx.Table.LR.cs_";
        const string templateSyntaxParserREADME =
            @"yieldTemplate\SyntaxParser\README.md";
        const string templateRegulation =
            @"yieldTemplate\SyntaxParser\CompilerXxx.Regulations.cs_";
        const string templateTExtracter =
            @"yieldTemplate\TExtracter\XxxExtracter.Init.cs_";
        const string templateTExtracterREADME =
            @"yieldTemplate\TExtracter\README.md";
        const string templateLexicalDelegates =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalDelegates.cs_";
        const string templateLexicalKeywords =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalKeywords.cs_";
        const string templateLexicalState0 =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalState0.cs_";
        const string templateLexicalState1_1 =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalState1_1.cs_";
        const string templateLexicalState1_2 =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalState1_2.cs_";
        const string templateLexicalState1_3 =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalState1_3.cs_";
        const string templateLexicalState1_4 =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalState1_4.cs_";
        const string templateLexicalStates =
            @"yieldTemplate\LexicalAnalyzer\CompilerXxx.LexicalStates.cs_";
        const string templateLexicalAnalyzerREADME =
            @"yieldTemplate\LexicalAnalyzer\README.md";
        const string templateLexicalAnalyzerChooseDFAorMiniDFA =
            @"yieldTemplate\LexicalAnalyzer\ChooseDFAorMiniDFA.md";
        const string templateDataStructureExtractedType =
            @"yieldTemplate\DataStructure\ExtractedType.cs_";
        const string templateDataStructureVn =
            @"yieldTemplate\DataStructure\Vn.cs_";

        //private static readonly Regex regexGrammarName = new Regex(@"\{GrammarName\}");
        //private static readonly Regex regexExtractedType = new Regex(@"\{ExtractedType\}");
        //private static readonly Regex regexExtractedType_var = new Regex(@"\{ExtractedType[.]var\}");
        //private static readonly Regex regexVtDeclarationList = new Regex(@"\{VtDeclarationList\}");
        //private static readonly Regex regexVnDeclarationList = new Regex(@"\{VnDeclarationList\}");
        //private static readonly Regex regexnow = new Regex(@"\{now\}");
        //private static readonly Regex regexGrammar = new Regex(@"\{Grammar\}");
        //private static readonly Regex regexFirstList = new Regex(@"\{FirstList\}");
        //private static readonly Regex regexFollowList = new Regex(@"\{FollowList\}");
        //private static readonly Regex regexLR0States = new Regex(@"\{LR\(0\)States\}");
        //private static readonly Regex regexLR0Edges = new Regex(@"\{LR\(0\)Edges\}");
        //private static readonly Regex regexSLRStates = new Regex(@"\{SLRStates\}");
        //private static readonly Regex regexSLREdges = new Regex(@"\{SLREdges\}");
        //private static readonly Regex regexLALR1States = new Regex(@"\{LALR\(1\)States\}");
        //private static readonly Regex regexLALR1Edges = new Regex(@"\{LALR\(1\)Edges\}");
        //private static readonly Regex regexLR1States = new Regex(@"\{LR\(1\)States\}");
        //private static readonly Regex regexLR1Edges = new Regex(@"\{LR\(1\)Edges\}");
        //private static readonly Regex regexsyntaxStateCount = new Regex(@"\{syntaxStateCount\}");
        //private static readonly Regex regexi_syntaxStates = new Regex(@"\{i_syntaxStates\}");
        //private static readonly Regex regexactionDict_Add_List = new Regex(@"\{actionDict[.]Add[.]List\}");
        //private static readonly Regex regexnew_Regulations = new Regex(@"\{new[.]Regulation\[\]\}");
        //private static readonly Regex regexkeywordDelcaration_List = new Regex(@"\{keywordDelcaration[.]List\}");
        //private static readonly Regex regexvtRegex = new Regex(@"\{vtRegex\}");
        const string strGrammarName = @"{GrammarName}";
        const string strVn = @"{Vn}";
        const string strExtractedType = @"{ExtractedType}";
        const string strExtractedType_var = @"{ExtractedType.var}";
        const string strextracterDict_Add_List = @"{extracterDict.Add.List}";

        const string strLexicalStateId = "{LexicalStateId}";
        const string strnewLexicalRuleList = "{newLexicalRuleList}";
        const string strLexicalStateCount = "{LexicalStateCount}";
        const string strVtRegexList = "{VtRegexList}";
        const string strextractedENFA = "{extracted ε-NFA}";
        const string strcompletedENFA = "{completed ε-NFA}";
        const string strNFA = "{NFA}";
        const string strDFA = "{DFA}";
        const string strDFASimple = "{DFA.simple}";
        const string strminiDFA = "{miniDFA}";
        const string strminiDFASimple = "{miniDFA.simple}";

        const string strVtDeclarationList = @"{VtDeclarationList}";
        const string strVnDeclarationList = @"{VnDeclarationList}";

        //const string strnow = @"{now}";
        const string strGrammar = @"{Grammar}";
        const string strLexicalAnalyerStatesDFA = @"{LexicalAnalyerStates(DFA)}";
        const string strnullable = @"{nullable}";
        const string strFirstList = @"{FirstList}";
        const string strFollowList = @"{FollowList}";

        //const string strLR0States = @"{LR(0)States}";
        //const string strSLR1States = @"{SLR(1)States}";
        //const string strLALR1States = @"{LALR(1)States}";
        //const string strLR1States = @"{LR(1)States}";

        //const string strLR0Edges = @"{LR(0)Edges}";
        //const string strSLR1Edges = @"{SLR(1)Edges}";
        //const string strLALR1Edges = @"{LALR(1)Edges}";
        //const string strLR1Edges = @"{LR(1)Edges}";

        const string strLR0SyntaxDiagram = @"{LR(0)SyntaxDiagram}";
        const string strSLRSyntaxDiagram = @"{SLR(1)SyntaxDiagram}";
        const string strLALR1SyntaxDiagram = @"{LALR(1)SyntaxDiagram}";
        const string strLR1SyntaxDiagram = @"{LR(1)SyntaxDiagram}";

        const string strLL1SyntaxTable = @"{LL(1)SyntaxTable}";
        const string strLR0SyntaxTable = @"{LR(0)SyntaxTable}";
        const string strSLR1SyntaxTable = @"{SLR(1)SyntaxTable}";
        const string strLALR1SyntaxTable = @"{LALR(1)SyntaxTable}";
        const string strLR1SyntaxTable = @"{LR(1)SyntaxTable}";

        const string strfirstVn = @"{firstVn}";
        const string strVnCount = @"{VnCount}";
        const string strsyntaxStateCount = @"{syntaxStateCount}";
        const string stractionCount = @"{actionCount}";
        const string strconflicts = @"{conflicts}";
        const string strEParsingTable = @"{EParsingTable}";
        const string stractionDict_Add_List = @"{actionDict.Add.List}";
        const string strnew_Regulations = @"{new.Regulation[]}";
        const string strkeywordDelcaration_List = @"{keywordDelcaration.List}";
        const string strCheckKeywordCases = @"{CheckKeywordCases}";
        const string strvtRegex = @"{vtRegex}";

    }
}