using System;

namespace ContactsApp
{
    public enum PhoneType
    {
        Private,
        Work,
        Home,
        Main
    }
    
    /// <summary>
    /// Класс "PhoneNumber", в котором содержатся данные о номере телефона контакта.
    /// </summary>
    public class PhoneNumber
    {
        private long number;
        private string numberString;
        
        public PhoneType Type { get; set; }

        /// <summary>
        /// Число, содержащее в себе номер телефона.
        /// На данные момент имеются ограничения.
        /// Номер телефона должен иметь 11 цифр и начинаться с 7.
        /// </summary>
        /// <exception cref="ArgumentException">Исключение, бросаемое при числа, не подходящего под ограничения</exception>
        public long Number
        {
            get => number;
            set
            {
                // Проверка на количество цифр
                if (Digits(value) < 11)
                    throw new ArgumentException("Not enough digits in phone number");
                // Проверка на код страны +7
                if (GetDigit(value,1) != 7)
                    throw new ArgumentException("Country code must start with 7");
                number = value;
            }
        }

        /// <summary>
        /// Строковое представление номера телефона.
        /// Используется для упрощения вывода его в GUI в легкочитаемой форме.
        /// </summary>
        public string NumberString
        {
            get => numberString;
            set
            {
                Number = Converters.PhoneNumberStringToLongConverter.ConvertPhoneToLong(value);
                numberString = value;
            }
        }

        /// <summary>
        /// Метод "Digits" вычисляет количество цифр в числе логарифмическим способом.
        /// Требуется, чтобы вводимое число было больше нуля.
        /// </summary>
        /// <param name="number">Число, для которого требуется вычислить количество цифр.</param>
        /// <returns>Количество цифр.</returns>
        private static int Digits(long number)
        {
            return(number == 0) ? 1 : (int) Math.Ceiling(Math.Log10(Math.Abs(number) + 0.5));
        }

        /// <summary>
        /// Метод "GetDigit" берёт цифру в числе по её позиции.
        /// </summary>
        /// <param name="number">Число.</param>
        /// <param name="position">Позиция нужной цифры.</param>
        /// <returns>Цифра, стоящая на нужной позиции во входном числе.</returns>
        private static long GetDigit(long number, int position)
        {
            int count = Digits(number) - position;
            for (int i = 0; i < count; i++)
                number = number / 10;
            return number % 10;
        }
    }
}