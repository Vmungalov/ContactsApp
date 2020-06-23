using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContactsApp;
using ContactsApp.Converters;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        private Dictionary<int,string> Errors = new Dictionary<int,string>();

        public Contact ContactInfo { get; private set; }
        public int Index { get; private set; }
        
        public EditForm(Contact contact = null, int index = -1)
        {
            ContactInfo = contact ?? new Contact();
            Index = index;
            InitializeComponent();
            SetBoxes();
            CheckRequiredFields();
        }

        /// <summary>
        /// Метод "SetBoxes" устанавливает значения по умолчанию для полей
        /// </summary>
        private void SetBoxes()
        {
            surnameTextBox.Text = ContactInfo.Surname;
            nameTextBox.Text = ContactInfo.FirstName;
            birthdayDatePicker.Value = ContactInfo.Birthday;
            phoneMaskedTextBox.Text = PhoneNumberConverter.ConvertPhoneToString(ContactInfo.Number.Number);
            emailTextBox.Text = ContactInfo.Email;
            vkTextBox.Text = ContactInfo.IdVk;
        }

        /// <summary>
        /// Метод "ValidateTextAndBackup" осуществляет валидацию текстовых полей после утери фокуса.
        /// Если нет ошибок, то контакт бэкапится.
        /// </summary>
        /// <param name="element">Текстовое поле</param>
        /// <param name="predicate">Метод-сеттер</param>
        private void ValidateTextAndBackup(TextBoxBase element, Func<string,bool> predicate, int errorNum)
        {
            bool validated = CheckText(element, predicate, errorNum);
            if (Errors.Count == 0 && validated)
                // Бэкап текущего контакта
                Task.Run(async () => await BackupContact());
        }
        
        /// <summary>
        /// Метод "CheckText" проверяет введённый текст на корректность
        /// </summary>
        private bool CheckText(TextBoxBase element, Func<string,bool> predicate, int errorNum)
        {
            bool validated = false;
            try
            {
                string value = element.Text;
                validated = predicate.Invoke(value);
            }
            catch (ArgumentException ex)
            {
                element.ForeColor = Color.Red;
                AddError(errorNum, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(errorNum);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
            CheckRequiredFields();
            return validated;
        }

        /// <summary>
        /// Метод "ValidateDateAndBackup" осуществляет валидацию текстовых полей после утери фокуса.
        /// Если нет ошибок, то контакт бэкапится.
        /// </summary>
        /// <param name="element">Текстовое поле</param>
        /// <param name="predicate">Метод-сеттер</param>
        private void ValidateDateAndBackup(DateTimePicker element, Func<DateTime,bool> predicate, int errorNum)
        {
            bool validated = CheckDate(element, predicate, errorNum);
            if (Errors.Count == 0 && validated)
                // Бэкап текущего контакта
                Task.Run(async () => await BackupContact());
        }
        
        /// <summary>
        /// Метод "CheckDate" проверяет введённый текст на корректность
        /// </summary>
        private bool CheckDate(DateTimePicker element, Func<DateTime, bool> predicate, int errorNum)
        {
            bool validated = false;
            try
            {
                DateTime value = element.Value;
                validated = predicate.Invoke(value);
            }
            catch (ArgumentException ex)
            {
                // Не работает с Windows 7 и новее
                element.ForeColor = Color.Red;
                AddError(errorNum, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(errorNum);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }

            return validated;
        }

        /// <summary>
        /// Метод "ShowError" показывает ошибку при заполнении форм
        /// </summary>
        /// <param name="message">Сообщение об ошибке</param>
        private void AddError(int errorNumber, string message)
        {
            if (!Errors.ContainsKey(errorNumber))
                Errors.Add(errorNumber, message);
            errorLabel.Text = message;
            errorLabel.Visible = true;
            buttonOk.Enabled = false;
        }

        /// <summary>
        /// Метод "HideError" скрывает сообщение об ошибке
        /// </summary>
        private void PopError(int errNum)
        {
            if (Errors.ContainsKey(errNum))
                Errors.Remove(errNum);
            if (Errors.Count > 0)
            {
                errorLabel.Text = Errors.LastOrDefault().Value;
                buttonOk.Enabled = false;
            }
            else
            {
                errorLabel.Text = "";
                errorLabel.Visible = false;
                buttonOk.Enabled = true;
            }
        }

        /// <summary>
        /// Метод "BackupContact" асинхронно сохраняет резервную копию контакта
        /// </summary>
        /// <returns></returns>
        private async Task BackupContact()
        {
            ContactBackup backup = new ContactBackup()
            {
                Contact = ContactInfo,
                Index = Index
            };
            await ProjectManager.BackupContactAsync(backup);
        }

        /// <summary>
        /// Метод "CheckRequiredFields" проверяет заполненность обязательных полей и выводит ошибку, если они
        /// не заполнены.
        /// </summary>
        private void CheckRequiredFields()
        {
            if (RequiredFieldsAreEmpty())
                AddError(7, "Не все обязательные поля заполнены.");
            else
                PopError(7);
        }

        /// <summary>
        /// Метод "RequiredFieldsAreEmpty" проверяет, пусты или заполнены все необходимые поля
        /// </summary>
        /// <returns>"Истина", если поля фамилии, имени, номера телефона и e-mail заполнены.
        /// Иначе "ложь".</returns>
        private bool RequiredFieldsAreEmpty()
        {
            return (string.IsNullOrEmpty(surnameTextBox.Text) ||
                    string.IsNullOrEmpty(nameTextBox.Text) ||
                    string.IsNullOrEmpty(emailTextBox.Text) ||
                    !ContactInfo.Number.NumberIsValid(phoneMaskedTextBox.Text) ||
                    string.IsNullOrEmpty(vkTextBox.Text));
        }
        
        #region Events
        
        // Кнопки
        
        private void buttonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Прочие поля для ввода
        
        private void surnameTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextAndBackup((TextBox)sender, ContactInfo.SetSurname, 1);
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckText((TextBox)sender, ContactInfo.SetSurname, 1);
        }
        
        // Поле для ввода имени
        
        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextAndBackup((TextBox)sender, ContactInfo.SetFirstName,2);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckText((TextBox)sender, ContactInfo.SetFirstName, 2);
        }
        
        // Поле для ввода E-Mail
        
        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextAndBackup((TextBox)sender, ContactInfo.SetEmail, 3);
        }
        
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckText((TextBox)sender, ContactInfo.SetEmail, 3);
        }
        
        // Поле для ввода ID VK
        
        private void vkTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextAndBackup((TextBox)sender, ContactInfo.SetVkId, 4);
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckText((TextBox)sender, ContactInfo.SetVkId, 4);
        }
        
        // Поле для ввода телефона
        
        private void phoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckText((MaskedTextBox) sender, ContactInfo.Number.SetNumber, 5);
        }

        private void phoneMaskedTextBox_Validated(object sender, EventArgs e)
        {
            ValidateTextAndBackup((MaskedTextBox) sender, ContactInfo.Number.SetNumber, 5);
        }
        
        // Выбор даты
        
        private void birthdayDatePicker_ValueChanged(object sender, EventArgs e)
        {
            CheckDate((DateTimePicker) sender, ContactInfo.SetBirthday, 6);
        }
        
        private void birthdayDatePicker_Validated(object sender, EventArgs e)
        {
            ValidateDateAndBackup((DateTimePicker)sender, ContactInfo.SetBirthday, 6);
        }
        
        #endregion
    }
}