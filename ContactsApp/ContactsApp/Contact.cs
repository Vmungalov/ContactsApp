using System;
using System.Globalization;

namespace ContactsAppUI.Properties
{
    public class Contact : ICloneable
    {
        DateTime DateCheck = new DateTime(1900, 01, 01);
        public string Surname {
            set
            {
                if (Surname.Length > 50)
                {
                    throw new ArgumentException("Фамилия не должна превышать 50 символов.");
                }
                else
                {
                    Surname = value;
                }
            }
            get { return Surname; }
        }
        
        public string Name {
            set
            {
                if (Name.Length > 50)
                {
                    throw new ArgumentException("Имя не должно превышать 50 символов.");
                }
                else
                {
                    Name = value;
                }
            }
            get { return Name; }
        }
        
        public string Email { get; set; }

        public string IDvk {
            set
            {
                if (IDvk.Length > 15)
                {
                    throw new ArgumentException("ID вконтакте не должен превышать 15 символов.");
                }
                else
                {
                    IDvk = value;
                }
            }
            get { return IDvk; }
        }

        public PhoneNumber Number { get; set; }

        public DateTime Birthday
        {
            get { return Birthday; }
            set
            {
                if (Birthday > DateTime.Today)
                {
                    throw new ArgumentException("Дата рождения не может быть больше текущей даты.");
                }
                else if (Birthday < DateCheck)
                {
                    throw new ArgumentException("Дата рождения не может быть меньше 1900 года.");
                }
                else
                {
                    Birthday = value;
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