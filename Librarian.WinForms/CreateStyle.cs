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
        private bool _idEdit = false;

        public CreateStyle(MongoConnection mongoConnection)
        {
            InitializeComponent();
            _config = new StyleConfig();
            _mongo = mongoConnection;
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
        }

        public CreateStyle(MongoConnection mongoConnection, Style style) : this(mongoConnection)
        {
            _style = style;
            _idEdit = true;
            _config = style.Config;
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
            if (_idEdit)
            {
                _style.Config = _config;
                _style.Name = styleNameTB.Text;
                _style.Fields = GetFields();
                _mongo.UpsertStyle(_style.Id, _style);
            }
            else
            {
                FieldType[] fields = GetFields();
                Style style = new Style(styleNameTB.Text, fields, _config);
                _mongo.InsertStyle(style);
            }

            MessageBox.Show("Стиль сохранён");
            this.Close();
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
    }
}
