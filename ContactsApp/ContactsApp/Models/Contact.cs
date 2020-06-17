using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Contact", содержащий в себе информацию о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        DateTime DateCheck = new DateTime(1900, 01, 01);

        private string surname = "";
        private string name = "";
        private string vkId = "";
        private DateTime birthday = new DateTime();
        
        /// <summary>
        /// Поле "Surname", в котором находятся данные о фамилии контакта.
        /// </summary>
        public string Surname {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Фамилия не должна превышать 50 символов.");
                }
                else
                {
                    surname = value;
                }
            }
            get => surname;
        }
        
        /// <summary>
        /// Поле "Name", в котором содержатся данные об имени контакта.
        /// </summary>
        public string Name {
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("Имя не должно превышать 50 символов.");
                }
                else
                {
                    name = value;
                }
            }
            get => name;
        }
        
        /// <summary>
        /// Поле "Email", в котором содержатся данные о почтовом адресе контакта.
        /// </summary>
        public string Email { get; set; }
        
        /// <summary>
        /// Поле "IDvk", в котором содержатся данные о ID вконтакте контакта.
        /// </summary>
        public string IDvk {
            set
            {
                if (vkId.Length > 15)
                {
                    throw new ArgumentException("ID вконтакте не должен превышать 15 символов.");
                }
                else
                {
                    vkId = value;
                }
            }
            get => vkId;
        }
        
        /// <summary>
        /// Поле "Number", в котором содержатся данные о номере телефона контакта.
        /// </summary>
        public PhoneNumber Number { get; set; }
        
        /// <summary>
        /// Поле "Birthday", в котором содержатся данные о дне рождении контакта.
        /// </summary>
        public DateTime Birthday
        {
            get => birthday;
            set
            {
                if (value > DateTime.Today)
                {
                    throw new ArgumentException("Дата рождения не может быть больше текущей даты.");
                }
                else if (value < DateCheck)
                {
                    throw new ArgumentException("Дата рождения не может быть меньше 1900 года.");
                }
                else
                {
                    birthday = value;
                }
            }
        }

        public object Clone()
        {
            Contact contact = new Contact();
            contact.Surname = this.Surname;
            contact.Name = this.Name;
            contact.IDvk = this.IDvk;
            contact.Email = this.Email;
            contact.Number = this.Number;
            contact.Birthday = this.Birthday;
            return contact;
        }
    }
}