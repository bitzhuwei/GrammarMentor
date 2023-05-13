namespace Practice.StepParser.Winform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSourceCode = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNMatches = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRemoveR = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMatchList = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullname
            // 
            this.txtFullname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullname.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFullname.Location = new System.Drawing.Point(139, 15);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(953, 26);
            this.txtFullname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Step文件：";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Font = new System.Drawing.Font("宋体", 12F);
            this.btnOpenFile.Location = new System.Drawing.Point(1098, 13);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(101, 30);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "打开...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Step文件|*.step;*.stp";
            this.openFileDialog1.Multiselect = true;
            // 
            // txtSourceCode
            // 
            this.txtSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceCode.Font = new System.Drawing.Font("宋体", 12F);
            this.txtSourceCode.Location = new System.Drawing.Point(12, 47);
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.ReadOnly = true;
            this.txtSourceCode.ShowSelectionMargin = true;
            this.txtSourceCode.Size = new System.Drawing.Size(873, 595);
            this.txtSourceCode.TabIndex = 3;
            this.txtSourceCode.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNMatches,
            this.lblRemoveR});
            this.statusStrip1.Location = new System.Drawing.Point(0, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1211, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNMatches
            // 
            this.lblNMatches.Name = "lblNMatches";
            this.lblNMatches.Size = new System.Drawing.Size(75, 17);
            this.lblNMatches.Text = "{0} matches";
            // 
            // lblRemoveR
            // 
            this.lblRemoveR.Name = "lblRemoveR";
            this.lblRemoveR.Size = new System.Drawing.Size(0, 17);
            this.lblRemoveR.Click += new System.EventHandler(this.lblRemoveR_Click);
            // 
            // txtMatchList
            // 
            this.txtMatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatchList.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMatchList.HideSelection = false;
            this.txtMatchList.Location = new System.Drawing.Point(891, 49);
            this.txtMatchList.Multiline = true;
            this.txtMatchList.Name = "txtMatchList";
            this.txtMatchList.ReadOnly = true;
            this.txtMatchList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMatchList.Size = new System.Drawing.Size(308, 593);
            this.txtMatchList.TabIndex = 0;
            this.txtMatchList.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 667);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtSourceCode);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatchList);
            this.Controls.Add(this.txtFullname);
            this.Name = "Form1";
            this.Text = "Step文件语法分析器";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txtSourceCode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNMatches;
        private System.Windows.Forms.ToolStripStatusLabel lblRemoveR;
        private System.Windows.Forms.TextBox txtMatchList;
    }
}