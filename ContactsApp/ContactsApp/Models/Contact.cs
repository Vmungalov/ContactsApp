using System;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Contact", содержащий в себе информацию о контакте.
    /// </summary>
    public class Contact : ICloneable
    {
        private readonly DateTime _minDate = new DateTime(1900,1,1);

        /// <summary>
        /// Максимальная длина фамилии, имени, e-mail и VK ID
        /// </summary>
        public short MaxLength = 50;

        private string _surname = "";
        private string _firstName = "";
        private string _email = "";
        private string _vkId = "";
        private PhoneNumber _number = new PhoneNumber();
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
        public string Surname
        {
            get => _surname;
            set
            {
                if (TextIsValid(value))
                    _surname = value;
                else
                    throw new ArgumentException("Длина фамилии не должна превышать " + 
                                            MaxLength + " знаков.");
            } 
        }

        /// <summary>
        /// Поле "FirstName", в котором содержатся данные об имени контакта.
        /// </summary>
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (TextIsValid(value))
                    _firstName = value;
                else
                    throw new ArgumentException("Длина имени не должна превышать " + 
                                            MaxLength + " знаков.");
            }
        }
        
        /// <summary>
        /// Поле "Email", в котором содержатся данные о почтовом адресе контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (TextIsValid(value))
                    _email = value;
                else
                    throw new ArgumentException("Длина E-Mail не должна превышать " + 
                                            MaxLength + " знаков.");
            }
        }

        /// <summary>
        /// Поле "IdVk", в котором содержатся данные о ID вконтакте контакта.
        /// </summary>
        public string IdVk
        {
            get => _vkId;
            set
            {
                if (TextIsValid(value))
                    _vkId = value;
                else
                    throw new ArgumentException("Длина ID VK не должна превышать " + 
                                            MaxLength + " знаков.");
            }
        }

        /// <summary>
        /// Поле "Number", в котором содержатся данные о номере телефона контакта.
        /// </summary>
        public PhoneNumber Number
        {
            get => _number;
            set => _number = value;
        }

        /// <summary>
        /// Поле "Birthday", в котором содержатся данные о дне рождении контакта.
        /// </summary>
        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                if (DateIsValid(value))
                    _birthday = value;
                else
                    throw new ArgumentException("Введеная неправильная дата рождения.");
            }
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