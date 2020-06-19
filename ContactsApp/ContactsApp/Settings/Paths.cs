using System;
using System.Collections.Generic;

namespace ContactsApp.Settings
{
    public static class Paths
    {
        public static Dictionary<FileType,string> PathsDictionary = new Dictionary<FileType, string>()
        {
            {FileType.Main, MainFilePath},
            {FileType.Backup, BackupFilePath},
            {FileType.OneContactBackup, OneContactBackupFilePath}
        };
        
        public static string AppData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string AppFolder => AppData + @"\ContactsApp";
        public static string MainFilePath => AppFolder + @"\ContactsApp.notes";
        public static string BackupFilePath => AppFolder + @"\ContactsApp.notes.bak";
        public static string OneContactBackupFilePath => AppFolder + @"\contact_{0}.bak";
    }
}