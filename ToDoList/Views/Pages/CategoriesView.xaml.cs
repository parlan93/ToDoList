using System.Linq;
using System.Windows.Controls;
using ToDoList.Models;
using ToDoList.ViewModels;

namespace ToDoList.Views.Pages
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class CategoriesView : Page
    {
        public CategoriesView()
        {
            InitializeComponent();

            this.DataContext = new CategoriesViewModel();

        }
    }
}
