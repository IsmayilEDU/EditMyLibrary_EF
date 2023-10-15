using ConsoleApp1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EditMyLibrary__EF.ViewModel.AuthorViewModels
{
    internal class UpdateAuthorViewModel
    {
        #region Fields
        public Author SelectedAuthor { get; set; }
        private TextBox FirstName_Textbox;
        private TextBox LastName_Textbox;
        #endregion
        public UpdateAuthorViewModel(Author selectedAuthor)
        {
            SelectedAuthor = selectedAuthor;
        }
    }
}
