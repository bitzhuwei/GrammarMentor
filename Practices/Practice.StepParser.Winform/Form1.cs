using bitzhuwei.Compiler;
using bitzhuwei.StepFormat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.StepParser.Winform
{
    public partial class Form1 : Form
    {
        class ManualEvent
        {
            public bool added = false;
            public EventHandler handler;

            public override string ToString()
            {
                return string.Format("{0}, {1}", added, handler);
            }
        }

        class TokenItem
        {
            public int index;
            //public System.Text.RegularExpressions.Match match;
            //public Grammar.StepFormat.Token_Step token;
            //public bitzhuwei.Compiler.Token<Grammar.StepFormat.CompilerStep.ETokenType> token;
            public bitzhuwei.Compiler.Token token;
            public int txtIndex;
            public int txtLength;
            public Color backColor;

            public override string ToString()
            {
                return string.Format("[{0}] is {1}", index, token);
            }
        }

        public Form1(string fullname = null)
        {
            InitializeComponent();

            this.txtResultSelectionChangedEvent = new ManualEvent()
            {
                added = false,
                handler = new EventHandler(this.txtSourceCode_SelectionChanged),
            };
            this.txtMatchesClickEvent = new ManualEvent()
            {
                added = false,
                handler = new EventHandler(this.txtMatchList_Click),
            };

            //if (fullname == null)
            //{
            //    fullname = @"D:\stepFiles\Test_2_jrhg03_1_1-15 liu_duotorus.stp";
            //}

            if (fullname != null)
            {
                this.ScanFile(fullname);
            }
        }

        private void ScanFile(string fullname)
        {
            this.txtFullname.Text = fullname;
            var content = System.IO.File.ReadAllText(fullname);
            int originalLength = content.Length;
            //content = regex.Replace(content, string.Empty);
            content = content.Replace("\r", string.Empty);
            if (content.Length != originalLength)
            {
                this.lblRemoveR.Text = @"已去掉行尾的[\r]字符";
            }
            this.currentContent = content;
            UpdateMatches(this.currentContent);
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fullnames = this.openFileDialog1.FileNames;
                if (fullnames.Length == 1)
                {
                    string fullname = fullnames[0];
                    this.ScanFile(fullname);
                }
                else
                {
                    foreach (var fullname in fullnames)
                    {
                        var form = new Form1(fullname);
                        form.Show();
                    }
                }
            }
        }

        private void Unbind()
        {
            if (this.txtResultSelectionChangedEvent.added)
            {
                this.txtSourceCode.SelectionChanged -= this.txtResultSelectionChangedEvent.handler;
                this.txtResultSelectionChangedEvent.added = false;
            }
            if (this.txtMatchesClickEvent.added)
            {
                this.txtMatchList.Click -= this.txtMatchesClickEvent.handler;
                this.txtMatchesClickEvent.added = false;
            }
        }
        private void Bind()
        {
            if (!this.txtResultSelectionChangedEvent.added)
            {
                this.txtSourceCode.SelectionChanged += this.txtResultSelectionChangedEvent.handler;
                this.txtResultSelectionChangedEvent.added = true;
            }
            if (!this.txtMatchesClickEvent.added)
            {
                this.txtMatchList.Click += this.txtMatchesClickEvent.handler;
                this.txtMatchesClickEvent.added = true;
            }
        }

        //private static System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\r");

        private string currentContent;
        private List<TokenItem> matchItemList = new List<TokenItem>();

        private void UpdateMatches(string content)
        {
            this.Unbind();

            this.txtSourceCode.Clear();
            this.txtMatchList.Clear();
            this.txtMatchListLastSelected = null;

            if (content == null) { content = string.Empty; }
            //var analyzer = new Grammar.StepFormat.Analyzer_Step();
            //Grammar.StepFormat.TokenList_Step tokens = analyzer.Analyze(content);
            //var parser = new Grammar.StepFormat.Parser_Step();
            //Grammar.StepFormat.Node_Step node = parser.Parse(tokens);
            //DumpInfo(matches);
            //var compiler = new Grammar.StepFormat.CompilerStep();
            //var tokens = compiler.Analyze(content);
            //var node = compiler.Parse(tokens);
            var compiler = new bitzhuwei.StepFormat.CompilerStep();
            var tokens = compiler.Analyze(content);
            var node = compiler.Parse(tokens);
            var stepFile = compiler.Extract(node, tokens);
            var builer = new StringBuilder();
            using (var w = new StringWriter(builer)) { stepFile.Print(w); }
            content = builer.ToString(); // this is formatted source code.
            content = content.Replace("\r", string.Empty);
            tokens = compiler.Analyze(content);
            node = compiler.Parse(tokens);
            stepFile = compiler.Extract(node, tokens);

            this.txtSourceCode.Text = content;
            bool red = true; int txtIndex = 0;
            int count = tokens.Count;
            this.lblNMatches.Text = string.Format("{0} matches", count);
            for (int index = 0; index < count; index++)
            {
                var token = tokens[index];
                //string line = string.Format("{0}:{1}[{2}]{3}", index, token.type, token.value, Environment.NewLine);
                string line = $"[{index}]={token}{Environment.NewLine}";
                var item = new TokenItem()
                {
                    index = index,
                    token = token,
                    txtIndex = txtIndex,
                    txtLength = line.Length,
                    backColor = red ? Color.Red : Color.Gold
                };
                txtIndex += line.Length;
                this.matchItemList.Add(item);
                this.txtMatchList.AppendText(line);

                this.txtSourceCode.Select(token.index, token.value.Length);
                this.txtSourceCode.SelectionBackColor = item.backColor;
                red = !red;
            }

            this.Bind();
        }

        //private void DumpInfo(Grammar.StepFormat.TokenList_Step matches)
        //private void DumpInfo(TokenList matches)
        //{
        //    int count = matches.Count;
        //    var list = new SortedList<string, string>();
        //    for (int index = 0; index < count; index++)
        //    {
        //        var token = matches[index];
        //        //if (token.type == Grammar.StepFormat.ETokenType_Step.TypeName)
        //        if (token.type == bitzhuwei.StepFormat.CompilerStep.EType.TypeName)
        //        {
        //            if (!list.ContainsKey(token.value))
        //            {
        //                list.Add(token.value, token.value);
        //            }
        //        }
        //    }

        //    using (var w = new System.IO.StreamWriter(string.Format("Types{0:yyyy-MM-dd_HH-mm-ss.fff}.txt", DateTime.Now)))
        //    {
        //        foreach (var item in list)
        //        {
        //            w.WriteLine(item.Value);
        //        }
        //    }
        //}

        private static readonly Color selectedBackColor = Color.SkyBlue;
        /// <summary>
        /// 在<paramref name="txtMatchList"/>中上次选择的<paramref name="MatchItem"/>。
        /// </summary>
        private TokenItem txtMatchListLastSelected = null;

        private void txtMatchList_Click(object sender, EventArgs e)
        {
            this.Unbind();

            this.btnOpenFile.Enabled = false;

            int index = this.txtMatchList.GetFirstCharIndexOfCurrentLine();
            int line = this.txtMatchList.GetLineFromCharIndex(index);
            if (0 <= line && line < this.matchItemList.Count)
            {
                var matchItem = this.matchItemList[line];
                var last = this.txtMatchListLastSelected;
                if (matchItem != last)
                {
                    // 恢复本色
                    RecoverColor(last);
                    this.txtMatchListLastSelected = matchItem;
                    // 使用选中色
                    int start = matchItem.token.index;
                    int length = matchItem.token.value.Length;
                    this.txtSourceCode.Select(start, length);
                    this.txtSourceCode.SelectionBackColor = selectedBackColor;
                    this.txtSourceCode.ScrollToCaret();
                }
            }

            this.btnOpenFile.Enabled = true;

            this.Bind();
        }

        private ManualEvent txtResultSelectionChangedEvent;
        private ManualEvent txtMatchesClickEvent;
        private void txtSourceCode_SelectionChanged(object sender, EventArgs e)
        {
            this.Unbind();

            //var lastSelected = this.txtMatchListLastSelected;
            int start = this.txtSourceCode.SelectionStart;
            //this.txtMatchListLastSelected = null;

            for (int index = 0; index < this.matchItemList.Count; index++)
            {
                var matchItem = this.matchItemList[index];
                if (matchItem.token.index <= start
                    && start <= matchItem.token.index + matchItem.token.value.Length)
                {
                    this.txtMatchList.Select(matchItem.txtIndex, 0);
                    this.txtMatchList.ScrollToCaret();
                    this.txtMatchList.Select(matchItem.txtIndex, matchItem.txtLength);
                    //this.txtMatchList.Focus();
                    //this.txtMatchListLastSelected = matchItem;
                    break;
                }
            }

            //if (lastSelected != this.txtMatchListLastSelected)
            //{
            //    // 恢复本色
            //    RecoverColor(lastSelected);
            //}

            this.Bind();
        }

        /// <summary>
        /// 恢复本色
        /// </summary>
        /// <param name="matchItem"></param>
        private void RecoverColor(TokenItem matchItem)
        {
            if (matchItem != null)
            {
                int start0 = this.txtSourceCode.SelectionStart;
                int length0 = this.txtSourceCode.SelectionLength;

                int start = matchItem.token.index;
                int length = matchItem.token.value.Length;
                this.txtSourceCode.Select(start, length);
                this.txtSourceCode.SelectionBackColor = matchItem.backColor;

                this.txtSourceCode.SelectionStart = start0;
                this.txtSourceCode.SelectionLength = length0;
            }
        }

        private void lblRemoveR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"已去掉行尾的 \r 符号。这是因为RichTextBox中Index+1会同时跳过 \r\n 两个字符。");
        }



    }
}
