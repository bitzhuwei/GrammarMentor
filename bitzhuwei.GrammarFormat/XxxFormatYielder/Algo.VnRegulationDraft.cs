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
        /// get all <see cref="VnRegulationDraft"/> objects whose <see cref="VnRegulationDraft.left"/> is <paramref name="left"/>.
        /// </summary>
        /// <param name="regulations"></param>
        /// <param name="left"><see cref="Node.type"/></param>
        /// <returns></returns>
        public static VnRegulationDraft[] GetVnRegulations(this VnRegulationDraft[] regulations, string/*Node.type*/ left) {
            var result = new List<VnRegulationDraft>();
            foreach (var item in regulations) {
                if (item.left == left) {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Get all Vn nodes from the <see cref="VnRegulationDraft.left"/>.
        /// </summary>
        /// <param name="regulations"></param>
        /// <returns></returns>
        public static string[] GetVnNodes(this VnRegulationDraft[] regulations) {
            //var query = (from item in regulations
            //             select item.left).Distinct().ToArray();
            var result = new List<string>();

            foreach (var regulation in regulations) {
                {
                    var node = regulation.left;
                    if (!result.Contains(node)) { result.Add(node); }
                }
            }

            return result.ToArray();
        }

        /// <summary>
        /// Get all Vt nodes.
        /// </summary>
        /// <param name="regulations"></param>
        /// <returns></returns>
        public static string[] GetVtNodes(this VnRegulationDraft[] regulations) {
            var result = new List<string>();

            foreach (var regulation in regulations) {
                foreach (var node in regulation.Right) {
                    if (node.IsVt()) {
                        if (!result.Contains(node)) {
                            result.Add(node);
                        }
                    }
                }
            }

            return result.ToArray();
        }
        /// <summary>
        /// Get all nodes(Vn and Vt, no <see cref="CompilerGrammar.keywordEmpty"/>).
        /// <para><see cref="CompilerGrammar.keywordEmpty"/> is neither a Vt nor a Vn.</para>
        /// </summary>
        /// <param name="regulations"></param>
        /// <returns></returns>
        public static string[] GetNodes(this VnRegulationDraft[] regulations) {
            var result = new List<string>();

            foreach (var regulation in regulations) {
                {
                    var node = regulation.left;
                    if (!result.Contains(node)) { result.Add(node); }
                }

                foreach (var node in regulation.Right) {
                    if (!result.Contains(node)) { result.Add(node); }
                }

                //if (regulation.Right.Count == 0)
                //{
                //    if (!result.Contains(CompilerGrammar.keywordEmpty)) { result.Add(CompilerGrammar.keywordEmpty); }
                //}
            }

            return result.ToArray();
        }
    }
}
