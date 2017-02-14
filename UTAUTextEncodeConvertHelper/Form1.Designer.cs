﻿namespace UTAUTextEncodeConvertHelper
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.groupBoxBefore = new System.Windows.Forms.GroupBox();
            this.richTextBoxBefore = new System.Windows.Forms.RichTextBox();
            this.groupBoxAfter = new System.Windows.Forms.GroupBox();
            this.richTextBoxAfter = new System.Windows.Forms.RichTextBox();
            this.buttonConvertToCHN = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonConvertToJPN = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageText.SuspendLayout();
            this.groupBoxBefore.SuspendLayout();
            this.groupBoxAfter.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Project.ust";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageText);
            this.tabControl1.Location = new System.Drawing.Point(13, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(566, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.buttonSaveAs);
            this.tabPageText.Controls.Add(this.groupBoxBefore);
            this.tabPageText.Controls.Add(this.groupBoxAfter);
            this.tabPageText.Controls.Add(this.buttonConvertToCHN);
            this.tabPageText.Controls.Add(this.buttonSave);
            this.tabPageText.Controls.Add(this.buttonConvertToJPN);
            this.tabPageText.Controls.Add(this.buttonRead);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(558, 303);
            this.tabPageText.TabIndex = 0;
            this.tabPageText.Text = "文本内容";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Location = new System.Drawing.Point(210, 145);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(137, 23);
            this.buttonSaveAs.TabIndex = 16;
            this.buttonSaveAs.Text = "另存为转换后内容";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // groupBoxBefore
            // 
            this.groupBoxBefore.Controls.Add(this.richTextBoxBefore);
            this.groupBoxBefore.Location = new System.Drawing.Point(350, 7);
            this.groupBoxBefore.Name = "groupBoxBefore";
            this.groupBoxBefore.Size = new System.Drawing.Size(200, 290);
            this.groupBoxBefore.TabIndex = 15;
            this.groupBoxBefore.TabStop = false;
            this.groupBoxBefore.Text = "转换后";
            // 
            // richTextBoxBefore
            // 
            this.richTextBoxBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBefore.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxBefore.Name = "richTextBoxBefore";
            this.richTextBoxBefore.Size = new System.Drawing.Size(188, 264);
            this.richTextBoxBefore.TabIndex = 14;
            this.richTextBoxBefore.Text = "";
            // 
            // groupBoxAfter
            // 
            this.groupBoxAfter.Controls.Add(this.richTextBoxAfter);
            this.groupBoxAfter.Location = new System.Drawing.Point(7, 7);
            this.groupBoxAfter.Name = "groupBoxAfter";
            this.groupBoxAfter.Size = new System.Drawing.Size(200, 290);
            this.groupBoxAfter.TabIndex = 14;
            this.groupBoxAfter.TabStop = false;
            this.groupBoxAfter.Text = "转换前";
            // 
            // richTextBoxAfter
            // 
            this.richTextBoxAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAfter.Location = new System.Drawing.Point(6, 20);
            this.richTextBoxAfter.Name = "richTextBoxAfter";
            this.richTextBoxAfter.Size = new System.Drawing.Size(188, 264);
            this.richTextBoxAfter.TabIndex = 13;
            this.richTextBoxAfter.Text = "";
            // 
            // buttonConvertToCHN
            // 
            this.buttonConvertToCHN.Location = new System.Drawing.Point(210, 87);
            this.buttonConvertToCHN.Name = "buttonConvertToCHN";
            this.buttonConvertToCHN.Size = new System.Drawing.Size(137, 23);
            this.buttonConvertToCHN.TabIndex = 11;
            this.buttonConvertToCHN.Text = "转换到GB2312";
            this.buttonConvertToCHN.UseVisualStyleBackColor = true;
            this.buttonConvertToCHN.Click += new System.EventHandler(this.buttonConvertToCHN_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(210, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(137, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "保存转换后内容";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonConvertToJPN
            // 
            this.buttonConvertToJPN.Location = new System.Drawing.Point(210, 58);
            this.buttonConvertToJPN.Name = "buttonConvertToJPN";
            this.buttonConvertToJPN.Size = new System.Drawing.Size(137, 23);
            this.buttonConvertToJPN.TabIndex = 9;
            this.buttonConvertToJPN.Text = "转换到Shift_JIS";
            this.buttonConvertToJPN.UseVisualStyleBackColor = true;
            this.buttonConvertToJPN.Click += new System.EventHandler(this.buttonConvertToJPN_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(210, 28);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(137, 23);
            this.buttonRead.TabIndex = 8;
            this.buttonRead.Text = "读取文件";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 341);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "UTAU Text Encode Convert Helper 0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageText.ResumeLayout(false);
            this.groupBoxBefore.ResumeLayout(false);
            this.groupBoxAfter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

