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

        /// <summary>
        /// Загрузка списка контактов и запуск основной формы
        /// </summary>
        /// <returns></returns>
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
                await HandleCorruptedFileError();
            }
            catch (InsufficientPermissionsException ex)
            {
                HandlePermissionsError();
            }
            catch (ProjectReadingException ex)
            {
                HandleReadError();
            }
        }

        /// <summary>
        /// Метод "HandleCorruptedFileError" позволяет обработать ошибку чтения повреждённого файла со списком контактов
        /// </summary>
        /// <returns></returns>
        private async Task HandleCorruptedFileError()
        {
            var mBoxResult = MessageBox.Show("Файл списка контактов повреждён. Нажмите OK, чтобы" +
                                              " попытаться восстановить файл. В случае неудачи все контакты будут" +
                                              "утеряны.", 
                "Ошибка чтения", MessageBoxButtons.OKCancel);
            if (mBoxResult == DialogResult.OK)
                await ProjectManager.RecreateProjectAsync();
            else
                CloseApplication(null, false);
        }

        /// <summary>
        /// Метод "HandleReadError" позволяет обработать ошибку чтения
        /// </summary>
        private void HandleReadError()
        {
            var mBoxResult = MessageBox.Show("Произошла ошибка чтения списка контактов. " +
                                             "Возможно, диск поврежден.",  
                "Ошибка чтения", 
                MessageBoxButtons.OK);
            CloseApplication(null, false);
        }

        /// <summary>
        /// Метод "HandlePermissionsError" позволяет обработать ошибку отсутствия у пользователя прав доступа к файлу
        /// со списком контактов
        /// </summary>
        private void HandlePermissionsError()
        {
            var mBoxResult = MessageBox.Show("Недостаточно прав для чтения списка контактов.",  
                "Нет доступа", 
                MessageBoxButtons.OK);
            CloseApplication(null, false);
        }
        
        private void MainFormOnFormClosing(object sender, FormClosingEventArgs e)
        {
            //CloseApplication();
        }

        public void CloseApplication(Project project, bool save = true)
        {
            if (save)
                ProjectManager.SaveProjectAsync(project, false);
            Application.Exit();
        }

        public static UiManager Current = new UiManager();
    }
}