﻿using System;
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
            Process.Start("explorer.exe");
            
            //read to end of file
            //Program.ReadFiles();
            //pass to encrypt 
            //Program.encryption();
            EncryptLogIn encryptLogIn = new EncryptLogIn();
            encryptLogIn.ShowDialog();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
