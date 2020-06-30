using System;
using System.Text.RegularExpressions;

namespace ContactsAppUI.Converters
{
    public static class PhoneNumberConverter
    {

        /// <summary>
        /// Метод "ConvertPhoneToLong" конвертирует строковое представление номера телефона,
        /// вводимое пользователем в MaskedTextBox, в число типа long
        /// </summary>
        /// <param name="phone">Строковое представление номера телефона следующего вида: "+7 (123) 456-7890"</param>
        /// <returns>Номер телефона в виде числовой переменной</returns>
        public static long ConvertPhoneToLong(string phone)
        {
            long num;
            try
            {
                Regex reg = new Regex(@"\D");
                string output = reg.Replace(phone, "");
                num = long.Parse(output);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("Entered phone number has invalid format", ex);
            }

            return num;
        }

        public static string ConvertPhoneToString(long phone)
        {
            return phone == 0 ? "+7 (___) ___-____" : phone.ToString("+0 (000) 000-0000");
        }
    }
}