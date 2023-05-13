using bitzhuwei.Compiler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practice.ReplaceComments
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

        class MatchItem
        {
            public int index;
            //public System.Text.RegularExpressions.Match match;
            //public CommentToken match;
            //public Token<Compiler_Char.EType> match;
            public Token match;
            public Color backColor;

            public override string ToString()
            {
                return string.Format("[{0}] is {1}", index, match);
                //return string.Format("{0}: {1}[{2}, {3}]",
                //index, match.value, match.index, match.Length);
            }
        }

        public Form1()
        {
            InitializeComponent();

            this.txtResultSelectionChangedEvent = new ManualEvent()
            {
                added = false,
                handler = new EventHandler(this.txtResult_SelectionChanged),
            };
            this.lstMatchesSelectedIndexChangedEvent = new ManualEvent()
            {
                added = false,
                handler = new EventHandler(this.lstMatches_SelectedIndexChanged),
            };
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fullname = this.openFileDialog1.FileName;
                this.txtFullname.Text = fullname;
                //this.txtPattern.ReadOnly = false;
                var content = System.IO.File.ReadAllText(fullname);
                int originalLength = content.Length;
                //content = regex.Replace(content, string.Empty);
                content = content.Replace("\r", string.Empty);
                if (content.Length != originalLength)
                {
                    MessageBox.Show(@"已去掉行尾的 \r 符号。这是因为RichTextBox中Index+1会同时跳过 \r\n 两个字符。");
                }
                this.currentContent = content;
                UpdateMatches(this.currentContent);//, this.txtPattern.Text);
            }
        }

        private void Unbind()
        {
            if (this.txtResultSelectionChangedEvent.added)
            {
                this.txtResult.SelectionChanged -= this.txtResultSelectionChangedEvent.handler;
                this.txtResultSelectionChangedEvent.added = false;
            }
            if (this.lstMatchesSelectedIndexChangedEvent.added)
            {
                this.lstMatches.SelectedIndexChanged -= this.lstMatchesSelectedIndexChangedEvent.handler;
                this.lstMatchesSelectedIndexChangedEvent.added = false;
            }
        }
        private void Bind()
        {
            if (!this.txtResultSelectionChangedEvent.added)
            {
                this.txtResult.SelectionChanged += this.txtResultSelectionChangedEvent.handler;
                this.txtResultSelectionChangedEvent.added = true;
            }
            if (!this.lstMatchesSelectedIndexChangedEvent.added)
            {
                this.lstMatches.SelectedIndexChanged += this.lstMatchesSelectedIndexChangedEvent.handler;
                this.lstMatchesSelectedIndexChangedEvent.added = true;
            }
        }

        //private static System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\r");

        private string currentContent;

        private void UpdateMatches(string content)//, string pattern)
        {
            this.btnOpenFile.Enabled = false;
            this.Unbind();

            this.txtResult.Clear();
            this.lastSelectedMatchItem = null;

            //string fullname = this.txtFullname.Text;

            //System.Text.RegularExpressions.MatchCollection matches = null;
            //CommentTokenList matches = null;
            //TokenList<Compiler_Char.EType> matches = null;
            TokenList matches = null;
            try
            {
                //if (!string.IsNullOrEmpty(pattern))
                {
                    //matches = System.Text.RegularExpressions.Regex.Matches(content, pattern);
                    // special version.
                    //var analyzer = new CommentAnalyzer();
                    //matches = analyzer.Analyze(content);
                    // generic version.

                    var compiler1 = new Compiler_Comment();
                    matches = compiler1.Analyze(content);
                    //var matches1 = compiler1.Analyze(content);

                    // another version.

                    //var compiler2 = new Compiler_Char();
                    //matches = compiler2.Analyze(content);

                }

                this.txtResult.Text = content;
            }
            catch (Exception ex)
            {
                this.txtResult.Text = ex.Message;
            }

            this.lstMatches.Items.Clear();
            if (matches != null)
            {
                int index = 0; bool red = true;
                //foreach (System.Text.RegularExpressions.Match match in matches)
                //foreach (Token<Compiler_Char.EType> match in matches)
                foreach (Token match in matches)
                {
                    var item = new MatchItem()
                    {
                        index = index,
                        match = match,
                        backColor = red ? Color.Red : Color.Gold
                    };
                    index++;
                    red = !red;
                    this.lstMatches.Items.Add(item);

                    int start = match.index;
                    int length = match.value.Length;
                    this.txtResult.Select(start, length);
                    this.txtResult.SelectionBackColor = item.backColor;
                }

                this.lblNMatches.Text = string.Format("{0} matches", matches.Count);
            }
            else
            {
                this.lblNMatches.Text = string.Format("no matches");
            }

            this.Bind();
            this.btnOpenFile.Enabled = true;
            //this.txtPattern.Focus();
        }

        //private void txtPattern_TextChanged(object sender, EventArgs e)
        //{
        //    string pattern = this.txtPattern.Text;

        //    this.UpdateMatches(this.currentContent, pattern);
        //}

        private static readonly Color selectedBackColor = Color.SkyBlue;
        private MatchItem lastSelectedMatchItem = null;
        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Unbind();

            int index = this.lstMatches.SelectedIndex;
            if (0 <= index && index < this.lstMatches.Items.Count)
            {
                // 恢复本色
                RecoverColor(this.lastSelectedMatchItem);
                // 使用选中色
                {
                    var matchItem = this.lstMatches.SelectedItem as MatchItem;
                    int start = matchItem.match.index;
                    int length = matchItem.match.value.Length;
                    this.txtResult.Select(start, length);
                    this.txtResult.SelectionBackColor = selectedBackColor;
                    this.lastSelectedMatchItem = matchItem;
                }

                this.txtResult.ScrollToCaret();
            }

            this.Bind();
        }

        private ManualEvent txtResultSelectionChangedEvent;
        private ManualEvent lstMatchesSelectedIndexChangedEvent;
        private void txtResult_SelectionChanged(object sender, EventArgs e)
        {
            this.Unbind();

            var lastSelected = this.lastSelectedMatchItem;
            int start = this.txtResult.SelectionStart;

            this.lastSelectedMatchItem = null;
            for (int index = 0; index < this.lstMatches.Items.Count; index++)
            {
                var matchItem = this.lstMatches.Items[index] as MatchItem;
                if (matchItem.match.index <= start
                    && start <= matchItem.match.index + matchItem.match.value.Length)
                {
                    this.lstMatches.SelectedIndex = index;
                    this.lastSelectedMatchItem = matchItem;
                    break;
                }
            }

            // 恢复本色
            RecoverColor(lastSelected);

            this.Bind();
        }

        private void RecoverColor(MatchItem matchItem)
        {
            if (matchItem != null)
            {
                int start0 = this.txtResult.SelectionStart;
                int length0 = this.txtResult.SelectionLength;

                int start = matchItem.match.index;
                int length = matchItem.match.value.Length;
                this.txtResult.Select(start, length);
                this.txtResult.SelectionBackColor = matchItem.backColor;

                this.txtResult.SelectionStart = start0;
                this.txtResult.SelectionLength = length0;
            }
        }

    }
}
