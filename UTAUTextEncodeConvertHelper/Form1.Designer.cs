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
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
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
            resources.ApplyResources(this.tabPageText, "tabPageText");
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // buttonConvertToUTF8
            // 
            resources.ApplyResources(this.buttonConvertToUTF8, "buttonConvertToUTF8");
            this.buttonConvertToUTF8.Name = "buttonConvertToUTF8";
            this.buttonConvertToUTF8.UseVisualStyleBackColor = true;
            this.buttonConvertToUTF8.Click += new System.EventHandler(this.buttonConvertToUTF8_Click);
            // 
            // buttonSaveAs
            // 
            resources.ApplyResources(this.buttonSaveAs, "buttonSaveAs");
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // groupBoxBefore
            // 
            this.groupBoxBefore.Controls.Add(this.richTextBoxBefore);
            resources.ApplyResources(this.groupBoxBefore, "groupBoxBefore");
            this.groupBoxBefore.Name = "groupBoxBefore";
            this.groupBoxBefore.TabStop = false;
            // 
            // richTextBoxBefore
            // 
            this.richTextBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBoxBefore, "richTextBoxBefore");
            this.richTextBoxBefore.Name = "richTextBoxBefore";
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.Controls.Add(this.richTextBoxAfter);
            resources.ApplyResources(this.groupBoxAfter, "groupBoxAfter");
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.TabStop = false;
            // 
            // richTextBoxAfter
            // 
            this.richTextBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBoxAfter, "richTextBoxAfter");
            this.richTextBoxAfter.Name = "richTextBoxAfter";
            // 
            // buttonConvertToCHN
            // 
            resources.ApplyResources(this.buttonConvertToCHN, "buttonConvertToCHN");
            this.buttonConvertToCHN.Name = "buttonConvertToCHN";
            this.buttonConvertToCHN.UseVisualStyleBackColor = true;
            this.buttonConvertToCHN.Click += new System.EventHandler(this.buttonConvertToCHN_Click);
            // 
            // buttonSave
            // 
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonConvertToJPN
            // 
            resources.ApplyResources(this.buttonConvertToJPN, "buttonConvertToJPN");
            this.buttonConvertToJPN.Name = "buttonConvertToJPN";
            this.buttonConvertToJPN.UseVisualStyleBackColor = true;
            this.buttonConvertToJPN.Click += new System.EventHandler(this.buttonConvertToJPN_Click);
            // 
            // buttonRead
            // 
            resources.ApplyResources(this.buttonRead, "buttonRead");
            this.buttonRead.Name = "buttonRead";
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
            resources.ApplyResources(this.tabPageFile, "tabPageFile");
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // buttonConvertOK
            // 
            resources.ApplyResources(this.buttonConvertOK, "buttonConvertOK");
            this.buttonConvertOK.Name = "buttonConvertOK";
            this.buttonConvertOK.UseVisualStyleBackColor = true;
            this.buttonConvertOK.Click += new System.EventHandler(this.buttonConvertOK_Click);
            // 
            // buttonFileToUTF8
            // 
            resources.ApplyResources(this.buttonFileToUTF8, "buttonFileToUTF8");
            this.buttonFileToUTF8.Name = "buttonFileToUTF8";
            this.buttonFileToUTF8.UseVisualStyleBackColor = true;
            this.buttonFileToUTF8.Click += new System.EventHandler(this.buttonFileToUTF8_Click);
            // 
            // buttonFileToGBK
            // 
            resources.ApplyResources(this.buttonFileToGBK, "buttonFileToGBK");
            this.buttonFileToGBK.Name = "buttonFileToGBK";
            this.buttonFileToGBK.UseVisualStyleBackColor = true;
            this.buttonFileToGBK.Click += new System.EventHandler(this.buttonFileToGBK_Click);
            // 
            // buttonFileToJPN
            // 
            resources.ApplyResources(this.buttonFileToJPN, "buttonFileToJPN");
            this.buttonFileToJPN.Name = "buttonFileToJPN";
            this.buttonFileToJPN.UseVisualStyleBackColor = true;
            this.buttonFileToJPN.Click += new System.EventHandler(this.buttonFileToJPN_Click);
            // 
            // listBoxBefore
            // 
            this.listBoxBefore.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxBefore, "listBoxBefore");
            this.listBoxBefore.Name = "listBoxBefore";
            // 
            // listBoxAfter
            // 
            this.listBoxAfter.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxAfter, "listBoxAfter");
            this.listBoxAfter.Name = "listBoxAfter";
            this.listBoxAfter.DoubleClick += new System.EventHandler(this.listBoxAfter_DoubleClick);
            // 
            // labelFoldPath
            // 
            resources.ApplyResources(this.labelFoldPath, "labelFoldPath");
            this.labelFoldPath.Name = "labelFoldPath";
            // 
            // buttonOpenPath
            // 
            resources.ApplyResources(this.buttonOpenPath, "buttonOpenPath");
            this.buttonOpenPath.Name = "buttonOpenPath";
            this.buttonOpenPath.UseVisualStyleBackColor = true;
            this.buttonOpenPath.Click += new System.EventHandler(this.buttonOpenPath_Click);
            // 
            // folderBrowserDialog
            // 
            resources.ApplyResources(this.folderBrowserDialog, "folderBrowserDialog");
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
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

