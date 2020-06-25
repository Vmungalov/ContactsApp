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
        /// <exception cref="ProjectFileCorruptedException">Возникает, если файл проекта повреждён</exception>
        /// <exception cref="ProjectReadingException">Возникает при ошибке чтения файла проекта</exception>
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
                projectStatus.Project = JsonConvert.DeserializeObject<Project>(file) ?? new Project();
                // Установка статуса в случае успешного чтения
                projectStatus.Status = type == FileType.Main ? LoadingStatus.Success : LoadingStatus.Backup;
            }
            // Ошибка десериализации
            // Возникает, если файл повреждён, неправильно изменён, или если в него был дописан мусор
            catch (JsonReaderException ex)
            {
                throw new ProjectFileCorruptedException(ex, ex.Message, path);
            }
            // Недостаточно прав для чтения файла
            catch (InsufficientPermissionsException)
            {
                throw;
            }
            // Ошибка ввода/вывода при чтении файла
            catch (ProjectReadingException)
            {
                throw;
            }
            // Любые другие ошибки
            catch (Exception ex)
            {
                throw new ProjectReadingException(ex, "Failed to read contacts file", path);
            }
            return projectStatus;
        }

        /// <summary>
        /// Метод "OverwriteProjectAsync" переписывает файл со списком контактов
        /// </summary>
        /// <param name="project">Объект для сериализации</param>
        /// <param name="type">Тип файла (основной, бэкап и т.д.)</param>
        /// <returns></returns>
        internal static async Task OverwriteFileAsync(object obj, FileType type)
        {
            // Выбор файла
            string path = Paths.PathsDictionary[type];
            try
            {
                // Создание папки проекта в случае её отсутствия
                // Если она есть, метод ничего не сделает
                CreateFolder(Paths.AppFolder);
                // Преобразование объекта Project в строку
                string data = JsonConvert.SerializeObject(obj);
                // Запись файла
                await OverwriteFile(path, data);
            }
            catch (InsufficientPermissionsException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new ProjectReadingException(ex, "Failed to write contacts file", path);
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

        /// <summary>
        /// Метод "OneContactBackupExists" проверяет наличие временного файла одного контакта (редактируемого)
        /// </summary>
        /// <returns>"Истина", если файл существует, иначе "ложь"</returns>
        internal static bool OneContactBackupExists()
        {
            return File.Exists(Paths.OneContactBackupFilePath);
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
            try
            {
                // Открывается поток для чтения файла
                FileStream stream = File.Open(path, FileMode.OpenOrCreate);
                // Создаётся массив байтов для чтения файла
                byte[] byteArray = new byte[stream.Length];
                // Читается файл от начала до конца
                await stream.ReadAsync(byteArray, 0, byteArray.Length);
                // Запись файла в строку
                string textString = System.Text.Encoding.UTF8.GetString(byteArray);
                // Закрытие потока
                stream.Close();
                // Возврат строки
                return textString;
            }
            // Ошибка, возникающая при отсутствии у пользователя прав доступа на файл
            catch (UnauthorizedAccessException ex)
            {
                throw new InsufficientPermissionsException(ex, "Unable to read file " + path + " due " +
                                                               "to permissions insufficiency", path);
            }
            // Ошибка ввода/вывода
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "An I/O error has occured during reading the file", path);
            }
            // Ошибка преобразования массива байтов в строку
            catch (ArgumentException ex)
            {
                throw new ProjectFileCorruptedException(ex, "An error has occured during converting bytes " +
                                                            "array into string. Input file may be corrupted.", path);
            }
            // Любая другая ошибка
            catch (Exception ex)
            {
                throw new ProjectReadingException(ex, "An undefined error has occured", path);
            }
        }

        /// <summary>
        /// Метод "CreateFolder" создаёт папку
        /// </summary>
        /// <param name="path">Путь к создаваемой папке</param>
        private static void CreateFolder(string path)
        {
            try
            {
                Directory.CreateDirectory(path);
            }
            // Ошибка возникает в случае отсутствия прав доступа на запись в %APPDATA%
            catch (UnauthorizedAccessException ex)
            {
                throw new InsufficientPermissionsException(ex, "Unable to create directory " + path + " due " +
                                                               "to permissions insufficiency", path);
            }
        }

        /// <summary>
        /// Метод "OverwriteFile" асинхронно переписывает файл
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="data">Строка данных</param>
        /// <returns></returns>
        /// <exception cref="InsufficientPermissionsException">Недостаточно прав для записи файла</exception>
        /// <exception cref="ProjectReadingException">Ошибка чтения или записи файла</exception>
        private static async Task OverwriteFile(string path, string data)
        {
            try
            {
                // Создание временного файла
                FileStream stream = File.Open(path + ".temp", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                // Создаётся массив байтов для записи в файл
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(data);
                // Асинхронная запись массива байтов в файл
                await stream.WriteAsync(byteArray, 0, byteArray.Length);
                // Закрытие потока
                stream.Close();
                // Удаление основного файла
                File.Delete(path);
                // Подстановка временного файла вместо бывшего основного
                File.Move(path + ".temp", path);
            }
            // Ошибка, возникающая при отсутствии у пользователя прав доступа на файл
            catch (UnauthorizedAccessException ex)
            {
                throw new InsufficientPermissionsException(ex, "Unable to write file " + path + " due " +
                                                               "to permissions insufficiency", path);
            }
            // Ошибка ввода/вывода
            catch (IOException ex)
            {
                throw new ProjectReadingException(ex, "An I/O error has occured during writing the file", path);
            }
            // Любая другая ошибка
            catch (Exception ex)
            {
                throw new ProjectReadingException(ex, "An undefined error has occured", path);
            }
        }
        
        #endregion
    }
}