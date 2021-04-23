using System;
using Capston_Project;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capston_Project
{
    public partial class EncryptMeUpload : Form
    {
        public EncryptMeUpload()
        {
            InitializeComponent();
        }
        private void EncryptMeUpload_Load_1(object sender, EventArgs e)
        {
            //Encryptlabel1.Text = OpenFileDialog.SetValueFortextbox1;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            //find the file
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.ShowDialog();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                //read to end of fill
                Program.ReadFiles(textBox1.Text);
            }
            //pass to encrypt 
            //Program.encryption();
            this.Close();
            EncryptLogIn encryptLogIn = new EncryptLogIn();
            encryptLogIn.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
