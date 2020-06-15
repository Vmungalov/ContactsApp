namespace ContactsAppUI
{
    public class Settings
    {
        public string Email => "v_mungalov@mail.ru";
        public string EmailMailto => "mailto:" + Email;
        public string GitHubLink => "https://github.com/Vmungalov/ContactsApp";
        
        public static Settings Current = new Settings();
    }
}