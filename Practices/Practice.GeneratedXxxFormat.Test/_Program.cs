using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;
using bitzhuwei.GrammarFormat;

namespace Practice.GeneratedXxxFormat.Test {
    internal class _Program {
        static void Main(string[] args) {
            //Test.Regexes();

            Test.PrintABB();
            Test.PrintSAB();
            Test.PrintSES();
            Test.PrintInts();
            Test.PrintInts2();
            Test.PrintCalc();
            Test.PrintNumbers();
            Test.PrintError();
            Test.PrintPostfix();
            Test.PrintPrefix();
            Test.PrintGrammar();
            Test.PrintV();
            Test.PrintPattern();
            Test.PrintScope();
            //Test.PrintStep();
        }

        //static void GrammarinCS() {
        //    VnNode statementList, statement, syntaxStatement, lexiStatement, CandidateList, Candidate, VList, V, Vn, Vt;
        //    statementList = Prodction("statementList", "statement");
        //    statementList = Prodction("statement");
        //    statement = Prodction("syntaxStatement");
        //    statement = Prodction("lexiStatement");
        //}

        //static VnNode Prodction(params string[] Vs) { return null; }

        //class VnNode { }
        //class VtNode { }

    }
}
