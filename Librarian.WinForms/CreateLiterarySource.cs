using Librarian.Core.LiterarySources;
using Librarian.Core.MongoDb;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Librarian.WinForms
{
    public partial class CreateLiterarySource : Form
    {
        private MongoConnection _mongo;
        private LiterarySource _source;
        private bool _isEdit = false;

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

        public CreateLiterarySource(MongoConnection mongoConnection, LiterarySource source) : this(mongoConnection)
        {
            deleteBtn.Visible = true;
            _source = source;
            _isEdit = true;
            sourceTypeComboBox.SelectedItem = source.LiterarySourceType;
            foreach (var author in source.Authors)
            {
                authorsListBox.Items.Add(author);
            }
            titleTB.Text = source.Title;
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
                    editionNumberL.Visible = true;
                    editionNumberTB.Visible = true;
                    pageCountL.Visible = true;
                    pageCountTB.Visible = true;
                    pageNumberL.Visible = true;
                    pageNumberTB.Visible = true;
                    cityL.Visible = true;
                    cityTB.Visible = true;
                    publisherL.Visible = true;
                    publisherTB.Visible = true;
                    yearL.Visible = true;
                    publishYearTB.Visible = true;
                    journalTitleL.Visible = true;
                    journalTitleTB.Visible = true;
                    break;
                case LiterarySourceType.JournalArticle:
                    editionNumberL.Visible = true;
                    editionNumberTB.Visible = true;
                    pageCountL.Visible = true;
                    pageCountTB.Visible = true;
                    pageNumberL.Visible = true;
                    pageNumberTB.Visible = true;
                    cityL.Visible = true;
                    cityTB.Visible = true;
                    publisherL.Visible = true;
                    publisherTB.Visible = true;
                    yearL.Visible = true;
                    publishYearTB.Visible = true;
                    journalTitleL.Visible = true;
                    journalTitleTB.Visible = true;
                    break;
                case LiterarySourceType.ScienceArticle:
                    pageCountL.Visible = true;
                    pageCountTB.Visible = true;
                    cityL.Visible = true;
                    cityTB.Visible = true;
                    publisherL.Visible = true;
                    publisherTB.Visible = true;
                    yearL.Visible = true;
                    publishYearTB.Visible = true;
                    break;
                case LiterarySourceType.WebArtice:
                    cityL.Visible = true;
                    cityTB.Visible = true;
                    publisherL.Visible = true;
                    publisherTB.Visible = true;
                    yearL.Visible = true;
                    publishYearTB.Visible = true;
                    urlL.Visible = true;
                    urlTB.Visible = true;
                    readDateL.Visible = true;
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

            editionNumberL.Visible = false;
            pageCountL.Visible = false;
            cityL.Visible = false;
            publisherL.Visible = false;
            yearL.Visible = false;
            urlL.Visible = false;
            pageNumberL.Visible = false;
            journalTitleL.Visible = false;
            readDateL.Visible = false;
        }

        private void authorUpBtn_Click(object sender, EventArgs e)
        {

            Program.MoveListBoxItems(authorsListBox, MoveDirection.Up);
        }
        private string[] GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (var author in authorsListBox.Items)
            {
                authors.Add(author.ToString());
            }
            return authors.ToArray();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (_isEdit)
            {
                UpdateSource(_source);
                _mongo.UpsertLiterarySources(_source.Id, _source);
                MessageBox.Show("Источник обновлён");
            }
            else
            {
                LiterarySource source = new LiterarySource();
                UpdateSource(source);
                _mongo.InsertLitSource(source);
                MessageBox.Show("Источник добавлен");
            }
        }

        private void UpdateSource(LiterarySource source)
        {
            LiterarySourceType selectedType = (LiterarySourceType)(sourceTypeComboBox.SelectedItem ?? LiterarySourceType.Default);
            PublishInfo publishInfo = new PublishInfo();
            source.Authors = GetAuthors();
            source.Title = titleTB.Text;
            switch (selectedType)
            {
                case LiterarySourceType.Default:
                    MessageBox.Show("Пожалуйста, выберите тип источника");
                    break;
                case LiterarySourceType.Book:
                    source.LiterarySourceType = LiterarySourceType.Book;
                    source.EditionNumber = editionNumberTB.Text;
                    source.PageCount = pageCountTB.Text;

                    publishInfo.City = cityTB.Text;
                    publishInfo.Publisher = publisherTB.Text;
                    publishInfo.Year = publishYearTB.Text;

                    source.PublishInfo = publishInfo;
                    break;
                case LiterarySourceType.JournalArticle:
                    source.LiterarySourceType = LiterarySourceType.JournalArticle;
                    source.EditionNumber = editionNumberTB.Text;
                    source.PageCount = pageCountTB.Text;
                    source.JournalTitle = journalTitleTB.Text;

                    publishInfo.City = cityTB.Text;
                    publishInfo.Publisher = publisherTB.Text;
                    publishInfo.Year = publishYearTB.Text;

                    source.PublishInfo = publishInfo;
                    break;
                case LiterarySourceType.ScienceArticle:
                    source.LiterarySourceType = LiterarySourceType.ScienceArticle;
                    source.PageCount = pageCountTB.Text;

                    publishInfo.City = cityTB.Text;
                    publishInfo.Publisher = publisherTB.Text;
                    publishInfo.Year = publishYearTB.Text;

                    source.PublishInfo = publishInfo;
                    break;
                case LiterarySourceType.WebArtice:
                    source.LiterarySourceType = LiterarySourceType.WebArtice;
                    source.Source = urlTB.Text;
                    source.ReadDate = readDateDP.Value;

                    publishInfo.City = cityTB.Text;
                    publishInfo.Publisher = publisherTB.Text;
                    publishInfo.Year = publishYearTB.Text;

                    source.PublishInfo = publishInfo;
                    break;
                default:
                    break;
            }
        }

        private void authorDownBtn_Click(object sender, EventArgs e)
        {
            Program.MoveListBoxItems(authorsListBox, MoveDirection.Down);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите удалить источник?", "Удалить источник", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _mongo.DeleteLitSource(_source.Id);
                MessageBox.Show("Источник удалён");
                this.Close();
            }

        }
    }
}
