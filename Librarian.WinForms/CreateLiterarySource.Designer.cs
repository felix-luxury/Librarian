
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
            this.label4 = new System.Windows.Forms.Label();
            this.readDateDP = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.editionNumberTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pageNumberTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pageCountTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.publisherTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.publishYearTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Название журнала";
            // 
            // readDateDP
            // 
            this.readDateDP.Location = new System.Drawing.Point(321, 212);
            this.readDateDP.Name = "readDateDP";
            this.readDateDP.Size = new System.Drawing.Size(200, 23);
            this.readDateDP.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата чтения";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(185, 212);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(121, 23);
            this.urlTB.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "URL адрес";
            // 
            // editionNumberTB
            // 
            this.editionNumberTB.Location = new System.Drawing.Point(185, 75);
            this.editionNumberTB.Name = "editionNumberTB";
            this.editionNumberTB.Size = new System.Drawing.Size(121, 23);
            this.editionNumberTB.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Номер издания";
            // 
            // pageNumberTB
            // 
            this.pageNumberTB.Location = new System.Drawing.Point(185, 167);
            this.pageNumberTB.Name = "pageNumberTB";
            this.pageNumberTB.Size = new System.Drawing.Size(121, 23);
            this.pageNumberTB.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер страницы";
            // 
            // pageCountTB
            // 
            this.pageCountTB.Location = new System.Drawing.Point(321, 75);
            this.pageCountTB.Name = "pageCountTB";
            this.pageCountTB.Size = new System.Drawing.Size(121, 23);
            this.pageCountTB.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(321, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Количество страниц";
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(185, 119);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(121, 23);
            this.cityTB.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Город";
            // 
            // publisherTB
            // 
            this.publisherTB.Location = new System.Drawing.Point(321, 119);
            this.publisherTB.Name = "publisherTB";
            this.publisherTB.Size = new System.Drawing.Size(121, 23);
            this.publisherTB.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Издатель";
            // 
            // publishYearTB
            // 
            this.publishYearTB.Location = new System.Drawing.Point(459, 119);
            this.publishYearTB.Name = "publishYearTB";
            this.publishYearTB.Size = new System.Drawing.Size(121, 23);
            this.publishYearTB.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(459, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Год издания";
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
            // CreateLiterarySource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 345);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.publishYearTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.publisherTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pageCountTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pageNumberTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.editionNumberTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.readDateDP);
            this.Controls.Add(this.journalTitleTB);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker readDateDP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox editionNumberTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pageNumberTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pageCountTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox publisherTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox publishYearTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveBtn;
    }
}