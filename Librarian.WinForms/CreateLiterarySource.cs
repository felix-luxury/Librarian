using Librarian.Core.LiterarySources;
using Librarian.Core.MongoDb;
using System;
using System.Windows.Forms;

namespace Librarian.WinForms
{
    public partial class CreateLiterarySource : Form
    {
        private MongoConnection _mongo;
        public CreateLiterarySource(MongoConnection mongoConnection)
        {
            InitializeComponent();
            _mongo = mongoConnection;
            sourceTypeComboBox.Items.Add(LiterarySourceType.Book);
            sourceTypeComboBox.Items.Add(LiterarySourceType.JournalArticle);
            sourceTypeComboBox.Items.Add(LiterarySourceType.ScienceArticle);
            sourceTypeComboBox.Items.Add(LiterarySourceType.WebArtice);
            HideAllFields();
        }

        private void addAuthorBtn_Click(object sender, EventArgs e)
        {
            if (newAuthorTextBox.Text.Length > 0)
            {
                var newAuthor = newAuthorTextBox.Text;
                authorsListBox.Items.Add(newAuthor);
                newAuthorTextBox.Text = "";
            }
        }

        private void authorsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (authorsListBox.SelectedItems.Count > 0)
            {
                authorsListBox.Items.Remove(authorsListBox.SelectedItems[0]);
            }
        }

        private void sourceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedType = (LiterarySourceType)(sourceTypeComboBox.SelectedItem ?? LiterarySourceType.Default);
            HideAllFields();
            switch (selectedType)
            {
                case LiterarySourceType.Default:
                    break;
                case LiterarySourceType.Book:
                    editionNumberTB.Visible = true;
                    pageCountTB.Visible = true;
                    cityTB.Visible = true;
                    publisherTB.Visible = true;
                    publishYearTB.Visible = true;
                    break;
                case LiterarySourceType.JournalArticle:
                    editionNumberTB.Visible = true;
                    pageCountTB.Visible = true;
                    cityTB.Visible = true;
                    publisherTB.Visible = true;
                    publishYearTB.Visible = true;
                    journalTitleTB.Visible = true;
                    break;
                case LiterarySourceType.ScienceArticle:
                    pageCountTB.Visible = true;
                    cityTB.Visible = true;
                    publisherTB.Visible = true;
                    publishYearTB.Visible = true;
                    break;
                case LiterarySourceType.WebArtice:
                    publishYearTB.Visible = true;
                    urlTB.Visible = true;
                    readDateDP.Visible = true;
                    break;
                default:
                    break;
            }
        }
        private void HideAllFields()
        {
            editionNumberTB.Visible = false;
            pageCountTB.Visible = false;
            cityTB.Visible = false;
            publisherTB.Visible = false;
            publishYearTB.Visible = false;
            urlTB.Visible = false;
            pageNumberTB.Visible = false;
            journalTitleTB.Visible = false;
            readDateDP.Visible = false;
        }

        private void authorUpBtn_Click(object sender, EventArgs e)
        {
            if (authorsListBox.SelectedItems.Count > 0)
            {
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            LiterarySourceType selectedType = (LiterarySourceType)(sourceTypeComboBox.SelectedItem ?? LiterarySourceType.Default);

            LiterarySource source = new LiterarySource();
            switch (selectedType)
            {
                case LiterarySourceType.Default:
                    MessageBox.Show("Пожалуйста, выберите тип источника");
                    break;
                case LiterarySourceType.Book:
                    break;
                case LiterarySourceType.JournalArticle:
                    break;
                case LiterarySourceType.ScienceArticle:
                    break;
                case LiterarySourceType.WebArtice:
                    break;
                default:
                    break;
            }
            //_mongo.InsertLitSource();
        }
    }
}
