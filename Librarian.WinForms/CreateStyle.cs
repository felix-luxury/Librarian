using Librarian.Core.LiterarySources;
using Librarian.Core.MongoDb;
using Librarian.Core.References;
using Librarian.Core.Styles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarian.WinForms
{
    public partial class CreateStyle : Form
    {
        private StyleConfig _config;
        private MongoConnection _mongo;
        private Style _style;
        private StyleFamily _family;
        private bool _idEdit = false;

        public CreateStyle(MongoConnection mongoConnection, StyleFamily family)
        {
            InitializeComponent();
            _config = new StyleConfig();
            _mongo = mongoConnection;
            _family = family;


            fieldsCB.Items.Add(FieldType.Title);
            fieldsCB.Items.Add(FieldType.Authors);
            fieldsCB.Items.Add(FieldType.Publisher);
            fieldsCB.Items.Add(FieldType.City);
            fieldsCB.Items.Add(FieldType.ReadDate);
            fieldsCB.Items.Add(FieldType.JournalTitle);
            fieldsCB.Items.Add(FieldType.PageCount);
            fieldsCB.Items.Add(FieldType.PageNumber);
            fieldsCB.Items.Add(FieldType.EditionNumber);
            fieldsCB.Items.Add(FieldType.Source);
            fieldsCB.Items.Add(FieldType.Year);

            styleTypeCB.Items.Add(LiterarySourceType.Book);
            styleTypeCB.Items.Add(LiterarySourceType.Default);
            styleTypeCB.Items.Add(LiterarySourceType.JournalArticle);
            styleTypeCB.Items.Add(LiterarySourceType.ScienceArticle);
            styleTypeCB.Items.Add(LiterarySourceType.WebArtice);
        }

        public CreateStyle(MongoConnection mongoConnection, StyleFamily family, Style style) : this(mongoConnection, family)
        {
            deleteStyleBtn.Visible = true;
            _style = style;
            _idEdit = true;
            _config = style.Config;
            styleTypeCB.SelectedItem = _style.Type;
            styleNameTB.Text = style.Name;
            foreach (var field in style.Fields)
            {
                fieldsLB.Items.Add(field);
            }
        }

        private void addFieldBtn_Click(object sender, EventArgs e)
        {
            if (fieldsCB.Text.Length > 0)
            {
                fieldsLB.Items.Add(fieldsCB.SelectedItem);
            }
        }

        private void configBtn_Click(object sender, EventArgs e)
        {
            using (StyleConfigEdit form = new StyleConfigEdit(_config))
            {
                form.ShowDialog();
            }
        }
        private FieldType[] GetFields()
        {
            List<FieldType> fields = new List<FieldType>();
            foreach (var field in fieldsLB.Items)
            {
                fields.Add((FieldType)field);
            }

            return fields.ToArray();
        }
        private void saveStyle_Click(object sender, EventArgs e)
        {
            if (styleTypeCB.SelectedItem != null) {
                if (_idEdit)
                {
                    _style.Config = _config;
                    _style.Name = styleNameTB.Text;
                    _style.Fields = GetFields();
                    _family.Remove(_style.Type);
                    _family.Add(_style.Type, _style);
                    _mongo.UpsertStyleFamily(_family.Id, _family);
                }
                else
                {
                    FieldType[] fields = GetFields();
                    LiterarySourceType type = (LiterarySourceType)styleTypeCB.SelectedItem;
                    Style style = new Style(styleNameTB.Text, fields, _config, type);
                    _family.Add(style.Type, style);
                    _mongo.UpsertStyleFamily(_family.Id, _family);
                }

                MessageBox.Show("Стиль сохранён");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Выберите тип");
            }
        }

        private void fieldsLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fieldsLB.SelectedItems.Count == 1)
            {
                fieldsLB.Items.Remove(fieldsLB.SelectedItems[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.MoveListBoxItems(fieldsLB, MoveDirection.Up);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.MoveListBoxItems(fieldsLB, MoveDirection.Down);
        }

        private void deleteStyleBtn_Click(object sender, EventArgs e)
        {
            _family.Remove(_style.Type);
            _mongo.UpsertStyleFamily(_family.Id, _family);
            MessageBox.Show("Стиль удалён");
            this.Close();
        }
    }
}
