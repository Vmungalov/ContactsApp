using System;

namespace ContactsApp.Exceptions
{
    public class InsufficientPermissionsException : ProjectReadingException
    {
        public InsufficientPermissionsException(Exception ex, string message, string path) : 
            base(ex, message, path)
        {
            
        }
    }
}