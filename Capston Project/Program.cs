using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capston_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EncryptLogIn());
        }
        /*public static void UserNamesAndPasswords()
        {
            //Set to get username and passwords 
            //get from text box on log in and compare to hash
            //hash will be stored in text file on hard drive for demo
            //might set up for now just store that data
            //readonly(UserPasswordTextBox);
            var FileToCreate = ; //Save file location for updated and edits
            

        }*/
        public static async Task CreateUserLogIn()
        {
            string[] lines =
            {
                createUserName,CreateUserPasswordFirst,CreateUserPasswordSecond
            };
            await File.WriteAllText("UserLogIn.txt", lines);
        }
        public static void ViewFile()
         {
             var fileToOpen = "SomeFilePathHere";
             var process = Process.Start("notepad.exe");
         }

         public static void ReadFiles()
        {

        }
        /*public static void encryption()
        {
           var filetoopen = "SomeFilePathHere";
           while (filetoopen != endoffile)
           {
               ReadFiles(filetoopen);
               foreach (char)
               {
                   //double CharCode;
                   //double OutPutNewCode;
                   //get the unicode of the char
                   //char = CharCode;
                   //take uniecode times 65
                   //OutPutNewCode = CharCode * 65;
                   //miniuse 5
                   //OutPutNewCode - 5;
                   //times 8
                   //OutPutNewCode * 8;
                   //devided by 10
                   //OutPutNewCode/10;
                   //output new unicode to and output to be new char
                   //create new text file //new text file made for this demo/project 
               }
           }
        }*/
    }
}
