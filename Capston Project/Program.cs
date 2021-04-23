using System;
using Capston_Project;
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
        public static void ViewFile(string text)
         {
             var fileToOpen = @"C:\";
             var process = Process.Start("notepad.exe");
         }

         public static void ReadFiles(string textbox1)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(textbox1);
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                //Program.Caesar(line);
                counter++;
            }

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
        }
        public static string Caesar(string value, int shift)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Letter.
                char letter = buffer[i];
                // Add shift to all.
                letter = (char)(letter + shift);
                // Subtract 26 on overflow.
                // Add 26 on underflow.
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Store.
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        /* public static void encryption()
         {
            var filetoopen = "SomeFilePathHere";
            while (filetoopen != endoffile)
            {
                ReadFiles(filetoopen);
                foreach (char)
                {
                     if(char == "A" || "a")
                     {
                         char = 1;
                     }
                     if(char == "B" || "b")
                     {
                         char = 2;
                     }
                     if(char == "C" || "c")
                     {
                         char = 3;
                     }
                     if(char == "D"||"d")
                     {
                         char = 4;
                     }
                     if(char == "E"||"e")
                     {
                         char = 5;
                     }
                     if(char =="F"||"f")
                     {
                         char = 6;
                     }
                     if (char == "G" || "g")
                     {
                         char = 7;
                     }
                     if (char == "H" || "h")
                     {
                         char = 8;
                     }
                     if (char == "I" || "i")
                     {
                         char = 9;
                     }
                     if (char == "J" || "j")
                     {
                         char = 10;
                     }
                     if (char == "K" || "k")
                     {
                         char = 11;
                     }
                     if (char == "L" || "l")
                     {
                         char = 12;
                     }
                     if (char == "M" || "m")
                     {
                         char = 13;
                     }
                     if (char == "N" || "n")
                     {
                         char = 14;
                     }
                     if (char == "O" || "o")
                     {
                         char = 15;
                     }
                     if (char == "P" || "p")
                     {
                         char = 16;
                     }
                     if (char == "Q" || "q")
                     {
                         char = 17;
                     }
                     if (char == "R" || "r")
                     {
                         char = 18;
                     }
                     if (char == "S" || "s")
                     {
                         char = 19;
                     }
                     if (char == "T" || "t")
                     {
                         char = 20;
                     }
                     if (char == "U" || "u")
                     {
                         char = 21;
                     }
                     if (char == "V" || "v")
                     {
                         char = 22;
                     }
                     if (char == "W" || "w")
                     {
                         char = 23;
                     }
                     if (char == "X" || "x")
                     {
                         char = 24;
                     }
                     if (char == "Y" || "y")
                     {
                         char = 25;
                     }
                     if (char == "Z" || "z")
                     {
                         char = 26;
                     }
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
        /*public static void Decryption()
        {
            //Readfile
            ReadFiles();
            //get unicode of current file
            //reverse the process of encryptinon 
            //creat and output new file//new file for demo/project
            
        }*/
    }
}
