using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.DataContexts
{
    public class MainPageContext : INotifyPropertyChanged
    {
        private string displayText = "";

        public string DisplayText
        {
            get { return displayText; }
            set
            {
                displayText = value == "-" ? "" : value;
                NotifyPropertyChanged(nameof(DisplayText));
            }
        }

        public void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
