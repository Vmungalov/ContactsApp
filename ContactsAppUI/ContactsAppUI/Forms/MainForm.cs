using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    // TODO: нет билд-ивентов или бат-файла в репозитории для запуска автоматической сборки установщика
    // TODO: добавить иконку программе
    public partial class MainForm : Form
    {
        private BindingList<Contact> _shownContacts;
        private int _selectedContactIndex;
        private string _substring = "";

        private BindingList<Contact> ShownContacts
        {
            get => _shownContacts;
            set => _shownContacts = value;
        }
        
        private int SelectedContactIndex
        {
            get => _selectedContactIndex;
            set
            {
                _selectedContactIndex = value;
                if (value < 0)
                    SwitchState(false);
                else
                    SwitchState(true);
            }
        }
        
        /// <summary>
        /// Переменная для поисковой строки
        /// </summary>
        private string Substring
        {
            get => _substring;
            set
            {
                _substring = value;
                // Обновление отображаемых контактов
                UpdateShownContacts();
            }
        }
        
        private Project Project;
        
        public MainForm(ProjectStatus status)
        {
            InitializeComponent();
            Project = status.Project;
            ShownContacts = new BindingList<Contact>(Project.GetSortedContactsList());
            contactsListBox.DataSource = ShownContacts;
            SetBirthdays();
            UpdateShownContacts();
            Closing += mainForm_Closing;
        }
        
        #region Privates
        
        /// <summary>
        /// Метод "UpdateRightPanelValues" обновляет значения в правой панели
        /// </summary>
        /// <param name="erase">"Истина", если необходимо очистить правую панель ото всех значений.
        /// Иначе "ложь".</param>
        private void UpdateRightPanelValues(bool erase = false)
        {
            surnameTextBox.Text = erase ? "" : ShownContacts[_selectedContactIndex].Surname;
            nameTextBox.Text = erase ? "" : ShownContacts[_selectedContactIndex].FirstName;
            birthdayTextBox.Text = erase ? "" : ShownContacts[_selectedContactIndex].Birthday.ToString("D");
            phoneTextBox.Text = erase ? "" : Converters.PhoneNumberConverter.
                ConvertPhoneToString(ShownContacts[_selectedContactIndex].Number.Number);
            emailTextBox.Text = erase ? "" : ShownContacts[_selectedContactIndex].Email;
            vkTextBox.Text = erase ? "" : ShownContacts[_selectedContactIndex].IdVk;
        }

        /// <summary>
        /// Метод "SwitchEdit" переключает состояние кнопок редактирования и удаления контактов
        /// </summary>
        /// <param name="enabled">"Истина", если кнопки необходимо включить. Иначе "ложь".</param>
        private void SwitchEdit(bool enabled)
        {
            editContactToolStripMenuItem.Enabled = enabled;
            deleteContactToolStripMenuItem.Enabled = enabled;
            buttonEdit.Enabled = enabled;
            buttonDelete.Enabled = enabled;
        }

        /// <summary>
        /// Переключает состояние формы (возможно редактирование или нет, а также отображаемый контакт).
        /// </summary>
        /// <param name="enabled">"Истина", если нужно обновить правую панель без очистки 
        /// и включить возможность редактирования и удаления контакта. Иначе "ложь".</param>
        private void SwitchState(bool enabled)
        {
            UpdateRightPanelValues(!enabled);
            SwitchEdit(enabled);
        }

        /// <summary>
        /// Метод "UpdateShownContacts" обновляет списко показываемых контактов.
        /// При необходимости блокируются кнопки редактирования и удаления контактов.
        /// </summary>
        private void UpdateShownContacts()
        {
            // Выделение списка контактов, начинающихся со введённой пользователем подстроки
            var selected = Project.GetSortedContactsList(Substring).ToList();
            // Формирование списка
            ShownContacts = new BindingList<Contact>(selected);
            // Новая привязка
            // Это делается для исключения ошибок с индексами
            contactsListBox.DataSource = ShownContacts;
            if (ShownContacts.Count == 0)
                // Если контактов нет, то в правой панели ничего отображаться не будет, а кнопки
                // редактирования и удаления будут выключены
                SwitchState(false);
            else if (SelectedContactIndex < 0)
                // Аналогично если индекс выбранного контакта меньше нуля (контакт не выбран)
                SwitchState(false);
            else
                // Всё включается
                SwitchState(true);
        }

        /// <summary>
        /// Метод "GetMainIndex" осуществляет получение индекса элемента в основном списке
        /// через список показываемых элементов
        /// </summary>
        /// <param name="shownIndex">Индекс элемента в показываемом списке</param>
        /// <returns>Индекс элемента в основном списке</returns>
        private int GetMainIndex(int shownIndex)
        {
            return Project.ContactList.IndexOf(ShownContacts[shownIndex]);
        }
        
        /// <summary>
        /// Метод "EditContact" создаёт окно редактирования контакта и позволяет создать/отредактировать контакт
        /// </summary>
        /// <param name="contact">Выбранный контакт (null, если создаётся новый)</param>
        /// <returns>Контакт</returns>
        private (Contact, DialogResult) EditContactOnForm(Contact contact = null)
        {
            // Блокирование формы на время присутствия на экране окна редактирования контакта
            Enabled = false;
            ContactForm contactForm = new ContactForm {ContactInfo = contact ?? new Contact()};
            (Contact, DialogResult) result = (contact, DialogResult.Cancel);
            using (contactForm)
            {
                // Показ окна
                contactForm.ShowDialog();
                if (contactForm.DialogResult == DialogResult.OK)
                    result = (contactForm.ContactInfo, DialogResult.OK);
            }
            // Форма вновь активна
            Enabled = true;
            return result;
        }
        
        /// <summary>
        /// Метод "OpenAboutForm" открывает окно "О программе"
        /// </summary>
        private void OpenAboutForm()
        {
            // Блокирование формы на время присутствия на экране окна "О программе"
            Enabled = false;
            AboutForm aboutForm = new AboutForm();
            using (aboutForm)
            {
                // Показ окна
                var result = aboutForm.ShowDialog();
            }
            // Форма вновь активна
            Enabled = true;
        }
        
        /// <summary>
        /// Метод "AddContact" вызывает диалоговое окно EditForm для создания контакта
        /// </summary>
        private void AddContact()
        {
            var result = EditContactOnForm();
            var contact = result.Item1;
            if (result.Item2 == DialogResult.OK)
            {
                Project.ContactList.Add(contact);
                UpdateShownContacts();
            }
        }
        
        /// <summary>
        /// Метод "EditContact" вызывает диалоговое окно EditForm для редакирования выбранного контакта
        /// </summary>
        private void EditContact()
        {
            int shownIndex = SelectedContactIndex;
            var edited = ShownContacts[shownIndex];
            int mainIndex = GetMainIndex(shownIndex);
            var result = EditContactOnForm(edited);
            var contact = result.Item1;
            if (result.Item2 == DialogResult.OK)
            {
                Project.ContactList[mainIndex] = contact;
                UpdateShownContacts();
            }
        }
        
        /// <summary>
        /// Метод "RemoveContact" удаляет выбранный контакт
        /// </summary>
        private void RemoveContact()
        {
            int shownIndex = SelectedContactIndex;
            int mainIndex = GetMainIndex(shownIndex);
            Project.ContactList.RemoveAt(mainIndex);
            if (SelectedContactIndex == ShownContacts.Count)
                SelectedContactIndex--;
            UpdateShownContacts();
        }

        /// <summary>
        /// Метод "SetBirthdays" отображает в правой панели список тех, у кого сегодня день рождения.
        /// </summary>
        private void SetBirthdays()
        {
            // Формирование списка именинников
            List<string> birthdaysSurnames = Project.
                GetContactsByBirthday(DateTime.Today).
                Select(i => i.Surname).
                ToList();
            if (birthdaysSurnames.Count > 0)
            {
                int count = birthdaysSurnames.Count;
                for (int i = 0; i < count - 1; i++)
                    birthsLabel.Text += birthdaysSurnames[i] + ", ";
                birthsLabel.Text += birthdaysSurnames[count - 1] + ".";
                birthsPanel.Visible = true;
            }
        }
        
        /// <summary>
        /// Метод "AskForRemoval" вызывает диалоговое окно с предложением подтвердить удаление выбранного контакта
        /// </summary>
        private void AskForRemoval()
        {
            var contact = ShownContacts[SelectedContactIndex];
            var mBoxResult = MessageBox.Show("Удалить контакт " + contact.FirstName + " " + contact.Surname + "?",
                contact.Surname, MessageBoxButtons.YesNo);
            if (mBoxResult == DialogResult.Yes)
                RemoveContact();
        }
        
        #endregion
        
        #region Events
        
        /// <summary>
        /// Событие нажатия на кнопку "About"
        /// </summary>
        /// <param name="sender">ToolStripMenuItem</param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAboutForm();
        }

        /// <summary>
        /// Событие выбора контакта в списке контактов
        /// </summary>
        /// <param name="sender">ListBox</param>
        /// <param name="e"></param>
        private void contactsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var s = (ListBox)sender;
            // Пользователь может кликнуть по пустой области в ListBox
            // В таком случае SelectedIndex будет равен -1
            SelectedContactIndex = s.SelectedIndex;
        }
        
        /// <summary>
        /// Событие нажатия на кнопку "Добавить контакт"
        /// </summary>
        /// <param name="sender">Кнопка "добавить контакт" в главном меню</param>
        /// <param name="e"></param>
        private void addContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
        }
        
        /// <summary>
        /// Событие нажатия на кнопку "Редактировать контакт"
        /// </summary>
        /// <param name="sender">Кнопка "редактировать контакт" в главном меню</param>
        /// <param name="e"></param>
        private void editContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact();
        }
        
        /// <summary>
        /// Событие нажатия на кнопку "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AskForRemoval();
        }

        /// <summary>
        /// Событие нажатия на кнопку "Добавить контакт" под списком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddContact();
        }

        /// <summary>
        /// Событие нажатия на кнопку "Редактировать контакт" под списком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditContact();
        }

        /// <summary>
        /// Событие нажатия на кнопку "Удалить контакт"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            AskForRemoval();
        }
        
        /// <summary>
        /// Событие ввода текста в поисковую строку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            var substr = ((TextBox)sender).Text;
            Substring = substr;
        }

        /// <summary>
        /// Событие закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainForm_Closing(object sender, EventArgs e)
        {
            // Отписка данного метода от события Closing формы
            // Это необходимо для того, чтобы событие OnClosing не случилось дважды.
            Closing -= mainForm_Closing;
            // Метод CloseApplication сохранит контакты и закроет приложение.
            UiManager.Current.CloseApplication(Project);
        }

        /// <summary>
        /// Событие нажатия на кнопку "Выход" в меню "Файл"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm_Closing(sender,e);
        }
        
        /// <summary>
        /// Событие отпускания клавиши "Delete", когда список контактов в фокесу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contactsListBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                AskForRemoval();
            }
        }
        #endregion
    }
}

// TODO: и не забудь добавить gitignore в проект, заодно поудалять из репозитория весь шлак obj и bin папок. gitignore надо создавать СРАЗУ вместе с репозиторием