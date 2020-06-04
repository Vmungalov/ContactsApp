namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RemoveContactButton = new System.Windows.Forms.Button();
            this.EditContactButton = new System.Windows.Forms.Button();
            this.AddContactButton = new System.Windows.Forms.Button();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Label();
            this.BirthdayTextBox = new System.Windows.Forms.TextBox();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.Vk = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RemoveContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddContactButton);
            this.splitContainer1.Panel1.Controls.Add(this.ContactsListBox);
            this.splitContainer1.Panel1.Controls.Add(this.FindTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.Find);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BirthdayTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.VkTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.EmailTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.PhoneTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.NameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.SurnameTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.Vk);
            this.splitContainer1.Panel2.Controls.Add(this.Email);
            this.splitContainer1.Panel2.Controls.Add(this.Phone);
            this.splitContainer1.Panel2.Controls.Add(this.Birthday);
            this.splitContainer1.Panel2.Controls.Add(this.Name);
            this.splitContainer1.Panel2.Controls.Add(this.Surname);
            this.splitContainer1.Size = new System.Drawing.Size(684, 437);
            this.splitContainer1.SplitterDistance = 227;
            this.splitContainer1.TabIndex = 1;
            // 
            // RemoveContactButton
            // 
            this.RemoveContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveContactButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.RemoveContact;
            this.RemoveContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveContactButton.FlatAppearance.BorderSize = 0;
            this.RemoveContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveContactButton.Location = new System.Drawing.Point(54, 406);
            this.RemoveContactButton.Name = "RemoveContactButton";
            this.RemoveContactButton.Size = new System.Drawing.Size(15, 15);
            this.RemoveContactButton.TabIndex = 5;
            this.RemoveContactButton.UseVisualStyleBackColor = true;
            // 
            // EditContactButton
            // 
            this.EditContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditContactButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.EditContact;
            this.EditContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditContactButton.FlatAppearance.BorderSize = 0;
            this.EditContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditContactButton.Location = new System.Drawing.Point(33, 406);
            this.EditContactButton.Name = "EditContactButton";
            this.EditContactButton.Size = new System.Drawing.Size(15, 15);
            this.EditContactButton.TabIndex = 4;
            this.EditContactButton.UseVisualStyleBackColor = true;
            // 
            // AddContactButton
            // 
            this.AddContactButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddContactButton.BackgroundImage = global::ContactsAppUI.Properties.Resources.AddContact;
            this.AddContactButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddContactButton.FlatAppearance.BorderSize = 0;
            this.AddContactButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddContactButton.Location = new System.Drawing.Point(12, 406);
            this.AddContactButton.Name = "AddContactButton";
            this.AddContactButton.Size = new System.Drawing.Size(15, 15);
            this.AddContactButton.TabIndex = 3;
            this.AddContactButton.UseVisualStyleBackColor = true;
            this.AddContactButton.Click += new System.EventHandler(this.AddContactButton_Click);
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.Location = new System.Drawing.Point(6, 28);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.ScrollAlwaysVisible = true;
            this.ContactsListBox.Size = new System.Drawing.Size(218, 355);
            this.ContactsListBox.TabIndex = 2;
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(39, 3);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(185, 20);
            this.FindTextBox.TabIndex = 1;
            // 
            // Find
            // 
            this.Find.AutoSize = true;
            this.Find.Location = new System.Drawing.Point(3, 6);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(30, 13);
            this.Find.TabIndex = 0;
            this.Find.Text = "Find:";
            // 
            // BirthdayTextBox
            // 
            this.BirthdayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayTextBox.Location = new System.Drawing.Point(75, 53);
            this.BirthdayTextBox.Name = "BirthdayTextBox";
            this.BirthdayTextBox.Size = new System.Drawing.Size(375, 20);
            this.BirthdayTextBox.TabIndex = 25;
            // 
            // VkTextBox
            // 
            this.VkTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VkTextBox.Location = new System.Drawing.Point(75, 128);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(375, 20);
            this.VkTextBox.TabIndex = 24;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(75, 103);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(375, 20);
            this.EmailTextBox.TabIndex = 23;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(75, 78);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(375, 20);
            this.PhoneTextBox.TabIndex = 22;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(75, 28);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(375, 20);
            this.NameTextBox.TabIndex = 21;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(75, 3);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(375, 20);
            this.SurnameTextBox.TabIndex = 20;
            // 
            // Vk
            // 
            this.Vk.AutoSize = true;
            this.Vk.Location = new System.Drawing.Point(24, 131);
            this.Vk.Name = "Vk";
            this.Vk.Size = new System.Drawing.Size(45, 13);
            this.Vk.TabIndex = 19;
            this.Vk.Text = "vk.com:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(31, 106);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 13);
            this.Email.TabIndex = 18;
            this.Email.Text = "E-mail:";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(28, 81);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 17;
            this.Phone.Text = "Phone:";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(21, 56);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(48, 13);
            this.Birthday.TabIndex = 16;
            this.Birthday.Text = "Birthday:";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(31, 31);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(38, 13);
            this.Name.TabIndex = 15;
            this.Name.Text = "Name:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(17, 6);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(52, 13);
            this.Surname.TabIndex = 14;
            this.Surname.Text = "Surname:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addContactToolStripMenuItem,
            this.editContactToolStripMenuItem,
            this.removeContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editContactToolStripMenuItem.Text = "Edit Contact";
            // 
            // removeContactToolStripMenuItem
            // 
            this.removeContactToolStripMenuItem.Name = "removeContactToolStripMenuItem";
            this.removeContactToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.removeContactToolStripMenuItem.Text = "Remove Contact";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox BirthdayTextBox;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label Vk;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label Find;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button RemoveContactButton;
        private System.Windows.Forms.Button EditContactButton;
        private System.Windows.Forms.Button AddContactButton;
    }
}