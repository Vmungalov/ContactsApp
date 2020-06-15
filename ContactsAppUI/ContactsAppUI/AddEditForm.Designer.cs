using System.Windows.Forms;

namespace ContactsAppUI
{
    partial class AddEditForm
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            this.panel1.Controls.Add(this.BirthdayDateTimePicker);
            this.panel1.Controls.Add(this.OkButton);
            this.panel1.Controls.Add(this.CancelButton);
            this.panel1.Controls.Add(this.VkTextBox);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.PhoneTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.SurnameTextBox);
            this.panel1.Controls.Add(this.Vk);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Controls.Add(this.Name);
            this.panel1.Controls.Add(this.Surname);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 211);
            this.panel1.TabIndex = 0;
            this.VkTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.VkTextBox.Location = new System.Drawing.Point(87, 141);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(346, 20);
            this.VkTextBox.TabIndex = 36;
            this.EmailTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(87, 115);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(346, 20);
            this.EmailTextBox.TabIndex = 35;
            this.PhoneTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneTextBox.Location = new System.Drawing.Point(87, 89);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(346, 20);
            this.PhoneTextBox.TabIndex = 34;
            this.NameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(87, 37);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(346, 20);
            this.NameTextBox.TabIndex = 33;
            this.SurnameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(87, 12);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(346, 20);
            this.SurnameTextBox.TabIndex = 32;
            this.Vk.AutoSize = true;
            this.Vk.Location = new System.Drawing.Point(36, 144);
            this.Vk.Name = "Vk";
            this.Vk.Size = new System.Drawing.Size(45, 13);
            this.Vk.TabIndex = 31;
            this.Vk.Text = "vk.com:";
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(43, 118);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(38, 13);
            this.Email.TabIndex = 30;
            this.Email.Text = "E-mail:";
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(40, 92);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(41, 13);
            this.Phone.TabIndex = 29;
            this.Phone.Text = "Phone:";
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(33, 67);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(48, 13);
            this.Birthday.TabIndex = 28;
            this.Birthday.Text = "Birthday:";
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(43, 40);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(38, 13);
            this.Name.TabIndex = 27;
            this.Name.Text = "Name:";
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(29, 15);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(52, 13);
            this.Surname.TabIndex = 26;
            this.Surname.Text = "Surname:";
            this.CancelButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(350, 167);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(82, 25);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.OkButton.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Location = new System.Drawing.Point(262, 167);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(82, 25);
            this.OkButton.TabIndex = 39;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(87, 63);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(95, 20);
            this.BirthdayDateTimePicker.TabIndex = 40;
            this.BirthdayDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.panel1);
            this.Name = new System.Windows.Forms.Label();
            this.Text = "Add\\Edit Contact";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OkButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label Vk;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Birthday;
        private new System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
    }
}