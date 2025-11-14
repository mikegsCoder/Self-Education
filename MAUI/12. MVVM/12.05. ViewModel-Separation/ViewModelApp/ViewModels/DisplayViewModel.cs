using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelApp.ViewModels
{
    public class DisplayViewModel : INotifyPropertyChanged
    {
        Person person;
        public event PropertyChangedEventHandler? PropertyChanged;
        public DisplayViewModel(Person person) => this.person = person;
        
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
