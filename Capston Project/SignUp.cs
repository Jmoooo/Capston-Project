﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace Capston_Project
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void CreatUserIdsButton_Click(object sender, EventArgs e)
        {
            String createUserName = CreateUserName.Text;
            String CreateUserPasswordFirst = CreatePasswordFirst.Text;
            String CreateUserPasswordSecond = CreatePasswordSecond.Text;

            //Program.UserNamesAndPasswords(createUserName,CreateUserPasswordFirst,CreateUserPasswordSecond);
            Program.CreateUserLogIn(CreateUserName, CreateUserPasswordFirst, CreateUserPasswordSecond);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
