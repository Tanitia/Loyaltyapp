using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loyaltyapp
{
    public partial class Form1 : Form
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppLogin());
        }

        //private void CreateOrFindTextFile() {
        //    //creates file if doesn't exist
        //    string applicationPath = Directory.GetCurrentDirectory() + "\\";
        //    if (!File.Exists(applicationPath + "userInfo.txt"))
        //    {
        //        StreamWriter myOutputStream = File.CreateText("userInfo.txt");
        //        myOutputStream.Close();
        //    }
        //    else { }
        //    if (!File.Exists(applicationPath + "loyaltyNumbers.txt"))
        //    {
        //        StreamWriter myOutputStream = File.CreateText("loyaltyNumbers.txt");
        //        myOutputStream.Close();
        //    }


        //}
    }
}
