using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public class UiManager
    {
        public static void CloseApplication(Project project)
        {
            ProjectManager.SaveProjectAsync(project, false);
            Application.Exit();
        }
    }
}