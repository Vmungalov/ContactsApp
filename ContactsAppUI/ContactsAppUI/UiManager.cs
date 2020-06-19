using System;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp;
using ContactsApp.Exceptions;

namespace ContactsAppUI
{
    public class UiManager
    {
        private MainForm MainForm;

        public async Task LaunchUi()
        {
            try
            {
                var status = await ProjectManager.LoadProjectAsync();
                MainForm = new MainForm(status);
                MainForm.FormClosing += MainFormOnFormClosing;
                Application.Run(new MainForm(status));
            }
            catch (ProjectFileCorruptedException ex)
            {
                // дописать обработку
            }
        }

        private void MainFormOnFormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void CloseApplication(Project project)
        {
            ProjectManager.SaveProjectAsync(project, false);
            Application.Exit();
        }
        
        public static UiManager Current = new UiManager();
    }
}