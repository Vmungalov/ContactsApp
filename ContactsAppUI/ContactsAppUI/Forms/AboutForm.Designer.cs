namespace ContactsAppUI
{
    partial class AboutForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelEmailTitle = new System.Windows.Forms.Label();
            this.linkLabelMailto = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelGitHub = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelTitle.Location = new System.Drawing.Point(15, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(227, 39);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "ContactsApp";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(15, 48);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(43, 15);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "v. 1.0.0";
            // 
            // labelAuthor
            // 
            this.labelAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(3, 2);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(43, 15);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Автор:";
            // 
            // labelEmailTitle
            // 
            this.labelEmailTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEmailTitle.Location = new System.Drawing.Point(3, 22);
            this.labelEmailTitle.Name = "labelEmailTitle";
            this.labelEmailTitle.Size = new System.Drawing.Size(50, 15);
            this.labelEmailTitle.TabIndex = 3;
            this.labelEmailTitle.Text = "E-Mail:";
            // 
            // linkLabelMailto
            // 
            this.linkLabelMailto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelMailto.Location = new System.Drawing.Point(69, 22);
            this.linkLabelMailto.Name = "linkLabelMailto";
            this.linkLabelMailto.Size = new System.Drawing.Size(155, 15);
            this.linkLabelMailto.TabIndex = 4;
            this.linkLabelMailto.TabStop = true;
            this.linkLabelMailto.Text = "v_mungalov@mail.ru";
            this.linkLabelMailto.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMailto_LinkClicked);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.05988F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.94012F));
            this.tableLayoutPanel1.Controls.Add(this.labelAuthor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEmailTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelMailto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelGitHub, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAuthorName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGitHub, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLabelGitHub.Location = new System.Drawing.Point(69, 42);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(260, 15);
            this.linkLabelGitHub.TabIndex = 7;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "https://github.com/Vmungalov/ContactsApp";
            this.linkLabelGitHub.LinkClicked +=
                new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(69, 2);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(100, 15);
            this.labelAuthorName.TabIndex = 8;
            this.labelAuthorName.Text = "Мунгалов Вадим";
            // 
            // labelGitHub
            // 
            this.labelGitHub.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelGitHub.Location = new System.Drawing.Point(3, 42);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(50, 15);
            this.labelGitHub.TabIndex = 6;
            this.labelGitHub.Text = "GitHub:";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 243);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AboutForm";
            this.Text = "О программе";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelEmailTitle;
        private System.Windows.Forms.LinkLabel linkLabelMailto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.LinkLabel linkLabelGitHub;
        private System.Windows.Forms.Label labelGitHub;
    }
}