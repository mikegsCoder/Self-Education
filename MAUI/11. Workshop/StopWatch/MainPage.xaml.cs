using System.Collections.ObjectModel;
using System.Diagnostics;

namespace StopWatch
{
    public partial class MainPage : ContentPage
    {
        private IDispatcherTimer dt;
        private Stopwatch sw;
        private ObservableCollection<string> elapsedTimes;
        private string currentTime;

        public MainPage()
        {
            InitializeComponent();

            dt = Application.Current.Dispatcher.CreateTimer();
            sw = new Stopwatch();
            currentTime = string.Empty;
            elapsedTimes = new ObservableCollection<string>();

            clockTxtLbl.Text = "00:00:00";
            elapsedTimesList.ItemsSource = elapsedTimes;

            dt.Interval = new TimeSpan(0, 0, 0, 0, 1); // milliseconds
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
        }
    }
}
