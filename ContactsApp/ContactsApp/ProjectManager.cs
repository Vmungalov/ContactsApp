using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
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
        /// Метод "LoadFromFile", осуществляет загрузку контактов из файла.
        /// </summary>
        private static Project LoadFromFile()
        {
            Project project = new Project();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(Settings.Paths.MainFilePath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }
            return project;
        }
        
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
        /// Метод "MainFileExists" проверяет наличие основного файла с контактами
        /// </summary>
        /// <returns>"Истина", если файл существует, иначе "ложь"</returns>
        private static bool MainFileExists()
        {
            return File.Exists(Settings.Paths.MainFilePath);
        }

        /// <summary>
        /// Метод "BackupExists" проверяет наличие временного файла с контактами
        /// </summary>
        /// <returns>"Истина", если файл существует, иначе "ложь"</returns>
        private static bool BackupExists()
        {
            return File.Exists(Settings.Paths.BackupFilePath);
        }

        /// <summary>
        /// Метод "LoadProject" пытается асинхронно загрузить список контактов из основного или резервного файла
        /// </summary>
        /// <returns>Объект класса ProjectStatus (внутри содержит объект класса Project и статус загрузки)</returns>
        public static async Task<ProjectStatus> LoadProject()
        {
            ProjectStatus status = new ProjectStatus();
            if (BackupExists())
            {
                
            }
            return status;
        }

        /// <summary>
        /// Метод "ReadFile" асинхронно читает файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Строка, содержащая весь файл</returns>
        public static async Task<string> ReadFile(string path)
        {
            // Открывается поток для чтения файла
            FileStream stream = File.Open(path, FileMode.Open);
            // Создаётся массив байтов для чтения файла
            byte[] byteArray = new byte[stream.Length];
            // Читается файл от начала до конца
            await stream.ReadAsync(byteArray, 0, byteArray.Length);
            // Запись файла в строку
            string textString = System.Text.Encoding.UTF8.GetString(byteArray);
            // Возврат строки
            return textString;
        }

        /// <summary>
        /// Метод "ReadProject" читает файл и возвращает объект класса ProjectStatus.
        /// В случае успеха в нём будет содержаться список контактов и успешный статус.
        /// В случае неудачи он бросит исключение.
        /// </summary>
        /// <param name="type">Тип файла</param>
        /// <returns>Объект класса ProjectStatus</returns>
        /// <exception cref="ProjectReadingException">Исключение, возникающее при ошибке чтения или
        /// десериализации файла контактов.</exception>
        public static async Task<ProjectStatus> ReadProject(FileType type)
        {
            ProjectStatus projectStatus = new ProjectStatus();
            // Выбор файла
            string path = type == FileType.Main ? Paths.MainFilePath : Paths.BackupFilePath;
            try
            {
                // Чтение файла в строку
                string file = await ReadFile(path);
                // Десериализация
                projectStatus.Project = JsonConvert.DeserializeObject<Project>(file);
                // Установка статуса в случае успешного чтения
                projectStatus.Status = type == FileType.Main ? LoadingStatus.Success : LoadingStatus.Backup;
            }
            catch (JsonSerializationException ex)
            {
                throw new ProjectReadingException(ex, "Failed to deserialize contacts file", path);
            }
            catch (Exception ex)
            {
                throw new ProjectReadingException(ex, "Failed to read contacts file", path);
            }
            return projectStatus;
        }
    }
}