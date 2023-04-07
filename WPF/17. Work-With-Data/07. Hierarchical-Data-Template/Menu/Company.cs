using System.Collections.ObjectModel;

namespace Menu
{
    public class Company
    {
        public string Name { get; set; }

        public ObservableCollection<Smartphone> Phones { get; set; }
        
        public Company()
        {
            Phones = new ObservableCollection<Smartphone>();
        }
    }
}
