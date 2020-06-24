using System;
using System.Linq;
using ContactsApp;
using NUnit.Framework;

namespace ContactsAppUnitTests
{
    [TestFixture]
    public class ProjectTest
    {
        private Project _project;

        [SetUp]
        public void InitProject()
        {
            _project = new Project();
            _project.ContactList.Add(new Contact()
            {
                Surname = "Denton",
                FirstName = "JC",
                Birthday = new DateTime(2000,1,1),
                Email = "jcd@unatco.gov",
                Number = new PhoneNumber()
                {
                    Number = 71234567890
                },
                IdVk = "justanotherparasite"
            });
            _project.ContactList.Add(new Contact()
            {
                Surname = "Denton",
                FirstName = "Paul",
                Birthday = new DateTime(1980,03,21),
                Email = "pauld@unatco.gov",
                Number = new PhoneNumber()
                {
                    Number = 70001112222
                },
                IdVk = "pauldenton"
            });
            _project.ContactList.Add(new Contact()
            {
                Surname = "Angelo",
                FirstName = "Tommy",
                Birthday = DateTime.Today,
                Email = "mafioznik@aol.com",
                Number = new PhoneNumber()
                {
                    Number = 79871235555
                },
                IdVk = "mobster"
            });
        }

        /// <summary>
        /// Тест сортировки контактов
        /// </summary>
        [Test(Description = "Тест сортировки списка контактов")]
        public void TestGetSortedContacts()
        {
        var expected = _project.ContactList.
          OrderBy(i => i.Surname).ToList();
        var actual = _project.GetSortedContactsList();
        Assert.AreEqual(expected, actual,"Метод GetSortedContactsList возвращает неправильный список контактов");
        }
        
        /// <summary>
        /// Тест поиска контактов
        /// </summary>
        /// <param name="substring"></param>
        /// <param name="message"></param>
        [TestCase("",
            "Должнен вернуться список контактов, начинающийся с пустой строки",
            TestName = "Поиск контактов на 1234")]
        [TestCase("1234",
            "Должнен вернуться список контактов, начинающийся на D",
            TestName = "Поиск контактов на 1234")]
        [TestCase("D",
            "Должнен вернуться список контактов, начинающийся на D",
            TestName = "Поиск контактов на D")]
        public void TestGetSortedContacts(string substring, string message)
        {
            var expected = _project.ContactList.
                Where(i => i.Surname.StartsWith(substring)).
                OrderBy(k => k.Surname).
                ToList();
            var actual = _project.GetSortedContactsList(substring);
            Assert.AreEqual(expected,actual,message);
        }
        
        /// <summary>
        /// Тест поиска именинников
        /// </summary>
        [Test(Description = "Тест поиска контактов")]
        public void TestGetBirthdays()
        {
            var date = DateTime.Today;
            var expected = _project.ContactList.Where(i =>
                i.Birthday.Day == date.Day &&
                i.Birthday.Month == date.Month).OrderBy(k => k.Surname).ToList();
            var actual = _project.GetContactsByBirthday(date);
            Assert.AreEqual(expected,actual,"Метод GetContactsByBirthday возвращает неправильный список именинников");
        }
    }
}