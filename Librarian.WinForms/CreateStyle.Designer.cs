
namespace Librarian.WinForms
{
    partial class CreateStyle
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
            this.fieldsLB = new System.Windows.Forms.ListBox();
            this.addFieldBtn = new System.Windows.Forms.Button();
            this.fieldsCB = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.configBtn = new System.Windows.Forms.Button();
            this.saveStyle = new System.Windows.Forms.Button();
            this.styleNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.styleTypeCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteStyleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fieldsLB
            // 
            this.fieldsLB.FormattingEnabled = true;
            this.fieldsLB.ItemHeight = 15;
            this.fieldsLB.Location = new System.Drawing.Point(13, 130);
            this.fieldsLB.Name = "fieldsLB";
            this.fieldsLB.Size = new System.Drawing.Size(120, 154);
            this.fieldsLB.TabIndex = 0;
            this.fieldsLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fieldsLB_MouseDoubleClick);
            // 
            // addFieldBtn
            // 
            this.addFieldBtn.Location = new System.Drawing.Point(12, 86);
            this.addFieldBtn.Name = "addFieldBtn";
            this.addFieldBtn.Size = new System.Drawing.Size(121, 23);
            this.addFieldBtn.TabIndex = 1;
            this.addFieldBtn.Text = "Добавить поле";
            this.addFieldBtn.UseVisualStyleBackColor = true;
            this.addFieldBtn.Click += new System.EventHandler(this.addFieldBtn_Click);
            // 
            // fieldsCB
            // 
            this.fieldsCB.FormattingEnabled = true;
            this.fieldsCB.Location = new System.Drawing.Point(12, 57);
            this.fieldsCB.Name = "fieldsCB";
            this.fieldsCB.Size = new System.Drawing.Size(121, 23);
            this.fieldsCB.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "↓";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список полей";
            // 
            // configBtn
            // 
            this.configBtn.Location = new System.Drawing.Point(139, 218);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(130, 66);
            this.configBtn.TabIndex = 6;
            this.configBtn.Text = "Конфигурация \r\nстиля";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.configBtn_Click);
            // 
            // saveStyle
            // 
            this.saveStyle.Location = new System.Drawing.Point(13, 290);
            this.saveStyle.Name = "saveStyle";
            this.saveStyle.Size = new System.Drawing.Size(121, 23);
            this.saveStyle.TabIndex = 7;
            this.saveStyle.Text = "Сохранить стиль";
            this.saveStyle.UseVisualStyleBackColor = true;
            this.saveStyle.Click += new System.EventHandler(this.saveStyle_Click);
            // 
            // styleNameTB
            // 
            this.styleNameTB.Location = new System.Drawing.Point(12, 27);
            this.styleNameTB.Name = "styleNameTB";
            this.styleNameTB.Size = new System.Drawing.Size(100, 23);
            this.styleNameTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Название стиля";
            // 
            // styleTypeCB
            // 
            this.styleTypeCB.FormattingEnabled = true;
            this.styleTypeCB.Location = new System.Drawing.Point(139, 27);
            this.styleTypeCB.Name = "styleTypeCB";
            this.styleTypeCB.Size = new System.Drawing.Size(121, 23);
            this.styleTypeCB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тип стиля";
            // 
            // deleteStyleBtn
            // 
            this.deleteStyleBtn.Location = new System.Drawing.Point(139, 290);
            this.deleteStyleBtn.Name = "deleteStyleBtn";
            this.deleteStyleBtn.Size = new System.Drawing.Size(121, 23);
            this.deleteStyleBtn.TabIndex = 12;
            this.deleteStyleBtn.Text = "Удалить стиль";
            this.deleteStyleBtn.UseVisualStyleBackColor = true;
            this.deleteStyleBtn.Visible = false;
            this.deleteStyleBtn.Click += new System.EventHandler(this.deleteStyleBtn_Click);
            // 
            // CreateStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 327);
            this.Controls.Add(this.deleteStyleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.styleTypeCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.styleNameTB);
            this.Controls.Add(this.saveStyle);
            this.Controls.Add(this.configBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fieldsCB);
            this.Controls.Add(this.addFieldBtn);
            this.Controls.Add(this.fieldsLB);
            this.Name = "CreateStyle";
            this.Text = "Создать стиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fieldsLB;
        private System.Windows.Forms.Button addFieldBtn;
        private System.Windows.Forms.ComboBox fieldsCB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Button saveStyle;
        private System.Windows.Forms.TextBox styleNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox styleTypeCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteStyleBtn;
    }
}