
namespace Librarian.WinForms
{
    partial class StyleFamilyManager
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
            this.familiesLB = new System.Windows.Forms.ListBox();
            this.stylesLB = new System.Windows.Forms.ListBox();
            this.createFamilyBtn = new System.Windows.Forms.Button();
            this.createStyleBtn = new System.Windows.Forms.Button();
            this.editStyleBtn = new System.Windows.Forms.Button();
            this.renameFamilyBtn = new System.Windows.Forms.Button();
            this.deleteFamilyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // familiesLB
            // 
            this.familiesLB.FormattingEnabled = true;
            this.familiesLB.ItemHeight = 15;
            this.familiesLB.Location = new System.Drawing.Point(13, 13);
            this.familiesLB.Name = "familiesLB";
            this.familiesLB.Size = new System.Drawing.Size(254, 424);
            this.familiesLB.TabIndex = 0;
            this.familiesLB.SelectedIndexChanged += new System.EventHandler(this.familiesLB_SelectedIndexChanged);
            // 
            // stylesLB
            // 
            this.stylesLB.FormattingEnabled = true;
            this.stylesLB.ItemHeight = 15;
            this.stylesLB.Location = new System.Drawing.Point(273, 13);
            this.stylesLB.Name = "stylesLB";
            this.stylesLB.Size = new System.Drawing.Size(254, 424);
            this.stylesLB.TabIndex = 1;
            this.stylesLB.SelectedIndexChanged += new System.EventHandler(this.stylesLB_SelectedIndexChanged);
            // 
            // createFamilyBtn
            // 
            this.createFamilyBtn.Location = new System.Drawing.Point(534, 13);
            this.createFamilyBtn.Name = "createFamilyBtn";
            this.createFamilyBtn.Size = new System.Drawing.Size(97, 43);
            this.createFamilyBtn.TabIndex = 2;
            this.createFamilyBtn.Text = "Создать семейство";
            this.createFamilyBtn.UseVisualStyleBackColor = true;
            this.createFamilyBtn.Click += new System.EventHandler(this.createFamilyBtn_Click);
            // 
            // createStyleBtn
            // 
            this.createStyleBtn.Enabled = false;
            this.createStyleBtn.Location = new System.Drawing.Point(534, 62);
            this.createStyleBtn.Name = "createStyleBtn";
            this.createStyleBtn.Size = new System.Drawing.Size(97, 43);
            this.createStyleBtn.TabIndex = 3;
            this.createStyleBtn.Text = "Создать стиль";
            this.createStyleBtn.UseVisualStyleBackColor = true;
            this.createStyleBtn.Click += new System.EventHandler(this.createStyleBtn_Click);
            // 
            // editStyleBtn
            // 
            this.editStyleBtn.Enabled = false;
            this.editStyleBtn.Location = new System.Drawing.Point(637, 62);
            this.editStyleBtn.Name = "editStyleBtn";
            this.editStyleBtn.Size = new System.Drawing.Size(105, 43);
            this.editStyleBtn.TabIndex = 4;
            this.editStyleBtn.Text = "Изменить стиль";
            this.editStyleBtn.UseVisualStyleBackColor = true;
            this.editStyleBtn.Click += new System.EventHandler(this.editStyleBtn_Click);
            // 
            // renameFamilyBtn
            // 
            this.renameFamilyBtn.Enabled = false;
            this.renameFamilyBtn.Location = new System.Drawing.Point(637, 13);
            this.renameFamilyBtn.Name = "renameFamilyBtn";
            this.renameFamilyBtn.Size = new System.Drawing.Size(105, 43);
            this.renameFamilyBtn.TabIndex = 5;
            this.renameFamilyBtn.Text = "Переименовать семейство";
            this.renameFamilyBtn.UseVisualStyleBackColor = true;
            this.renameFamilyBtn.Click += new System.EventHandler(this.renameFamilyBtn_Click);
            // 
            // deleteFamilyBtn
            // 
            this.deleteFamilyBtn.Enabled = false;
            this.deleteFamilyBtn.Location = new System.Drawing.Point(748, 13);
            this.deleteFamilyBtn.Name = "deleteFamilyBtn";
            this.deleteFamilyBtn.Size = new System.Drawing.Size(105, 43);
            this.deleteFamilyBtn.TabIndex = 6;
            this.deleteFamilyBtn.Text = "Удалить семейство";
            this.deleteFamilyBtn.UseVisualStyleBackColor = true;
            this.deleteFamilyBtn.Click += new System.EventHandler(this.deleteFamilyBtn_Click);
            // 
            // StyleFamilyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.deleteFamilyBtn);
            this.Controls.Add(this.renameFamilyBtn);
            this.Controls.Add(this.editStyleBtn);
            this.Controls.Add(this.createStyleBtn);
            this.Controls.Add(this.createFamilyBtn);
            this.Controls.Add(this.stylesLB);
            this.Controls.Add(this.familiesLB);
            this.Name = "StyleFamilyManager";
            this.Text = "StyleFamilyManager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox familiesLB;
        private System.Windows.Forms.ListBox stylesLB;
        private System.Windows.Forms.Button createFamilyBtn;
        private System.Windows.Forms.Button createStyleBtn;
        private System.Windows.Forms.Button editStyleBtn;
        private System.Windows.Forms.Button renameFamilyBtn;
        private System.Windows.Forms.Button deleteFamilyBtn;
    }
}