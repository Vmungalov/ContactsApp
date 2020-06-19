using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ContactsApp;
using ContactsAppUI.Models;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private BindingList<Contact> _contactsList;
        private int _selectedContactIndex = 0;
        
        private BindingList<Contact> ContactsList
        {
            get => _contactsList;
            set
            {
                _contactsList = value;
                ContactsData.ContactList = value.ToList();
            }
        }
        public Project ContactsData;

        public MainForm(ProjectStatus status)
        {
            ContactsData = status.Project;
            _contactsList = new BindingList<Contact>(ContactsData.ContactList);
            InitializeComponent();
            contactsListBox.DataSource = _contactsList;
        }

        #region Privates
        
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
        /// Метод "EditContact" создаёт окно редактирования контакта и позволяет создать/отредактировать контакт
        /// </summary>
        /// <param name="contact">Выбранный контакт (null, если создаётся новый)</param>
        /// <returns>Контакт</returns>
        private DialogReturn<Contact> EditContactOnForm(Contact contact = null)
        {
            // Блокирование формы на время присутствия на экране окна редактирования контакта
            Enabled = false;
            EditForm editForm = new EditForm(contact,_selectedContactIndex);
            DialogReturn<Contact> result = new DialogReturn<Contact>()
            {
                Result = DialogResult.Cancel
            };
            using (editForm)
            {
                // Показ окна
                editForm.ShowDialog();
                if (editForm.DialogResult == DialogResult.OK)
                {
                    result.Result = DialogResult.OK;
                    result.Value = editForm.ContactInfo;
                }
            }
            // Форма вновь активна
            Enabled = true;
            return result;
        }

        /// <summary>
        /// Метод "AddContact" вызывает диалоговое окно EditForm для создания контакта
        /// </summary>
        private void AddContact()
        {
            var result = EditContactOnForm();
            var contact = result.Value;
            if (result.Result == DialogResult.OK)
                _contactsList.Add(contact);
        }

        /// <summary>
        /// Метод "EditContact" вызывает диалоговое окно EditForm для редакирования выбранного контакта
        /// </summary>
        private void EditContact()
        {
            var result = EditContactOnForm(_contactsList[_selectedContactIndex]);
            var contact = result.Value;
            if (result.Result == DialogResult.OK)
                _contactsList[_selectedContactIndex] = contact;
        }

        /// <summary>
        /// Метод "RemoveContact" удаляет выбранный контакт
        /// </summary>
        private void RemoveContact()
        {
            _contactsList.RemoveAt(_selectedContactIndex);
        }

        /// <summary>
        /// Метод "UpdateRightPanelValues" обновляет значения в правой панели
        /// </summary>
        private void UpdateRightPanelValues()
        {
            surnameTextBox.Text = _contactsList[_selectedContactIndex].Surname;
            nameTextBox.Text = _contactsList[_selectedContactIndex].FirstName;
            birthdayDatePicker.Value = _contactsList[_selectedContactIndex].Birthday;
            phoneTextBox.Text = _contactsList[_selectedContactIndex].Number?.NumberString;
            emailTextBox.Text = _contactsList[_selectedContactIndex].Email;
            vkTextBox.Text = _contactsList[_selectedContactIndex].IdVk;
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
        /// Событие нажатия на кнопку выхода
        /// </summary>
        /// <param name="sender">ToolStripMenuItem</param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactsData.ContactList = _contactsList.ToList();
            UiManager.Current.CloseApplication(ContactsData);
        }
        
        /// <summary>
        /// Событие выбора контакта в списке контактов
        /// </summary>
        /// <param name="sender">ListBox</param>
        /// <param name="e"></param>
        private void contactsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var s = (ListBox) sender;
            int index = s.SelectedIndex;
            // Пользователь может кликнуть по пустой области в ListBox
            // В таком случае SelectedIndex будет равен -1
            _selectedContactIndex = index >= 0 ? index : _selectedContactIndex;
            UpdateRightPanelValues();
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
            RemoveContact();
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
            RemoveContact();
        }
        
        #endregion
    }
}