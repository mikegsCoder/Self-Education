using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ViewModelApp
{
    // MainViewModel without separation of concerns:
    public class MainViewModel : INotifyPropertyChanged
    {
        Person person = new Person("Tom", 38);
        string name = "";
        int age;
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand SaveCommand { get; set; }
        public ICommand EditCommand { get; set; }

        public MainViewModel()
        {
            SaveCommand = new Command(() =>
            {
                PersonName = Name;
                PersonAge = Age;
                Name = "";
                Age = 0;
            });

            EditCommand = new Command(() =>
            {
                Name = PersonName;
                Age = PersonAge;
            });
        }

        public string PersonName
        {
            get => person.Name;
            set
            {
                if (person.Name != value)
                {
                    person.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public int PersonAge
        {
            get => person.Age;
            set
            {
                if (person.Age != value)
                {
                    person.Age = value;
                    OnPropertyChanged();
                }
            }
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
        }
    }
}
