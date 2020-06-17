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
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var serialized = JsonConvert.SerializeObject(new DateTime(1999, 6, 16));
            var deserialized = JsonConvert.DeserializeObject<DateTime>(serialized);
            var status = await ContactsApp.ProjectManager.LoadProject();
            Application.Run(new MainForm(status));
        }
    }
}