using System.ComponentModel;

namespace CalculatorApp.DataContexts
{
    public class MainPageContext : INotifyPropertyChanged
    {
        private string displayText = "";
        private string tempDisplay = "";

        public string DisplayText
        {
            get { return displayText; }
            set
            {
                displayText = value == "-" ? "" : value;
                NotifyPropertyChanged(nameof(DisplayText));
            }
        }

        public string TempDisplay
        {
            get { return tempDisplay; }
            set
            {
                tempDisplay = value;
                NotifyPropertyChanged(nameof(TempDisplay));
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
