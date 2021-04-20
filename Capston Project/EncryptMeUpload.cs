using System;
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

        private void UploadButton_Click(object sender, EventArgs e)
        {
            //find the file
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.ShowDialog();
            //read to end of file
            Program.ReadFiles();
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
