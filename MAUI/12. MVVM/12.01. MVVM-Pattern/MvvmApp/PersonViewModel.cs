using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmApp
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        Person person = new Person { Name = "Tom", Age = 38 };

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name
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

        public int Age
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

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
