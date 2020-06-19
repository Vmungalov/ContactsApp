using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ContactsApp;
using ContactsApp.Converters;

namespace ContactsAppUI
{
    public partial class EditForm : Form
    {
        private bool okAllowed = false;
        
        public Contact ContactInfo { get; private set; }
        public int Index { get; private set; }
        
        public EditForm(Contact contact = null, int index = -1)
        {
            ContactInfo = contact ?? new Contact();
            Index = index;
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

        private async Task<bool> ValidateText(TextBoxBase element)
        {
            if (element.Text.Length > ContactInfo.MaxLength)
            {
                surnameTextBox.ForeColor = Color.Red;
                return false;
            }
            else
            {
                surnameTextBox.ForeColor = Color.Black;
                await BackupContact();
                return true;
            }
        }

        private void SetTextBoxValidated(TextBoxBase textBox)
        {
            textBox.ForeColor = Color.Black;
        }
        
        private async Task BackupContact()
        {
            ContactBackup backup = new ContactBackup()
            {
                Contact = ContactInfo,
                Index = Index
            };
            await ProjectManager.BackupContactAsync(backup);
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

        // Поле для ввода телефона
        
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
        
        // Прочие поля для ввода
        
        private void surnameTextBox_Validated(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                string value = (sender as TextBox)?.Text;
                ContactInfo.Surname = value;
                bool validated = await ValidateText(sender as TextBox);
            });
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTextBoxValidated(sender as TextBox);
        }
        
        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                string value = (sender as TextBox)?.Text;
                ContactInfo.FirstName = value;
                bool validated = await ValidateText(sender as TextBox);
            });
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTextBoxValidated(sender as TextBox);
        }
        
        private void emailTextBox_Validated(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                string value = (sender as TextBox)?.Text;
                ContactInfo.Email = value;
                bool validated = await ValidateText(sender as TextBox);
            });
        }
        
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTextBoxValidated(sender as TextBox);
        }
        
        private void vkTextBox_Validated(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                string value = (sender as TextBox)?.Text;
                ContactInfo.IdVk = value;
                bool validated = await ValidateText(sender as TextBox);
            });
        }

        private void vkTextBox_TextChanged(object sender, EventArgs e)
        {
            SetTextBoxValidated(sender as TextBox);
        }
        
        #endregion
    }
}