using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsApp
{
    /// <summary>
    /// Класс "Project", в котором содержится список всех контактов.
    /// </summary>
    public class Project
    {
        public List<Contact> ContactList = new List<Contact>();

        /// <summary>
        /// Метод "GetSortedContactsList" возвращает список контактов, отсортированный по алфавиту
        /// </summary>
        /// <returns>Список контактов, отсортированный по алфавиту</returns>
        public List<Contact> GetSortedContactsList()
        {
            return ContactList?.OrderBy(i => i.Surname).ToList();
        }

        /// <summary>
        /// Метод "GetSortedContactsList" возвращает список контактов, отсортированный по алфавиту
        /// и содержащий входную подстроку.
        /// </summary>
        /// <returns>Список контактов, отсортированный по алфавиту и содержащий входную подстроку</returns>
        public List<Contact> GetSortedContactsList(string search)
        {
            return ContactList?.
                Where(i => i.Surname.Contains(search)).
                OrderBy(k => k.Surname).
                ToList();
        }

        public List<Contact> GetContactsByBirthday(DateTime date)
        {
            return ContactList?.Where(i =>
                i.Birthday.Day == date.Day &&
                i.Birthday.Month == date.Month).OrderBy(k => k.Surname).ToList();
        }
    }
}