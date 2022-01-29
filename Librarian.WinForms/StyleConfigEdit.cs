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
    public partial class StyleConfigEdit : Form
    {
        private StyleConfig _config;
        public StyleConfigEdit(StyleConfig config)
        {
            InitializeComponent();
            _config = config;

            authorsPrefixTextBox.Text = _config.AuthorPrefix;
            authorsPostfixTextBox.Text = _config.AuthorPostfix;
            authorsDelimiterTextBox.Text = _config.AuthorDelimiter;
            authorsLastDelimiterTextBox.Text = _config.AuthorLastDelimiter;
            yearPrefixTextBox.Text = _config.YearPrefix;
            yearPostfixTextBox.Text = _config.YearPostfix;
            titlePrefixTextBox.Text = _config.TitlePrefix;
            titlePostfixTextBox.Text = _config.TitlePostfix;
            journalPrefixTextBox.Text = _config.JournalTitlePrefix;
            journalPostfixTextBox.Text = _config.JournalTitlePostfix;
            datePrefixTextBox.Text = _config.DatePrefix;
            datePostfixTextBox.Text = _config.DatePostfix;
            dateFormatTextBox.Text = _config.DateFormat;
            sourcePrefixTextBox.Text = _config.SourcePrefix;
            sourcePostfixTextBox.Text = _config.SourcePostfix;
            EditionNumberPrefixTB.Text = _config.EditionNumberPrefix;
            EditionNumberPostfixTB.Text = _config.EditionNumberPostfix;
            PageNumberPrefixTB4.Text = _config.PageNumberPrefix;
            PageNumberPostfixTB.Text = _config.PageNumberPostfix;
            PageCountPrefixTB.Text = _config.PageCountPrefix;
            PageCountPostfixTB.Text = _config.PageCountPostfix;
            CityPrefixTb.Text = _config.CityPrefix;
            CityPostfixTb.Text = _config.CityPostfix;
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            _config.AuthorPrefix = authorsPrefixTextBox.Text;
            _config.AuthorPostfix = authorsPostfixTextBox.Text;
            _config.AuthorDelimiter = authorsDelimiterTextBox.Text;
            _config.AuthorLastDelimiter = authorsLastDelimiterTextBox.Text;
            _config.YearPrefix = yearPrefixTextBox.Text;
            _config.YearPostfix = yearPostfixTextBox.Text;
            _config.TitlePrefix = titlePrefixTextBox.Text;
            _config.TitlePostfix = titlePostfixTextBox.Text;
            _config.JournalTitlePrefix = journalPrefixTextBox.Text;
            _config.JournalTitlePostfix = journalPostfixTextBox.Text;
            _config.DatePrefix = datePrefixTextBox.Text;
            _config.DatePostfix = datePostfixTextBox.Text;
            _config.DateFormat = dateFormatTextBox.Text;
            _config.SourcePrefix = sourcePrefixTextBox.Text;
            _config.SourcePostfix = sourcePostfixTextBox.Text;
            _config.EditionNumberPrefix = EditionNumberPrefixTB.Text;
            _config.EditionNumberPostfix = EditionNumberPostfixTB.Text;
            _config.PageNumberPrefix = PageNumberPrefixTB4.Text;
            _config.PageNumberPostfix = PageNumberPostfixTB.Text;
            _config.PageCountPrefix = PageCountPrefixTB.Text;
            _config.PageCountPostfix = PageCountPostfixTB.Text;
            _config.CityPrefix = CityPrefixTb.Text;
            _config.CityPostfix = CityPostfixTb.Text;

            this.Close();
        }

    }
}
