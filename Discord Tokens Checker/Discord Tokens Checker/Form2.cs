using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Discord_Tokens_Checker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LoadFromCopyboard_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list = Clipboard.GetText().Split(Environment.NewLine.ToCharArray()).Distinct().ToList().Select(t => t.Trim()).ToList();
            list.RemoveAll(t => t.Length < 59);

            Form1.Tokens = list;
            this.Close();
        }

        private void LoadFromFile_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                list = File.ReadAllText(dialog.FileName).Split(Environment.NewLine.ToCharArray()).Distinct().ToList().Select(t => t.Trim()).ToList();
                list.RemoveAll(t => t.Length < 59);

                Form1.Tokens = list;
            }
            this.Close();
        }
    }
}
