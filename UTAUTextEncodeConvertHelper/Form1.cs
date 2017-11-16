using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace UTAUTextEncodeConvertHelper
{

    public partial class Form1 : Form
    {

        string FileName;
        string SafeFileName;
        string foldPath;
        bool UtauPlugin = false;
        ToolTip toolTip = new ToolTip();
        Encoding JPN = Encoding.GetEncoding("Shift_JIS");
        Encoding CHN = Encoding.GetEncoding("gb2312");
        Encoding myEncode;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string ustPath)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(ustPath))
            {
                Text += " - 正作为UTAU插件运行";
                buttonRead.Hide();
                buttonSaveAs.Hide();
                buttonSave.Text = "确定";

                UtauPlugin = true;
                richTextBoxAfter.Text = File.ReadAllText(ustPath, Encoding.Default);
                FileName = ustPath;
            }
        }

        private void buttonConvertToJPN_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, JPN);
            myEncode = JPN;
        }

        private void buttonConvertToCHN_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, CHN);
            myEncode = CHN;
        }

        private void buttonConvertToUTF8_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, Encoding.UTF8);
            myEncode = Encoding.UTF8;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            DialogResult touchStone = openFileDialog.ShowDialog();
            if (touchStone == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                SafeFileName = openFileDialog.SafeFileName;
                richTextBoxAfter.Text = File.ReadAllText(FileName, Encoding.Default);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileName == null || FileName == "" || FileName == " ")
                {
                    MessageBox.Show("文件名为空" + "\n\r\n\r保存文件失败。");
                }
                else if (richTextBoxBefore.Text == "")
                {
                    MessageBox.Show("未经转换。");
                }
                else
                {
                    if (myEncode == JPN)
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
                if ((fileNameSaveAs = saveFileDialog.FileName.ToString()) != null)
                {
                    if (myEncode == JPN)
                    {
                        File.WriteAllText(fileNameSaveAs, richTextBoxAfter.Text.Replace("/n", "/n/r"), JPN);
                    }
                    else
                    {
                        File.WriteAllText(fileNameSaveAs, richTextBoxBefore.Text.Replace("/n", "/n/r"), Encoding.Default);
                    }
                }
                MessageBox.Show("另存为成功");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            if (UtauPlugin)
            {
                buttonOpenPath.Enabled = false;
                labelFoldPath.Text = "UTAU插件模式下不可用";
                labelFoldPath.ForeColor = System.Drawing.Color.SlateGray;
            }
            //Fx.EffectsWindows(Handle, 500, Fx.AW_BLEND);
        }

        private void buttonOpenPath_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = folderBrowserDialog.SelectedPath;
                DirectoryInfo folder = new DirectoryInfo(foldPath);
                labelFoldPath.Text = "文件夹路径：" + foldPath;
                listBoxAfter.Items.Clear();
                foreach (FileInfo file in folder.GetFiles("*.*"))
                {
                    listBoxAfter.Items.Add(file.Name);
                }
                buttonFileToGBK.Enabled = true;
                buttonFileToJPN.Enabled = true;
                buttonFileToUTF8.Enabled = true;
            }
        }

        private void buttonFileToJPN_Click(object sender, EventArgs e)
        {
            listBoxBefore.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(foldPath);
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, JPN));
            }
            myEncode = JPN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonFileToGBK_Click(object sender, EventArgs e)
        {
            listBoxBefore.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(foldPath);
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, CHN));
            }
            myEncode = CHN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonFileToUTF8_Click(object sender, EventArgs e)
        {
            listBoxBefore.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(foldPath);
            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, Encoding.UTF8));
                Computer MyComputer = new Computer();
            }
            myEncode = CHN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonConvertOK_Click(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
            this.Enabled = false;
        }

        private void listBoxAfter_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxAfter.SelectedItem != null)
            {
                if (myEncode == null)
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
                            if (myFileName != EncodeConvert.Converter(myFileName, myEncode))
                            {
                                Computer MyComputer = new Computer();
                                MyComputer.FileSystem.RenameFile(foldPath + @"\" + myFileName, EncodeConvert.Converter(myFileName, myEncode));
                            }
                            else
                            {
                                MessageBox.Show("[已跳过] " + myFileName);
                            }
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("[Warning]" + exp.Message);
                    }
                    listBoxAfter.Items.Clear();
                    listBoxBefore.Items.Clear();

                    foreach (FileInfo file in new DirectoryInfo(foldPath).GetFiles("*.*"))
                    {
                        listBoxAfter.Items.Add(file.Name);
                    }

                    foreach (FileInfo file in new DirectoryInfo(foldPath).GetFiles("*.*"))
                    {
                        listBoxBefore.Items.Add(EncodeConvert.Converter(file.Name, myEncode));
                    }
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Fx.EffectsWindows(Handle, 100, Fx.AW_HIDE + Fx.AW_BLEND);
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (myEncode == null)
            {
                MessageBox.Show("清先选择文件编码。");
            }
            else
            {
                long startTime = DateTime.Now.ToBinary();
                DirectoryInfo folder = new DirectoryInfo(foldPath);
                foreach (FileInfo file in folder.GetFiles("*.*"))
                {
                    try
                    {
                        if (file.Name != EncodeConvert.Converter(file.Name, myEncode))
                        {
                            Computer MyComputer = new Computer();
                            MyComputer.FileSystem.RenameFile(file.FullName, EncodeConvert.Converter(file.Name, myEncode));
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("[Warning]" + exp.Message);
                    }
                }

                MessageBox.Show("[OK]转换完成 \n\r[耗时]" + DateTime.FromBinary(DateTime.Now.ToBinary() - startTime).TimeOfDay.ToString());

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            DirectoryInfo folder = new DirectoryInfo(foldPath);

            listBoxAfter.Items.Clear();
            listBoxBefore.Items.Clear();

            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxAfter.Items.Add(file.Name);
            }

            this.Enabled = true;
            buttonConvertOK.Enabled = false;
        }
    }
}
