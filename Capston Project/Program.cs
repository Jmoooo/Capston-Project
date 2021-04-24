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
        public static void ViewFile(string textbox1)
         {
            System.IO.StreamReader file =
               new System.IO.StreamReader(textbox1);
            var process = Process.Start("notepad.exe",textbox1);
         }
         public static void ReadFilesEncript(string textbox1)
        {
            int counter = 0;
            string line;
            //Random rnd = new Random();
            int dice = 20;// rnd.Next(1, 10);
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(textbox1);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
                Program.Encrypt(line, dice);
            }
            //ReadFilesDEcript(dice);
            file.Close();
            Console.WriteLine("There were {0} lines.", counter);
        }
        public static string Encrypt(string value, int shift)
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
                Console.WriteLine(buffer);
            }
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\jcmor\\OneDrive\\Documents\\encryptTest.txt");
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                //sw.WriteLine("is this working");
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exeception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Exeception finallly block.");
            }
            return new string(buffer);
        }
        public static void ReadFilesDEcript(string textbox1)
        {
            int counter = 0;
            string line;
            int dice = 20;
            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(textbox1);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
                Program.Dencrypt(line, dice);
            }

            file.Close();
            Console.WriteLine("There were {0} lines.", counter);
        }
        public static string Dencrypt(string value, int shift)
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
                if (letter < 'z')
                {
                    letter = (char)(letter + 26);
                }
                else if (letter > 'a')
                {
                    letter = (char)(letter - 26);
                }
                // Store.
                buffer[i] = letter;
                Console.WriteLine(buffer);
            }
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\jcmor\\OneDrive\\Documents\\decryptTest.txt");
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
                sw.WriteLine(buffer);
               // sw.WriteLine("is this working");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Exeception finallly block.");
            }
            return new string(buffer);
        }
        /* public static void encryption(string value)
         {
            char[] buffer = value.ToCharArray();
            
            for(int i = 0; i<buffer.Length;)
            {
                char latter = buffer[i];
                latter = (char);
                if(latter == "A" || "a")
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
                if (char == "D" || "d")
                {
                    char = 4;
                }
                if (char == "E" || "e")
                {
                    char = 5;
                }
                if (char == "F" || "f")
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
