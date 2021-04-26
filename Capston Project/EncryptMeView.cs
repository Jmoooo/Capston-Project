using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capston_Project
{
    public partial class EncryptMeView : Form
    {
        public EncryptMeView()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
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
                //SetValueFortextbox1 = textBox1.Text;
                Program.ViewFile(textBox1.Text);
            }
            this.Close();
            //EncryptLogIn encryptLogIn = new EncryptLogIn();
            //encryptLogIn.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
