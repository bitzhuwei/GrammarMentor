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

namespace Practice.RegularExpression.Winform {
    public partial class FormRegularExpresion : Form {
        class ManualEvent {
            public bool added = false;
            public EventHandler handler;

            public override string ToString() {
                return string.Format("{0}, {1}", added, handler);
            }
        }

        class MatchItem {
            public int index;
            public System.Text.RegularExpressions.Match match;
            public int txtIndex;
            public int txtLength;
            public Color backColor;

            public override string ToString() {
                return string.Format("{0}: {1}[{2}, {3}]",
                    index, match.Value, match.Index, match.Length);
            }
        }

        public FormRegularExpresion(string fullname = null, string pattern = null) {
            InitializeComponent();

            this.txtResultSelectionChangedEvent = new ManualEvent() {
                added = false,
                handler = new EventHandler(this.txtResult_SelectionChanged),
            };
            this.txtMatchesClickEvent = new ManualEvent() {
                added = false,
                handler = new EventHandler(this.txtMatches_Click),
            };

            if (fullname != null) {
                this.ScanFile(fullname, pattern);
            }
        }

        private void ScanFile(string fullname, string pattern) {
            var fileInfo = new FileInfo(fullname);
            this.fileSystemWatcher1.Path = fileInfo.DirectoryName;
            this.fileSystemWatcher1.Filter = fileInfo.Name;
            this.txtPattern.Text = pattern;
            this.txtFullname.Text = fullname;
            var content = ReadAllText(fullname); /*System.IO.File.ReadAllText(fullname);*/
            int originalLength = content.Length;
            //content = regex.Replace(content, string.Empty);
            content = content.Replace("\r", string.Empty);
            if (content.Length != originalLength) {
                this.lblRemoveR.Text = @"已去掉行尾的 \r 符号";
            }
            this.currentContent = content;
            UpdateMatches(this.currentContent, this.txtPattern.Text);
        }
        private void btnOpenFile_Click(object sender, EventArgs e) {
            if (this.openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                string[] fullnames = this.openFileDialog1.FileNames;
                string pattern = this.txtPattern.Text;
                if (fullnames.Length == 1) {
                    string fullname = fullnames[0];
                    this.ScanFile(fullname, pattern);
                }
                else {
                    foreach (var fullname in fullnames) {
                        var form = new FormRegularExpresion(fullname, pattern);
                        form.Show();
                    }
                }
            }
        }

        private void Unbind() {
            if (this.txtResultSelectionChangedEvent.added) {
                this.txtResult.SelectionChanged -= this.txtResultSelectionChangedEvent.handler;
                this.txtResultSelectionChangedEvent.added = false;
            }
            if (this.txtMatchesClickEvent.added) {
                this.txtMatches.Click -= this.txtMatchesClickEvent.handler;
                this.txtMatchesClickEvent.added = false;
            }
        }
        private void Bind() {
            if (!this.txtResultSelectionChangedEvent.added) {
                this.txtResult.SelectionChanged += this.txtResultSelectionChangedEvent.handler;
                this.txtResultSelectionChangedEvent.added = true;
            }
            if (!this.txtMatchesClickEvent.added) {
                this.txtMatches.Click += this.txtMatchesClickEvent.handler;
                this.txtMatchesClickEvent.added = true;
            }
        }

        //private static System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"\r");

        private string currentContent;
        private readonly List<MatchItem> matchItemList = new List<MatchItem>();

        private void UpdateMatches(string content, string pattern) {
            this.txtPattern.Enabled = false;
            this.Unbind();

            this.txtResult.Clear();
            this.txtMatches.Clear();
            this.lastSelectedMatchItem = null;

            System.Text.RegularExpressions.MatchCollection matches = null;
            try {
                if (content != null && (!string.IsNullOrEmpty(pattern))) {
                    matches = System.Text.RegularExpressions.Regex.Matches(content, pattern);
                }
                if (content != null) {
                    this.txtResult.Text = content;
                }
            }
            catch (Exception ex) {
                this.txtResult.Text = ex.Message;
            }

            if (matches != null) {
                int index = 0; bool red = true;
                int txtIndex = 0;
                //var list = new SortedList<string, string>();
                foreach (System.Text.RegularExpressions.Match match in matches) {
                    string line = string.Format("{0}: {1}[{2}, {3}]{4}",
                    index, match.Value, match.Index, match.Length, Environment.NewLine);
                    var item = new MatchItem() {
                        index = index,
                        match = match,
                        txtIndex = txtIndex,
                        txtLength = line.Length,
                        backColor = red ? Color.Red : Color.Gold
                    };
                    index++; txtIndex += line.Length;
                    //this.lstMatches.Items.Add(item);
                    this.matchItemList.Add(item);
                    this.txtMatches.AppendText(line);

                    int start = match.Index;
                    int length = match.Length;
                    this.txtResult.Select(start, length);
                    this.txtResult.SelectionBackColor = item.backColor;
                    red = !red;

                    //if (!list.ContainsKey(match.Value))
                    //{
                    //    list.Add(match.Value, match.Value);
                    //}
                }

                //using (var w = new System.IO.StreamWriter(string.Format("values{0:yyyy-MM-dd_HH-mm-ss.fff}.txt", DateTime.Now)))
                //{
                //    foreach (var item in list)
                //    {
                //        w.WriteLine(item.Value);
                //    }
                //}

                this.lblNMatches.Text = string.Format("{0} matches", matches.Count);
            }
            else {
                this.lblNMatches.Text = string.Format("no matches");
            }

            this.Bind();
            this.txtPattern.Enabled = true;
            this.txtPattern.Focus();
        }

        private void txtPattern_TextChanged(object sender, EventArgs e) {
            string pattern = this.txtPattern.Text;

            this.UpdateMatches(this.currentContent, pattern);
        }

        private static readonly Color selectedBackColor = Color.SkyBlue;
        private MatchItem lastSelectedMatchItem = null;

        private void txtMatches_Click(object sender, EventArgs e) {
            this.Unbind();

            int index = this.txtMatches.GetFirstCharIndexOfCurrentLine();
            int line = this.txtMatches.GetLineFromCharIndex(index);
            if (0 <= line && line < this.matchItemList.Count) {
                // 恢复本色
                RecoverColor(this.lastSelectedMatchItem);
                // 使用选中色
                {
                    //var matchItem = this.lstMatches.SelectedItem as MatchItem;
                    var matchItem = this.matchItemList[line];
                    int start = matchItem.match.Index;
                    int length = matchItem.match.Length;
                    this.txtResult.Select(start, length);
                    this.txtResult.SelectionBackColor = selectedBackColor;
                    this.lastSelectedMatchItem = matchItem;
                }

                this.txtResult.ScrollToCaret();
            }

            this.Bind();
        }

        private readonly ManualEvent txtResultSelectionChangedEvent;
        private readonly ManualEvent txtMatchesClickEvent;
        private void txtResult_SelectionChanged(object sender, EventArgs e) {
            this.Unbind();

            var lastSelected = this.lastSelectedMatchItem;
            this.lastSelectedMatchItem = null;
            int start = this.txtResult.SelectionStart;
            //for (int index = 0; index < this.lstMatches.Items.Count; index++)
            for (int index = 0; index < this.matchItemList.Count; index++) {
                //var matchItem = this.lstMatches.Items[index] as MatchItem;
                var matchItem = this.matchItemList[index];
                if (matchItem.match.Index <= start
                    && start <= matchItem.match.Index + matchItem.match.Length) {
                    this.txtMatches.Select(matchItem.txtIndex, 0);
                    this.txtMatches.ScrollToCaret();
                    this.txtMatches.Select(matchItem.txtIndex, matchItem.txtLength);
                    //this.txtMatches.Focus();
                    this.lastSelectedMatchItem = matchItem;
                    break;
                }
            }

            if (lastSelected != this.lastSelectedMatchItem) {
                // 恢复本色
                RecoverColor(lastSelected);
            }

            this.Bind();
        }

        /// <summary>
        /// 恢复本色
        /// </summary>
        /// <param name="matchItem"></param>
        private void RecoverColor(MatchItem matchItem) {
            if (matchItem != null) {
                int start0 = this.txtResult.SelectionStart;
                int length0 = this.txtResult.SelectionLength;

                int start = matchItem.match.Index;
                int length = matchItem.match.Length;
                this.txtResult.SelectionStart = start;
                this.txtResult.SelectionLength = length;
                //this.txtResult.Select(start, length);
                this.txtResult.SelectionBackColor = matchItem.backColor;

                this.txtResult.SelectionStart = start0;
                this.txtResult.SelectionLength = length0;
                //this.txtResult.Select(start0, length0);
            }
        }

        private void lblRemoveR_Click(object sender, EventArgs e) {
            MessageBox.Show(@"已去掉行尾的 \r 符号。这是因为RichTextBox中Index+1会同时跳过 \r\n 两个字符。");
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e) {
            if (e.ChangeType == WatcherChangeTypes.Changed) {
                System.Threading.Thread.Sleep(0);
                var parttern = this.txtPattern.Text;
                this.ScanFile(e.FullPath, parttern);
                //using (var file = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                //{
                //    using (var stream = new StreamReader(file))
                //    {
                //        //this.txtResult.Text = File.ReadAllText(e.FullPath);
                //        this.txtResult.Text = stream.ReadToEnd();
                //    }
                //}
            }
        }

        private string ReadAllText(string fullname) {
            var result = string.Empty;
            using (var stream = new FileStream(fullname, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
                using (var reader = new StreamReader(stream)) {
                    //this.txtResult.Text = File.ReadAllText(e.FullPath);
                    //this.txtResult.Text = stream.ReadToEnd();
                    result = reader.ReadToEnd();
                }
            }

            return result;
        }
    }
}
