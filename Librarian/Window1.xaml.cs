using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
// using Excel = Microsoft.Office.Interop.Excel;

namespace Librarian
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Personal : Window
    {
        public MainWindow W;
         // public Excel.Application Ex;
         // public Excel.Workbook wb;
         // public Excel.Worksheet psh;
        public Personal()
        {
            InitializeComponent();
        }

        private void Personal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // wb.Close();
            // Ex.Quit();
            W.Show();
            e.Cancel = true;
            this.Hide();
        }
        public void Prepare()
        {
            // Ex = new Excel.Application();
            // wb = Ex.Workbooks.Open(@"C:\Users\User\Desktop\My_Publications.xlsx");
            // psh = wb.Worksheets["Публикации"];
        }
        private void Window_Activated(object sender, EventArgs e)
        {
           // MessageBox.Show("Ku-ku!");

        }
        private string getval(dynamic r)
        {
            string c = "";
            if (r != null)
            {
                if (r.Value != null)
                {
                    c = r.Value.ToString();
                }
            }
            return c;
        }
        private void b_Add_Click(object sender, RoutedEventArgs e)
        {

            //int y = 1;
            //while (getval(psh.Cells[y, 1]) != "")
            //{
            //    ++y;
            //}
            //psh.Cells[y, 1].Value = c_Autor.Text;
            //psh.Cells[y, 2].Value = t_Title.Text;
            //wb.Save();
        }

        private void c_Publisher_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void c_Autor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
