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

            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1); // milliseconds
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            sw.Start();

            dt.Start();
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
            }

            elapsedTimes.Add(currentTime);
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            sw.Reset();

            clockTxtLbl.Text = "00:00:00";
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;

                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

                clockTxtLbl.Text = currentTime;
            }
        }
    }
}
