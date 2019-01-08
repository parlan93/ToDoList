using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using ToDoList.Models;

namespace ToDoList.Views.Pages
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class CategoriesView : Page
    {
        //DataModel db = new DataModel();
        //public static DataGrid Grid;

        public CategoriesView()
        {
            InitializeComponent();

            Load();
        }

        private void Load()
        {
            using (var db = new DataModel())
            {
                //Database.SetInitializer(new DropCreateDatabaseAlways<DbModel>());

                //var category = new Categories() { Name = "Second", Color = "#FF00FF00" };
                //db.Categories.Add(category);
                //db.SaveChanges();

                var task = new Tasks() { Name = "FIRST", Categories = db.Categories.Find(1), Completed = 0 };
                db.Tasks.Add(task);
                db.SaveChanges();

                tmpGrid.ItemsSource = db.Categories.ToList();
                //Grid = tmpGrid;
            }
        }
    }
}
