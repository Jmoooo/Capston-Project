using System;
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
            //string createUserName = CreateUserName.Text;
            //string CreateUserPasswordFirst = CreatePasswordFirst.Text;
            //string CreateUserPasswordSecond = CreatePasswordSecond.Text;
            //CreateUserLogIn(CreatePasswordFirst, CreatePasswordSecond);

            //Program.UserNamesAndPasswords(createUserName,CreateUserPasswordFirst,CreateUserPasswordSecond);
            //CreateUserLogIn(CreateUserName, CreateUserPasswordFirst, CreateUserPasswordSecond);
        }
       /* public class Login
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            static string path = @"c:\folder\p1.txt";
            public static void WriteUser(Login obj)
            {
                BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create));
                bw.Write(obj.UserName);
                bw.Write(obj.Password);
                bw.Close();
            }
            public static void ReadUser(Login obj)
            {
                BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
                obj.UserName = br.ReadString();
                obj.Password = br.ReadString();
                br.Close();
            }
        }

        class Test
        {
            static void Main()
            {
                Login a = new Login();

                a.UserName = "user1";
                a.Password = "pass1";
                Login.WriteUser(a);

                Login.ReadUser(a);
                Console.WriteLine(a.UserName + " " + a.Password);
            }
        }*/
        public static void CreateUserLogIn()
        {
           /* string CreateUserName = CreateUserNameTxt.Text;
            string CreateUserPasswordFirst = CreatePasswordFirst.Text;
            string CreateUserPasswordSecond = CreatePasswordSecond.Text;
            // string[] lines =
            // {
            //     createUserName,CreateUserPasswordFirst,CreateUserPasswordSecond
            // };
            //await File.WriteAllText("UserLogIn.txt", lines);
            //if file exists 
            //edit file
            string path = "\\Temp\\users.txt";
            string line = CreateUserName + "," + CreateUserPasswordFirst;

            if (!File.Exists(path))
            {
                MessageBox.Show(CreateUserName + " successfully created.");
                FileStream cred = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(cred);
                sw.WriteLine(line);
                sw.Close();
                cred.Close();
            }
            else
            {
                MessageBox.Show(CreateUserName + " successfully created");
                FileStream creds = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(creds);
                sw.WriteLine(line);
                sw.Close();
                creds.Close();
            }*/

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
