
namespace Librarian.WinForms
{
    partial class CreateLiterarySource
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
            this.sourceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newAuthorTextBox = new System.Windows.Forms.TextBox();
            this.addAuthorBtn = new System.Windows.Forms.Button();
            this.authorsListBox = new System.Windows.Forms.ListBox();
            this.authorDownBtn = new System.Windows.Forms.Button();
            this.authorUpBtn = new System.Windows.Forms.Button();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.journalTitleTB = new System.Windows.Forms.TextBox();
            this.journalTitleL = new System.Windows.Forms.Label();
            this.readDateDP = new System.Windows.Forms.DateTimePicker();
            this.readDateL = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.urlL = new System.Windows.Forms.Label();
            this.editionNumberTB = new System.Windows.Forms.TextBox();
            this.editionNumberL = new System.Windows.Forms.Label();
            this.pageNumberTB = new System.Windows.Forms.TextBox();
            this.pageNumberL = new System.Windows.Forms.Label();
            this.pageCountTB = new System.Windows.Forms.TextBox();
            this.pageCountL = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.cityL = new System.Windows.Forms.Label();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.publisherL = new System.Windows.Forms.Label();
            this.publishYearTB = new System.Windows.Forms.TextBox();
            this.yearL = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceTypeComboBox
            // 
            this.sourceTypeComboBox.FormattingEnabled = true;
            this.sourceTypeComboBox.Location = new System.Drawing.Point(12, 31);
            this.sourceTypeComboBox.Name = "sourceTypeComboBox";
            this.sourceTypeComboBox.Size = new System.Drawing.Size(121, 23);
            this.sourceTypeComboBox.TabIndex = 0;
            this.sourceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип источника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Авторы";
            // 
            // newAuthorTextBox
            // 
            this.newAuthorTextBox.Location = new System.Drawing.Point(12, 119);
            this.newAuthorTextBox.Name = "newAuthorTextBox";
            this.newAuthorTextBox.Size = new System.Drawing.Size(121, 23);
            this.newAuthorTextBox.TabIndex = 3;
            // 
            // addAuthorBtn
            // 
            this.addAuthorBtn.Location = new System.Drawing.Point(13, 149);
            this.addAuthorBtn.Name = "addAuthorBtn";
            this.addAuthorBtn.Size = new System.Drawing.Size(120, 23);
            this.addAuthorBtn.TabIndex = 4;
            this.addAuthorBtn.Text = "Добавить автора";
            this.addAuthorBtn.UseVisualStyleBackColor = true;
            this.addAuthorBtn.Click += new System.EventHandler(this.addAuthorBtn_Click);
            // 
            // authorsListBox
            // 
            this.authorsListBox.FormattingEnabled = true;
            this.authorsListBox.ItemHeight = 15;
            this.authorsListBox.Location = new System.Drawing.Point(13, 179);
            this.authorsListBox.Name = "authorsListBox";
            this.authorsListBox.Size = new System.Drawing.Size(120, 94);
            this.authorsListBox.TabIndex = 5;
            this.authorsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.authorsListBox_MouseDoubleClick);
            // 
            // authorDownBtn
            // 
            this.authorDownBtn.Location = new System.Drawing.Point(139, 243);
            this.authorDownBtn.Name = "authorDownBtn";
            this.authorDownBtn.Size = new System.Drawing.Size(30, 30);
            this.authorDownBtn.TabIndex = 7;
            this.authorDownBtn.Text = "↓";
            this.authorDownBtn.UseVisualStyleBackColor = true;
            this.authorDownBtn.Click += new System.EventHandler(this.authorDownBtn_Click);
            // 
            // authorUpBtn
            // 
            this.authorUpBtn.Location = new System.Drawing.Point(139, 179);
            this.authorUpBtn.Name = "authorUpBtn";
            this.authorUpBtn.Size = new System.Drawing.Size(30, 30);
            this.authorUpBtn.TabIndex = 6;
            this.authorUpBtn.Text = "↑";
            this.authorUpBtn.UseVisualStyleBackColor = true;
            this.authorUpBtn.Click += new System.EventHandler(this.authorUpBtn_Click);
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(12, 75);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(121, 23);
            this.titleTB.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Название источника";
            // 
            // journalTitleTB
            // 
            this.journalTitleTB.Location = new System.Drawing.Point(459, 75);
            this.journalTitleTB.Name = "journalTitleTB";
            this.journalTitleTB.Size = new System.Drawing.Size(121, 23);
            this.journalTitleTB.TabIndex = 11;
            // 
            // journalTitleL
            // 
            this.journalTitleL.AutoSize = true;
            this.journalTitleL.Location = new System.Drawing.Point(459, 57);
            this.journalTitleL.Name = "journalTitleL";
            this.journalTitleL.Size = new System.Drawing.Size(110, 15);
            this.journalTitleL.TabIndex = 10;
            this.journalTitleL.Text = "Название журнала";
            // 
            // readDateDP
            // 
            this.readDateDP.Location = new System.Drawing.Point(321, 212);
            this.readDateDP.Name = "readDateDP";
            this.readDateDP.Size = new System.Drawing.Size(200, 23);
            this.readDateDP.TabIndex = 12;
            // 
            // readDateL
            // 
            this.readDateL.AutoSize = true;
            this.readDateL.Location = new System.Drawing.Point(321, 194);
            this.readDateL.Name = "readDateL";
            this.readDateL.Size = new System.Drawing.Size(73, 15);
            this.readDateL.TabIndex = 13;
            this.readDateL.Text = "Дата чтения";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(185, 212);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(121, 23);
            this.urlTB.TabIndex = 15;
            // 
            // urlL
            // 
            this.urlL.AutoSize = true;
            this.urlL.Location = new System.Drawing.Point(185, 194);
            this.urlL.Name = "urlL";
            this.urlL.Size = new System.Drawing.Size(62, 15);
            this.urlL.TabIndex = 14;
            this.urlL.Text = "URL адрес";
            // 
            // editionNumberTB
            // 
            this.editionNumberTB.Location = new System.Drawing.Point(185, 75);
            this.editionNumberTB.Name = "editionNumberTB";
            this.editionNumberTB.Size = new System.Drawing.Size(121, 23);
            this.editionNumberTB.TabIndex = 17;
            // 
            // editionNumberL
            // 
            this.editionNumberL.AutoSize = true;
            this.editionNumberL.Location = new System.Drawing.Point(185, 57);
            this.editionNumberL.Name = "editionNumberL";
            this.editionNumberL.Size = new System.Drawing.Size(92, 15);
            this.editionNumberL.TabIndex = 16;
            this.editionNumberL.Text = "Номер издания";
            // 
            // pageNumberTB
            // 
            this.pageNumberTB.Location = new System.Drawing.Point(185, 167);
            this.pageNumberTB.Name = "pageNumberTB";
            this.pageNumberTB.Size = new System.Drawing.Size(121, 23);
            this.pageNumberTB.TabIndex = 19;
            // 
            // pageNumberL
            // 
            this.pageNumberL.AutoSize = true;
            this.pageNumberL.Location = new System.Drawing.Point(185, 149);
            this.pageNumberL.Name = "pageNumberL";
            this.pageNumberL.Size = new System.Drawing.Size(102, 15);
            this.pageNumberL.TabIndex = 18;
            this.pageNumberL.Text = "Номер страницы";
            // 
            // pageCountTB
            // 
            this.pageCountTB.Location = new System.Drawing.Point(321, 75);
            this.pageCountTB.Name = "pageCountTB";
            this.pageCountTB.Size = new System.Drawing.Size(121, 23);
            this.pageCountTB.TabIndex = 21;
            // 
            // pageCountL
            // 
            this.pageCountL.AutoSize = true;
            this.pageCountL.Location = new System.Drawing.Point(321, 57);
            this.pageCountL.Name = "pageCountL";
            this.pageCountL.Size = new System.Drawing.Size(120, 15);
            this.pageCountL.TabIndex = 20;
            this.pageCountL.Text = "Количество страниц";
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(185, 119);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(121, 23);
            this.cityTB.TabIndex = 23;
            // 
            // cityL
            // 
            this.cityL.AutoSize = true;
            this.cityL.Location = new System.Drawing.Point(185, 101);
            this.cityL.Name = "cityL";
            this.cityL.Size = new System.Drawing.Size(40, 15);
            this.cityL.TabIndex = 22;
            this.cityL.Text = "Город";
            // 
            // publisherTB
            // 
            this.publisherTB.Location = new System.Drawing.Point(321, 119);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(121, 23);
            this.publisherTB.TabIndex = 25;
            // 
            // publisherL
            // 
            this.publisherL.AutoSize = true;
            this.publisherL.Location = new System.Drawing.Point(321, 101);
            this.publisherL.Name = "publisherL";
            this.publisherL.Size = new System.Drawing.Size(57, 15);
            this.publisherL.TabIndex = 24;
            this.publisherL.Text = "Издатель";
            // 
            // publishYearTB
            // 
            this.publishYearTB.Location = new System.Drawing.Point(459, 119);
            this.publishYearTB.Name = "publishYearTB";
            this.publishYearTB.Size = new System.Drawing.Size(121, 23);
            this.publishYearTB.TabIndex = 27;
            // 
            // yearL
            // 
            this.yearL.AutoSize = true;
            this.yearL.Location = new System.Drawing.Point(459, 101);
            this.yearL.Name = "yearL";
            this.yearL.Size = new System.Drawing.Size(73, 15);
            this.yearL.TabIndex = 26;
            this.yearL.Text = "Год издания";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 280);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 28;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(94, 280);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 29;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // CreateLiterarySource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 345);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.publishYearTB);
            this.Controls.Add(this.yearL);
            this.Controls.Add(this.publisherTB);
            this.Controls.Add(this.publisherL);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.cityL);
            this.Controls.Add(this.pageCountTB);
            this.Controls.Add(this.pageCountL);
            this.Controls.Add(this.pageNumberTB);
            this.Controls.Add(this.pageNumberL);
            this.Controls.Add(this.editionNumberTB);
            this.Controls.Add(this.editionNumberL);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.urlL);
            this.Controls.Add(this.readDateL);
            this.Controls.Add(this.readDateDP);
            this.Controls.Add(this.journalTitleTB);
            this.Controls.Add(this.journalTitleL);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.authorDownBtn);
            this.Controls.Add(this.authorUpBtn);
            this.Controls.Add(this.authorsListBox);
            this.Controls.Add(this.addAuthorBtn);
            this.Controls.Add(this.newAuthorTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceTypeComboBox);
            this.Name = "CreateLiterarySource";
            this.Text = "Добавить литературный источник";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sourceTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newAuthorTextBox;
        private System.Windows.Forms.Button addAuthorBtn;
        private System.Windows.Forms.ListBox authorsListBox;
        private System.Windows.Forms.Button authorDownBtn;
        private System.Windows.Forms.Button authorUpBtn;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox journalTitleTB;
        private System.Windows.Forms.Label journalTitleL;
        private System.Windows.Forms.DateTimePicker readDateDP;
        private System.Windows.Forms.Label readDateL;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label urlL;
        private System.Windows.Forms.TextBox editionNumberTB;
        private System.Windows.Forms.Label editionNumberL;
        private System.Windows.Forms.TextBox pageNumberTB;
        private System.Windows.Forms.Label pageNumberL;
        private System.Windows.Forms.TextBox pageCountTB;
        private System.Windows.Forms.Label pageCountL;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label cityL;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.Label publisherL;
        private System.Windows.Forms.TextBox publishYearTB;
        private System.Windows.Forms.Label yearL;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}