using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exceptions;
using ContactsApp.Settings;
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
            // Открытие основного файла контактов
            // Если его нет, он будет автоматически создан
            status = await FileWorker.ReadProjectAsync(Paths.MainFilePath);
            return status;
        }

        /// <summary>
        /// Метод "SaveProjectAsync" асинхронно записывает список контактов в файл
        /// </summary>
        /// <param name="project">Объект класса Project, содержащий список контактов</param>
        public static async Task SaveProjectAsync(Project project)
        {
            await FileWorker.OverwriteFileAsync(project);
        }

        /// <summary>
        /// Метод "RecreateProjectAsync" удаляет текущий основной файл контактов и пересоздаёт его с нуля
        /// </summary>
        /// <returns></returns>
        public static async Task RecreateProjectAsync()
        {
            await FileWorker.OverwriteFileAsync(new Project());
        }
    }
}