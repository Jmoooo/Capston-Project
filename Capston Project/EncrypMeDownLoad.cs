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
    public partial class EncrypMeDownLoad : Form
    {
        public EncrypMeDownLoad()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DownLoadButton_Click(object sender, EventArgs e)
        {
            //download the file or creat new doc of the read file 
            //or create an unencrypted and open that
        }
    }
}
