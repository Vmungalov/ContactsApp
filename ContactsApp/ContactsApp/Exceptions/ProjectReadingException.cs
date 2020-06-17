using System;

namespace ContactsApp.Exceptions
{
    public class ProjectReadingException : Exception
    {
        public new Exception InnerException { get; }
        public string Reason { get; }
        public string Path { get; }
        
        public ProjectReadingException(Exception ex, string reason, string path)
        {
            InnerException = ex;
            Reason = reason;
            Path = path;
        }
    }
}