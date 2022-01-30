using Librarian.Core.LiterarySources;
using Librarian.Core.MongoDb;
using Librarian.Core.References;
using Librarian.Core.Styles;
using NPOI.XWPF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            stylesComboBox.Items.Clear();
            stylesComboBox.Text = "";
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
            litSourcesListView.Items.Clear();
            ListViewItem item = new ListViewItem();
            for (int i = 0; i < _literarySources.Count; i++)
            {
                item = new ListViewItem(_literarySources[i].Title);
                item.SubItems.Add(String.Join("; ", _literarySources[i].Authors));
                item.SubItems.Add(_literarySources[i].LiterarySourceType.ToString());
                item.SubItems.Add(i.ToString());
                litSourcesListView.Items.Add(item);
            }
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

        private void createStyle_Click(object sender, EventArgs e)
        {
            using (CreateStyle form = new CreateStyle(_mongoDb))
            {
                form.ShowDialog();

                LoadStyles();
            }
        }

        private void ExportToTxt_Click(object sender, EventArgs e)
        {
            if (stylesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите стиль");
                return;
            }
            if (selectedLitSourcesListView.Items.Count == 0)
            {
                MessageBox.Show("Сначала выберите лит. источники");
                return;
            }
            
            string styleName = stylesComboBox.SelectedItem.ToString();
            Style style = _styles.Where(x => x.Name == styleName).First();
            List<string> litSourceTitle = new List<string>();
            List<LiterarySource> sources  = new List<LiterarySource>();
            foreach (var item in selectedLitSourcesListView.Items)
            {
                var lvItem = item as ListViewItem;
                litSourceTitle.Add(lvItem.Text);
            }
            foreach (var title in litSourceTitle)
            {
                sources.Add(_literarySources.Where(x => x.Title == title).First());
            }

            StringBuilder sb = new StringBuilder();
            int index = 1;
            foreach (var source in sources)
            {
                var builder = new ReferenceBuilder(source, style);
                sb.Append($"{index}. {builder.Build()} \n");
                index++;
            }
            File.WriteAllText($"Литературные источники {DateTime.Now.ToString("dd.MM.yy HH-mm-ss")}.txt", sb.ToString());
            //Console.WriteLine(builder.Build());
        }

        private void editStyle_Click(object sender, EventArgs e)
        {
            if (stylesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите стиль");
            }
            else
            {
                string styleName = stylesComboBox.SelectedItem.ToString();
                Style style = _styles.Where(x => x.Name == styleName).First();
                using (CreateStyle form = new CreateStyle(_mongoDb, style))
                {
                    form.ShowDialog();

                    LoadStyles();
                }
            }
        }

        private void EditSource_Click(object sender, EventArgs e)
        {
            if (litSourcesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Сначала выберите источник");
            }
            else
            {
                string title = litSourcesListView.SelectedItems[0].Text;
                LiterarySource source = _literarySources.Where(x => x.Title == title).First();
                using (CreateLiterarySource form = new CreateLiterarySource(_mongoDb, source))
                {
                    form.ShowDialog();

                    LoadLitSources();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.MoveListViewItems(selectedLitSourcesListView, MoveDirection.Up);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.MoveListViewItems(selectedLitSourcesListView, MoveDirection.Down);
        }

        private void exportToDoc_Click(object sender, EventArgs e)
        {
            if (stylesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите стиль");
                return;
            }
            if (selectedLitSourcesListView.Items.Count == 0)
            {
                MessageBox.Show("Сначала выберите лит. источники");
                return;
            }

            string styleName = stylesComboBox.SelectedItem.ToString();
            Style style = _styles.Where(x => x.Name == styleName).First();
            List<string> litSourceTitle = new List<string>();
            List<LiterarySource> sources = new List<LiterarySource>();
            foreach (var item in selectedLitSourcesListView.Items)
            {
                var lvItem = item as ListViewItem;
                litSourceTitle.Add(lvItem.Text);
            }
            foreach (var title in litSourceTitle)
            {
                sources.Add(_literarySources.Where(x => x.Title == title).First());
            }

            StringBuilder sb = new StringBuilder();

            XWPFDocument doc = new XWPFDocument();
            var numId = 1.ToString();
            XWPFParagraph par1 = doc.CreateParagraph();
            par1.Alignment = ParagraphAlignment.CENTER;
            XWPFRun run1 = par1.CreateRun();
            run1.FontFamily = "Times New Roman";
            run1.FontSize = 16;
            run1.IsBold = true;
            run1.SetText("Список литературы");
            foreach (var source in sources)
            {
                var builder = new ReferenceBuilder(source, style);
                XWPFParagraph par = doc.CreateParagraph();
                par.SetNumID(numId);
                XWPFRun run = par.CreateRun();
                run.FontFamily = "Times New Roman";
                run.FontSize = 14;
                run.SetText(builder.Build());
            }


            FileStream fs = new FileStream($"Литературные источники {DateTime.Now.ToString("dd.MM.yy HH-mm-ss")}.docx", FileMode.Create);
            doc.Write(fs);
            fs.Close();
            MessageBox.Show("Экспорт завершён");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (stylesComboBox.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите стиль");
                return;
            }
            if (selectedLitSourcesListView.Items.Count == 0)
            {
                MessageBox.Show("Сначала выберите лит. источники");
                return;
            }

            string styleName = stylesComboBox.SelectedItem.ToString();
            Style style = _styles.Where(x => x.Name == styleName).First();
            List<string> litSourceTitle = new List<string>();
            List<LiterarySource> sources = new List<LiterarySource>();
            foreach (var item in selectedLitSourcesListView.Items)
            {
                var lvItem = item as ListViewItem;
                litSourceTitle.Add(lvItem.Text);
            }
            foreach (var title in litSourceTitle)
            {
                sources.Add(_literarySources.Where(x => x.Title == title).First());
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Word files (.docx ,.doc)|*.docx;*.doc";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var template = dialog.FileName;
                using (var rs = File.OpenRead(template))
                {
                    var generateFile = $"Литературные источники {DateTime.Now.ToString("dd.MM.yy HH-mm-ss")}.docx";
                    using (var ws = File.Create(generateFile))
                    {
                        var doc = new XWPFDocument(rs);
                        var numId = 1.ToString();
                        XWPFParagraph par1 = doc.CreateParagraph();
                        par1.Alignment = ParagraphAlignment.CENTER;
                        XWPFRun run1 = par1.CreateRun();
                        run1.FontFamily = "Times New Roman";
                        run1.FontSize = 16;
                        run1.IsBold = true;
                        run1.SetText("Список литературы");
                        foreach (var source in sources)
                        {
                            var builder = new ReferenceBuilder(source, style);
                            XWPFParagraph par = doc.CreateParagraph();
                            par.SetNumID(numId);
                            XWPFRun run = par.CreateRun();
                            run.FontFamily = "Times New Roman";
                            run.FontSize = 14;
                            run.SetText(builder.Build());
                        }
                        doc.Write(ws);
                        MessageBox.Show("Экспорт завершён");
                    }
                }
            }

            
        }
    }
}
