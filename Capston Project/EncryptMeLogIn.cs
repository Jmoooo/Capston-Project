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
    public partial class EncryptLogIn : Form
    {
        public EncryptLogIn()
        {
            InitializeComponent();
        }

        private void EncryptLogIn_Load(object sender, EventArgs e)
        {

        }
        
        private void LogInButton_Click(object sender, EventArgs e)
        {
            string UserName = UserNameTextBox.Text;
            string UserPassword = UserPasswordTextBox.Text;
             if (UserName.Length >=8 && UserPassword.Length >=8)
            {
                if (UserName == "UserEncrypt" && UserPassword == "UserEncrypt")
                {
                    EncryptMeUpload encryptMeUpload = new EncryptMeUpload();
                    encryptMeUpload.ShowDialog();
                }
                else
                {
                    PopUpLogInFailed popUpLogInFailed = new PopUpLogInFailed();
                    popUpLogInFailed.ShowDialog();
                };
                if (UserName == "UserView" && UserPassword == "UserView")
                {
                    EncryptMeView encryptMeView = new EncryptMeView();
                    encryptMeView.ShowDialog();
                }
                else
                {
                    PopUpLogInFailed popUpLogInFailed = new PopUpLogInFailed();
                    popUpLogInFailed.ShowDialog();
                };
                if(UserName == "UserDecrypt" && UserPassword == "UserDecrypt")
                {
                    EncrypMeDownLoad encrypMeDownLoad = new EncrypMeDownLoad();
                    encrypMeDownLoad.ShowDialog();
                }
                else
                {
                    PopUpLogInFailed popUpLogInFailed = new PopUpLogInFailed();
                    popUpLogInFailed.ShowDialog();
                };
            }
             else
            {
                LogInError logInError = new LogInError();
                logInError.ShowDialog();
            }
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
