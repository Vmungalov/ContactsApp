using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Contact", содержащий в себе информацию о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        DateTime DateCheck = new DateTime(1900, 01, 01);
        private short maxLength = 50;
        private string firstName = "";
        private string patronymicName = "";
        private string vkId = "";
        private DateTime birthday = new DateTime(1900,01,01);

        /// <summary>
        /// Поле "Surname", в котором находятся данные о фамилии контакта.
        /// </summary>
        public string Surname { get; set; } = "";

        /// <summary>
        /// Поле "FirstName", в котором содержатся данные об имени контакта.
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Поле "Email", в котором содержатся данные о почтовом адресе контакта.
        /// </summary>
        public string Email { get; set; } = "";

        /// <summary>
        /// Поле "IdVk", в котором содержатся данные о ID вконтакте контакта.
        /// </summary>
        public string IdVk { get; set; } = "";

        /// <summary>
        /// Поле "Number", в котором содержатся данные о номере телефона контакта.
        /// </summary>
        public PhoneNumber Number { get; set; } = new PhoneNumber();

        /// <summary>
        /// Поле "Birthday", в котором содержатся данные о дне рождении контакта.
        /// </summary>
        public DateTime Birthday { get; set; } = new DateTime(1900,1,1);

        public object Clone()
        {
            Contact contact = new Contact();
            contact.Surname = Surname;
            contact.FirstName = FirstName;
            contact.IdVk = IdVk;
            contact.Email = Email;
            contact.Number = Number;
            contact.Birthday = Birthday;
            return contact;
        }
    }
}