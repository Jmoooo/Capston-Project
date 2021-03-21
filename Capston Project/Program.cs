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
        /*public static ReadFiles(string)
        {

        }
        public static void encryption()
        {

        }
        */

    }
}
