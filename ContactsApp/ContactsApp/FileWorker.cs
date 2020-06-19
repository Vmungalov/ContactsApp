using System;
using System.IO;
using System.Threading.Tasks;
using ContactsApp.Exceptions;
using ContactsApp.Settings;
using Newtonsoft.Json;

namespace ContactsApp
{
    public static class FileWorker
    {
        #region Internals
        
        /// <summary>
        /// Метод "ReadProject" читает файл и возвращает объект класса ProjectStatus.
        /// В случае успеха в нём будет содержаться список контактов и успешный статус.
        /// В случае неудачи он бросит исключение.
        /// </summary>
        /// <param name="type">Тип файла</param>
        /// <returns>Объект класса ProjectStatus</returns>
        /// <exception cref="ProjectReadingException">Исключение, возникающее при ошибке чтения или
        /// десериализации файла контактов.</exception>
        internal static async Task<ProjectStatus> ReadProjectAsync(FileType type)
        {
            ProjectStatus projectStatus = new ProjectStatus();
            // Выбор файла
            string path = Paths.PathsDictionary[type];
            try
            {
                // Создание папки проекта в случае её отсутствия
                // Если она есть, метод ничего не сделает
                CreateFolder(Paths.AppFolder);
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

        /// <summary>
        /// Метод "OverwriteProjectAsync" переписывает файл со списком контактов
        /// </summary>
        /// <param name="project">Объект класса Project</param>
        /// <param name="type">Тип файла (основной, бэкап и т.д.)</param>
        /// <returns></returns>
        internal static async Task OverwriteProjectAsync(Project project, FileType type)
        {
            // Выбор файла
            string path = Paths.PathsDictionary[type];
            try
            {
                // Создание папки проекта в случае её отсутствия
                // Если она есть, метод ничего не сделает
                CreateFolder(Paths.AppFolder);
                // Преобразование объекта Project в строку
                string data = JsonConvert.SerializeObject(project);
                // Запись файла
                await OverwriteFile(path, data);
            }
            catch (Exception ex)
            {
                // Нужно дописать исключения
            }
        }

        /// <summary>
        /// Метод "DeleteBackup" удаляет резевный файл контактов
        /// </summary>
        internal static void DeleteBackup()
        {
            if (BackupExists())
                File.Delete(Paths.BackupFilePath);
        }
        
        /// <summary>
        /// Метод "MainFileExists" проверяет наличие основного файла с контактами
        /// </summary>
        /// <returns>"Истина", если файл существует, иначе "ложь"</returns>
        internal static bool MainFileExists()
        {
            return File.Exists(Settings.Paths.MainFilePath);
        }

        /// <summary>
        /// Метод "BackupExists" проверяет наличие временного файла с контактами
        /// </summary>
        /// <returns>"Истина", если файл существует, иначе "ложь"</returns>
        internal static bool BackupExists()
        {
            return File.Exists(Settings.Paths.BackupFilePath);
        }

        #endregion
        
        #region Privates

        /// <summary>
        /// Метод "ReadFile" асинхронно читает файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Строка, содержащая весь файл</returns>
        private static async Task<string> ReadFile(string path)
        {
            // Открывается поток для чтения файла
            FileStream stream = File.Open(path, FileMode.OpenOrCreate);
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
        /// Метод "DeleteFile" удаляет файл
        /// </summary>
        /// <param name="path">Путь до файла</param>
        private static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// Метод "CreateFolder" создаёт папку
        /// </summary>
        /// <param name="path">Путь к создаваемой папке</param>
        private static void CreateFolder(string path)
        {
            System.IO.Directory.CreateDirectory(path);
            // Дописать исключения на права
        }

        /// <summary>
        /// Метод "OverwriteFile" асинхронно переписывает файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="data">Строка данных</param>
        /// <returns></returns>
        private static async Task OverwriteFile(string path, string data)
        {
            // Открытие файла
            FileStream stream = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            // Создаётся массив байтов для записи в файл
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(data);
            // Асинхронная запись массива байтов в файл
            await stream.WriteAsync(byteArray, 0, byteArray.Length);
        }
        
        #endregion
    }
}