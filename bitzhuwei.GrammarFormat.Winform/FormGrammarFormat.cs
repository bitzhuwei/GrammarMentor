using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bitzhuwei.GrammarFormat.Winform {
    public partial class FormGrammarFormat : Form {
        public FormGrammarFormat() {
            InitializeComponent();
        }

        readonly CompilerGrammar compiler = new CompilerGrammar();

        private void btnGenerate_Click(object sender, EventArgs e) {
            this.btnGenerate.Enabled = false;

            try {
                var folder = this.txtGenerationDirectory.Text;
                var grammarName = this.txtGrammarName.Text;
                var extractedType = this.txtExtractedType.Text;
                var sourceCode = this.txtGrammar.Text; // File.ReadAllText(@"Eg.StepFormat.st");// this.txtGrammar.Text;

                var tokens = compiler.Analyze(sourceCode);
                if (Directory.Exists(folder)) {
                    foreach (var item in Directory.EnumerateFiles(folder, "*.*", SearchOption.AllDirectories)) {
                        File.Delete(item);
                    }
                }
                else { Directory.CreateDirectory(folder); }

                //System.Diagnostics.Process.Start("explorer.exe", folder);// there's something to show now.
                var node = compiler.Parse(tokens);
                var grammar = compiler.Extract(node, tokens);
                var error = grammar.SemanticCheck(out var errorInfo);
                if (!error) {
                    var vn = grammar.VnRegulations[0].left;
                    var sameFirstName = (vn == extractedType);
                    if (sameFirstName) { extractedType = extractedType + "@"; }
                    var parameter = new YieldParameter(folder, grammarName, extractedType, sourceCode, tokens, node);
                    grammar.YieldCompiler(parameter);
                    if (sameFirstName) {
                        MessageBox.Show($"提取的class名称[{vn}]与Grammar的第一个Vn相同，请注意修改[{vn}Extracter.Init.cs]！提示：搜索[EType.EndOfTokenList]");
                    }
                }
                else {
                    MessageBox.Show($"{errorInfo}");
                }
            }
            catch (Exception ex) {
                MessageBox.Show($"{ex}");
            }

            this.btnGenerate.Enabled = true;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e) {
            if (this.folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                this.txtGenerationDirectory.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }

    }
}
