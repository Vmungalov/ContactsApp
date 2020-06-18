using System;
using System.Windows.Forms;
using ContactsApp;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        public Contact ContactInfo { get; private set; }
        
        public EditForm(Contact contact = null)
        {
            ContactInfo = contact ?? new Contact();
            InitializeComponent();
        }

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

        private void phoneMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            string val = ((MaskedTextBox) sender).Text;
        }
    }
}