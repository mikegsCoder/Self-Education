using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CanExecuteApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string name = "";
        int age;
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand AddCommand { get; set; }
        public ObservableCollection<Person> People { get; } = new();

        public MainViewModel()
        {
            // Set AddCommand:
            AddCommand = new Command(() =>
            {
                People.Add(new Person(Name, Age));
                Name = "";
                Age = 0;
            },
            // Func<bool> CanExecute :
            () => Age > 0 && Age < 110 && Name.Length > 2);
        }

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
            
            ((Command)AddCommand).ChangeCanExecute();
        }
    }
}
