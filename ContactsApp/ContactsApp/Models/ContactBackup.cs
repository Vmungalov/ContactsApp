namespace ContactsApp
{
    public class ContactBackup
    {
        public Contact Contact;
        public int Index;

        public bool Equals(ContactBackup other)
        {
            if (other == null)
                return false;
            return Contact.Equals(other.Contact) && Index.Equals(other.Index);
        }
    }
}