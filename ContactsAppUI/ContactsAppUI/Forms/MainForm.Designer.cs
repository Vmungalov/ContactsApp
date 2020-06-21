using System.ComponentModel;

namespace ContactsAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.findLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.fileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.vkLabel = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.rightTablePanelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.rightTablePanelLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // findLabel
            // 
            this.findLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.findLabel.Location = new System.Drawing.Point(3, 3);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(52, 23);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Поиск:";
            this.findLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(65, 2);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.searchTextBox.MinimumSize = new System.Drawing.Size(163, 23);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(163, 23);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.BackgroundImage = global::ContactsAppUI.Properties.Resources.Trash;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDelete.Location = new System.Drawing.Point(79, 3);
            this.buttonDelete.MaximumSize = new System.Drawing.Size(31, 32);
            this.buttonDelete.MinimumSize = new System.Drawing.Size(31, 32);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(31, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEdit.BackgroundImage = global::ContactsAppUI.Properties.Resources.Pencil;
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.Location = new System.Drawing.Point(41, 3);
            this.buttonEdit.MaximumSize = new System.Drawing.Size(31, 32);
            this.buttonEdit.MinimumSize = new System.Drawing.Size(31, 32);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(31, 32);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.BackgroundImage = global::ContactsAppUI.Properties.Resources.Plus;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.MaximumSize = new System.Drawing.Size(31, 32);
            this.buttonAdd.MinimumSize = new System.Drawing.Size(31, 32);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(31, 32);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // fileMenuStrip
            // 
            this.fileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.exitToolStripMenuItem});
            this.fileMenuStrip.Name = "fileMenuStrip";
            this.fileMenuStrip.Size = new System.Drawing.Size(48, 20);
            this.fileMenuStrip.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editMenuStrip
            // 
            this.editMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.addContactToolStripMenuItem, this.editContactToolStripMenuItem, this.deleteContactToolStripMenuItem
            });
            this.editMenuStrip.Name = "editMenuStrip";
            this.editMenuStrip.Size = new System.Drawing.Size(108, 20);
            this.editMenuStrip.Text = "Редактирование";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.addContactToolStripMenuItem.Text = "Добавить контакт";
            this.addContactToolStripMenuItem.Click += new System.EventHandler(this.addContactToolStripMenuItem_Click);
            // 
            // editContactToolStripMenuItem
            // 
            this.editContactToolStripMenuItem.Name = "editContactToolStripMenuItem";
            this.editContactToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.editContactToolStripMenuItem.Text = "Редактировать контакт";
            this.editContactToolStripMenuItem.Click += new System.EventHandler(this.editContactToolStripMenuItem_Click);
            // 
            // deleteContactToolStripMenuItem
            // 
            this.deleteContactToolStripMenuItem.Name = "deleteContactToolStripMenuItem";
            this.deleteContactToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deleteContactToolStripMenuItem.Text = "Удалить контакт";
            this.deleteContactToolStripMenuItem.Click +=
                new System.EventHandler(this.deleteContactToolStripMenuItem_Click);
            // 
            // helpMenuStrip
            // 
            this.helpMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.aboutToolStripMenuItem});
            this.helpMenuStrip.Name = "helpMenuStrip";
            this.helpMenuStrip.Size = new System.Drawing.Size(68, 20);
            this.helpMenuStrip.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.fileMenuStrip, this.editMenuStrip, this.helpMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(653, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // surnameLabel
            // 
            this.surnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.surnameLabel.Location = new System.Drawing.Point(3, 3);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(104, 23);
            this.surnameLabel.TabIndex = 0;
            this.surnameLabel.Text = "Фамилия:";
            this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.Location = new System.Drawing.Point(114, 3);
            this.surnameTextBox.MaxLength = 50;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.ReadOnly = true;
            this.surnameTextBox.Size = new System.Drawing.Size(276, 23);
            this.surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(114, 32);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(276, 23);
            this.nameTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameLabel.Location = new System.Drawing.Point(3, 32);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(104, 23);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "Имя:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayDatePicker.Enabled = false;
            this.birthdayDatePicker.Location = new System.Drawing.Point(114, 61);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(276, 23);
            this.birthdayDatePicker.TabIndex = 5;
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.birthdayLabel.Location = new System.Drawing.Point(3, 61);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(104, 23);
            this.birthdayLabel.TabIndex = 6;
            this.birthdayLabel.Text = "Дата рождения:";
            this.birthdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.phoneTextBox.Location = new System.Drawing.Point(114, 90);
            this.phoneTextBox.MaxLength = 50;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(276, 23);
            this.phoneTextBox.TabIndex = 7;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.phoneLabel.Location = new System.Drawing.Point(3, 90);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(104, 23);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Телефон:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(114, 119);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(276, 23);
            this.emailTextBox.TabIndex = 9;
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailLabel.Location = new System.Drawing.Point(3, 119);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(104, 23);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "E-mail:";
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vkTextBox
            // 
            this.vkTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.vkTextBox.Location = new System.Drawing.Point(114, 148);
            this.vkTextBox.MaxLength = 50;
            this.vkTextBox.Name = "vkTextBox";
            this.vkTextBox.ReadOnly = true;
            this.vkTextBox.Size = new System.Drawing.Size(276, 23);
            this.vkTextBox.TabIndex = 11;
            // 
            // vkLabel
            // 
            this.vkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vkLabel.Location = new System.Drawing.Point(3, 148);
            this.vkLabel.Name = "vkLabel";
            this.vkLabel.Size = new System.Drawing.Size(104, 23);
            this.vkLabel.TabIndex = 12;
            this.vkLabel.Text = "VK:";
            this.vkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelRight
            // 
            this.panelRight.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Location = new System.Drawing.Point(248, 32);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(393, 511);
            this.panelRight.TabIndex = 2;
            // 
            // rightTablePanelLayout
            // 
            this.rightTablePanelLayout.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.rightTablePanelLayout.ColumnCount = 2;
            this.rightTablePanelLayout.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.rightTablePanelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rightTablePanelLayout.Controls.Add(this.surnameTextBox, 1, 0);
            this.rightTablePanelLayout.Controls.Add(this.vkTextBox, 1, 5);
            this.rightTablePanelLayout.Controls.Add(this.vkLabel, 0, 5);
            this.rightTablePanelLayout.Controls.Add(this.surnameLabel, 0, 0);
            this.rightTablePanelLayout.Controls.Add(this.nameLabel, 0, 1);
            this.rightTablePanelLayout.Controls.Add(this.emailTextBox, 1, 4);
            this.rightTablePanelLayout.Controls.Add(this.emailLabel, 0, 4);
            this.rightTablePanelLayout.Controls.Add(this.nameTextBox, 1, 1);
            this.rightTablePanelLayout.Controls.Add(this.birthdayLabel, 0, 2);
            this.rightTablePanelLayout.Controls.Add(this.phoneTextBox, 1, 3);
            this.rightTablePanelLayout.Controls.Add(this.phoneLabel, 0, 3);
            this.rightTablePanelLayout.Controls.Add(this.birthdayDatePicker, 1, 2);
            this.rightTablePanelLayout.Location = new System.Drawing.Point(248, 32);
            this.rightTablePanelLayout.MinimumSize = new System.Drawing.Size(393, 174);
            this.rightTablePanelLayout.Name = "rightTablePanelLayout";
            this.rightTablePanelLayout.RowCount = 6;
            this.rightTablePanelLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.rightTablePanelLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.rightTablePanelLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.rightTablePanelLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.rightTablePanelLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.rightTablePanelLayout.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.rightTablePanelLayout.Size = new System.Drawing.Size(393, 174);
            this.rightTablePanelLayout.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Bottom) |
                                                       System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.3913F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.6087F));
            this.tableLayoutPanel1.Controls.Add(this.findLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.contactsListBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 511);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // contactsListBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.contactsListBox, 2);
            this.contactsListBox.DisplayMember = "Surname";
            this.contactsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsListBox.FormattingEnabled = true;
            this.contactsListBox.ItemHeight = 15;
            this.contactsListBox.Location = new System.Drawing.Point(3, 32);
            this.contactsListBox.MinimumSize = new System.Drawing.Size(224, 439);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(224, 439);
            this.contactsListBox.TabIndex = 2;
            this.contactsListBox.SelectedValueChanged +=
                new System.EventHandler(this.contactsListBox_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Location = new System.Drawing.Point(0, 473);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 38);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 555);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rightTablePanelLayout);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(669, 594);
            this.Name = "MainForm";
            this.Text = "Контакты";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.rightTablePanelLayout.ResumeLayout(false);
            this.rightTablePanelLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem helpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TableLayoutPanel rightTablePanelLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContactToolStripMenuItem;
    }
}