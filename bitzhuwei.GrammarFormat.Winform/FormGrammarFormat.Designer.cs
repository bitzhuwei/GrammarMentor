namespace bitzhuwei.GrammarFormat.Winform {
    partial class FormGrammarFormat {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGrammarFormat));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenerationDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblProcessInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGrammarName = new System.Windows.Forms.TextBox();
            this.txtExtractedType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGrammar = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Font = new System.Drawing.Font("宋体", 12F);
            this.btnGenerate.Location = new System.Drawing.Point(1098, 42);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 30);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSelectFolder.Location = new System.Drawing.Point(1098, 6);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(101, 30);
            this.btnSelectFolder.TabIndex = 10;
            this.btnSelectFolder.Text = "选择...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "目标文件夹：";
            // 
            // txtGenerationDirectory
            // 
            this.txtGenerationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenerationDirectory.Font = new System.Drawing.Font("宋体", 12F);
            this.txtGenerationDirectory.Location = new System.Drawing.Point(123, 10);
            this.txtGenerationDirectory.Name = "txtGenerationDirectory";
            this.txtGenerationDirectory.Size = new System.Drawing.Size(969, 26);
            this.txtGenerationDirectory.TabIndex = 5;
            this.txtGenerationDirectory.Text = "D:\\VtRegexFolder";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblProcessInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1211, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblProcessInfo
            // 
            this.lblProcessInfo.Name = "lblProcessInfo";
            this.lblProcessInfo.Size = new System.Drawing.Size(131, 17);
            this.lblProcessInfo.Text = "toolStripStatusLabel1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(13, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "编译器名称：";
            // 
            // txtGrammarName
            // 
            this.txtGrammarName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrammarName.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.txtGrammarName.Location = new System.Drawing.Point(122, 42);
            this.txtGrammarName.Name = "txtGrammarName";
            this.txtGrammarName.Size = new System.Drawing.Size(109, 23);
            this.txtGrammarName.TabIndex = 6;
            this.txtGrammarName.Text = "Grammar";
            // 
            // txtExtractedType
            // 
            this.txtExtractedType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtractedType.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.txtExtractedType.Location = new System.Drawing.Point(387, 42);
            this.txtExtractedType.Name = "txtExtractedType";
            this.txtExtractedType.Size = new System.Drawing.Size(155, 23);
            this.txtExtractedType.TabIndex = 6;
            this.txtExtractedType.Text = "GrammarDraft";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(238, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "提取的class名称：";
            // 
            // txtGrammar
            // 
            this.txtGrammar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGrammar.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrammar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtGrammar.Location = new System.Drawing.Point(12, 78);
            this.txtGrammar.Multiline = true;
            this.txtGrammar.Name = "txtGrammar";
            this.txtGrammar.Size = new System.Drawing.Size(1187, 564);
            this.txtGrammar.TabIndex = 6;
            this.txtGrammar.Text = resources.GetString("txtGrammar.Text");
            // 
            // FormGrammarFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 667);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGenerationDirectory);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGrammar);
            this.Controls.Add(this.txtExtractedType);
            this.Controls.Add(this.txtGrammarName);
            this.Name = "FormGrammarFormat";
            this.Text = "Grammar -> C# Code of Compiler(LexicalAnalyzer + SyntaxParser + TExtracter)";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenerationDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGrammarName;
        private System.Windows.Forms.TextBox txtExtractedType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGrammar;
        private System.Windows.Forms.ToolStripStatusLabel lblProcessInfo;
    }
}

