using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Contact", содержащий в себе информацию о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        private DateTime _minDate = new DateTime(1900,1,1);
        public short MaxLength = 50;
        
        private DateTime _birthday = new DateTime(1900,01,01);

        /// <summary>
        /// Метод "TextIsValid" проверяет правильность ввода текстовых полей (имени, фамилии и т.д.)
        /// </summary>
        /// <param name="value">Входная строка</param>
        /// <returns>"Истина", если значение корректно, иначе "ложь"</returns>
        private bool TextIsValid(string value)
        {
            return value != null && value.Length <= MaxLength;
        }

        /// <summary>
        /// Метод "DateIsValid" проверяет правильность ввода даты рождения
        /// </summary>
        /// <param name="date">Дата рождения</param>
        /// <returns>"Истина", если значение корректно, иначе "ложь"</returns>
        private bool DateIsValid(DateTime date)
        {
            return date >= _minDate && date <= DateTime.Now;
        }

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
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }

        public bool SetSurname(string value)
        {
            if (TextIsValid(value))
            {
                Surname = value;
                return true;
            }
            throw new ArgumentException("Длина фамилии не должна превышать " + 
                                        MaxLength + " знаков.");
        }
        
        public bool SetFirstName(string value)
        {
            if (TextIsValid(value))
            {
                FirstName = value;
                return true;
            }
            throw new ArgumentException("Длина имени не должна превышать " + 
                                        MaxLength + " знаков.");
        }
        
        public bool SetEmail(string value)
        {
            if (TextIsValid(value))
            {
                Email = value;
                return true;
            }
            throw new ArgumentException("Длина E-Mail не должна превышать " + 
                                        MaxLength + " знаков.");
        }
        
        public bool SetVkId(string value)
        {
            if (TextIsValid(value))
            {
                IdVk = value;
                return true;
            }
            throw new ArgumentException("Длина ID VK не должна превышать " + 
                                        MaxLength + " знаков.");
        }

        public bool SetBirthday(DateTime date)
        {
            if (DateIsValid(date))
            {
                Birthday = date;
                return true;
            }
            throw new ArgumentException("Введеная неправильная дата рождения.");
        }
        
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
        
        public bool Equals(Contact other)
        {
            return other.Surname.Equals(Surname)
                   && other.FirstName.Equals(FirstName)
                   && other.Birthday.Equals(Birthday)
                   && other.Number.Equals(Number)
                   && other.Email.Equals(Email)
                   && other.IdVk.Equals(IdVk);
        }
    }
}