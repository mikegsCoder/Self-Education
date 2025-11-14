using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModelApp.ViewModels
{
    // MainViewModel with separation of concerns:
    public class MainViewModel
    {
        public ICommand SaveCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public DisplayViewModel Person { get; set; }
        public EditViewModel EditData { get; set; }

        public MainViewModel()
        {
            Person = new DisplayViewModel(new Person("Tom", 38));

            EditData = new EditViewModel();

            SaveCommand = new Command(() =>
            {
                Person.Name = EditData.Name;
                Person.Age = EditData.Age;
                EditData.Name = "";
                EditData.Age = 0;
            });

            EditCommand = new Command(() =>
            {
                EditData.Name = Person.Name;
                EditData.Age = Person.Age;
            });
        }
    }
}
