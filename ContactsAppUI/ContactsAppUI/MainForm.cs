using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsAppUI.Properties;

namespace ContactsAppUI
{
    public partial class MainForm : Form
    {
        private List<Contact> _contacts = new List<Contact>();
        public MainForm()
        {
            InitializeComponent();
           // PhoneNumber Test = new PhoneNumber();
           // Contact contact = new Contact();
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddContact()
        {
            //var addContaсtForm = new ContactForm();
            addContaсtForm.ShowDialog();
            var newContact = addContaсtForm.Contact;
        }

        private void AddContactButton_Click(object sender, EventArgs e)
        {

        }
    }
}