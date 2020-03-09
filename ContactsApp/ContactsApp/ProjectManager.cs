using System;
using System.IO;
using Newtonsoft.Json;

namespace ContactsAppUI.Properties
{
    public class ProjectManager
    {
        private static string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                     @"\Roaming\ContactsApp.notes";
        
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