using EditMyLibrary__EF.ViewModel.AuthorViewModels;
using Models.Entities;
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

namespace EditMyLibrary__EF.Views.AuthorViews
{
    /// <summary>
    /// Interaction logic for UpdateAuthorView.xaml
    /// </summary>
    public partial class UpdateAuthorView : Window
    {
        public UpdateAuthorView(Author SelectedAuthor)
        {
            InitializeComponent();
            DataContext = new UpdateAuthorViewModel(SelectedAuthor);
        }
    }
}
