using System;

namespace ContactsApp
{
   
    /// <summary>
    /// Класс "PhoneNumber", в котором содержатся данные о номере телефона контакта.
    /// </summary>
    public class PhoneNumber
    {
        private long _number = 70000000000;

        /// <summary>
        /// Число, содержащее в себе номер телефона.
        /// На данные момент имеются ограничения.
        /// Номер телефона должен иметь 11 цифр и начинаться с 7.
        /// </summary>
        /// <exception cref="ArgumentException">Исключение, бросаемое при числа, не подходящего под ограничения</exception>
        public long Number
        {
            get => _number;
            set
            {
                if (Digits(value) < 11)
                    throw new ArgumentException("Недостаточно цифр в номере телефона");
                // Проверка на код страны +7
                if (GetDigit(value,1) != 7)
                    throw new ArgumentException("Код страны должен начинаться с 7");
                _number = value;
            }
        }

        /// <summary>
        /// Метод "NumberIsValid" проверяет введённый номер на корректность.
        /// Более мягкий вариант проверки: значение не присваивается, а исключения не выбрасываются.
        /// </summary>
        /// <param name="num">Строковое представление номера телефона</param>
        /// <returns>"Истина", если номер корректен, иначе "ложь".</returns>
        public bool NumberIsValid(long num)
        {
            if (Digits(num) < 11 || GetDigit(num, 1) != 7)
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

        public bool Equals(PhoneNumber obj)
        {
            if (obj == null)
                return false;
            return Number == obj.Number;
        }
    }
}