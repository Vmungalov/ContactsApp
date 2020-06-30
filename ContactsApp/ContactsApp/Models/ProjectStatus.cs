namespace ContactsApp
{
    public enum LoadingStatus
    {
        Success,
        Failed
    }

    public class ProjectStatus
    {
        public LoadingStatus Status { get; set; }
        public Project Project { get; set; }
    }
}