using System;
using System.Collections.Generic;
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
        static class UserNamesAndPasswords
        {
            //Set to get username and passwords 
            //might set up for now just store that data

        }
        /* static void ViewFile()
         {
             var fileToOpen = "SomeFilePathHere";
             var process = new Process("notepad.exe");
             process.StartInfo = new ProcessStartInfo("notepad.exe")
             {
                 UseShellExecute = true,
                 FileName = fileToOpen
             };

             process.Start();
             process.WaitForExit();
         }

         static void ReadFiles()
         {
             int counter = 0;
             string line;

             // Read the file and display it line by line.  
             System.IO.StreamReader file =/*file from upload or download*/
        // new System.IO.StreamReader(/*file from upload or download);
        /* while ((line = file.ReadLine()) != null)
         {
             System.Console.WriteLine(line);
             counter++;
         }

         file.Close();
         System.Console.WriteLine("There were {0} lines.", counter);
         // Suspend the screen.  
         System.Console.ReadLine();
     }*/
        /* public static void encryption()
         {

         }
         */

    }
}
