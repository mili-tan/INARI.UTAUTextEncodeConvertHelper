using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UTAUTextEncodeConvertHelper
{

    public partial class Form1 : Form
    {

        string FileName;
        Encoding JPN = Encoding.GetEncoding("Shift_JIS");
        Encoding CHN = Encoding.GetEncoding("gb2312");

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvertToJPN_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = CHN.GetString(JPN.GetBytes(richTextBoxAfter.Text));
        }

        private void buttonConvertToCHN_Click(object sender, EventArgs e)
        {
            richTextBoxBefore.Text = JPN.GetString(CHN.GetBytes(richTextBoxAfter.Text));
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            DialogResult touchStone = openFileDialog1.ShowDialog();
            if (touchStone == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                richTextBoxAfter.Text = File.ReadAllText(FileName);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileName == null || FileName == "" || FileName == " ")
                {
                    MessageBox.Show("文件名为空" + "\n\r保存文件失败。");
                }
                else if (richTextBoxBefore.Text == "")
                {
                    MessageBox.Show("未经转换。");
                }
                else
                {
                    File.WriteAllText(FileName, richTextBoxBefore.Text);
                    MessageBox.Show("保存成功！");
                }
            }
            catch(Exception ErrorMsg)
            {
                MessageBox.Show(ErrorMsg + "\n\r保存文件失败。");
            }
        }
    }
}
