using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Librarian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Publication> Publications;
        Personal PersonalWindow;
        public MainWindow()
        {
            InitializeComponent();
            Publications = new List<Publication>();
            PersonalWindow = new Personal() { Visibility = Visibility.Hidden, W = this };
        }

        private void b_login_Click(object sender, RoutedEventArgs e)
        {
            PersonalWindow.Prepare();
            PersonalWindow.Visibility = Visibility.Visible;
            this.Visibility = Visibility.Hidden;
        }

        private void t_Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void b_Add_Click(object sender, RoutedEventArgs e)
        //{

        //    Publication p = new Publication()
        //    {
        //        Title = t_Title.Text,
        //        Author = t_Author.Text
        //    };
        //    Publications.Add(p);
        //}
    }
}
