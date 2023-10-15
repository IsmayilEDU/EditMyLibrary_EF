
using Models.Entities;
using System.Collections.Generic;


namespace EditMyLibrary__EF.Models
{
    public static class MyLibrary
    {

        #region Properties of tables
        public static List<Author>? Authors { get; set; }
        public static List<Book>? Books { get; set; }
        public static List<Category>? Categories { get; set; }
        public static List<Department>? Departments { get; set; }
        public static List<Faculty>? Faculties { get; set; }
        public static List<Group>? Groups { get; set; }
        public static List<Lib>? Libs { get; set; }
        public static List<Press>? Presses { get; set; }
        public static List<S_Card>? S_Cards { get; set; }
        public static List<Student>? Students { get; set; }
        public static List<T_Card>? T_Cards { get; set; }
        public static List<Teacher>? Teachers { get; set; }
        public static List<Theme>? Themes { get; set; }
        #endregion
        
    }
}
