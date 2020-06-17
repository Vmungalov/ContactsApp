using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsAppUI.Properties;
using Newtonsoft.Json;

namespace ContactsAppUI
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
            string date = JsonConvert.SerializeObject(new DateTime(1900, 01, 01));
            var check = ContactsApp.ProjectManager.ReadProject(FileType.Main).Result;
            Application.Run(new MainForm());
        }
    }
}