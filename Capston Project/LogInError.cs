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
    public partial class LogInError : Form
    {
        public LogInError()
        {
            InitializeComponent();
        }

        private void LogInError_Load(object sender, EventArgs e)
        {

        }

        private void PasswordError_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
