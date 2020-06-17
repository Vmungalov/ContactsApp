using System;

namespace ContactsApp.Settings
{
    public static class Paths
    {
        public static string MainFilePath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
                                      @"\ContactsApp.notes";
        
        public static string BackupFilePath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + 
                                               @"\ContactsApp.notes.bak";
    }
}