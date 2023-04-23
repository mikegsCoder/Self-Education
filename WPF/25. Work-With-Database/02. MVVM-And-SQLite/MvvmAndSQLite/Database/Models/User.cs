using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmAndSQLite.Database.Models
{
    public class User : INotifyPropertyChanged
    {
        public int Id { get; set; }

        string? name;

        int age;

        public string? Name
        {
            get { return name; }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Age
        {
            get { return age; }

            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
