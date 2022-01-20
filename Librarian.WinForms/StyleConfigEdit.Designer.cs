
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
            this.label1 = new System.Windows.Forms.Label();
            this.authorsPrefixTextBox = new System.Windows.Forms.TextBox();
            this.authorsPostfixTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Префикс авторов";
            // 
            // authorsPrefixTextBox
            // 
            this.authorsPrefixTextBox.Location = new System.Drawing.Point(12, 27);
            this.authorsPrefixTextBox.Name = "authorsPrefixTextBox";
            this.authorsPrefixTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorsPrefixTextBox.TabIndex = 1;
            // 
            // authorsPostfixTextBox
            // 
            this.authorsPostfixTextBox.Location = new System.Drawing.Point(122, 27);
            this.authorsPostfixTextBox.Name = "authorsPostfixTextBox";
            this.authorsPostfixTextBox.Size = new System.Drawing.Size(100, 23);
            this.authorsPostfixTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Постфикс авторов";
            // 
            // StyleConfigEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.authorsPostfixTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorsPrefixTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StyleConfigEdit";
            this.Text = "StyleConfigEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorsPrefixTextBox;
        private System.Windows.Forms.TextBox authorsPostfixTextBox;
        private System.Windows.Forms.Label label2;
    }
}