using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ContactsApp;
using ContactsAppUI.Converters;

namespace ContactsAppUI
{
    public partial class ContactForm : Form
    {
        private List<Control> _controls;
        
        public Contact ContactInfo { get; set; } = new Contact();

        public ContactForm()
        {
            InitializeComponent();
            AddControls();
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
        /// Метод "AddControls" добавляет элементы управления в соответствующий список.
        /// Это необходимо для обработки ошибок через ErrorProvider.
        /// </summary>
        private void AddControls()
        {
            _controls = new List<Control>();
            _controls.Add(surnameTextBox);
            _controls.Add(nameTextBox);
            _controls.Add(emailTextBox);
            _controls.Add(birthdayDatePicker);
            _controls.Add(vkTextBox);
            _controls.Add(phoneMaskedTextBox);
        }

        /// <summary>
        /// Метод "ShowError" показывает ошибку при заполнении форм
        /// </summary>
        /// <param name="control">Элемент управления</param>
        /// <param name="message">Сообщение об ошибке</param>
        private void AddError(Control control, string message)
        {
            errorProvider.SetError(control, message);
            buttonOk.Enabled = false;
        }

        /// <summary>
        /// Метод "PopError" убирает конкретную ошибку из списка ошибок
        /// </summary>
        private void PopError(Control control)
        {
            errorProvider.SetError(control, "");
        }

        /// <summary>
        /// Метод "CheckRequiredFields" проверяет заполненность обязательных полей и выводит ошибку, если они
        /// не заполнены.
        /// </summary>
        private void CheckRequiredFields()
        {
            if (RequiredFieldsAreEmpty())
                buttonOk.Enabled = false;
            else
                buttonOk.Enabled = true;
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
                    !ContactInfo.Number.
                        NumberIsValid(PhoneNumberConverter.ConvertPhoneToLong(phoneMaskedTextBox.Text)) ||
                    string.IsNullOrEmpty(vkTextBox.Text));
        }

        /// <summary>
        /// Метод "FieldsContainsErrors" проверяет наличие ошибок в полях
        /// </summary>
        /// <returns></returns>
        private bool FieldsContainsErrors()
        {
            return _controls.Any(i => !string.IsNullOrEmpty(errorProvider.GetError(i)));
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

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            var element = (TextBoxBase) sender;
            bool validated = false;
            try
            {
                string value = element.Text;
                ContactInfo.Surname = value;
                validated = true;
            }
            catch (ArgumentException ex)
            {
                element.ForeColor = Color.Red;
                AddError(surnameTextBox, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(element);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
            CheckRequiredFields();
        }
        
        // Поле для ввода имени

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            var element = (TextBoxBase) sender;
            bool validated = false;
            try
            {
                string value = element.Text;
                ContactInfo.FirstName = value;
                validated = true;
            }
            catch (ArgumentException ex)
            {
                element.ForeColor = Color.Red;
                AddError(element, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(element);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
            CheckRequiredFields();
        }
        
        // Поле для ввода E-Mail

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            var element = (TextBoxBase) sender;
            bool validated = false;
            try
            {
                string value = element.Text;
                ContactInfo.Email = value;
                validated = true;
            }
            catch (ArgumentException ex)
            {
                element.ForeColor = Color.Red;
                AddError(element, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(element);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
            CheckRequiredFields();
        }
        
        // Поле для ввода ID VK

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            var element = (TextBoxBase) sender;
            bool validated = false;
            try
            {
                string value = element.Text;
                ContactInfo.IdVk = value;
                validated = true;
            }
            catch (ArgumentException ex)
            {
                element.ForeColor = Color.Red;
                AddError(element, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(element);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
            CheckRequiredFields();
        }
        
        // Поле для ввода телефона
        
        private void phoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            var element = (TextBoxBase) sender;
            bool validated = false;
            try
            {
                string value = element.Text;
                ContactInfo.Number.Number = PhoneNumberConverter.ConvertPhoneToLong(value);
                validated = true;
            }
            catch (ArgumentException ex)
            {
                element.ForeColor = Color.Red;
                AddError(element, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(element);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
            CheckRequiredFields();
        }

        // Выбор даты
        
        private void birthdayDatePicker_ValueChanged(object sender, EventArgs e)
        {
            bool validated = false;
            var element = (DateTimePicker) sender;
            try
            {
                DateTime value = element.Value;
                ContactInfo.Birthday = value;
                validated = true;
            }
            catch (ArgumentException ex)
            {
                // Не работает с Windows 7 и новее
                element.ForeColor = Color.Red;
                AddError(element, ex.Message);
            }
            if (validated)
            {
                // Ошибки нет
                PopError(element);
                // Вернуть изначальный цвет текста
                element.ResetForeColor();
            }
        }

        #endregion
    }
}