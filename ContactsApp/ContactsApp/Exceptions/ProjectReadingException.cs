using System;

namespace ContactsApp.Exceptions
{
    public class ProjectReadingException : Exception
    {
        public string Reason { get; }
        public string Path { get; }
        
        public ProjectReadingException(Exception ex, string reason, string path) : base(reason, ex)
        {
            Reason = reason;
            Path = path;
        }
    }
}