using EditMyLibrary__EF.Models;
using EditMyLibrary__EF.Views.AuthorViews;
using GalaSoft.MvvmLight.Command;
using Models.Entities;
using System.Collections.Generic;

using System.Windows;

namespace EditMyLibrary__EF.ViewModel.AuthorViewModels
{
    public class AuthorViewModel : ObservableObject
    {
        #region Fields
        private List<Author> authors;
        public List<Author>? Authors
        {
            get => authors;
            set
            {
                authors = value;
                OnPropertyChanged();
            }
        }
        public Author SelectedAuthor { get; set; }
        public RelayCommand UpdateCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }

        #endregion

        public AuthorViewModel()
        {
            Authors = MyLibrary.Authors;
            UpdateCommand = new(update);
            DeleteCommand = new(delete);
        }

        #region Functions of command
        private void update()
        {
            Application.Current.MainWindow.Hide();
            UpdateAuthorView updateAuthorView = new(SelectedAuthor);
            Application.Current.MainWindow = updateAuthorView;
            updateAuthorView.ShowDialog();
        }
        private void delete()
        {
            Authors.Remove(SelectedAuthor);
        }
        #endregion
    }
}
