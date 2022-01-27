
using System.Windows.Forms;

namespace Librarian.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addSourceBtn = new System.Windows.Forms.Button();
            this.litSourcesListView = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Authors = new System.Windows.Forms.ColumnHeader();
            this.Type = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.stylesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createStyle = new System.Windows.Forms.Button();
            this.ExportToTxt = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.selectedLitSourcesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.editStyle = new System.Windows.Forms.Button();
            this.EditSource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addSourceBtn
            // 
            this.addSourceBtn.Location = new System.Drawing.Point(12, 9);
            this.addSourceBtn.Name = "addSourceBtn";
            this.addSourceBtn.Size = new System.Drawing.Size(76, 53);
            this.addSourceBtn.TabIndex = 0;
            this.addSourceBtn.Text = "Добавить\r\nисточник";
            this.addSourceBtn.UseVisualStyleBackColor = true;
            this.addSourceBtn.Click += new System.EventHandler(this.createLitSource_Click);
            // 
            // litSourcesListView
            // 
            this.litSourcesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Authors,
            this.Type});
            this.litSourcesListView.HideSelection = false;
            this.litSourcesListView.Location = new System.Drawing.Point(12, 68);
            this.litSourcesListView.MultiSelect = false;
            this.litSourcesListView.Name = "litSourcesListView";
            this.litSourcesListView.Size = new System.Drawing.Size(486, 580);
            this.litSourcesListView.TabIndex = 1;
            this.litSourcesListView.UseCompatibleStateImageBehavior = false;
            this.litSourcesListView.View = System.Windows.Forms.View.Details;
            this.litSourcesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.litSourcesListView_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Название";
            this.Title.Width = 200;
            // 
            // Authors
            // 
            this.Authors.Text = "Авторы";
            this.Authors.Width = 200;
            // 
            // Type
            // 
            this.Type.Text = "Тип";
            this.Type.Width = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(996, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Поднять";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(996, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Опустить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // stylesComboBox
            // 
            this.stylesComboBox.FormattingEnabled = true;
            this.stylesComboBox.Location = new System.Drawing.Point(219, 25);
            this.stylesComboBox.Name = "stylesComboBox";
            this.stylesComboBox.Size = new System.Drawing.Size(156, 23);
            this.stylesComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выбрать стиль";
            // 
            // createStyle
            // 
            this.createStyle.Location = new System.Drawing.Point(380, 11);
            this.createStyle.Name = "createStyle";
            this.createStyle.Size = new System.Drawing.Size(119, 48);
            this.createStyle.TabIndex = 7;
            this.createStyle.Text = "Создать стиль";
            this.createStyle.UseVisualStyleBackColor = true;
            this.createStyle.Click += new System.EventHandler(this.createStyle_Click);
            // 
            // ExportToTxt
            // 
            this.ExportToTxt.Location = new System.Drawing.Point(996, 567);
            this.ExportToTxt.Name = "ExportToTxt";
            this.ExportToTxt.Size = new System.Drawing.Size(117, 23);
            this.ExportToTxt.TabIndex = 10;
            this.ExportToTxt.Text = "Выгрузить в .txt";
            this.ExportToTxt.UseVisualStyleBackColor = true;
            this.ExportToTxt.Click += new System.EventHandler(this.ExportToTxt_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(996, 596);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Выгрузить в .doc";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(996, 625);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Добавить в .doc";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // selectedLitSourcesListView
            // 
            this.selectedLitSourcesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.selectedLitSourcesListView.HideSelection = false;
            this.selectedLitSourcesListView.Location = new System.Drawing.Point(504, 68);
            this.selectedLitSourcesListView.Name = "selectedLitSourcesListView";
            this.selectedLitSourcesListView.Size = new System.Drawing.Size(486, 580);
            this.selectedLitSourcesListView.TabIndex = 13;
            this.selectedLitSourcesListView.UseCompatibleStateImageBehavior = false;
            this.selectedLitSourcesListView.View = System.Windows.Forms.View.Details;
            this.selectedLitSourcesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.selectedLitSourcesListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Авторы";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип";
            this.columnHeader3.Width = 100;
            // 
            // editStyle
            // 
            this.editStyle.Location = new System.Drawing.Point(504, 11);
            this.editStyle.Name = "editStyle";
            this.editStyle.Size = new System.Drawing.Size(119, 48);
            this.editStyle.TabIndex = 14;
            this.editStyle.Text = "Редактировать стиль";
            this.editStyle.UseVisualStyleBackColor = true;
            this.editStyle.Click += new System.EventHandler(this.editStyle_Click);
            // 
            // EditSource
            // 
            this.EditSource.Location = new System.Drawing.Point(94, 9);
            this.EditSource.Name = "EditSource";
            this.EditSource.Size = new System.Drawing.Size(95, 53);
            this.EditSource.TabIndex = 15;
            this.EditSource.Text = "Редактировать источник";
            this.EditSource.UseVisualStyleBackColor = true;
            this.EditSource.Click += new System.EventHandler(this.EditSource_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 660);
            this.Controls.Add(this.EditSource);
            this.Controls.Add(this.editStyle);
            this.Controls.Add(this.selectedLitSourcesListView);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.ExportToTxt);
            this.Controls.Add(this.createStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stylesComboBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.litSourcesListView);
            this.Controls.Add(this.addSourceBtn);
            this.Name = "Form1";
            this.Text = "BiblioReferences";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSourceBtn;
        private System.Windows.Forms.ListView litSourcesListView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox stylesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createStyle;
        private System.Windows.Forms.Button ExportToTxt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Authors;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ListView selectedLitSourcesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Button editStyle;
        private Button EditSource;
    }
}

