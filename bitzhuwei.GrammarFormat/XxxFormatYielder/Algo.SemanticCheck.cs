using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using bitzhuwei.Compiler;

namespace bitzhuwei.GrammarFormat {
    public static partial class Algorithm {
        /// <summary>
        /// returns true if something is wrong.
        /// </summary>
        /// <param name="grammar"></param>
        /// <param name="errorInfo"></param>
        /// <returns></returns>
        public static bool SemanticCheck(this GrammarDraft grammar, out string errorInfo) {
            var b = new StringBuilder();
            // no regulation at all?
            bool error = CheckFirstRegulation(grammar.VnRegulations, b);
            if (!error) {
                {
                    // duplicated regulation?
                    bool innerError = CheckDuplication(grammar.VnRegulations, b);
                    if (innerError) { error = true; }
                }
                {
                    // duplicated Vt expression?
                    bool innerError = CheckDuplication(grammar.VtPatterns, b);
                    if (innerError) { error = true; }
                }
                {
                    // lack of regulation for some Vn?
                    bool innerError = CheckLackRegulation(grammar.VnRegulations, b);
                    if (innerError) { error = true; }
                }
                {
                    // useless Vn?
                    bool innerError = CheckUnusedVn(grammar.VnRegulations, b);
                    if (innerError) { error = true; }
                }
                {
                    // the keyword(empty) is not allowed to be a Vn.
                    bool innerError = CheckKeyword(grammar.VnRegulations, b);
                    if (innerError) { error = true; }
                }
                {
                    // Vn : Vn ; is meaningless.
                    bool innerError = CheckLeftIsRight(grammar.VnRegulations, b);
                    if (innerError) { error = true; }
                }
                {
                    // Vn name should be [a-zA-Z_][a-zA-Z0-9_]*
                    bool innerError = CheckVnName(grammar.VnRegulations, b);
                    if (innerError) { error = true; }
                }
            }

            errorInfo = b.ToString();

            return error;
        }

        private static bool CheckVnName(VnRegulationDraft[] regulations, StringBuilder b) {
            var error = false;
            for (int i = 0; i < regulations.Length; i++) {
                var regulation = regulations[i];
                var list = new List<string>(); list.Add(regulation.left); // list.AddRange(regulation.Right);
                foreach (var V in list) {
                    if (V.IsVn()) {
                        if (string.IsNullOrEmpty(V)) {
                            b.AppendLine($"empty node name in regulations[{i}]");
                            error = true;
                            break;
                        }
                        var first = V[0];
                        if (!
                             (
                              ('a' <= first && first <= 'z')
                              || ('A' <= first && first <= 'Z')
                              || (first == '_')
                             )
                            ) {
                            b.AppendLine($"in regulations[{i}]:{V} should start with letter or _");
                            error = true;
                            break;
                        }
                        for (int j = 1; j < V.Length; j++) {
                            var c = V[j];
                            if (!
                                (
                                 ('a' <= first && first <= 'z')
                                 || ('A' <= first && first <= 'Z')
                                 || ('0' <= first && first <= '9')
                                 || (first == '_')
                                )
                               ) {
                                b.AppendLine($"in regulations[{i}]:{V} should NOT contains '{c}'");
                                error = true;
                                break;
                            }
                        }
                    }
                }
            }

            return error;
        }

        private static bool CheckLeftIsRight(VnRegulationDraft[] regulations, StringBuilder b) {
            var error = false;
            int length = regulations.Length;
            for (int i = 0; i < length; i++) {
                var regulation = regulations[i];
                if (regulation.Right.Count == 1) {
                    var right0 = regulation.Right[0];
                    var left = regulation.left;
                    if (left == right0) {
                        b.AppendLine($"meaningless regulations[{i}] = {regulation}");
                        error = true;
                    }
                }
            }

            return error;
        }

        /// <summary>
        /// the keyword(empty) is not allowed to be a Vn.
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static bool CheckKeyword(VnRegulationDraft[] regulations, StringBuilder b) {
            var error = false;
            for (int index = 0; index < regulations.Length; index++) {
                var left = regulations[index].left;
                if (left == CompilerGrammar.keywordEmpty) {
                    b.AppendLine($"The keyword(empty) is not allowed to be a Vn at:");
                    b.AppendLine($"regulations[{index}] = {regulations[index]}");
                    error = true;
                }
            }

            return error;
        }

        /// <summary>
        /// useless Vn?
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static bool CheckUnusedVn(VnRegulationDraft[] regulations, StringBuilder b) {
            var usedList = new List<string>();/*List<Node.type>*/
            usedList.Add(regulations[0].left);
            bool changed = false;
            int index = 0;
            do {
                changed = false;
                int count = usedList.Count;
                for (; index < count; index++) {
                    var node = usedList[index];
                    foreach (var regulation in regulations) {
                        if (regulation.left == node) {
                            foreach (var item in regulation.Right) {
                                if ((item.IsVn()) && (!usedList.Contains(item))) {
                                    usedList.Add(item);
                                    changed = true;
                                }
                            }
                        }
                    }
                }
            } while (changed);

            var unusedList = new List<string>();
            var Vns = regulations.GetVnNodes();
            foreach (var Vn in Vns) {
                if (!usedList.Contains(Vn)) {
                    unusedList.Add(Vn);
                }
            }

            int unusedCount = unusedList.Count;
            if (unusedCount > 0) {
                b.AppendLine(equalLine);
                b.AppendLine($"{unusedCount} unused nodes:");
                foreach (var item in unusedList) {
                    b.AppendLine(item);
                }
            }
            return unusedCount > 0;
        }

        /// <summary>
        /// lack of regulation for some Vn?
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static bool CheckLackRegulation(VnRegulationDraft[] regulations, StringBuilder b) {

            var lackList = new List<string>(); /*new List<Node.type>()*/
            var Vns = regulations.GetVnNodes();

            foreach (var regulation in regulations) {
                foreach (var node in regulation.Right) {
                    if ((node.IsVn()) // this node is Vn.
                        && (!Vns.Contains(node)) // no regulation for this node.
                        && (!lackList.Contains(node))) // not added to result yet.
                    {
                        lackList.Add(node);
                    }
                }
            }

            int count = lackList.Count;
            if (count > 0) {
                b.AppendLine(equalLine);
                b.AppendLine($"Lack of [{count}] regulation's definitions:");
                foreach (var item in lackList) {
                    b.AppendLine(item);
                }
            }

            return count > 0;
        }

        /// <summary>
        /// duplicated Vt expression?
        /// </summary>
        /// <param name="vtRegexes"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static bool CheckDuplication(VtPatternDraft[] vtRegexes, StringBuilder b) {
            var groups = from item in vtRegexes
                         group item by item.ToString() into g
                         where g.Count() > 1
                         select g;
            int duplicatedCount = groups.Count();
            if (duplicatedCount > 0) {
                b.AppendLine(equalLine);
                b.AppendLine($"[{duplicatedCount}] duplicated lexicalStatements:");
                foreach (var group in groups) {
                    b.AppendLine($"The regulation [{group.Key}] duplicated [{group.Count()}] times!");
                }
            }

            return duplicatedCount > 0;
        }

        /// <summary>
        /// duplicated regulation?
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static bool CheckDuplication(VnRegulationDraft[] regulations, StringBuilder b) {
            var groups = from item in regulations
                         group item by item.ToString() into g
                         where g.Count() > 1
                         select g;
            int duplicatedCount = groups.Count();
            if (duplicatedCount > 0) {
                b.AppendLine(equalLine);
                b.AppendLine($"[{duplicatedCount}] duplicated regulations:");
                foreach (var group in groups) {
                    b.AppendLine($"The regulation [{group.Key}] duplicated [{group.Count()}] times!");
                }
            }

            return duplicatedCount > 0;
        }
        private static bool CheckFirstRegulation(VnRegulationDraft[] regulations, StringBuilder b) {
            bool none = regulations == null || regulations.Length == 0;
            if (none) {
                b.AppendLine(equalLine);
                b.AppendLine($"No regulation exists!");
            }

            return none;
        }

        private const string equalLine = "====================================================================";
    }
}
