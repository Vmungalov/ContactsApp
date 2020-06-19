using System;
using System.Drawing;
using System.Windows.Forms;
using ContactsApp;
using ContactsApp.Converters;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        private bool okAllowed = false;
        
        public Contact ContactInfo { get; private set; }
        
        public EditForm(Contact contact = null)
        {
            ContactInfo = contact ?? new Contact();
            InitializeComponent();
            SetBoxes();
        }

        private void SetBoxes()
        {
            surnameTextBox.Text = ContactInfo.Surname;
            nameTextBox.Text = ContactInfo.FirstName;
            birthdayDatePicker.Value = ContactInfo.Birthday;
            phoneMaskedTextBox.Text = ContactInfo.Number.NumberString;
            emailTextBox.Text = ContactInfo.Email;
            vkTextBox.Text = ContactInfo.IdVk;
        }
        
        #region Events
        
        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactInfo.Surname = (sender as TextBox)?.Text;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactInfo.FirstName = (sender as TextBox)?.Text;
        }

        private void birthdayDatePicker_ValueChanged(object sender, EventArgs e)
        {
            var val = (sender as DateTimePicker)?.Value;
            ContactInfo.Birthday = val ?? DateTime.Today;
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactInfo.Email = (sender as TextBox)?.Text;
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactInfo.IdVk = (sender as TextBox)?.Text;
        }

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

        private void phoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            phoneMaskedTextBox.ForeColor = Color.Black;
        }

        private void phoneMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            phoneMaskedTextBox.ForeColor = Color.Red;
            okAllowed = false;
        }

        private void phoneMaskedTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                if (ContactInfo.Number == null)
                    ContactInfo.Number = new PhoneNumber();
                string text = ((MaskedTextBox) sender).Text;
                ContactInfo.Number.NumberString = text;
            }
            catch (ArgumentException ex)
            {
                phoneMaskedTextBox.ForeColor = Color.Red;
                okAllowed = false;
            }
        }
        
        #endregion
    }
}