using CommandEventInteractions;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace CommandEventInteractions
{
    // ViewModel:
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        Phone? selectedPhone;
        public ObservableCollection<Phone> Phones { get; set; }

        // command to add new object
        RelayCommand? addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Phone phone = new Phone("", "", 0);
                      Phones.Insert(0, phone);
                      SelectedPhone = phone;
                  }));
            }
        }

        // command to remove
        RelayCommand? removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Phone? phone = obj as Phone;
                      if (phone != null)
                      {
                          Phones.Remove(phone);
                      }
                  },
                 (obj) => Phones.Count > 0));
            }
        }

        RelayCommand? doubleCommand;
        public RelayCommand DoubleCommand
        {
            get
            {
                return doubleCommand ??
                    (doubleCommand = new RelayCommand(obj =>
                    {
                        Phone? phone = obj as Phone;

                        if (phone != null)
                        {
                            Phone phoneCopy = new Phone(phone.Title, phone.Company, phone.Price);
                            Phones.Insert(0, phoneCopy);
                        }
                    }));
            }
        }

        public Phone? SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone("iPhone 7", "Apple", 56000),
                new Phone("Galaxy S7 Edge", "Samsung", 60000),
                new Phone("Elite x3", "HP", 56000),
                new Phone("Mi5S", "Xiaomi", 35000)
            };
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
