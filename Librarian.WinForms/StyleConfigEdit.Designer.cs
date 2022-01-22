
namespace Librarian.WinForms
{
    partial class StyleConfigEdit
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
            this.authorsPrefixLabel = new System.Windows.Forms.Label();
            this.authorsPrefixTextBox = new System.Windows.Forms.TextBox();
            this.authorsPostfixTextBox = new System.Windows.Forms.TextBox();
            this.authorsPostfixLabel = new System.Windows.Forms.Label();
            this.authorsDelimiterTextBox = new System.Windows.Forms.TextBox();
            this.authorsDelimiterLabel1 = new System.Windows.Forms.Label();
            this.authorsLastDelimiterTextBox = new System.Windows.Forms.TextBox();
            this.authorsDelimiterLabel2 = new System.Windows.Forms.Label();
            this.yearPrefixTextBox = new System.Windows.Forms.TextBox();
            this.yearPrefixLabel = new System.Windows.Forms.Label();
            this.yearPostfixTextBox = new System.Windows.Forms.TextBox();
            this.yearPostfixLabel = new System.Windows.Forms.Label();
            this.titlePostfixTextBox = new System.Windows.Forms.TextBox();
            this.titlePostfixLabel = new System.Windows.Forms.Label();
            this.titlePrefixTextBox = new System.Windows.Forms.TextBox();
            this.titlePrefixLabel = new System.Windows.Forms.Label();
            this.journalPostfixTextBox = new System.Windows.Forms.TextBox();
            this.journalPostfixLabel = new System.Windows.Forms.Label();
            this.journalPrefixTextBox = new System.Windows.Forms.TextBox();
            this.journalPrefixLabel = new System.Windows.Forms.Label();
            this.datePostfixTextBox = new System.Windows.Forms.TextBox();
            this.datePostfixLabel = new System.Windows.Forms.Label();
            this.datePrefixTextBox = new System.Windows.Forms.TextBox();
            this.datePrefixLabel = new System.Windows.Forms.Label();
            this.dateFormatTextBox = new System.Windows.Forms.TextBox();
            this.dateFormatLabel = new System.Windows.Forms.Label();
            this.sourcePostfixTextBox = new System.Windows.Forms.TextBox();
            this.sourcePostfixLabel = new System.Windows.Forms.Label();
            this.sourcePrefixTextBox = new System.Windows.Forms.TextBox();
            this.sourcePrefixLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authorsPrefixLabel
            // 
            this.authorsPrefixLabel.AutoSize = true;
            this.authorsPrefixLabel.Location = new System.Drawing.Point(12, 12);
            this.authorsPrefixLabel.Name = "authorsPrefixLabel";
            this.authorsPrefixLabel.Size = new System.Drawing.Size(104, 15);
            this.authorsPrefixLabel.TabIndex = 0;
            this.authorsPrefixLabel.Text = "Префикс авторов";
            // 
            // authorsPrefixTextBox
            // 
            this.authorsPrefixTextBox.Location = new System.Drawing.Point(12, 30);
            this.authorsPrefixTextBox.Name = "authorsPrefixTextBox";
            this.authorsPrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorsPrefixTextBox.TabIndex = 1;
            // 
            // authorsPostfixTextBox
            // 
            this.authorsPostfixTextBox.Location = new System.Drawing.Point(150, 30);
            this.authorsPostfixTextBox.Name = "authorsPostfixTextBox";
            this.authorsPostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorsPostfixTextBox.TabIndex = 3;
            // 
            // authorsPostfixLabel
            // 
            this.authorsPostfixLabel.AutoSize = true;
            this.authorsPostfixLabel.Location = new System.Drawing.Point(150, 12);
            this.authorsPostfixLabel.Name = "authorsPostfixLabel";
            this.authorsPostfixLabel.Size = new System.Drawing.Size(109, 15);
            this.authorsPostfixLabel.TabIndex = 2;
            this.authorsPostfixLabel.Text = "Постфикс авторов";
            // 
            // authorsDelimiterTextBox
            // 
            this.authorsDelimiterTextBox.Location = new System.Drawing.Point(12, 74);
            this.authorsDelimiterTextBox.Name = "authorsDelimiterTextBox";
            this.authorsDelimiterTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorsDelimiterTextBox.TabIndex = 5;
            this.authorsDelimiterTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // authorsDelimiterLabel1
            // 
            this.authorsDelimiterLabel1.AutoSize = true;
            this.authorsDelimiterLabel1.Location = new System.Drawing.Point(3, 56);
            this.authorsDelimiterLabel1.Name = "authorsDelimiterLabel1";
            this.authorsDelimiterLabel1.Size = new System.Drawing.Size(122, 15);
            this.authorsDelimiterLabel1.TabIndex = 4;
            this.authorsDelimiterLabel1.Text = "Разделитель авторов";
            this.authorsDelimiterLabel1.Click += new System.EventHandler(this.label3_Click);
            // 
            // authorsLastDelimiterTextBox
            // 
            this.authorsLastDelimiterTextBox.Location = new System.Drawing.Point(150, 74);
            this.authorsLastDelimiterTextBox.Name = "authorsLastDelimiterTextBox";
            this.authorsLastDelimiterTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorsLastDelimiterTextBox.TabIndex = 7;
            // 
            // authorsDelimiterLabel2
            // 
            this.authorsDelimiterLabel2.AutoSize = true;
            this.authorsDelimiterLabel2.Location = new System.Drawing.Point(131, 56);
            this.authorsDelimiterLabel2.Name = "authorsDelimiterLabel2";
            this.authorsDelimiterLabel2.Size = new System.Drawing.Size(143, 15);
            this.authorsDelimiterLabel2.TabIndex = 6;
            this.authorsDelimiterLabel2.Text = "Последний Разделитель ";
            this.authorsDelimiterLabel2.Click += new System.EventHandler(this.label4_Click);
            // 
            // yearPrefixTextBox
            // 
            this.yearPrefixTextBox.Location = new System.Drawing.Point(12, 137);
            this.yearPrefixTextBox.Name = "yearPrefixTextBox";
            this.yearPrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearPrefixTextBox.TabIndex = 9;
            this.yearPrefixTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // yearPrefixLabel
            // 
            this.yearPrefixLabel.AutoSize = true;
            this.yearPrefixLabel.Location = new System.Drawing.Point(22, 119);
            this.yearPrefixLabel.Name = "yearPrefixLabel";
            this.yearPrefixLabel.Size = new System.Drawing.Size(84, 15);
            this.yearPrefixLabel.TabIndex = 8;
            this.yearPrefixLabel.Text = "Префикс года";
            this.yearPrefixLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // yearPostfixTextBox
            // 
            this.yearPostfixTextBox.Location = new System.Drawing.Point(150, 137);
            this.yearPostfixTextBox.Name = "yearPostfixTextBox";
            this.yearPostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.yearPostfixTextBox.TabIndex = 11;
            this.yearPostfixTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // yearPostfixLabel
            // 
            this.yearPostfixLabel.AutoSize = true;
            this.yearPostfixLabel.Location = new System.Drawing.Point(157, 119);
            this.yearPostfixLabel.Name = "yearPostfixLabel";
            this.yearPostfixLabel.Size = new System.Drawing.Size(89, 15);
            this.yearPostfixLabel.TabIndex = 10;
            this.yearPostfixLabel.Text = "Постфикс года";
            this.yearPostfixLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // titlePostfixTextBox
            // 
            this.titlePostfixTextBox.Location = new System.Drawing.Point(150, 206);
            this.titlePostfixTextBox.Name = "titlePostfixTextBox";
            this.titlePostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.titlePostfixTextBox.TabIndex = 15;
            this.titlePostfixTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // titlePostfixLabel
            // 
            this.titlePostfixLabel.AutoSize = true;
            this.titlePostfixLabel.Location = new System.Drawing.Point(144, 173);
            this.titlePostfixLabel.Name = "titlePostfixLabel";
            this.titlePostfixLabel.Size = new System.Drawing.Size(115, 30);
            this.titlePostfixLabel.TabIndex = 14;
            this.titlePostfixLabel.Text = "Постфикс названия\r\n      произведения\r\n";
            this.titlePostfixLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // titlePrefixTextBox
            // 
            this.titlePrefixTextBox.Location = new System.Drawing.Point(12, 206);
            this.titlePrefixTextBox.Name = "titlePrefixTextBox";
            this.titlePrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.titlePrefixTextBox.TabIndex = 13;
            this.titlePrefixTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // titlePrefixLabel
            // 
            this.titlePrefixLabel.AutoSize = true;
            this.titlePrefixLabel.Location = new System.Drawing.Point(6, 173);
            this.titlePrefixLabel.Name = "titlePrefixLabel";
            this.titlePrefixLabel.Size = new System.Drawing.Size(110, 30);
            this.titlePrefixLabel.TabIndex = 12;
            this.titlePrefixLabel.Text = "Префикс названия\r\n    произведения";
            this.titlePrefixLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // journalPostfixTextBox
            // 
            this.journalPostfixTextBox.Location = new System.Drawing.Point(150, 279);
            this.journalPostfixTextBox.Name = "journalPostfixTextBox";
            this.journalPostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.journalPostfixTextBox.TabIndex = 19;
            // 
            // journalPostfixLabel
            // 
            this.journalPostfixLabel.AutoSize = true;
            this.journalPostfixLabel.Location = new System.Drawing.Point(144, 246);
            this.journalPostfixLabel.Name = "journalPostfixLabel";
            this.journalPostfixLabel.Size = new System.Drawing.Size(115, 30);
            this.journalPostfixLabel.TabIndex = 18;
            this.journalPostfixLabel.Text = "Постфикс названия\r\n          журнала\r\n";
            // 
            // journalPrefixTextBox
            // 
            this.journalPrefixTextBox.Location = new System.Drawing.Point(12, 279);
            this.journalPrefixTextBox.Name = "journalPrefixTextBox";
            this.journalPrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.journalPrefixTextBox.TabIndex = 17;
            // 
            // journalPrefixLabel
            // 
            this.journalPrefixLabel.AutoSize = true;
            this.journalPrefixLabel.Location = new System.Drawing.Point(6, 246);
            this.journalPrefixLabel.Name = "journalPrefixLabel";
            this.journalPrefixLabel.Size = new System.Drawing.Size(110, 30);
            this.journalPrefixLabel.TabIndex = 16;
            this.journalPrefixLabel.Text = "Префикс названия\r\n         журнала";
            // 
            // datePostfixTextBox
            // 
            this.datePostfixTextBox.Location = new System.Drawing.Point(150, 332);
            this.datePostfixTextBox.Name = "datePostfixTextBox";
            this.datePostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.datePostfixTextBox.TabIndex = 23;
            // 
            // datePostfixLabel
            // 
            this.datePostfixLabel.AutoSize = true;
            this.datePostfixLabel.Location = new System.Drawing.Point(157, 314);
            this.datePostfixLabel.Name = "datePostfixLabel";
            this.datePostfixLabel.Size = new System.Drawing.Size(91, 15);
            this.datePostfixLabel.TabIndex = 22;
            this.datePostfixLabel.Text = "Постфикс даты";
            // 
            // datePrefixTextBox
            // 
            this.datePrefixTextBox.Location = new System.Drawing.Point(12, 332);
            this.datePrefixTextBox.Name = "datePrefixTextBox";
            this.datePrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.datePrefixTextBox.TabIndex = 21;
            // 
            // datePrefixLabel
            // 
            this.datePrefixLabel.AutoSize = true;
            this.datePrefixLabel.Location = new System.Drawing.Point(22, 314);
            this.datePrefixLabel.Name = "datePrefixLabel";
            this.datePrefixLabel.Size = new System.Drawing.Size(86, 15);
            this.datePrefixLabel.TabIndex = 20;
            this.datePrefixLabel.Text = "Префикс даты";
            // 
            // dateFormatTextBox
            // 
            this.dateFormatTextBox.Location = new System.Drawing.Point(285, 332);
            this.dateFormatTextBox.Name = "dateFormatTextBox";
            this.dateFormatTextBox.Size = new System.Drawing.Size(100, 23);
            this.dateFormatTextBox.TabIndex = 25;
            // 
            // dateFormatLabel
            // 
            this.dateFormatLabel.AutoSize = true;
            this.dateFormatLabel.Location = new System.Drawing.Point(298, 314);
            this.dateFormatLabel.Name = "dateFormatLabel";
            this.dateFormatLabel.Size = new System.Drawing.Size(79, 15);
            this.dateFormatLabel.TabIndex = 24;
            this.dateFormatLabel.Text = "Формат даты";
            // 
            // sourcePostfixTextBox
            // 
            this.sourcePostfixTextBox.Location = new System.Drawing.Point(150, 396);
            this.sourcePostfixTextBox.Name = "sourcePostfixTextBox";
            this.sourcePostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.sourcePostfixTextBox.TabIndex = 29;
            // 
            // sourcePostfixLabel
            // 
            this.sourcePostfixLabel.AutoSize = true;
            this.sourcePostfixLabel.Location = new System.Drawing.Point(137, 378);
            this.sourcePostfixLabel.Name = "sourcePostfixLabel";
            this.sourcePostfixLabel.Size = new System.Drawing.Size(123, 15);
            this.sourcePostfixLabel.TabIndex = 28;
            this.sourcePostfixLabel.Text = "Постфикс источника";
            // 
            // sourcePrefixTextBox
            // 
            this.sourcePrefixTextBox.Location = new System.Drawing.Point(12, 396);
            this.sourcePrefixTextBox.Name = "sourcePrefixTextBox";
            this.sourcePrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.sourcePrefixTextBox.TabIndex = 27;
            // 
            // sourcePrefixLabel
            // 
            this.sourcePrefixLabel.AutoSize = true;
            this.sourcePrefixLabel.Location = new System.Drawing.Point(5, 378);
            this.sourcePrefixLabel.Name = "sourcePrefixLabel";
            this.sourcePrefixLabel.Size = new System.Drawing.Size(118, 15);
            this.sourcePrefixLabel.TabIndex = 26;
            this.sourcePrefixLabel.Text = "Префикс источника";
            // 
            // StyleConfigEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yearPostfixTextBox);
            this.Controls.Add(this.sourcePostfixTextBox);
            this.Controls.Add(this.sourcePostfixLabel);
            this.Controls.Add(this.sourcePrefixTextBox);
            this.Controls.Add(this.sourcePrefixLabel);
            this.Controls.Add(this.dateFormatTextBox);
            this.Controls.Add(this.dateFormatLabel);
            this.Controls.Add(this.datePostfixTextBox);
            this.Controls.Add(this.datePostfixLabel);
            this.Controls.Add(this.datePrefixTextBox);
            this.Controls.Add(this.datePrefixLabel);
            this.Controls.Add(this.journalPostfixTextBox);
            this.Controls.Add(this.journalPostfixLabel);
            this.Controls.Add(this.journalPrefixTextBox);
            this.Controls.Add(this.journalPrefixLabel);
            this.Controls.Add(this.titlePostfixTextBox);
            this.Controls.Add(this.titlePostfixLabel);
            this.Controls.Add(this.titlePrefixTextBox);
            this.Controls.Add(this.titlePrefixLabel);
            this.Controls.Add(this.yearPostfixLabel);
            this.Controls.Add(this.yearPrefixTextBox);
            this.Controls.Add(this.yearPrefixLabel);
            this.Controls.Add(this.authorsLastDelimiterTextBox);
            this.Controls.Add(this.authorsDelimiterLabel2);
            this.Controls.Add(this.authorsDelimiterTextBox);
            this.Controls.Add(this.authorsDelimiterLabel1);
            this.Controls.Add(this.authorsPostfixTextBox);
            this.Controls.Add(this.authorsPostfixLabel);
            this.Controls.Add(this.authorsPrefixTextBox);
            this.Controls.Add(this.authorsPrefixLabel);
            this.Name = "StyleConfigEdit";
            this.Text = "StyleConfigEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label authorsPrefixLabel;
        private System.Windows.Forms.TextBox authorsPrefixTextBox;
        private System.Windows.Forms.TextBox authorsPostfixTextBox;
        private System.Windows.Forms.Label authorsPostfixLabel;
        private System.Windows.Forms.TextBox authorsDelimiterTextBox;
        private System.Windows.Forms.Label authorsDelimiterLabel1;
        private System.Windows.Forms.TextBox authorsLastDelimiterTextBox;
        private System.Windows.Forms.Label authorsDelimiterLabel2;
        private System.Windows.Forms.TextBox yearPrefixTextBox;
        private System.Windows.Forms.Label yearPrefixLabel;
        private System.Windows.Forms.TextBox yearPostfixTextBox;
        private System.Windows.Forms.Label yearPostfixLabel;
        private System.Windows.Forms.TextBox titlePostfixTextBox;
        private System.Windows.Forms.Label titlePostfixLabel;
        private System.Windows.Forms.TextBox titlePrefixTextBox;
        private System.Windows.Forms.Label titlePrefixLabel;
        private System.Windows.Forms.TextBox journalPostfixTextBox;
        private System.Windows.Forms.Label journalPostfixLabel;
        private System.Windows.Forms.TextBox journalPrefixTextBox;
        private System.Windows.Forms.Label journalPrefixLabel;
        private System.Windows.Forms.TextBox datePostfixTextBox;
        private System.Windows.Forms.Label datePostfixLabel;
        private System.Windows.Forms.TextBox datePrefixTextBox;
        private System.Windows.Forms.Label datePrefixLabel;
        private System.Windows.Forms.TextBox dateFormatTextBox;
        private System.Windows.Forms.Label dateFormatLabel;
        private System.Windows.Forms.TextBox sourcePostfixTextBox;
        private System.Windows.Forms.Label sourcePostfixLabel;
        private System.Windows.Forms.TextBox sourcePrefixTextBox;
        private System.Windows.Forms.Label sourcePrefixLabel;
    }
}