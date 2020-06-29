namespace ContactsApp
{
    // TODO: зачем этот класс? Просто для сохранения промежуточных результатов в EditForm?
    // Не проще ли хранить бэкап в дополнительном поле в форме, чем создавать кучу прикладной логики во всём проекте
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