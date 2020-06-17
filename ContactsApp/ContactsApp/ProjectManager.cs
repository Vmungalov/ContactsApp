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
        /// Метод "SaveToFile", осуществляет загрузку контактов в файл.
        /// </summary>
        private static void SaveToFile(Project project)
        {
            if (!File.Exists(Settings.Paths.MainFilePath))
                using (FileStream fs = File.Create(Settings.Paths.MainFilePath)) { }
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Settings.Paths.MainFilePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод "LoadProject" пытается асинхронно загрузить список контактов из основного или резервного файла
        /// </summary>
        /// <returns>Объект класса ProjectStatus (внутри содержит объект класса Project и статус загрузки)</returns>
        public static async Task<ProjectStatus> LoadProject()
        {
            ProjectStatus status = new ProjectStatus();
            ProjectStatus backupStatus = new ProjectStatus();
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

    }
}