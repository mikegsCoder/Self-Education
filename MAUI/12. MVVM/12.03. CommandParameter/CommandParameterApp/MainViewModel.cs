using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CommandParameterApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string name = "";
        int age;
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }
        public ObservableCollection<Person> People { get; } = new();

        public MainViewModel()
        {
            // Set AddCommand:
            AddCommand = new Command(() =>
            {
                People.Add(new Person(Name, Age));
                Name = "";
                Age = 0;
            });

            // Set RemoveCommand:
            //RemoveCommand = new Command((object? args) =>
            //{
            //    if (args is Person person)
            //    {
            //        People.Remove(person);
            //    }
            //});

            // Set RemoveCommand with argument type:
            RemoveCommand = new Command<Person>((Person person) =>
            {
                People.Remove(person);
            });
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
