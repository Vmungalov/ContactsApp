using System;

namespace ContactsApp.Exceptions
{
    public class ProjectFileCorruptedException : ProjectReadingException
    {
        public ProjectFileCorruptedException(Exception ex, string jsonMessage, string path) : 
            base(ex, jsonMessage, path)
        {
            
        }
    }
}