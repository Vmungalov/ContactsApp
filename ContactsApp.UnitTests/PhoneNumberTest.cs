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
            long expected = 71234567890;
            _number.Number = expected;
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
        [TestCase("91234567890",
            "Должно возникнуть исключение при присвоении номера с неправильным кодом страны",
            TestName = "Присвоение номера с неправильным кодом страны")]
        [TestCase("111111111111111",
            "Должно возникнуть исключение при присвоении слишком длинного номера",
            TestName = "Присвоение слишком длинного номера")]
        public void TestNumberSet_IncorrectNumber(string wrong, string message)
        {
            long wrongNumber = long.Parse(wrong);
            Assert.Throws<ArgumentException>(() => { _number.Number = wrongNumber; });
        }
    }
}