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
            int dice = -20;
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
    }
}
