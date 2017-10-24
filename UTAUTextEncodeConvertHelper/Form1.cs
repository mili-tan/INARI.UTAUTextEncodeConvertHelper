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
        Stream Streams;
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
            //richTextBoxBefore.Text = CHN.GetString(JPN.GetBytes(richTextBoxAfter.Text));
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, JPN);
            myEncode = JPN;
        }

        private void buttonConvertToCHN_Click(object sender, EventArgs e)
        {
            //richTextBoxBefore.Text = JPN.GetString(CHN.GetBytes(richTextBoxAfter.Text));
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, CHN);
            myEncode = CHN;
        }

        private void buttonConvertToUTF8_Click(object sender, EventArgs e)
        {
            //richTextBoxBefore.Text = Encoding.UTF8.GetString(CHN.GetBytes(richTextBoxAfter.Text));
            richTextBoxBefore.Text = EncodeConvert.Converter(richTextBoxAfter.Text, Encoding.UTF8);
            myEncode = Encoding.UTF8;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            DialogResult touchStone = openFileDialog.ShowDialog();
            if (touchStone == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                SafeFileName= openFileDialog.SafeFileName;
                richTextBoxAfter.Text = File.ReadAllText(FileName,Encoding.Default);
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
                        File.WriteAllText(FileName, richTextBoxAfter.Text.Replace("/n", "/n/r"),JPN);
                    }
                    else
                    {
                        File.WriteAllText(FileName, richTextBoxBefore.Text.Replace("/n", "/n/r"),Encoding.Default);
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
            catch(Exception ErrorMsg)
            {
                MessageBox.Show(ErrorMsg + "\n\r\n\r保存文件失败。");
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = SafeFileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((Streams = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter sWrite = new StreamWriter(Streams))
                    {
                        sWrite.Write(richTextBoxBefore.Text.Replace("/n", "/r/n"));
                    }

                    Streams.Close();
                    MessageBox.Show("另存为成功");
                }
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
                Text = file.FullName;
            }
            myEncode = CHN;
            buttonConvertOK.Enabled = true;
        }

        private void buttonConvertOK_Click(object sender, EventArgs e)
        {
            listBoxLog.Items.Add("[开始转换] ");
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
                        listBoxLog.Items.Add("[已转换] " + file.Name);
                    }
                    else
                    {
                        listBoxLog.Items.Add("[已跳过] " + file.Name);
                    }
                }
                catch (Exception exp)
                {
                    listBoxLog.Items.Add("[Warning]" + exp.Message);
                }
            }

            listBoxLog.Items.Add("[耗时]" + DateTime.FromBinary(DateTime.Now.ToBinary() - startTime).TimeOfDay.ToString());
            listBoxLog.Items.Add("[OK]转换完成");

            listBoxAfter.Items.Clear();
            listBoxBefore.Items.Clear();

            foreach (FileInfo file in folder.GetFiles("*.*"))
            {
                listBoxAfter.Items.Add(file.Name);
            }
            
            buttonConvertOK.Enabled = false;
        }
    }
}
