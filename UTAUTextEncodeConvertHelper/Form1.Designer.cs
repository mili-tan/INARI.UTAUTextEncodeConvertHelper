namespace UTAUTextEncodeConvertHelper
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.buttonConvertToUTF8 = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.groupBoxBefore = new System.Windows.Forms.GroupBox();
            this.richTextBoxBefore = new System.Windows.Forms.RichTextBox();
            this.groupBoxAfter = new System.Windows.Forms.GroupBox();
            this.richTextBoxAfter = new System.Windows.Forms.RichTextBox();
            this.buttonConvertToCHN = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonConvertToJPN = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonConvertOK = new System.Windows.Forms.Button();
            this.buttonFileToUTF8 = new System.Windows.Forms.Button();
            this.buttonFileToGBK = new System.Windows.Forms.Button();
            this.buttonFileToJPN = new System.Windows.Forms.Button();
            this.listBoxBefore = new System.Windows.Forms.ListBox();
            this.listBoxAfter = new System.Windows.Forms.ListBox();
            this.labelFoldPath = new System.Windows.Forms.Label();
            this.buttonOpenPath = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.groupBoxBefore.SuspendLayout();
            this.groupBoxAfter.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Project.ust";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageText);
            this.tabControl1.Controls.Add(this.tabPageFile);
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(17, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(755, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.buttonConvertToUTF8);
            this.tabPageText.Controls.Add(this.buttonSaveAs);
            this.tabPageText.Controls.Add(this.groupBoxBefore);
            this.tabPageText.Controls.Add(this.groupBoxAfter);
            this.tabPageText.Controls.Add(this.buttonConvertToCHN);
            this.tabPageText.Controls.Add(this.buttonSave);
            this.tabPageText.Controls.Add(this.buttonConvertToJPN);
            this.tabPageText.Controls.Add(this.buttonRead);
            this.tabPageText.Location = new System.Drawing.Point(4, 29);
            this.tabPageText.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageText.Size = new System.Drawing.Size(747, 374);
            this.tabPageText.TabIndex = 0;
            this.tabPageText.Text = "文本";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // buttonConvertToUTF8
            // 
            this.buttonConvertToUTF8.Location = new System.Drawing.Point(280, 100);
            this.buttonConvertToUTF8.Name = "buttonConvertToUTF8";
            this.buttonConvertToUTF8.Size = new System.Drawing.Size(183, 29);
            this.buttonConvertToUTF8.TabIndex = 17;
            this.buttonConvertToUTF8.Text = "转换到UTF-8";
            this.buttonConvertToUTF8.UseVisualStyleBackColor = true;
            this.buttonConvertToUTF8.Click += new System.EventHandler(this.buttonConvertToUTF8_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(280, 173);
            this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(183, 29);
            this.buttonSaveAs.TabIndex = 16;
            this.buttonSaveAs.Text = "另存为转换后内容";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // groupBoxBefore
            // 
            this.groupBoxBefore.Controls.Add(this.richTextBoxBefore);
            this.groupBoxBefore.Location = new System.Drawing.Point(467, 9);
            this.groupBoxBefore.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxBefore.Name = "groupBoxBefore";
            this.groupBoxBefore.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxBefore.Size = new System.Drawing.Size(267, 362);
            this.groupBoxBefore.TabIndex = 15;
            this.groupBoxBefore.TabStop = false;
            this.groupBoxBefore.Text = "转换后";
            // 
            // richTextBoxBefore
            // 
            this.richTextBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBefore.Location = new System.Drawing.Point(8, 25);
            this.richTextBoxBefore.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxBefore.Name = "richTextBoxBefore";
            this.richTextBoxBefore.Size = new System.Drawing.Size(251, 330);
            this.richTextBoxBefore.TabIndex = 14;
            this.richTextBoxBefore.Text = "";
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.Controls.Add(this.richTextBoxAfter);
            this.groupBoxAfter.Location = new System.Drawing.Point(9, 9);
            this.groupBoxAfter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAfter.Size = new System.Drawing.Size(267, 362);
            this.groupBoxAfter.TabIndex = 14;
            this.groupBoxAfter.TabStop = false;
            this.groupBoxAfter.Text = "转换前";
            // 
            // richTextBoxAfter
            // 
            this.richTextBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAfter.Location = new System.Drawing.Point(8, 25);
            this.richTextBoxAfter.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxAfter.Name = "richTextBoxAfter";
            this.richTextBoxAfter.Size = new System.Drawing.Size(251, 330);
            this.richTextBoxAfter.TabIndex = 13;
            this.richTextBoxAfter.Text = "";
            // 
            // buttonConvertToCHN
            // 
            this.buttonConvertToCHN.Location = new System.Drawing.Point(280, 64);
            this.buttonConvertToCHN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConvertToCHN.Name = "buttonConvertToCHN";
            this.buttonConvertToCHN.Size = new System.Drawing.Size(183, 29);
            this.buttonConvertToCHN.TabIndex = 11;
            this.buttonConvertToCHN.Text = "转换到GB2312";
            this.buttonConvertToCHN.UseVisualStyleBackColor = true;
            this.buttonConvertToCHN.Click += new System.EventHandler(this.buttonConvertToCHN_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(280, 137);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(183, 29);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "保存转换后内容";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonConvertToJPN
            // 
            this.buttonConvertToJPN.Location = new System.Drawing.Point(280, 27);
            this.buttonConvertToJPN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConvertToJPN.Name = "buttonConvertToJPN";
            this.buttonConvertToJPN.Size = new System.Drawing.Size(183, 29);
            this.buttonConvertToJPN.TabIndex = 9;
            this.buttonConvertToJPN.Text = "转换到Shift_JIS";
            this.buttonConvertToJPN.UseVisualStyleBackColor = true;
            this.buttonConvertToJPN.Click += new System.EventHandler(this.buttonConvertToJPN_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(280, 210);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(183, 29);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "读取文件";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.progressBar);
            this.tabPageFile.Controls.Add(this.buttonConvertOK);
            this.tabPageFile.Controls.Add(this.buttonFileToUTF8);
            this.tabPageFile.Controls.Add(this.buttonFileToGBK);
            this.tabPageFile.Controls.Add(this.buttonFileToJPN);
            this.tabPageFile.Controls.Add(this.listBoxBefore);
            this.tabPageFile.Controls.Add(this.listBoxAfter);
            this.tabPageFile.Controls.Add(this.labelFoldPath);
            this.tabPageFile.Controls.Add(this.buttonOpenPath);
            this.tabPageFile.Location = new System.Drawing.Point(4, 29);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Size = new System.Drawing.Size(747, 374);
            this.tabPageFile.TabIndex = 1;
            this.tabPageFile.Text = "文件名";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(253, 275);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(235, 23);
            this.progressBar.TabIndex = 22;
            this.progressBar.Visible = false;
            // 
            // buttonConvertOK
            // 
            this.buttonConvertOK.Enabled = false;
            this.buttonConvertOK.Location = new System.Drawing.Point(253, 304);
            this.buttonConvertOK.Name = "buttonConvertOK";
            this.buttonConvertOK.Size = new System.Drawing.Size(235, 29);
            this.buttonConvertOK.TabIndex = 21;
            this.buttonConvertOK.Text = "应用转换";
            this.buttonConvertOK.UseVisualStyleBackColor = true;
            this.buttonConvertOK.Click += new System.EventHandler(this.buttonConvertOK_Click);
            // 
            // buttonFileToUTF8
            // 
            this.buttonFileToUTF8.Enabled = false;
            this.buttonFileToUTF8.Location = new System.Drawing.Point(253, 122);
            this.buttonFileToUTF8.Name = "buttonFileToUTF8";
            this.buttonFileToUTF8.Size = new System.Drawing.Size(235, 29);
            this.buttonFileToUTF8.TabIndex = 20;
            this.buttonFileToUTF8.Text = "转换到UTF-8";
            this.buttonFileToUTF8.UseVisualStyleBackColor = true;
            this.buttonFileToUTF8.Click += new System.EventHandler(this.buttonFileToUTF8_Click);
            // 
            // buttonFileToGBK
            // 
            this.buttonFileToGBK.Enabled = false;
            this.buttonFileToGBK.Location = new System.Drawing.Point(253, 86);
            this.buttonFileToGBK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFileToGBK.Name = "buttonFileToGBK";
            this.buttonFileToGBK.Size = new System.Drawing.Size(235, 29);
            this.buttonFileToGBK.TabIndex = 19;
            this.buttonFileToGBK.Text = "转换到GB2312";
            this.buttonFileToGBK.UseVisualStyleBackColor = true;
            this.buttonFileToGBK.Click += new System.EventHandler(this.buttonFileToGBK_Click);
            // 
            // buttonFileToJPN
            // 
            this.buttonFileToJPN.Enabled = false;
            this.buttonFileToJPN.Location = new System.Drawing.Point(253, 49);
            this.buttonFileToJPN.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFileToJPN.Name = "buttonFileToJPN";
            this.buttonFileToJPN.Size = new System.Drawing.Size(235, 29);
            this.buttonFileToJPN.TabIndex = 18;
            this.buttonFileToJPN.Text = "转换到Shift_JIS";
            this.buttonFileToJPN.UseVisualStyleBackColor = true;
            this.buttonFileToJPN.Click += new System.EventHandler(this.buttonFileToJPN_Click);
            // 
            // listBoxBefore
            // 
            this.listBoxBefore.FormattingEnabled = true;
            this.listBoxBefore.ItemHeight = 20;
            this.listBoxBefore.Location = new System.Drawing.Point(494, 49);
            this.listBoxBefore.Name = "listBoxBefore";
            this.listBoxBefore.Size = new System.Drawing.Size(230, 284);
            this.listBoxBefore.TabIndex = 3;
            // 
            // listBoxAfter
            // 
            this.listBoxAfter.FormattingEnabled = true;
            this.listBoxAfter.ItemHeight = 20;
            this.listBoxAfter.Location = new System.Drawing.Point(16, 49);
            this.listBoxAfter.Name = "listBoxAfter";
            this.listBoxAfter.Size = new System.Drawing.Size(230, 284);
            this.listBoxAfter.TabIndex = 2;
            this.listBoxAfter.DoubleClick += new System.EventHandler(this.listBoxAfter_DoubleClick);
            // 
            // labelFoldPath
            // 
            this.labelFoldPath.AutoSize = true;
            this.labelFoldPath.Location = new System.Drawing.Point(147, 18);
            this.labelFoldPath.Name = "labelFoldPath";
            this.labelFoldPath.Size = new System.Drawing.Size(99, 20);
            this.labelFoldPath.TabIndex = 1;
            this.labelFoldPath.Text = "文件夹路径：";
            // 
            // buttonOpenPath
            // 
            this.buttonOpenPath.Location = new System.Drawing.Point(16, 15);
            this.buttonOpenPath.Name = "buttonOpenPath";
            this.buttonOpenPath.Size = new System.Drawing.Size(125, 27);
            this.buttonOpenPath.TabIndex = 0;
            this.buttonOpenPath.Text = "打开文件夹";
            this.buttonOpenPath.UseVisualStyleBackColor = true;
            this.buttonOpenPath.Click += new System.EventHandler(this.buttonOpenPath_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "请选择文件路径";
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 426);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTAU TextEncode Convert Helper 0.56";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.groupBoxBefore.ResumeLayout(false);
            this.groupBoxAfter.ResumeLayout(false);
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.Button buttonConvertToCHN;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonConvertToJPN;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.GroupBox groupBoxBefore;
        private System.Windows.Forms.RichTextBox richTextBoxBefore;
        private System.Windows.Forms.GroupBox groupBoxAfter;
        private System.Windows.Forms.RichTextBox richTextBoxAfter;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button buttonConvertToUTF8;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.Button buttonOpenPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label labelFoldPath;
        private System.Windows.Forms.ListBox listBoxAfter;
        private System.Windows.Forms.Button buttonFileToUTF8;
        private System.Windows.Forms.Button buttonFileToGBK;
        private System.Windows.Forms.Button buttonFileToJPN;
        private System.Windows.Forms.ListBox listBoxBefore;
        private System.Windows.Forms.Button buttonConvertOK;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

