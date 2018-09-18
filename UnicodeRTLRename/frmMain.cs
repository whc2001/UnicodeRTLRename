using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeRTLRename
{
    public partial class frmMain : Form
    {
        private readonly byte[] unicodeRlo = { 0x2E, 0x20 };
        private readonly byte[] dot = { 0x2E, 0x00 };

        private string MakeFileName()
        {
            if (string.IsNullOrEmpty(txtFileInput.Text) || string.IsNullOrEmpty(txtFakeExtension.Text) || string.IsNullOrEmpty(txtRealExtension.Text))
                throw new InvalidOperationException();
            return Encoding.Unicode.GetString(Encoding.Unicode.GetBytes(txtName.Text).Concat(unicodeRlo).Concat(Encoding.Unicode.GetBytes(txtFakeExtension.Text.Reverse().ToArray())).Concat(dot).Concat(Encoding.Unicode.GetBytes(txtRealExtension.Text.Reverse().ToArray())).ToArray());
        }

        private void ContentChanged(object sender, EventArgs e)
        {
            try
            {
                txtOutputFileName.Text = MakeFileName();
            }
            catch
            {

            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileInput.Text = openFileDialog1.FileName;
                int indexOfDot = txtFileInput.Text.LastIndexOf(".");
                int indexOfSlash = txtFileInput.Text.LastIndexOf("\\");
                if (indexOfDot != -1)
                {
                    txtRealExtension.Text = txtFileInput.Text.Substring(indexOfDot + 1, txtFileInput.Text.Length - indexOfDot - 1); //grab real extension
                    if (indexOfSlash != -1)
                        txtName.Text = txtFileInput.Text.Substring(indexOfSlash + 1, indexOfDot - indexOfSlash - 1); //grab main name
                }
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = MakeFileName();
                string fileNameFull = txtFileInput.Text.Substring(0, txtFileInput.Text.LastIndexOf("\\") + 1) + fileName;
                if (File.Exists(fileNameFull))
                    File.Delete(fileNameFull);
                File.Copy(txtFileInput.Text, fileNameFull);
                MessageBox.Show("OK!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Please make sure you filled every required field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }
    }
}
