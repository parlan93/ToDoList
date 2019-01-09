using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class CategoriesViewModel : ViewModel
    {
        public ObservableCollection<CategoryItemViewModel> Items { get; set; }

        public CategoriesViewModel()
        {
            //var cat1 = new Categories { Name = "First", Color = "#FFFF0000" };
            //var cat2 = new Categories { Name = "Second", Color = "#FF00FF00" };
            //var cat3 = new Categories { Name = "Third", Color = "#FF0000FF" };
            //db.Categories.AddRange(new List<Categories>() { cat1, cat2, cat3 });
            //db.SaveChanges();

            var categories = db.Categories;
            this.Items = new ObservableCollection<CategoryItemViewModel>(categories.ToList().Select(category => new CategoryItemViewModel(category.CategoryId, category.Name, category.Color)));
        }
    }
}
