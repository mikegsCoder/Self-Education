using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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
