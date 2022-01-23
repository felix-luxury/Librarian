using Librarian.Core.LiterarySources;
using Librarian.Core.MongoDb;
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
    public partial class Form1 : Form
    {
        private MongoConnection _mongoDb;
        private List<LiterarySource> _literarySources;
        private List<Style> _styles;
        public List<LiterarySource> SelectedLiterarySources
        {
            get
            {
                var result = new List<LiterarySource>();
                foreach (ListViewItem item in selectedLitSourcesListView.Items)
                {
                    var index = int.Parse(item.SubItems[3].Text);
                    result.Add(_literarySources[index]);
                }
                return result;
            }
        }
        public Form1()
        {
            InitializeComponent();
            _mongoDb = new MongoConnection("mongodb://localhost:27017");
            _literarySources = new List<LiterarySource>();
            _styles = new List<Style>();
            LoadLitSources();
            LoadStyles();
        }

        private void LoadStyles()
        {
            _styles = _mongoDb.GetStyles();
            UpdateStylesComboBox();
        }

        private void UpdateStylesComboBox()
        {
            foreach (var item in _styles)
            {
                stylesComboBox.Items.Add(item.Name);
            }
        }

        private void LoadLitSources()
        {

            _literarySources = _mongoDb.GetLiterarySources();
            UpdateLitSourcesListView();
        }
        private void UpdateLitSourcesListView()
        {
            //litSourcesListView.Clear();
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < _literarySources.Count; i++)
            {
                item = new ListViewItem(_literarySources[i].Title);
                item.SubItems.Add(String.Join("; ", _literarySources[i].Authors));
                item.SubItems.Add(_literarySources[i].LiterarySourceType.ToString());
                item.SubItems.Add(i.ToString());
            }
            litSourcesListView.Items.Add(item);
        }
        private void UpdateSelectedLitSourcesListView()
        {
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < _literarySources.Count; i++)
            {
                item = new ListViewItem(_literarySources[i].Title);
                item.SubItems.Add(String.Join("; ", _literarySources[i].Authors));
                item.SubItems.Add(_literarySources[i].LiterarySourceType.ToString());
                item.SubItems.Add(i.ToString());
            }
            selectedLitSourcesListView.Items.Add(item);
        }

        private void litSourcesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (litSourcesListView.SelectedItems.Count == 1)
            {
                ListViewItem item = litSourcesListView.SelectedItems[0];
                selectedLitSourcesListView.Items.Add(item.Clone() as ListViewItem);
            }
            var a = SelectedLiterarySources;
        }

        private void selectedLitSourcesListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectedLitSourcesListView.SelectedItems.Count == 1)
            {
                selectedLitSourcesListView.Items.Remove(selectedLitSourcesListView.SelectedItems[0]);
            }
        }

        private void createLitSource_Click(object sender, EventArgs e)
        {
            using(CreateLiterarySource form = new CreateLiterarySource(_mongoDb))
            {
                form.ShowDialog();

                LoadLitSources();
            }
        }
    }
}
