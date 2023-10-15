using Models.Entities;

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
