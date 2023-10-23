using Database.Contexts;
using EditMyLibrary__EF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace EditMyLibrary__EF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            LibraryDbContext context = new LibraryDbContext();
            MyLibrary.Authors = context.Authors.ToList();
            MyLibrary.Books = context.Books.ToList();
            MyLibrary.Categories = context.Categories.ToList();
            MyLibrary.Departments = context.Departments.ToList();
            MyLibrary.Faculties = context.Faculties.ToList();
            MyLibrary.Groups = context.Groups.ToList();
            MyLibrary.Libs = context.Libs.ToList();
            MyLibrary.Presses = context.Presses.ToList();
            MyLibrary.S_Cards = context.S_Cards.ToList();
            MyLibrary.Students = context.Students.ToList();
            MyLibrary.T_Cards = context.T_Cards.ToList();
            MyLibrary.Teachers = context.Teachers.ToList();
            MyLibrary.Themes = context.Themes.ToList();
        }
    }
}
