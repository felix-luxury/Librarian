using Librarian.Core.MongoDb;
using Librarian.Core.Styles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Librarian.WinForms
{
    public partial class StyleFamilyManager : Form
    {
        private List<StyleFamily> _families;
        private MongoConnection _mongo;
        public StyleFamilyManager(MongoConnection mongo)
        {
            InitializeComponent();
            familiesLB.ValueMember = "Name";
            _mongo = mongo;

            ReloadFamilies();
        }
        private void ReloadFamilies()
        {
            familiesLB.SelectedIndex = -1;
            stylesLB.Items.Clear();
            familiesLB.Items.Clear();
            _families = _mongo.GetStyleFamilies();
            foreach (var family in _families)
            {
                familiesLB.Items.Add(family);
            }
        }

        private void familiesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (familiesLB.SelectedIndex == -1)
            {
                createStyleBtn.Enabled = false;
                renameFamilyBtn.Enabled = false;
                deleteFamilyBtn.Enabled = false;
            }
            else
            {
                createStyleBtn.Enabled = true;
                renameFamilyBtn.Enabled = true;
                deleteFamilyBtn.Enabled = true;
            }
            stylesLB.Items.Clear();
            ReloadFamily();
        }

        private void createFamilyBtn_Click(object sender, EventArgs e)
        {
            using (Prompt dialog = new Prompt("Введите имя нового семейства", "Новое семейство стилей"))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var name = dialog.Text;
                    StyleFamily family = new StyleFamily();
                    family.Name = name;
                    _mongo.InsertStyleFamily(family);
                    MessageBox.Show("Стиль добавлен");
                    ReloadFamilies();
                }
            }
        }

        private void createStyleBtn_Click(object sender, EventArgs e)
        {
            using (CreateStyle form = new CreateStyle(_mongo, familiesLB.SelectedItem as StyleFamily))
            {
                form.ShowDialog();

                ReloadFamily();
            }
        }

        private void ReloadFamily()
        {
            stylesLB.Items.Clear();
            if (familiesLB.SelectedIndex != -1)
            {
                StyleFamily family = familiesLB.SelectedItem as StyleFamily;
                foreach (var style in family.Styles)
                {
                    stylesLB.Items.Add(style.Value);
                }
            }
        }

        private void editStyleBtn_Click(object sender, EventArgs e)
        {
            if (stylesLB.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите стиль");
            }
            using (CreateStyle form = new CreateStyle(_mongo, (StyleFamily)familiesLB.SelectedItem, (Style)stylesLB.SelectedItem))
            {
                form.ShowDialog();

                ReloadFamily();
            }
        }

        private void stylesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stylesLB.SelectedIndex == -1)
            {
                editStyleBtn.Enabled = false;
            }
            else
            {
                editStyleBtn.Enabled = true;
            }
        }

        private void renameFamilyBtn_Click(object sender, EventArgs e)
        {
            using (Prompt dialog = new Prompt("Введите новое имя семейства", "Переименовать семейство"))
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var family = (StyleFamily)familiesLB.SelectedItem;
                    var name = dialog.Text;
                    family.Name = name;
                    _mongo.UpsertStyleFamily(family.Id,family);
                    MessageBox.Show("Стиль переименован");
                    ReloadFamilies();
                }
            }
        }

        private void deleteFamilyBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить семейство?", "Удалить семейство", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var family = (StyleFamily)familiesLB.SelectedItem;
                _mongo.DeleteStyleFamily(family.Id);
                MessageBox.Show("Семейство удалено");
                ReloadFamilies();
            }
        }
    }
    public class Prompt : IDisposable
    {
        public string Text { get; set; }
        private Form _form;
        public Prompt(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Width = 400, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ок", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Отмена", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.Cancel };
            confirmation.Click += (sender, e) => { Text = textBox.Text; prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;
            _form = prompt;
        }

        public void Dispose()
        {
            _form.Dispose();
        }

        public DialogResult ShowDialog()
        {
            return _form.ShowDialog();
        }
    }
}
