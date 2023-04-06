using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectDataProvider
{
    public class PhoneRepository
    {
        private ObservableCollection<Phone> phones;

        public PhoneRepository()
        {
            phones = new ObservableCollection<Phone>
            {
                new Phone {Id=1, Title="iPhone 6S", Company="Apple" },
                new Phone {Id=2, Title="Lumia 950", Company="Microsoft" },
                new Phone {Id=3, Title="Nexus 5X", Company="Google" },
                new Phone {Id=4, Title="Galaxy S6", Company="Samsung"}
            };
        }

        public ObservableCollection<Phone> GetPhones()
        {
            return phones;
        }
    }
}
