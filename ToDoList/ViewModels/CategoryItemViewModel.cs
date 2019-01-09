using System.Windows.Input;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class CategoryItemViewModel : ViewModel
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public ICommand AddCategoryCommand { get; set; }
        public ICommand EditCategoryCommand { get; set; }
        public ICommand DeleteCategoryCommand { get; set; }

        public CategoryItemViewModel(long categoryId, string name, string color)
        {
            this.AddCategoryCommand = new RelayCommand(AddCategory);
            this.EditCategoryCommand = new RelayCommand(EditCategory);
            this.DeleteCategoryCommand = new RelayCommand(DeleteCategory);

            this.CategoryId = categoryId;
            this.Name = name;
            this.Color = color;
        }

        private void AddCategory()
        {
            var category = new Categories() { Name = this.Name, Color = this.Color };
            db.Categories.Add(category);
            db.SaveChanges();
        }

        private void EditCategory() { }

        private void DeleteCategory()
        {
            var category = db.Categories.Find(this.CategoryId);
            db.Categories.Remove(category);
            db.SaveChanges();
        }
    }
}
