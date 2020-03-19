using System;
using System.IO;
using Newtonsoft.Json;

namespace ContactsAppUI.Properties
{
    /// <summary>
    /// Класс "ProjectManager", в котором происходит работа с файлом.
    /// </summary>
    public class ProjectManager
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                     @"\Roaming\ContactsApp.notes";
        /// <summary>
        /// Метод "LoadFromFile", осуществляет загрузку контактов из файла.
        /// </summary>
        public static Project LoadFromFile()
        {
            Project project = null;
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(path))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }
            return project;
        }
        
        /// <summary>
        /// Метод "SaveToFile", осуществляет загрузку контактов в файл.
        /// </summary>
        public static void SaveToFile(Project project)
        {
            if (!File.Exists(path))
                using (FileStream fs = File.Create(path)) { }
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }
    }
}