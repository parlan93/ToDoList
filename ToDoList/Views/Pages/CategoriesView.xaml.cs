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

                //var task = new Tasks() { Name = "FIRST", Categories = db.Categories.Find(1), Completed = 0 };
                //db.Tasks.Add(task);
                //db.SaveChanges();

                //var alert = new Alerts() { Active = true, DateTime = new DateTime(2019, 1, 10, 20, 0, 0) };
                //db.Alerts.Add(alert);
                //db.SaveChanges();

                var task = new Tasks()
                {
                    Name = "First normal task to do",
                    CreationDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
                    TaskDateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second),
                    Completed = false,
                    Categories = db.Categories.Find(2),
                    Alerts = db.Alerts.Add(new Alerts()
                    {
                        DateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, DateTime.Now.Hour - 1, DateTime.Now.Minute, DateTime.Now.Second),
                        Active = true
                    })
                };
                db.Tasks.Add(task);
                db.SaveChanges();

                tmpGrid.ItemsSource = db.Categories.ToList();
                //Grid = tmpGrid;
            }
        }
    }
}
