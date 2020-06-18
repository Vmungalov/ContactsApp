using System;
using System.IO;
using System.Threading.Tasks;
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
            try
            {
                // Чтение бэкапа, если он существует
                if (FileWorker.BackupExists())
                {
                    backupStatus = await FileWorker.ReadProject(FileType.Backup);
                    status = backupStatus;
                    FileWorker.DeleteBackup();
                    return status;
                }
                // Открытие основного файла контактов
                // Если его нет, он будет автоматически создан
                status = await FileWorker.ReadProject(FileType.Main);
            }
            catch (Exception ex)
            {
                // Нужно дописать исключения
            }

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
            
        }

    }
}