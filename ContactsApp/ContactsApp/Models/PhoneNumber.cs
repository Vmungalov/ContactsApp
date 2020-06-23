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
        public PhoneType Type { get; set; } = PhoneType.Private;

        /// <summary>
        /// Число, содержащее в себе номер телефона.
        /// На данные момент имеются ограничения.
        /// Номер телефона должен иметь 11 цифр и начинаться с 7.
        /// </summary>
        /// <exception cref="ArgumentException">Исключение, бросаемое при числа, не подходящего под ограничения</exception>
        public long Number { get; set; }

        public bool SetNumber(string num)
        {
            long value = Converters.PhoneNumberConverter.ConvertPhoneToLong(num);
            // Проверка на количество цифр
            if (Digits(value) < 11)
                throw new ArgumentException("Недостаточно цифр в номере телефона");
            // Проверка на код страны +7
            if (GetDigit(value,1) != 7)
                throw new ArgumentException("Код страны должен начинаться с 7");
            Number = value;
            return true;
        }

        /// <summary>
        /// Метод "NumberIsValid" проверяет введённый номер на корректность.
        /// Более мягкий вариант проверки: значение не присваивается, а исключения не выбрасываются.
        /// </summary>
        /// <param name="num">Строковое представление номера телефона</param>
        /// <returns>"Истина", если номер корректен, иначе "ложь".</returns>
        public bool NumberIsValid(string num)
        {
            long value = Converters.PhoneNumberConverter.ConvertPhoneToLong(num);
            if (Digits(value) < 11 || GetDigit(value, 1) != 7)
                return false;
            return true;
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