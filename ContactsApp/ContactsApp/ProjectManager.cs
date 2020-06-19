using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exceptions;
using Newtonsoft.Json;

namespace ContactsApp
{
    /// <summary>
    /// Класс "ProjectManager", в котором происходит работа с файлом.
    /// </summary>
    public class ProjectManager
    {
        /// <summary>
        /// Метод "LoadProjectAsync" пытается асинхронно загрузить список контактов из основного или резервного файла
        /// </summary>
        /// <returns>Объект класса ProjectStatus (внутри содержит объект класса Project и статус загрузки)</returns>
        public static async Task<ProjectStatus> LoadProjectAsync()
        {
            ProjectStatus status = new ProjectStatus();
            ProjectStatus backupStatus;
            // Чтение бэкапа, если он существует
            if (FileWorker.BackupExists())
            {
                backupStatus = await FileWorker.ReadProjectAsync(FileType.Backup);
                status = backupStatus;
                FileWorker.DeleteBackup();
                return status;
            }
            // Открытие основного файла контактов
            // Если его нет, он будет автоматически создан
            status = await FileWorker.ReadProjectAsync(FileType.Main);
            return status;
        }

        /// <summary>
        /// Метод "SaveProjectAsync" асинхронно записывает список контактов в файл
        /// </summary>
        /// <param name="project">Объект класса Project, содержащий список контактов</param>
        /// <param name="backup">Булевая переменная, значение которой определяет необходимость записать информацию в
        /// резервный файл. "Истина", если нужно писать бэкап, иначе "ложь"</param>
        public static async Task SaveProjectAsync(Project project, bool backup)
        {
            FileType type = backup ? FileType.Backup : FileType.Main; 
            await FileWorker.OverwriteFileAsync(project, type);
            if (FileWorker.BackupExists())
                FileWorker.DeleteBackup();
        }

        public static async Task BackupContactAsync(ContactBackup contact)
        {
            await FileWorker.OverwriteFileAsync(contact, FileType.OneContactBackup);
        }

        /// <summary>
        /// Метод "RecreateProjectAsync" удаляет текущий основной файл контактов и пересоздаёт его с нуля
        /// </summary>
        /// <returns></returns>
        public static async Task RecreateProjectAsync()
        {
            await FileWorker.OverwriteFileAsync(new Project(), FileType.Main);
        }
    }
}