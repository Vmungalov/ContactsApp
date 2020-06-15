﻿using System.ComponentModel;

namespace ContactsAppUI
{
    partial class EditForm
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
            this.rightTablePanelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.vkTextBox = new System.Windows.Forms.TextBox();
            this.vkLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.birthdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.rightTablePanelLayout.SuspendLayout();
            this.SuspendLayout();
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
            this.rightTablePanelLayout.Location = new System.Drawing.Point(12, 12);
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
            this.rightTablePanelLayout.Size = new System.Drawing.Size(411, 174);
            this.rightTablePanelLayout.TabIndex = 14;
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
            this.surnameTextBox.Size = new System.Drawing.Size(294, 23);
            this.surnameTextBox.TabIndex = 1;
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
            this.vkTextBox.Size = new System.Drawing.Size(294, 23);
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
            // emailTextBox
            // 
            this.emailTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Location = new System.Drawing.Point(114, 119);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(294, 23);
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
            // nameTextBox
            // 
            this.nameTextBox.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(114, 32);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(294, 23);
            this.nameTextBox.TabIndex = 2;
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
            this.phoneTextBox.Size = new System.Drawing.Size(294, 23);
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
            // birthdayDatePicker
            // 
            this.birthdayDatePicker.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayDatePicker.Enabled = false;
            this.birthdayDatePicker.Location = new System.Drawing.Point(114, 61);
            this.birthdayDatePicker.Name = "birthdayDatePicker";
            this.birthdayDatePicker.Size = new System.Drawing.Size(294, 23);
            this.birthdayDatePicker.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancel.Location = new System.Drawing.Point(341, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOk.Location = new System.Drawing.Point(256, 191);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(79, 23);
            this.buttonOk.TabIndex = 16;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 221);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.rightTablePanelLayout);
            this.MaximumSize = new System.Drawing.Size(1000, 260);
            this.MinimumSize = new System.Drawing.Size(450, 260);
            this.Name = "EditForm";
            this.Text = "Редактирование контакта";
            this.rightTablePanelLayout.ResumeLayout(false);
            this.rightTablePanelLayout.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DateTimePicker birthdayDatePicker;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label vkLabel;
        private System.Windows.Forms.TextBox vkTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TableLayoutPanel rightTablePanelLayout;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}