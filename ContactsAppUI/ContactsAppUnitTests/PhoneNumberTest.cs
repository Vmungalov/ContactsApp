using System;
using ContactsApp;
using NUnit.Framework;

namespace ContactsAppUnitTests
{
    public class PhoneNumberTest
    {
        private PhoneNumber _number;

        [SetUp]
        public void InitPhoneNumber()
        {
            _number = new PhoneNumber();
        }

        /// <summary>
        /// Позитивный тест геттера Number
        /// </summary>
        [Test(Description = "Позитивный тест геттера Number")]
        public void TestNumberGet_CorrectValue()
        {
            string input = "+7 (123) 456-7890";
            long expected = 71234567890;
            _number.SetNumber(input);
            var actual = _number.Number;
            Assert.AreEqual(expected,actual,"Геттер Number вернул неправильный номер");
        }

        /// <summary>
        /// Негативный тест SetNumber
        /// </summary>
        /// <param name="wrong">Неправильный номер телефона</param>
        /// <param name="message"></param>
        [TestCase("0",
            "Должно возникнуть исключение при присвоении номера из одной цифры",
            TestName = "Присвоение слишком короткого номера")]
        [TestCase("+91234567890",
            "Должно возникнуть исключение при присвоении номера с неправильным кодом страны",
            TestName = "Присвоение номера с неправильным кодом страны")]
        [TestCase("+111111111111111",
            "Должно возникнуть исключение при присвоении слишком длинного номера",
            TestName = "Присвоение слишком длинного номера")]
        public void TestNumberSet_IncorrectNumber(string wrong, string message)
        {
            Assert.Throws<ArgumentException>(() => { _number.SetNumber(wrong); });
        }
    }
}