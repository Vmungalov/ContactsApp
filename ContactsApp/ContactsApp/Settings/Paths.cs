using System;

namespace ContactsApp.Settings
{
    public static class Paths
    {
        public static string AppFolder => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                                          @"\ContactsApp";
        
        public static string MainFilePath => AppFolder + @"\ContactsApp.notes";
        
        public static string BackupFilePath => AppFolder + @"\ContactsApp.notes.bak";
    }
}