using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ItemSelectionApp
{

    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        Person? selectedPerson;

        public ObservableCollection<Person> People { get; }

        public ViewModel()
        {
            People = new ObservableCollection<Person>
            {
                new  Person { Name="Tom", Company ="Microsoft" },
                new  Person { Name="Sam", Company ="Google" },
                new  Person { Name="Bob",  Company ="JetBrains" },
                new  Person { Name="Alice", Company ="Microsoft" },
                new  Person { Name="Kate", Company ="Google" },
                new  Person { Name="Amelia", Company ="JetBrains" }
            };

            SelectedPerson = People[1];
        }

        public Person? SelectedPerson
        {
            get => selectedPerson;
            set
            {
                if (selectedPerson != value)
                {
                    selectedPerson = value;
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
