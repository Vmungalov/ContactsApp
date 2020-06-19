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
        private BindingList<Contact> ContactsList;
        private Project ContactsData;
        private int SelectedContactIndex = 0;
        
        public MainForm(ProjectStatus status)
        {
            ContactsData = status.Project;
            ContactsList = new BindingList<Contact>(ContactsData.ContactList);
            InitializeComponent();
            contactsListBox.DataSource = ContactsList;
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
            EditForm editForm = new EditForm(contact);
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
                ContactsList.Add(contact);
        }

        /// <summary>
        /// Метод "EditContact" вызывает диалоговое окно EditForm для редакирования выбранного контакта
        /// </summary>
        private void EditContact()
        {
            var result = EditContactOnForm(ContactsList[SelectedContactIndex]);
            var contact = result.Value;
            if (result.Result == DialogResult.OK)
                ContactsList[SelectedContactIndex] = contact;
        }

        /// <summary>
        /// Метод "RemoveContact" удаляет выбранный контакт
        /// </summary>
        private void RemoveContact()
        {
            ContactsList.RemoveAt(SelectedContactIndex);
        }

        /// <summary>
        /// Метод "UpdateRightPanelValues" обновляет значения в правой панели
        /// </summary>
        private void UpdateRightPanelValues()
        {
            surnameTextBox.Text = ContactsList[SelectedContactIndex].Surname;
            nameTextBox.Text = ContactsList[SelectedContactIndex].FirstName;
            birthdayDatePicker.Value = ContactsList[SelectedContactIndex].Birthday;
            phoneTextBox.Text = ContactsList[SelectedContactIndex].Number?.NumberString;
            emailTextBox.Text = ContactsList[SelectedContactIndex].Email;
            vkTextBox.Text = ContactsList[SelectedContactIndex].IdVk;
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
            ContactsData.ContactList = ContactsList.ToList();
            UiManager.CloseApplication(ContactsData);
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
            SelectedContactIndex = index >= 0 ? index : SelectedContactIndex;
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