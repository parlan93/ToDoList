using System.ComponentModel;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public DataModel db = new DataModel();

    }
}
