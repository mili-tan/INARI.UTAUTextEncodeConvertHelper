using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;
// ReSharper disable InconsistentNaming
// ReSharper disable LocalizableElement

namespace UTAUTextEncodeConvertHelper
{

    public partial class Form1 : Form
    {

        private string FileName;
        private string FoldPath;
        private string MyMsg = "";
        private bool UtauPlugin;
        private readonly Encoding JPN = Encoding.GetEncoding("Shift_JIS");
        private readonly Encoding CHN = Encoding.GetEncoding("gb2312");
        private Encoding MyEncode;

        public Form1()
        {
            InitializeComponent();
            UtauPlugin = false;
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey600, Accent.LightBlue700, TextShade.WHITE);
            Fx.EffectsWindows(Handle, 200, Fx.AW_BLEND);
        }

        public Form1(string ustPath)
        {
            InitializeComponent();
            UtauPlugin = false;
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey700, Primary.BlueGrey600, Accent.LightBlue700, TextShade.WHITE);
            if (!string.IsNullOrEmpty(ustPath))
            {
                Text += @" - UTAU Plugin";
                buttonRead.Hide();
                buttonSaveAs.Hide();
                buttonSave.Text = "确定";

                UtauPlugin = true;
                richTextBoxAfter.Text = File.ReadAllText(ustPath, Encoding.Default);
                FileName = ustPath;
            }
            Fx.EffectsWindows(Handle, 200, Fx.AW_BLEND);
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void buttonConvertToJPN_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, JPN);
            MyEncode = JPN;
        }

        private void buttonConvertToCHN_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, CHN);
            MyEncode = CHN;
        }

        private void buttonConvertToUTF8_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, Encoding.UTF8);
            MyEncode = Encoding.UTF8;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            richTextBoxAfter.Clear();
            richTextBoxBefore.Clear();
            DialogResult touchStone = openFileDialog.ShowDialog();
            if (touchStone == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                richTextBoxAfter.Text = File.ReadAllText(FileName, Encoding.Default);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FileName) || FileName == " ")
                {
                    MessageBox.Show("文件名为空" + "\n\r\n\r保存文件失败。");
                }
                else if (richTextBoxBefore.Text == "")
                {
                    MessageBox.Show("未经转换。");
                }
                else
                {
                    if (Equals(MyEncode, JPN))
                    {
                        File.WriteAllText(FileName, richTextBoxAfter.Text.Replace("/n", "/n/r"), JPN);
                    }
                    else
                    {
                        File.WriteAllText(FileName, richTextBoxBefore.Text.Replace("/n", "/n/r"), Encoding.Default);
                    }
                    if (UtauPlugin)
                    {
                        Close();
                        MessageBox.Show("转换完成！");
                    }
                    else
                    {
                        MessageBox.Show("文件保存成功！");
                    }
                    richTextBoxAfter.Clear();
                    richTextBoxBefore.Clear();
                }
            }
            catch (Exception ErrorMsg)
            {
                MessageBox.Show(ErrorMsg + "\n\r\n\r保存文件失败。");
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileNameSaveAs;
                if ((fileNameSaveAs = saveFileDialog.FileName) != null)
                {
                    if (Equals(MyEncode, JPN))
                    {
                        File.WriteAllText(fileNameSaveAs, richTextBoxAfter.Text.Replace("/n", "/n/r"), JPN);
                    }
                    else
                    {
                        File.WriteAllText(fileNameSaveAs, richTextBoxBefore.Text.Replace("/n", "/n/r"), Encoding.Default);
                    }
                }
                MessageBox.Show("另存为成功");
                richTextBoxAfter.Clear();
                richTextBoxBefore.Clear();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            if (UtauPlugin)
            {
                buttonOpenPath.Enabled = false;
                labelFoldPath.Text = "UTAU插件模式下不可用";
                labelFoldPath.ForeColor = System.Drawing.Color.SlateGray;
            }

            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            Fx.EffectsWindows(Handle, 150, Fx.AW_BLEND);
        }

        private void buttonOpenPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FoldPath = folderBrowserDialog.SelectedPath;
                DirectoryInfo folder = new DirectoryInfo(FoldPath);
                labelFoldPath.Text = "文件夹路径：" + FoldPath;
                listBoxAfter.Items.Clear();
                foreach (FileInfo file in folder.GetFiles("*.*"))
                {
                    listBoxAfter.Items.Add(file.Name);
                }
                buttonFileToGBK.Enabled = true;
                buttonFileToJPN.Enabled = true;
                buttonFileToUTF8.Enabled = true;

                openFileDialog.InitialDirectory = FoldPath;
            }
        }

        private void buttonFileToJPN_Click(object sender, EventArgs e)
        {
            listBoxBefore.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(FoldPath);
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, JPN));
            }
            MyEncode = JPN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonFileToGBK_Click(object sender, EventArgs e)
        {
            listBoxBefore.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(FoldPath);
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, CHN));
            }
            MyEncode = CHN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonFileToUTF8_Click(object sender, EventArgs e)
        {
            listBoxBefore.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(FoldPath);
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, Encoding.UTF8));
            }
            MyEncode = CHN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonConvertOK_Click(object sender, EventArgs e)
        {
            progressBar.Maximum = new DirectoryInfo(FoldPath).GetFiles().Length;
            progressBar.Visible = true;
            backgroundWorker.RunWorkerAsync();
        }

        private void listBoxAfter_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAfter.SelectedItem != null)
            {
                if (MyEncode == null)
                {
                    MessageBox.Show("清先选择文件编码。");
                }
                else
                {
                    try
                    {
                        string myFileName = listBoxAfter.SelectedItem.ToString();
                        if (DialogResult.OK == MessageBox.Show("仅转换" + myFileName + "吗？", "转换", MessageBoxButtons.OKCancel))
                        {
                            if (myFileName != EncodeConvert.Converter(myFileName, MyEncode))
                            {
                                Computer myComputer = new Computer();
                                myComputer.FileSystem.RenameFile(FoldPath + @"\" + myFileName, EncodeConvert.Converter(myFileName, MyEncode));
                            }
                            else
                            {
                                MessageBox.Show("[已跳过] " + myFileName);
                            }
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(@"[Warning]" + exp.Message);
                    }
                    listBoxAfter.Items.Clear();
                    listBoxBefore.Items.Clear();

                    foreach (FileInfo file in new DirectoryInfo(FoldPath).GetFiles("*.*"))
                    {
                        listBoxAfter.Items.Add(file.Name);
                    }

                    foreach (FileInfo file in new DirectoryInfo(FoldPath).GetFiles("*.*"))
                    {
                        listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, MyEncode));
                    }
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Fx.EffectsWindows(Handle, 100, Fx.AW_HIDE + Fx.AW_BLEND);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int i = 1;
            if (MyEncode == null)
            {
                MessageBox.Show("清先选择文件编码。");
            }
            else
            {
                long startTime = DateTime.Now.ToBinary();
                DirectoryInfo folder = new DirectoryInfo(FoldPath);
                foreach (FileInfo file in folder.GetFiles("*.*"))
                {
                    try
                    {
                        if (file.Name != EncodeConvert.Converter(file.Name, MyEncode))
                        {
                            Computer MyComputer = new Computer();
                            MyComputer.FileSystem.RenameFile(file.FullName, EncodeConvert.Converter(file.Name, MyEncode));
                        }
                    }
                    catch (Exception exp)
                    {
                        MyMsg += "[Warning]" + exp.Message + "\n\r";
                    }
                    backgroundWorker.ReportProgress(i++);
                }

                MessageBox.Show("[OK]转换完成 \n\r[耗时]" + DateTime.FromBinary(DateTime.Now.ToBinary() - startTime).TimeOfDay.ToString() + "\n\r" + MyMsg);

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            MyMsg = "";

            DirectoryInfo folder = new DirectoryInfo(FoldPath);

            listBoxAfter.Items.Clear();
            listBoxBefore.Items.Clear();

            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxAfter.Items.Add(file.Name);
            }

            buttonConvertOK.Enabled = false;
            progressBar.Value = 0;
            progressBar.Visible = false;
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
    }
}
