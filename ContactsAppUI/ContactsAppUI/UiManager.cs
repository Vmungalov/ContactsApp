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
        /// <summary>
        /// Загрузка списка контактов и запуск основной формы
        /// </summary>
        /// <returns></returns>
        public async Task LaunchUi()
        {
            try
            {
                var status = await ProjectManager.LoadProjectAsync();
                var mainForm = new MainForm(status);
                Application.Run(mainForm);
            }
            catch (ProjectFileCorruptedException)
            {
                await HandleCorruptedFileError();
            }
            catch (InsufficientPermissionsException)
            {
                HandlePermissionsError();
            }
            catch (ProjectReadingException)
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

        /// <summary>
        /// Метод "CloseApplication" сохраняет данные и закрывает приложение
        /// </summary>
        /// <param name="project">Объект Project для сохранения</param>
        /// <param name="save">"Истина", если необходимо сохранить данные (по умолчанию).</param>
        public void CloseApplication(Project project, bool save = true)
        {
            if (save)
                ProjectManager.SaveProjectAsync(project);
            Application.Exit();
        }

        #region Singleton
        
        private static readonly Lazy<UiManager> _current = new Lazy<UiManager>(() => new UiManager());
        
        public static UiManager Current => _current.Value;
        
        #endregion
    }
}