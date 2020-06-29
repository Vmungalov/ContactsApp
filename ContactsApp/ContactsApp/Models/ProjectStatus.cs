namespace ContactsApp
{
    public enum LoadingStatus
    {
        Success,
        Backup,
        Failed, // TODO: не используется
        NotExist // TODO: не используется
    }

    // TODO: сильно переусложнил. Должен быть только один тип файла, основной. Остальные не нужны. Тем более сохранять бэкапы на том же жестком диске бессмысленно
    public enum FileType
    {
        Main,
        Backup,
        OneContactBackup // TODO: слово бэкап вводит в заблуждение - так как это не для восстановления данных пользователя в случае смерти устройств или иных форсмажоров, а просто промежуточное сохранение данных
    }
    
    public class ProjectStatus
    {
        public LoadingStatus Status { get; set; }
        public Project Project { get; set; }
    }
}