using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace DialogueWindows
{
    // Model:
    [DataContract]
    public class Phone : INotifyPropertyChanged
    {
        private string title;
        private string company;
        private int price;

        public Phone(string title = "", string company = "", int price = 0)
        {
            this.title = title;
            this.company = company;
            this.price = price;
        }

        [DataMember]
        public string Title
        {
            get { return title; }

            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }

        [DataMember]
        public string Company
        {
            get { return company; }

            set
            {
                company = value;
                OnPropertyChanged("Company");
            }
        }

        [DataMember]
        public int Price
        {
            get { return price; }

            set
            {
                price = value;
                OnPropertyChanged("Price");
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
