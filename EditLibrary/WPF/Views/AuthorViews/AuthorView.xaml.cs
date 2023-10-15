using EditMyLibrary__EF.ViewModel.AuthorViewModels;
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
using System.Windows.Shapes;

namespace EditMyLibrary__EF.Views
{
    /// <summary>
    /// Interaction logic for AuthorView.xaml
    /// </summary>
    public partial class AuthorView : Window
    {
        public AuthorView()
        {
            InitializeComponent();
            DataContext = new AuthorViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Hide();
            MainWindowView mainWindowView = new();
            Application.Current.MainWindow = mainWindowView;
            mainWindowView.ShowDialog();
        }
    }
}
