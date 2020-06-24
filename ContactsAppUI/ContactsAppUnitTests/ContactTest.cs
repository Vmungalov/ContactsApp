using System;
using ContactsApp;
using NUnit.Framework;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;

        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }
        
        #region Тесты фамилии
        
        /// <summary>
        /// Позитивный тест геттера Surname
        /// </summary>
        [Test(Description = "Позитивный тест геттера Surname")]
        public void TestSurnameGet_CorrectValue()
        {
            var expected = "Смирнов";
            _contact.SetSurname(expected);
            var actual = _contact.Surname;
            
            Assert.AreEqual(expected, actual, "Геттер Surname возвращает неправильную фамилию.");
        }

        /// <summary>
        /// Негативный тест метода SetSurname
        /// </summary>
        [Test(Description = "Присвоение неправильной фамилии (больше 50 символов)")]
        public void TestSurnameSet_LongerThan50Symbols()
        {
            // 51 символ
            var wrongSurname = "йцукенгшщзхъфывапролджэячсмитьбюыыыыыыыыыыыыыыыыыыы";
            _contact = new Contact();
            Assert.Throws<ArgumentException>(() => { _contact.SetSurname(wrongSurname); }, 
                "Фамилия длиннее 50 символов должна вызвать ArgumentException.");
        }
        
        #endregion
        
        #region Тесты имени
        
        /// <summary>
        /// Позитивный тест геттера FirstName
        /// </summary>
        [Test(Description = "Позитивный тест геттера FirstName")]
        public void TestFirstNameGet_CorrectValue()
        {
            var expected = "Алексей";
            _contact.SetFirstName(expected);
            var actual = _contact.FirstName;
            
            Assert.AreEqual(expected, actual, "Геттер FirstName возвращает неправильную фамилию.");
        }

        /// <summary>
        /// Негативный тест метода SetFirstName
        /// </summary>
        [Test(Description = "Присвоение неправильного имени (больше 50 символов)")]
        public void TestFirstNameSet_LongerThan50Symbols()
        {
            // 51 символ
            var wrongName = @"¯\_(ツ)_/¯ Brfxxccxxmnpcccclllmmnprxvclmnckssqlbb11116";
            _contact = new Contact();
            Assert.Throws<ArgumentException>(() => { _contact.SetFirstName(wrongName); }, 
                "Фамилия длиннее 50 символов должна вызвать ArgumentException.");
        }
        
        #endregion
        
        #region Тесты E-Mail
        
        /// <summary>
        /// Позитивный тест геттера Email
        /// </summary>
        [Test(Description = "Позитивный тест геттера E-Mail")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "v_mungalov@mail.ru";
            _contact.SetEmail(expected);
            var actual = _contact.Email;
            
            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную фамилию.");
        }

        /// <summary>
        /// Негативный тест метода SetEmail
        /// </summary>
        [Test(Description = "Присвоение неправильного E-Mail (больше 50 символов)")]
        public void TestEmailSet_LongerThan50Symbols()
        {
            // 51 символ
            var wrongEmail = @"¯\_(ツ)_/¯ Brfxxccxxmnpcccclllmmnprxvclmnckssqlbb11116";
            _contact = new Contact();
            Assert.Throws<ArgumentException>(() => { _contact.SetEmail(wrongEmail); }, 
                "Фамилия длиннее 50 символов должна вызвать ArgumentException.");
        }
        
        #endregion
        
        #region Тесты VkId
        
        /// <summary>
        /// Позитивный тест геттера Email
        /// </summary>
        [Test(Description = "Позитивный тест геттера VkId")]
        public void TestVkIdGet_CorrectValue()
        {
            var expected = "v_mungalov";
            _contact.SetVkId(expected);
            var actual = _contact.IdVk;
            
            Assert.AreEqual(expected, actual, "Геттер IdVk возвращает неправильную фамилию.");
        }

        /// <summary>
        /// Негативный тест метода SetVkId
        /// </summary>
        [Test(Description = "Присвоение неправильного VkId (больше 50 символов)")]
        public void TestVkIdSet_LongerThan50Symbols()
        {
            // 51 символ
            var wrongVk = "v_mungalov_0000011111222223333344444555556666677777";
            _contact = new Contact();
            Assert.Throws<ArgumentException>(() => { _contact.SetVkId(wrongVk); }, 
                "Фамилия длиннее 50 символов должна вызвать ArgumentException.");
        }
        
        #endregion
        
        #region Тесты даты рождения

        /// <summary>
        /// Позитивный тест геттера Birthday
        /// </summary>
        [Test(Description = "Позитивный тест геттера Birthday")]
        public void TestBirthdayGet_CorrectValue()
        {
            var expected = new DateTime(1999, 04,02);
            _contact.Birthday = expected;
            var actual = _contact.Birthday;

            Assert.AreEqual(expected, actual, "Геттер Birthday возвращает неправильное значение");
        }
        
        /// <summary>
        /// Негативный тест метода SetBirthday
        /// </summary>
        /// <param name="wrong">Строковое представление неправильной даты</param>
        /// <param name="message"></param>
        [TestCase("01/01/0001",
            "Должно возникнуть исключение при присвоении даты ранее 1.1.1900",
            TestName = "Присвоение слишком ранней даты")]
        [TestCase("01/01/3000",
            "Должно возникнуть исключение при присвоении даты позднее сегодняшней",
            TestName = "Присвоение слишком поздней даты")]
        public void TestBirthdaySet_ArgumentException(string wrong, string message)
        {
            var wrongDate = DateTime.Parse(wrong);
            Assert.Throws<ArgumentException>(() => { _contact.SetBirthday(wrongDate); });
        }
        
        #endregion
    }
}