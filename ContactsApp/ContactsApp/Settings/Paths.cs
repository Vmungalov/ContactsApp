using System;
using System.Collections.Generic;

namespace ContactsApp.Settings
{
    public static class Paths
    {
        public static string AppData => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string AppFolder => AppData + @"\ContactsApp";
        public static string MainFilePath => AppFolder + @"\ContactsApp.notes";
    }
}