namespace ContactsApp
{
    public enum LoadingStatus
    {
        Success,
        Backup,
        Failed,
        NotExist
    }

    public enum FileType
    {
        Main,
        Backup
    }
    
    public class ProjectStatus
    {
        public LoadingStatus Status { get; set; }
        public Project Project { get; set; }
    }
}